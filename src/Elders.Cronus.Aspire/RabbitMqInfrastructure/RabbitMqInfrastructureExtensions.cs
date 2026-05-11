using Aspire.Hosting;
using Aspire.Hosting.ApplicationModel;
using Elders.Cronus.Aspire.Common;

namespace Elders.Cronus.Aspire.RabbitMqInfrastructure;

internal static class RabbitMqInfrastructureExtensions
{
    extension(IDistributedApplicationBuilder builder)
    {
        internal IResourceBuilder<RabbitMQServerResource> AddRabbitMq(RabbitMqContainerOptions? options)
        {
            options ??= new RabbitMqContainerOptions();

            string enabledPluginsPath = Path.Combine(Path.GetTempPath(), options.EnabledPluginsFileName);

            File.WriteAllText(enabledPluginsPath, options.EnabledPluginsContent);

            return builder.AddRabbitMQ(options.ServiceName)
                .WithLifetime(ContainerLifetime.Persistent)
                .WithManagementPlugin(options.ManagementPort)
                .WithBindMount(enabledPluginsPath, options.ContainerPluginsPath)
                .WithMemoryLimits(options);
        }
    }

    extension(IResourceBuilder<ProjectResource> project)
    {
        internal IResourceBuilder<ProjectResource> WithRabbitMqConfigurations(IResourceBuilder<RabbitMQServerResource> rabbitmq)
        {
            return project
                    .WithReference(rabbitmq)
                    .WithEnvironment(CronusConfigurationKeys.TransportServerKey, () => rabbitmq.GetEndpoint("tcp").Host)
                    .WithEnvironment(CronusConfigurationKeys.TransportPortKey, () => rabbitmq.GetEndpoint("tcp").Port.ToString())
                    .WithEnvironment(CronusConfigurationKeys.TransportUsernameKey, rabbitmq.Resource.UserNameReference)
                    .WithEnvironment(CronusConfigurationKeys.TransportPasswordKey, rabbitmq.Resource.PasswordParameter)
                    .WithEnvironment(CronusConfigurationKeys.TransportAdminPortKey, () => rabbitmq.GetEndpoint("management").Port.ToString())
                    // RabbitMQ Public Transport (Federated Exchange) configuration
                    .WithEnvironment(CronusConfigurationKeys.PublicTransportServerKey, () => rabbitmq.GetEndpoint("tcp").Host)
                    .WithEnvironment(CronusConfigurationKeys.PublicTransportPortKey, () => rabbitmq.GetEndpoint("tcp").Port.ToString())
                    .WithEnvironment(CronusConfigurationKeys.PublicTransportUsernameKey, rabbitmq.Resource.UserNameReference)
                    .WithEnvironment(CronusConfigurationKeys.PublicTransportPasswordKey, rabbitmq.Resource.PasswordParameter)
                    .WithEnvironment(CronusConfigurationKeys.PublicTransportAdminPortKey, () => rabbitmq.GetEndpoint("management").Port.ToString())
                    // Federated Exchange Upstream URI - uses callback context to compose from parameters
                    .WithEnvironment(context =>
                    {
                        var username = context.ExecutionContext.IsPublishMode
                            ? rabbitmq.Resource.UserNameReference.ValueExpression
                            : "guest";

                        var password = context.ExecutionContext.IsPublishMode
                            ? rabbitmq.Resource.PasswordParameter.ValueExpression
                            : context.EnvironmentVariables[CronusConfigurationKeys.TransportPasswordKey];

                        var host = rabbitmq.GetEndpoint("tcp").Host;
                        var port = rabbitmq.GetEndpoint("tcp").Port;

                        context.EnvironmentVariables[CronusConfigurationKeys.FederatedExchangeUriKey] =
                            $"{username}:{password}@{host}:{port}";
                    });
        }
    }
}

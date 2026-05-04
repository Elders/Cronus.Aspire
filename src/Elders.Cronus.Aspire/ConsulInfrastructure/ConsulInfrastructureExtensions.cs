using Aspire.Hosting;
using Aspire.Hosting.ApplicationModel;
using Elders.Cronus.Aspire.Common;

namespace Elders.Cronus.Aspire.ConsulInfrastructure;

internal static class ConsulInfrastructureExtensions
{
    extension(IDistributedApplicationBuilder builder)
    {
        internal IResourceBuilder<ContainerResource> AddConsul(ConsulContainerOptions? options)
        {
            options ??= new ConsulContainerOptions();

            return builder.AddContainer(options.ServiceName, options.Image, options.Version)
                .WithLifetime(ContainerLifetime.Persistent)
                .WithHttpEndpoint(
                    port: options.HttpPort,
                    targetPort: options.HttpPort,
                    name: options.HttpEndpointName)
                .WithEndpoint(
                    port: options.DnsPort,
                    targetPort: options.DnsPort,
                    name: options.DnsEndpointName,
                    scheme: options.DnsScheme)
                .WithArgs(options.Args)
                .WithAnnotation(new ContainerRuntimeArgsCallbackAnnotation(args =>
                {
                    args.Add($"{options.MemoryArg}={options.MemoryLimit}");
                    args.Add($"{options.MemorySwapArg}={options.MemorySwap}");
                }));
        }
    }

    extension(IResourceBuilder<ProjectResource> project)
    {
        internal IResourceBuilder<ProjectResource> WithConsulConfigurations(IResourceBuilder<ContainerResource> consul)
        {
            return project.WithEnvironment(CronusConfigurationKeys.ConsulKey, () => consul.GetEndpoint("http").Url);
        }
    }
}
using Aspire.Hosting;
using Aspire.Hosting.ApplicationModel;
using Elders.Cronus.Aspire.Common;

namespace Elders.Cronus.Aspire.RedisInfrastructure;

internal static class RedisInfrastructureExtensions
{
    private const string ConnectionStringValueExpression = "{ConnectionStrings:redis}";

    extension(IDistributedApplicationBuilder builder)
    {
        internal IResourceBuilder<RedisResource> AddRedis(RedisContainerOptions? options)
        {
            options ??= new RedisContainerOptions();

            return builder.AddRedis(options.ServiceName)
                .WithLifetime(ContainerLifetime.Persistent)
                .WithAnnotation(new ContainerRuntimeArgsCallbackAnnotation(args =>
                {
                    args.Add($"{options.MemoryArg}={options.MemoryLimit}");
                    args.Add($"{options.MemorySwapArg}={options.MemorySwap}");
                }));
        }
    }

    extension(IResourceBuilder<ProjectResource> project)
    {
        internal IResourceBuilder<ProjectResource> WithRedisConfigurations(IResourceBuilder<RedisResource> redis)
        {
            return project
                .WithReference(redis)
                .WithEnvironment(CronusConfigurationKeys.AtomicActionsKey, ConnectionStringValueExpression);
        }
    }
}
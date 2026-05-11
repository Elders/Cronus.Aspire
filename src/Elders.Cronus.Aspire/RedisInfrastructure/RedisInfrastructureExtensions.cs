using Aspire.Hosting;
using Aspire.Hosting.ApplicationModel;
using Elders.Cronus.Aspire.Common;

namespace Elders.Cronus.Aspire.RedisInfrastructure;

internal static class RedisInfrastructureExtensions
{
    extension(IDistributedApplicationBuilder builder)
    {
        internal IResourceBuilder<RedisResource> AddRedis(RedisContainerOptions? options)
        {
            options ??= new RedisContainerOptions();

            return builder.AddRedis(options.ServiceName)
                .WithLifetime(ContainerLifetime.Persistent)
                .WithMemoryLimits(options);
        }
    }

    extension(IResourceBuilder<ProjectResource> project)
    {
        internal IResourceBuilder<ProjectResource> WithRedisConfigurations(IResourceBuilder<RedisResource> redis)
        {
            return project
                .WithReference(redis)
                .WithEnvironment(CronusConfigurationKeys.AtomicActionsKey, redis.Resource.ConnectionStringExpression);
        }
    }
}

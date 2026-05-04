using Aspire.Hosting.ApplicationModel;

namespace Elders.Cronus.Aspire.Common;

public sealed class CronusInfrastructure
{
    public required IResourceBuilder<ContainerResource> Cassandra { get; init; }
    public required IResourceBuilder<RabbitMQServerResource> RabbitMq { get; init; }
    public required IResourceBuilder<RedisResource> Redis { get; init; }
    public required IResourceBuilder<ContainerResource> Consul { get; init; }
}

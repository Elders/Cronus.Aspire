using Elders.Cronus.Aspire.CassandraInfrastructure;
using Elders.Cronus.Aspire.ConsulInfrastructure;
using Elders.Cronus.Aspire.RabbitMqInfrastructure;
using Elders.Cronus.Aspire.RedisInfrastructure;

namespace Elders.Cronus.Aspire.Common;

public sealed class CronusInfrastructureContainerOptions
{
    public RabbitMqContainerOptions RabbitMqOptions { get; init; } = new();
    public CassandraContainerOptions CassandraOptions { get; init; } = new();
    public RedisContainerOptions RedisOptions { get; init; } = new();
    public ConsulContainerOptions ConsulOptions { get; init; } = new();
}
namespace Elders.Cronus.Aspire.RabbitMqInfrastructure;

internal static class RabbitMqContainerDefaults
{
    internal const string ServiceName = "rabbitmq";

    internal const string EnabledPluginsContent =
        "[rabbitmq_management,rabbitmq_federation,rabbitmq_federation_management].";

    internal const string EnabledPluginsFileName = "rabbitmq_enabled_plugins";
    internal const string ContainerPluginsPath = "/etc/rabbitmq/enabled_plugins";

    internal const int ManagementPort = 15672;

    internal const string MemoryLimit = "1g";
    internal const string MemorySwap = "1g";
}

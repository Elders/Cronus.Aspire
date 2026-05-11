using Elders.Cronus.Aspire.Common;

namespace Elders.Cronus.Aspire.RabbitMqInfrastructure;

/// <summary>
/// Represents configuration options for provisioning and configuring a RabbitMQ container
/// within an Aspire distributed application.
/// </summary>
public sealed class RabbitMqContainerOptions : ContainerOptions
{
    public RabbitMqContainerOptions()
        : base(
            RabbitMqContainerDefaults.ServiceName,
            RabbitMqContainerDefaults.MemoryLimit,
            RabbitMqContainerDefaults.MemorySwap)
    {
    }

    /// <summary>
    /// Gets or sets the content of the enabled plugins configuration file used by RabbitMQ.
    /// </summary>
    public string EnabledPluginsContent { get; set; } = RabbitMqContainerDefaults.EnabledPluginsContent;

    /// <summary>
    /// Gets or sets the file name for the RabbitMQ enabled plugins configuration file.
    /// </summary>
    public string EnabledPluginsFileName { get; set; } = RabbitMqContainerDefaults.EnabledPluginsFileName;

    /// <summary>
    /// Gets or sets the container path where the enabled plugins configuration file is mounted.
    /// </summary>
    public string ContainerPluginsPath { get; set; } = RabbitMqContainerDefaults.ContainerPluginsPath;

    /// <summary>
    /// Gets or sets the port exposed by the RabbitMQ management plugin.
    /// </summary>
    public int ManagementPort { get; set; } = RabbitMqContainerDefaults.ManagementPort;
}


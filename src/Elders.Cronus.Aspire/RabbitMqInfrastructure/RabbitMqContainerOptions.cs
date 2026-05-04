namespace Elders.Cronus.Aspire.RabbitMqInfrastructure;

/// <summary>
/// Represents configuration options for provisioning and configuring a RabbitMQ container
/// within an Aspire distributed application.
/// </summary>
public sealed class RabbitMqContainerOptions
{
    /// <summary>
    /// Gets or sets the logical name of the RabbitMQ service within the distributed application.
    /// </summary>
    public string ServiceName { get; set; } = RabbitMqContainerDefaults.ServiceName;

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

    /// <summary>
    /// Gets or sets the argument name used to configure container memory limits.
    /// </summary>
    public string MemoryArg { get; set; } = RabbitMqContainerDefaults.MemoryArg;

    /// <summary>
    /// Gets or sets the argument name used to configure container memory swap limits.
    /// </summary>
    public string MemorySwapArg { get; set; } = RabbitMqContainerDefaults.MemorySwapArg;

    /// <summary>
    /// Gets or sets the memory limit applied to the RabbitMQ container.
    /// </summary>
    public string MemoryLimit { get; set; } = RabbitMqContainerDefaults.MemoryLimit;

    /// <summary>
    /// Gets or sets the memory swap limit applied to the RabbitMQ container.
    /// </summary>
    public string MemorySwap { get; set; } = RabbitMqContainerDefaults.MemorySwap;
}

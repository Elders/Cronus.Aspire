namespace Elders.Cronus.Aspire.RedisInfrastructure;

/// <summary>
/// Represents configuration options for provisioning and configuring a Redis container
/// within an Aspire distributed application.
/// </summary>
public sealed class RedisContainerOptions
{
    /// <summary>
    /// Gets or sets the logical name of the Redis service within the distributed application.
    /// </summary>
    public string ServiceName { get; set; } = RedisContainerDefaults.ServiceName;

    /// <summary>
    /// Gets or sets the argument name used to configure container memory limits.
    /// </summary>
    public string MemoryArg { get; set; } = RedisContainerDefaults.MemoryArg;

    /// <summary>
    /// Gets or sets the memory limit applied to the Redis container.
    /// </summary>
    public string MemoryLimit { get; set; } = RedisContainerDefaults.MemoryLimit;

    /// <summary>
    /// Gets or sets the argument name used to configure container memory swap limits.
    /// </summary>
    public string MemorySwapArg { get; set; } = RedisContainerDefaults.MemorySwapArg;

    /// <summary>
    /// Gets or sets the memory swap limit applied to the Redis container.
    /// </summary>
    public string MemorySwap { get; set; } = RedisContainerDefaults.MemorySwap;
}

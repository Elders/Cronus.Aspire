namespace Elders.Cronus.Aspire.Common;

/// <summary>
/// Represents shared options for Cronus infrastructure containers.
/// Used by resources that are present in the official Aspire Integrations Gallery
/// </summary>
public abstract class ContainerOptions
{
    protected ContainerOptions(string serviceName, string memoryLimit, string memorySwap)
    {
        ServiceName = serviceName;
        MemoryLimit = memoryLimit;
        MemorySwap = memorySwap;
    }

    /// <summary>
    /// Gets or sets the logical name of the service within the distributed application.
    /// </summary>
    public string ServiceName { get; set; }

    /// <summary>
    /// Gets or sets the argument name used to configure container memory limits.
    /// </summary>
    public string MemoryArg { get; set; } = ContainerOptionsDefaults.MemoryArg;

    /// <summary>
    /// Gets or sets the argument name used to configure container memory swap limits.
    /// </summary>
    public string MemorySwapArg { get; set; } = ContainerOptionsDefaults.MemorySwapArg;

    /// <summary>
    /// Gets or sets the memory limit applied to the container.
    /// </summary>
    public string MemoryLimit { get; set; }

    /// <summary>
    /// Gets or sets the memory swap limit applied to the container.
    /// </summary>
    public string MemorySwap { get; set; }
}

namespace Elders.Cronus.Aspire.Common;

/// <summary>
/// Represents shared options for Cronus infrastructure containers created from explicit images.
/// Used by resources that are NOT present in the official Aspire Integrations Gallery (e.g Cassandra)
/// </summary>
public abstract class ContainerImageOptions : ContainerOptions
{
    protected ContainerImageOptions(string serviceName, string image, string version, string memoryLimit, string memorySwap)
        : base(serviceName, memoryLimit, memorySwap)
    {
        Image = image;
        Version = version;
    }

    /// <summary>
    /// Gets or sets the container image used to run the service.
    /// </summary>
    public string Image { get; set; }

    /// <summary>
    /// Gets or sets the image tag or version of the container.
    /// </summary>
    public string Version { get; set; }
}

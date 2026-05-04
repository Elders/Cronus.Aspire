namespace Elders.Cronus.Aspire.ConsulInfrastructure;

/// <summary>
/// Represents configuration options for provisioning and configuring a Consul container
/// within an Aspire distributed application.
/// </summary>
public sealed class ConsulContainerOptions
{
    /// <summary>
    /// Gets or sets the logical name of the Consul service within the distributed application.
    /// </summary>
    public string ServiceName { get; set; } = ConsulContainerDefaults.ServiceName;

    /// <summary>
    /// Gets or sets the container image used to run Consul.
    /// </summary>
    public string Image { get; set; } = ConsulContainerDefaults.Image;

    /// <summary>
    /// Gets or sets the image tag or version of the Consul container.
    /// </summary>
    public string Version { get; set; } = ConsulContainerDefaults.Version;

    /// <summary>
    /// Gets or sets the HTTP port exposed by the Consul agent for API and UI access.
    /// </summary>
    public int HttpPort { get; set; } = ConsulContainerDefaults.HttpPort;

    /// <summary>
    /// Gets or sets the DNS port exposed by the Consul agent for service discovery queries.
    /// </summary>
    public int DnsPort { get; set; } = ConsulContainerDefaults.DnsPort;

    /// <summary>
    /// Gets or sets the endpoint name used for HTTP access within the distributed application.
    /// </summary>
    public string HttpEndpointName { get; set; } = ConsulContainerDefaults.HttpEndpointName;

    /// <summary>
    /// Gets or sets the endpoint name used for DNS-based service discovery.
    /// </summary>
    public string DnsEndpointName { get; set; } = ConsulContainerDefaults.DnsEndpointName;

    /// <summary>
    /// Gets or sets the DNS scheme used by the Consul container (e.g., udp or tcp depending on configuration).
    /// </summary>
    public string DnsScheme { get; set; } = ConsulContainerDefaults.DnsScheme;

    /// <summary>
    /// Gets or sets the arguments passed to the Consul agent at startup.
    /// </summary>
    public string[] Args { get; set; } = ConsulContainerDefaults.Args;

    /// <summary>
    /// Gets or sets the argument name used to configure container memory limits.
    /// </summary>
    public string MemoryArg { get; set; } = ConsulContainerDefaults.MemoryArg;

    /// <summary>
    /// Gets or sets the argument name used to configure container memory swap limits.
    /// </summary>
    public string MemorySwapArg { get; set; } = ConsulContainerDefaults.MemorySwapArg;

    /// <summary>
    /// Gets or sets the memory limit applied to the Consul container.
    /// </summary>
    public string MemoryLimit { get; set; } = ConsulContainerDefaults.MemoryLimit;

    /// <summary>
    /// Gets or sets the memory swap limit applied to the Consul container.
    /// </summary>
    public string MemorySwap { get; set; } = ConsulContainerDefaults.MemorySwap;
}

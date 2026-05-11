using Elders.Cronus.Aspire.Common;

namespace Elders.Cronus.Aspire.ConsulInfrastructure;

/// <summary>
/// Represents configuration options for provisioning and configuring a Consul container
/// within an Aspire distributed application.
/// </summary>
public sealed class ConsulContainerOptions : ContainerImageOptions
{
    public ConsulContainerOptions()
        : base(
            ConsulContainerDefaults.ServiceName,
            ConsulContainerDefaults.Image,
            ConsulContainerDefaults.Version,
            ConsulContainerDefaults.MemoryLimit,
            ConsulContainerDefaults.MemorySwap)
    {
    }

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
}


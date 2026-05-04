namespace Elders.Cronus.Aspire.ConsulInfrastructure;

internal static class ConsulContainerDefaults
{
    internal const string ServiceName = "consul";
    internal const string Image = "consul";
    internal const string Version = "1.15.4";

    internal const int HttpPort = 8500;
    internal const int DnsPort = 8600;

    internal const string HttpEndpointName = "http";
    internal const string DnsEndpointName = "dns";
    internal const string DnsScheme = "dns";

    internal static readonly string[] Args =
    {
        "agent",
        "-dev",
        "-ui",
        "-client=0.0.0.0"
    };

    internal const string MemoryArg = "--memory";
    internal const string MemorySwapArg = "--memory-swap";

    internal const string MemoryLimit = "512m";
    internal const string MemorySwap = "512m";
}
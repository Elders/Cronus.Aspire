namespace Elders.Cronus.Aspire.RedisInfrastructure;

internal static class RedisContainerDefaults
{
    internal const string ServiceName = "redis";
    internal const string MemoryArg = "--memory";
    internal const string MemoryLimit = "512m";
    internal const string MemorySwapArg = "--memory-swap";
    internal const string MemorySwap = "512m";
}
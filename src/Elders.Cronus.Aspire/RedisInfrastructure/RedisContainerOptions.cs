using Elders.Cronus.Aspire.Common;

namespace Elders.Cronus.Aspire.RedisInfrastructure;

/// <summary>
/// Represents configuration options for provisioning and configuring a Redis container
/// within an Aspire distributed application.
/// </summary>
public sealed class RedisContainerOptions : ContainerOptions
{
    public RedisContainerOptions()
        : base(
            RedisContainerDefaults.ServiceName,
            RedisContainerDefaults.MemoryLimit,
            RedisContainerDefaults.MemorySwap)
    {
    }
}


using Aspire.Hosting.ApplicationModel;

namespace Elders.Cronus.Aspire.Common;

internal static class ContainerRuntimeArgsExtensions
{
    internal static IResourceBuilder<TResource> WithMemoryLimits<TResource>(this IResourceBuilder<TResource> resource, ContainerOptions options)
        where TResource : IResource
    {
        return resource.WithAnnotation(new ContainerRuntimeArgsCallbackAnnotation(args =>
        {
            args.Add($"{options.MemoryArg}={options.MemoryLimit}");
            args.Add($"{options.MemorySwapArg}={options.MemorySwap}");
        }));
    }
}

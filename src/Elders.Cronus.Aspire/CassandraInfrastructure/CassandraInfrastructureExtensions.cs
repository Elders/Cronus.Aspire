using Aspire.Hosting;
using Aspire.Hosting.ApplicationModel;
using Elders.Cronus.Aspire.Common;

namespace Elders.Cronus.Aspire.CassandraInfrastructure;

internal static class CassandraInfrastructureExtensions
{
    private const string CqlEndpoint = "cql";

    extension(IResourceBuilder<ProjectResource> project)
    {
        internal IResourceBuilder<ProjectResource> WithCassandraConfigurations(
            IResourceBuilder<ContainerResource> cassandra)
        {
            return project.WithEnvironment(CronusConfigurationKeys.EventStoreKey,
                    () =>
                        $"Contact Points={cassandra.GetEndpoint(CqlEndpoint).Host};Port={cassandra.GetEndpoint(CqlEndpoint).Port}")
                .WithEnvironment(CronusConfigurationKeys.ProjectionsKey,
                    () =>
                        $"Contact Points={cassandra.GetEndpoint(CqlEndpoint).Host};Port={cassandra.GetEndpoint(CqlEndpoint).Port}");
        }
    }

    extension(IDistributedApplicationBuilder builder)
    {
        internal IResourceBuilder<ContainerResource> AddCassandra(CassandraContainerOptions? options)
        {
            options ??= new CassandraContainerOptions();

            return builder.AddContainer(options.ServiceName, options.Image, options.Version)
                .WithLifetime(ContainerLifetime.Persistent)
                .WithEndpoint(
                    port: options.Port,
                    targetPort: options.Port,
                    name: options.EndpointName)
                .WithEnvironment(options.ClusterNameEnv, options.ClusterName)
                .WithEnvironment(options.DataCenterEnv, options.DataCenter)
                .WithEnvironment(options.SnitchEnv, options.Snitch)
                .WithEnvironment(options.MaxHeapEnv, options.MaxHeap)
                .WithEnvironment(options.HeapNewSizeEnv, options.HeapNewSize)
                .WithMemoryLimits(options);
        }
    }
}

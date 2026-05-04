namespace Elders.Cronus.Aspire.CassandraInfrastructure;

/// <summary>
/// Represents configuration options for provisioning and configuring a Cassandra container
/// within an Aspire distributed application.
/// </summary>
public sealed class CassandraContainerOptions
{
    /// <summary>
    /// Gets or sets the logical name of the Cassandra service within the distributed application.
    /// </summary>
    public string ServiceName { get; set; } = CassandraContainerDefaults.ServiceName;

    /// <summary>
    /// Gets or sets the container image used to run Cassandra.
    /// </summary>
    public string Image { get; set; } = CassandraContainerDefaults.Image;

    /// <summary>
    /// Gets or sets the image tag or version of the Cassandra container.
    /// </summary>
    public string Version { get; set; } = CassandraContainerDefaults.Version;

    /// <summary>
    /// Gets or sets the port exposed by the Cassandra service.
    /// </summary>
    public int Port { get; set; } = CassandraContainerDefaults.Port;

    /// <summary>
    /// Gets or sets the endpoint name used when registering the Cassandra service
    /// for discovery within the distributed application.
    /// </summary>
    public string EndpointName { get; set; } = CassandraContainerDefaults.EndpointName;

    /// <summary>
    /// Gets or sets the name of the environment variable used to configure the cluster name.
    /// </summary>
    public string ClusterNameEnv { get; set; } = CassandraContainerDefaults.ClusterNameEnv;

    /// <summary>
    /// Gets or sets the Cassandra cluster name.
    /// </summary>
    public string ClusterName { get; set; } = CassandraContainerDefaults.ClusterName;

    /// <summary>
    /// Gets or sets the name of the environment variable used to configure the data center.
    /// </summary>
    public string DataCenterEnv { get; set; } = CassandraContainerDefaults.DataCenterEnv;

    /// <summary>
    /// Gets or sets the Cassandra data center name.
    /// </summary>
    public string DataCenter { get; set; } = CassandraContainerDefaults.DataCenter;

    /// <summary>
    /// Gets or sets the name of the environment variable used to configure the snitch.
    /// </summary>
    public string SnitchEnv { get; set; } = CassandraContainerDefaults.SnitchEnv;

    /// <summary>
    /// Gets or sets the snitch implementation used by Cassandra for topology awareness.
    /// </summary>
    public string Snitch { get; set; } = CassandraContainerDefaults.Snitch;

    /// <summary>
    /// Gets or sets the name of the environment variable used to configure the maximum JVM heap size.
    /// </summary>
    public string MaxHeapEnv { get; set; } = CassandraContainerDefaults.MaxHeapEnv;

    /// <summary>
    /// Gets or sets the maximum heap size allocated to the Cassandra JVM.
    /// </summary>
    public string MaxHeap { get; set; } = CassandraContainerDefaults.MaxHeap;

    /// <summary>
    /// Gets or sets the name of the environment variable used to configure the new generation heap size.
    /// </summary>
    public string HeapNewSizeEnv { get; set; } = CassandraContainerDefaults.HeapNewSizeEnv;

    /// <summary>
    /// Gets or sets the size of the new generation heap for the Cassandra JVM.
    /// </summary>
    public string HeapNewSize { get; set; } = CassandraContainerDefaults.HeapNewSize;

    /// <summary>
    /// Gets or sets the argument name used to configure container memory limits.
    /// </summary>
    public string MemoryArg { get; set; } = CassandraContainerDefaults.MemoryArg;

    /// <summary>
    /// Gets or sets the argument name used to configure container memory swap limits.
    /// </summary>
    public string MemorySwapArg { get; set; } = CassandraContainerDefaults.MemorySwapArg;

    /// <summary>
    /// Gets or sets the memory limit applied to the Cassandra container.
    /// </summary>
    public string MemoryLimit { get; set; } = CassandraContainerDefaults.MemoryLimit;

    /// <summary>
    /// Gets or sets the memory swap limit applied to the Cassandra container.
    /// </summary>
    public string MemorySwap { get; set; } = CassandraContainerDefaults.MemorySwap;
}

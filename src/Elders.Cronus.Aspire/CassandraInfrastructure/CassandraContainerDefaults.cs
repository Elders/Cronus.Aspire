namespace Elders.Cronus.Aspire.CassandraInfrastructure;

internal static class CassandraContainerDefaults
{
    internal const string ServiceName = "cassandra";
    internal const string Image = "cassandra";
    internal const string Version = "latest";

    internal const int Port = 9042;
    internal const string EndpointName = "cql";

    internal const string ClusterNameEnv = "CASSANDRA_CLUSTER_NAME";
    internal const string ClusterName = "CronusCluster";

    internal const string DataCenterEnv = "CASSANDRA_DC";
    internal const string DataCenter = "datacenter1";

    internal const string SnitchEnv = "CASSANDRA_ENDPOINT_SNITCH";
    internal const string Snitch = "GossipingPropertyFileSnitch";

    internal const string MaxHeapEnv = "MAX_HEAP_SIZE";
    internal const string MaxHeap = "2G";

    internal const string HeapNewSizeEnv = "HEAP_NEWSIZE";
    internal const string HeapNewSize = "512M";

    internal const string MemoryArg = "--memory";
    internal const string MemorySwapArg = "--memory-swap";

    internal const string MemoryLimit = "4g";
    internal const string MemorySwap = "4g";
}

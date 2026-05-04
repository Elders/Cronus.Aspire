namespace Elders.Cronus.Aspire.Common;

public static class CronusConfigurationKeys
{
    // Redis
    public const string AtomicActionsKey = "Cronus__AtomicAction__Redis__ConnectionString";
    
    // Consul
    public const string ConsulKey = "Cronus__Cluster__Consul__Address";
    
    // Cassandra
    public const string EventStoreKey = "Cronus__Persistence__Cassandra__ConnectionString";
    public const string ProjectionsKey = "Cronus__Projections__Cassandra__ConnectionString";
    
    // RabbitMQ
    public const string TransportServerKey = "Cronus__Transport__RabbitMQ__Server";
    public const string TransportPortKey = "Cronus__Transport__RabbitMQ__Port";
    public const string TransportUsernameKey = "Cronus__Transport__RabbitMQ__Username";
    public const string TransportPasswordKey = "Cronus__Transport__RabbitMQ__Password";
    public const string TransportAdminPortKey = "Cronus__Transport__RabbitMQ__AdminPort";
    public const string PublicTransportServerKey = "Cronus__Transport__PublicRabbitMQ__0__Server";
    public const string PublicTransportPortKey = "Cronus__Transport__PublicRabbitMQ__0__Port";
    public const string PublicTransportUsernameKey = "Cronus__Transport__PublicRabbitMQ__0__Username";
    public const string PublicTransportPasswordKey = "Cronus__Transport__PublicRabbitMQ__0__Password";
    public const string PublicTransportAdminPortKey = "Cronus__Transport__PublicRabbitMQ__0__AdminPort";
    public const string FederatedExchangeUriKey = "Cronus__Transport__PublicRabbitMQ__0__FederatedExchange__UpstreamUri";
}
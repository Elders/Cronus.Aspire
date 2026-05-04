using Aspire.Hosting;
using Aspire.Hosting.ApplicationModel;
using Elders.Cronus.Aspire.CassandraInfrastructure;
using Elders.Cronus.Aspire.Common;
using Elders.Cronus.Aspire.ConsulInfrastructure;
using Elders.Cronus.Aspire.RabbitMqInfrastructure;
using Elders.Cronus.Aspire.RedisInfrastructure;

namespace Elders.Cronus.Aspire;

public static class CronusAspireExtensions
{
    /// <summary>
    /// Extension methods for registering and configuring Cronus infrastructure services
    /// (Cassandra, RabbitMQ, Redis, and Consul) within an Aspire distributed application.
    /// </summary>
    extension(IDistributedApplicationBuilder builder)
    {
        /// <summary>
        /// Adds the full Cronus infrastructure stack to the distributed application,
        /// including Cassandra, RabbitMQ, Redis, and Consul services.
        /// </summary>
        /// <param name="optionsFactory">
        /// Optional factory used to customize infrastructure container options.
        /// If not provided, default configuration values are used.
        /// </param>
        /// <returns>
        /// A <see cref="CronusInfrastructure"/> instance representing the registered resources.
        /// </returns>
        public CronusInfrastructure AddCronusInfrastructure(Func<CronusInfrastructureContainerOptions>? optionsFactory = null)
        {
            var options = optionsFactory?.Invoke() ?? new CronusInfrastructureContainerOptions();

            var cassandra = builder.AddCassandra(options.CassandraOptions);
            var rabbitMq = builder.AddRabbitMq(options.RabbitMqOptions);
            var redis = builder.AddRedis(options.RedisOptions);
            var consul = builder.AddConsul(options.ConsulOptions);

            return new CronusInfrastructure
            {
                Cassandra = cassandra,
                RabbitMq = rabbitMq,
                Redis = redis,
                Consul = consul
            };
        }
    }

    /// <summary>
    /// Extension methods for wiring a project resource to the Cronus infrastructure
    /// within an Aspire distributed application.
    /// </summary>
    extension(IResourceBuilder<ProjectResource> project)
    {
        /// <summary>
        /// Configures the project resource to use the Cronus infrastructure dependencies,
        /// including Cassandra, RabbitMQ, Consul, and Redis.
        /// </summary>
        /// <param name="infrastructure">
        /// The Cronus infrastructure instance containing registered service resources.
        /// </param>
        /// <returns>
        /// The updated <see cref="IResourceBuilder{T}"/> for chaining.
        /// </returns>
        public IResourceBuilder<ProjectResource> WithCronusReference(CronusInfrastructure infrastructure)
        {
            project
                .WithCassandraConfigurations(infrastructure.Cassandra)
                .WithRabbitMqConfigurations(infrastructure.RabbitMq)
                .WithConsulConfigurations(infrastructure.Consul)
                .WithRedisConfigurations(infrastructure.Redis);

            return project;
        }

        /// <summary>
        /// Configures the project resource to wait for all Cronus infrastructure services
        /// to be available before starting.
        /// </summary>
        /// <param name="infrastructure">
        /// The Cronus infrastructure instance containing the dependent services.
        /// </param>
        /// <returns>
        /// The updated <see cref="IResourceBuilder{T}"/> for chaining.
        /// </returns>
        public IResourceBuilder<ProjectResource> WaitForCronus(CronusInfrastructure infrastructure)
        {
            project
                .WaitFor(infrastructure.Redis)
                .WaitFor(infrastructure.Cassandra)
                .WaitFor(infrastructure.RabbitMq)
                .WaitFor(infrastructure.Consul);

            return project;
        }
    }
}

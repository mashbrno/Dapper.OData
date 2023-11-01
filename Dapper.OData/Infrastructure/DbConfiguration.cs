namespace Dapper.OData.Infrastructure
{
    public interface IDbConfiguration
    {
        string ConnectionString { get; }
        int ConnectionTimeout { get; }
    }

    public class DbConfiguration : IDbConfiguration
    {

        public DbConfiguration(string connectionString, int connectionTimeout)
        {
            ConnectionString = connectionString;
            ConnectionTimeout = connectionTimeout;
        }
        public string ConnectionString { get; init; }

        public int ConnectionTimeout { get; init; }
    }
}

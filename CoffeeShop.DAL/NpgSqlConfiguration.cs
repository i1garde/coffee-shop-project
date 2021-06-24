using System.Data.Common;
using System.Data.Entity;
using Npgsql;
using System.Data.Entity;

namespace CoffeeShop.DAL
{
    public static class NpgSqlConfiguration
    {
        public static DbConnection GetDatabaseConnection()
        {
            var providerName = "Npgsql"; //Get this
            var databaseName = "CoffeeShopDB";
            var userName = "postgres";
            var password = "postgres";
            var host = "localhost";
            var port = 5432;

            //Insert it here
            var conn = DbProviderFactories.GetFactory(providerName).CreateConnection(); 
            conn.ConnectionString = $"Server={host}; " + $"Port={port}; " + 
                                    $"User Id={userName};" + $"Password={password};" + $"Database={databaseName};";

            return conn;
        }
    }
}
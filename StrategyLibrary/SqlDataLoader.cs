using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace StrategyLibrary
{
    public class SqlDataLoader<T> : IDataLoader<T> where T : DataModel
    {
        private readonly IConfiguration configuration;
        private readonly string cnnString;
        public string ConnectionString => configuration.GetConnectionString(cnnString);

        public SqlDataLoader(IConfiguration configuration, string cnnString)
        {
            this.configuration = configuration;
            this.cnnString = cnnString;
        }

        private IEnumerable<T> GetFromDb()
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                string sql = $"SELECT * FROM {nameof(T)}Table";
                return connection.Query<T>(sql);
            }
        }

        public IEnumerable<T> LoadData()
        {
            return GetFromDb();
        }
    }
}

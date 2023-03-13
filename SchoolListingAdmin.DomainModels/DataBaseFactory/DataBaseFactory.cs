using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using SchoolListingAdmin.DomainModels.Models.TokenEntity;
using System.Data;

namespace SchoolListingAdmin.DomainModels.DataBaseFactory
{
    public class DatabaseFactory
    {

        private readonly IConfiguration _configuration;
        private readonly string _connectionString;
        public DatabaseFactory(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("DefaultConnection");

            AuthDetails.Issuer = _configuration.GetSection("JwtAuth:Issuer").Value;
            AuthDetails.Audience = _configuration.GetSection("JwtAuth:Audience").Value;
            AuthDetails.Key = _configuration.GetSection("JwtAuth:Key").Value;

        }

        public IDbConnection CreateConnection()
            => new SqlConnection(_connectionString);

    }

}

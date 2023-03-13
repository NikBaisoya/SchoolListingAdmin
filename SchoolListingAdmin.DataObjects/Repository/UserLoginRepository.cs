using SchoolListingAdmin.DataObjects.IRepository;
using SchoolListingAdmin.DomainModels.Models.Login;
using System;
using Dapper;
using SchoolListingAdmin.DomainModels.DataBaseFactory;
using System.Data;

namespace SchoolListingAdmin.DataObjects.Repository
{
    public class UserLoginRepository : IUserLoginRepository
    {

        private readonly DatabaseFactory _databaseFactory;

        public  UserLoginRepository(DatabaseFactory databaseFactory)
        {
            _databaseFactory = databaseFactory;

        }



        public UserLogin PerformLogin(UserAuthentication userAuthentication)
        {

            using (var dbConnection= _databaseFactory.CreateConnection())
            {

                var parameters = new DynamicParameters();
                parameters.Add("@UserName", userAuthentication.UserName);
                parameters.Add("@Password", userAuthentication.Password);

                return dbConnection.QueryFirstOrDefault<UserLogin>("dbo.usp_UserLogin_Get", parameters, null, null, CommandType.StoredProcedure);


            }



        }
    }
}

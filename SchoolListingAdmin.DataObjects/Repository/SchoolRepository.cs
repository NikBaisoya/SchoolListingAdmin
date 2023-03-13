using Dapper;
using SchoolListingAdmin.DataObjects.IRepository;
using SchoolListingAdmin.DomainModels.DataBaseFactory;
using SchoolListingAdmin.DomainModels.Models.School;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolListingAdmin.DataObjects.Repository
{
    public class SchoolRepository : ISchoolRepository
    {

        private readonly DatabaseFactory _DatabaseFactory;
        public SchoolRepository(DatabaseFactory databaseFactory)
        {
            _DatabaseFactory = databaseFactory;

        }




        public IEnumerable<School> MySchoolsByIdGet(int userId)
        {

            using (var dbConnetion = _DatabaseFactory.CreateConnection())
            {

                var parameter = new DynamicParameters();
                parameter.Add("@UserId", userId);

                return  dbConnetion.Query<School>("dbo.usp_MySchoolsById_Get", parameter, null, true, null, CommandType.StoredProcedure);


            }



        }
    }
}

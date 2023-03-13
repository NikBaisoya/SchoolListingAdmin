using SchoolListingAdmin.DomainModels.Models.School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolListingAdmin.DataObjects.IRepository
{
    public interface ISchoolRepository
    {

        IEnumerable<School> MySchoolsByIdGet(int userId);


    }
}

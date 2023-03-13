using SchoolListingAdmin.DomainModels.Models.School;
using SchoolListingAdmin.DomainModels.RequestResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolListingAdmin.BusinessObjects.IService
{
    public interface ISchoolService
    {
      RequestResponse MySchoolsListGet(int userId);

    }
}

using SchoolListingAdmin.DomainModels.Models.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolListingAdmin.BusinessObjects.IService
{
    public interface IUserLoginService
    {
        UserLogin PerformLogin(UserAuthentication userAuthentication);
    }
}

using SchoolListingAdmin.DomainModels.Models.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolListingAdmin.DataObjects.IRepository
{
    public interface IUserLoginRepository
    {
        UserLogin PerformLogin(UserAuthentication userAuthentication);
    }
}

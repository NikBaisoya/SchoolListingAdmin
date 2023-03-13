using SchoolListingAdmin.BusinessObjects.IService;
using SchoolListingAdmin.DataObjects.IRepository;
using SchoolListingAdmin.DataObjects.Repository;
using SchoolListingAdmin.DomainModels.Models.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolListingAdmin.BusinessObjects.Service
{
    public class UserLoginService : IUserLoginService
    {

        private readonly IUserLoginRepository _UserLoginRepository;
        public UserLoginService(IUserLoginRepository userLoginRepository)
        {
            _UserLoginRepository = userLoginRepository;
        }

        public UserLogin PerformLogin(UserAuthentication userAuthentication)
        {

            try
            {
                return this._UserLoginRepository.PerformLogin(userAuthentication);
            }

            catch(Exception ex)
            {
                throw new NotImplementedException();
            }
        }
    }
}

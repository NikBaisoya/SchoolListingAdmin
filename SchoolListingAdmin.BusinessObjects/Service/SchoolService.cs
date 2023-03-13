using Azure;
using SchoolListingAdmin.BusinessObjects.IService;
using SchoolListingAdmin.DataObjects.IRepository;
using SchoolListingAdmin.DomainModels.Models.School;
using SchoolListingAdmin.DomainModels.RequestResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SchoolListingAdmin.BusinessObjects.Service
{
    public class SchoolService : ISchoolService
    {
        private readonly ISchoolRepository _SchoolRepository;
        public RequestResponse _response = new RequestResponse();



        public SchoolService(ISchoolRepository schoolRepository)
        {
            _SchoolRepository = schoolRepository;
        }

        public RequestResponse MySchoolsListGet(int userId)
        {
            try
            {
               var response = this._SchoolRepository.MySchoolsByIdGet(userId).ToList();

                _response.Data = response;
                _response.StatusMessage = "Success";
                _response.StatuCode = (int)HttpStatusCode.OK;

            }


            catch(Exception ex)
            {
                _response.Data = null;
                _response.StatusMessage = "Success";
                _response.StatuCode = (int)HttpStatusCode.InternalServerError;
            }

            return _response;
        
        }
    }
}

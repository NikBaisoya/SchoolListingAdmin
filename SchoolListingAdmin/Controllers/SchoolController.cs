using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolListingAdmin.BusinessObjects.IService;
using SchoolListingAdmin.DataObjects.IRepository;
using SchoolListingAdmin.DomainModel.Helpers;
using System.Security.Claims;

namespace SchoolListingAdmin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolController : ControllerBase
    {

        private readonly ISchoolService _SchoolService;
        public SchoolController(ISchoolService schoolService)
        {
            _SchoolService = schoolService;

        }



        [Authorize]
        [HttpGet]
        [Route("MySchoolsListGet")]
        public IActionResult MySchoolsListGet()
        {
           var identity = HttpContext.User.Identity as ClaimsIdentity;
           var currentUser = TokenHelper.GetCurrentUser(identity);

            if(currentUser.Id ==null || currentUser.Id==0)
            {
                return Unauthorized();
            }

            var response = this._SchoolService.MySchoolsListGet(currentUser.Id);
            return Ok(response);
        }



    }
}

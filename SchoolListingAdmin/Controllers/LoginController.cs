using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolListingAdmin.BusinessObjects.IService;
using SchoolListingAdmin.DomainModels.Models.Login;
using SchoolListingAdmin.DomainModel.Helpers;

namespace SchoolListingAdmin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IUserLoginService _LoginService;
        public LoginController(IUserLoginService loginService, IConfiguration configuration)
        {
            _LoginService = loginService;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("AuthenticateUser")]

        public IActionResult AuthenticateUser(UserAuthentication userAuthentication)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var response = this._LoginService.PerformLogin(userAuthentication);
            if (response.UserName == null)
            {
                return Unauthorized();
            }

            var Token = TokenHelper.GenerateToken(response);
            return Ok(Token);
        }
    }
}

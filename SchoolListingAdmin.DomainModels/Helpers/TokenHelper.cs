
using Microsoft.IdentityModel.Tokens;
using SchoolListingAdmin.DomainModels.Models.Login;
using SchoolListingAdmin.DomainModels.Models.TokenEntity;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace SchoolListingAdmin.DomainModel.Helpers
{
    public  class TokenHelper
    {

        //Important note***************
        //The secret is a base64-encoded string, always make sure to use a secure long string so no one can guess it. ever!.
        //a very recommended approach to use is through the HMACSHA256() class, to generate such a secure secret, you can refer to the below function
        // you can run a small test by calling the GenerateSecureSecret() function to generate a random secure secret once, grab it, and use it as the secret above 
        // or you can save it into appsettings.json file and then load it from them, the choice is yours


        public static TokenEntity GenerateToken(UserLogin userLogin)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.UTF8.GetBytes(AuthDetails.Key);//Convert.FromBase64String(Secret);

            var claimsIdentity = new ClaimsIdentity(new[] {
                new Claim(ClaimTypes.NameIdentifier, userLogin.Id.ToString()),
                new Claim(ClaimTypes.Email, userLogin.UserName.ToString()),
                new Claim(ClaimTypes.Name, userLogin.Name.ToString()),
                new Claim(ClaimTypes.GivenName, userLogin.Id.ToString()),
                new Claim("IsActive", userLogin.IsActive.ToString()),
                new Claim("IsDefaultPasswordReset", userLogin.IsDefaultPasswordReset.ToString()),
                new Claim("RoleTitle", userLogin.IsActive.ToString()),
                new Claim("IsAuthorize", true.ToString())

            });

            var signingCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = claimsIdentity,
                Issuer = AuthDetails.Issuer,
                Audience = AuthDetails.Audience,
                Expires = DateTime.Now.AddDays(1),
                SigningCredentials = signingCredentials,

            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return new TokenEntity() { Token = tokenHandler.WriteToken(token), ValidFrom = token.ValidFrom, ValidTo = token.ValidTo };


        }



        public static UserLogin GetCurrentUser(ClaimsIdentity identity)
        {
            if (identity != null)
            {
                var userClaims = identity.Claims;
                return new UserLogin
                {
                    UserName = userClaims.FirstOrDefault(x => x.Type == ClaimTypes.Email)?.Value,
                    Id = Convert.ToInt16(userClaims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value),

                };
            }
            return null;


        }










   






    }

}

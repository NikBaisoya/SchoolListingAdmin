using SchoolListingAdmin.DomainModels.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolListingAdmin.DomainModels.Models.Login
{
    public class UserLogin
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? UserName { get; set; }
        public string? Passsword { get; set; }
        public int RoleId { get; set; }
        public string? IsActive { get; set; }
        public string? IsDefaultPasswordReset { get; set; }
        public DateTime CreatedOn { get; set; }
        public string? RoleTitle { get; set; }
        public List<int>? Permissions { get; set; }

        



    }
}

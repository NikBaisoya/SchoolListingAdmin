using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolListingAdmin.DomainModels.Models.TokenEntity
{
    public class AuthDetails
    {
        public static string Issuer { get; set; }
        public static string Audience { get; set; }
        public static string Key { get; set; }
    }
}

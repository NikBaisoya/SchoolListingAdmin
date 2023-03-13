using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolListingAdmin.DomainModels.RequestResponse
{
    public class RequestResponse
    {
        public object Data { get; set; }
        public string StatusMessage { get; set; }
        public  int StatuCode { get; set; }


    }
}

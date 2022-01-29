using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DapperExample.Models
{
    public class RegistrationModel
    {
        public string EmployeeName { get; set; }
        public string Pwd { get; set; }
        public string EGender { get; set; }
        public string Country { get; set; }
        public string EAddress { get; set; }
        public bool EAcceptterm { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DapperExample.Models
{
    public class RegistrationModel
    {
        [Required(ErrorMessage ="Employee Name Cannot be Empty")]
        public string EmployeeName { get; set; }
        [Required(ErrorMessage = "PWd Name Cannot be Empty")]

        public string Pwd { get; set; }
        [Compare("Pwd",ErrorMessage ="Pwd and confirm password mismatch")]
        public string ConfirmPwd { get; set; }
        [DataType(DataType.EmailAddress)]
        public string  EmaildAddress { get; set; }
        public string EGender { get; set; }
        [Required]
        public string Country { get; set; }
        [StringLength(10,ErrorMessage ="MAx 10 character")]
        public string EAddress { get; set; }
        public bool EAcceptterm { get; set; }
    }
}
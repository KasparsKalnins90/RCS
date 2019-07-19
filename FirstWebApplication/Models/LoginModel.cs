using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FirstWebApplication.Models
{
    public class LoginModel
    {
        
        [StringLength(100)]
        public string Email { get; set; }

        
        [StringLength(50)]
        public string Password { get; set; }

        [StringLength(100)]
        [Display(Name = "Name")] // šeit var mainīt kā mēs gribam lai parāda šo nosaukumu tabulā
        public string Name { get; set; }
    }
}
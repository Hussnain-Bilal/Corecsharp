using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Corecsharp2.Models
{
    public class Contact
    {
        
        public int ContactID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required,EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Message { get; set; }

    }
}
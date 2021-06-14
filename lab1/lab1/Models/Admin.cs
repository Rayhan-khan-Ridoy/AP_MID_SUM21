using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace lab1.Models
{
    public class Admin
    {
        [Required(ErrorMessage = "Please put your username")]
        [MaxLength(10, ErrorMessage = "Max Length 10")]

        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }



     
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace lab1.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Please put your name")]
        [MaxLength(5, ErrorMessage = "Max Length 5")]
        public string Name{ get; set; }

        [Required]
        public string ID{ get; set; }

        

        [Required]
        public string DOB { get; set; }

        [Required]
        public string Credit { get; set; }

        [Required]
        public string CGPA { get; set; }

        [Required]
        public string Dept_id { get; set; }

    }
}
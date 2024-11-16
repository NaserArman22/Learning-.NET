using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace formValidation.Models
{
    public class Student
    {
        [Required(ErrorMessage ="Please provide Name")]
        [StringLength(20) ]
        public string Name {  get; set; }
        [Required]
        [EmailAddress]
        public string email { get; set; }
        [Required]
        [Range(1,40)]
        public int ID { get; set; }
        public float cgpa { get; set; }
        [Required]
        //[StringLength(100,MinimumLength=8,ErrorMessage ="minimum 8 character")]
        [MinLength(8)]
        public string password {  get; set; }

    }
}
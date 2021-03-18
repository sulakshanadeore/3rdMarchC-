using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Web;


namespace MVCStateMgtDemo.Models
{
    public class Employee
    {
        [Required(ErrorMessage =" Empno Required")]
        public int Empid { get; set; }

        [Required(ErrorMessage ="Email Required")]
        [StringLength(10,ErrorMessage ="Name is more than 10 chars")]
        [MinLength(1,ErrorMessage =
            "Name must be atleast 1 char")]
        public string Empname { get; set; }

        [EmailAddress(ErrorMessage ="Not valid email")]
        [Required(ErrorMessage ="Required Data")]
        public string Email { get; set; }

        [RegularExpression("http(s)?://([\\w-]+\\.)+[\\w-]+(/[\\w- ./?%&=]*)?", ErrorMessage ="Url is Invalid")]
        public string Url { get; set; }

        [Range(19,60,ErrorMessage ="Not valid range")]
        public int Age{ get; set; }

        [FileExtensions(Extensions = "doc,pdf", ErrorMessage = "Not valid extension")]
        public FileStream ResumeFile { get; set; }

        [DataType(DataType.PhoneNumber)]
        [StringLength(12,ErrorMessage ="Not valid")]
        
        //[Phone()]
        //[MaxLength(13,ErrorMessage ="Exceeded Max length")]
        public string ContactNumber { get; set; }


    }
}
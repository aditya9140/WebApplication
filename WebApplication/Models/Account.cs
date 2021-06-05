using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models
{
    public class Account
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Please Enter Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please Enter Phone No")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please Enter Email")]

        public string Email { get; set; }
        
        public string Text { get; set; }
    

       }
}
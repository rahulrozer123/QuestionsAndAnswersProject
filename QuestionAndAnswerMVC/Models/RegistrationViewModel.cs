using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuestionAndAnswerMVC.Models
{
    public class RegistrationViewModel
    {       
        [Key]
        public int UserId { get; set; }
        [Required(ErrorMessage = "Username Is required")]

        public int RoleId { get; set; }
        public string Username { get; set; }
        [Required(ErrorMessage = "Email id Is required")]       
        public string Email { get; set; }
        [Required(ErrorMessage = "Password Is required")]
        [DataType(DataType.Password)]
        public string Pwd { get; set; }
        [DataType(DataType.Password)]
        [Compare("Pwd", ErrorMessage = "Passwords must match")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Years of experience Is required")]        
        public int YearsOfExperience { get; set; }
        [Required(ErrorMessage = "Technology Is required")]
        //[Display(Name = "Technology")]
        public string Technology { get; set; }
    }
}
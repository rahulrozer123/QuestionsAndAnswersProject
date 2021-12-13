using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionsAndAnswersWebAPI.Models
{
    public class RegistrationModel
    {
        //[Key]
        //public int UserId { get; set; }
        //public int RoleId { get; set; }
        public string Username { get; set; }       
        public string Email { get; set; }
        public int YearsOfExperience { get; set; }
        public string Technology { get; set; }

    }
}

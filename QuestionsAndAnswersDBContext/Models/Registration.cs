﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace QuestionsAndAnswersDBContext.Models
{
    public  partial class Registration
    {
        [Key]
        public int UserId { get; set; }       
        public int RoleId { get; set; }
        public string Username { get; set; }
        public string Pwd { get; set; }
        public string ConfirmPassword { get; set; }

        public string Email { get; set; }
        public int YearsOfExperience { get; set; }
        public string Technology { get; set; }
    }
}

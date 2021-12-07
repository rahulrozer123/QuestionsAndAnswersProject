using Microsoft.EntityFrameworkCore;
using QuestionsAndAnswersProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionsAndAnswersProject.Data
{
    public class ApplicationUser : DbContext
    {
        public ApplicationUser(DbContextOptions<ApplicationUser> options) : base(options)
        {

        }

        public DbSet<RegistrationModel> UserRegistration { get; set; }

       // public DbSet<QuestionandAnswer> QuestionandAnswer { get; set; }
    }
}

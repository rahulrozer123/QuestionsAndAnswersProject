using Microsoft.EntityFrameworkCore;
using QuestionsAndAnswersDBContext.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionsAndAnswersDBContext.Data
{
    public class AnswersContext : DbContext
    {
        public AnswersContext(DbContextOptions<AnswersContext> options)
           : base(options)
        {
        }

        public DbSet<AnswersModel> Answers { get; set; }
        public DbSet<RegistrationModel> UserRegistration { get; set; }
        public DbSet<QuestionsAndAnswersModel> QuestionandAnswer { get; set; }

        public DbSet<TechnologyModel> MasterTechnology { get; set; }
    }
}

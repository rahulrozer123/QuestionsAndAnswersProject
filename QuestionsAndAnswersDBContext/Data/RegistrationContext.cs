using Microsoft.EntityFrameworkCore;
using QuestionsAndAnswersDBContext.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionsAndAnswersDBContext.Data
{
    public class RegistrationContext : DbContext
    {
        public RegistrationContext(DbContextOptions<RegistrationContext> options)
            : base(options)
        {

        }

        public DbSet<RegistrationModel> UserRegistration { get; set; }
    }
}

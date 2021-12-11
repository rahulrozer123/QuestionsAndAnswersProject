using Microsoft.EntityFrameworkCore;
using QuestionsAndAnswersWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionsAndAnswersWebAPI.Data
{
    public class AnswersContext : DbContext
    {
        public AnswersContext(DbContextOptions<AnswersContext> options)
            : base(options)
        {
        }

        public DbSet<AnswersModel> Answers { get; set; }
    }
}

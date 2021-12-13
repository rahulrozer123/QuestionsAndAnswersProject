using Microsoft.EntityFrameworkCore;
using QuestionsAndAnswersDBContext.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionsAndAnswersDBContext.Data
{
    public class QuestionsAndAnswersContext : DbContext
    {
        public QuestionsAndAnswersContext(DbContextOptions<QuestionsAndAnswersContext> options)
           : base(options)
        {
        }
        public DbSet<QuestionsAndAnswersModel> QuestionandAnswer { get; set; }
    }
}

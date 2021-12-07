using Microsoft.EntityFrameworkCore;
using QuestionsAndAnswersWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionsAndAnswersWebAPI.Data
{
    public class QuestionsAndAnswersContext :DbContext
    {
        public QuestionsAndAnswersContext(DbContextOptions<QuestionsAndAnswersContext> options)
            : base(options)
        {
        }

        public DbSet<QuestionsAndAnswersModel> QuestionandAnswer { get; set; }

        public DbSet<TechnologyModel> MasterTechnology { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using QuestionsAndAnswersDBContext.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionsAndAnswersDBContext.Data
{
    public class TechnologyContext : DbContext
    {
        public TechnologyContext(DbContextOptions<TechnologyContext> options)
            : base(options)
        {

        }

        public DbSet<TechnologyModel> MasterTechnology { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using QuestionsAndAnswersWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionsAndAnswersWebAPI.Data
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

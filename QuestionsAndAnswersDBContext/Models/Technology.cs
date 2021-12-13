using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionsAndAnswersDBContext.Models
{
    public partial class Technology
    {
        [Key]
        public int TechnologyId { get; set; }

        public string TechnologyName { get; set; }
    }
}

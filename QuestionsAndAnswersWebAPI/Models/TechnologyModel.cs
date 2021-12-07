using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionsAndAnswersWebAPI.Models
{
    public class TechnologyModel
    {
        [Key]
        public int TechnologyId { get; set; }

        public string TechnologyName { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuestionAndAnswerMVC.Models
{
    public class TechnologyViewModel
    {
        [Key]
        public int TechnologyId { get; set; }
        public string TechnologyName { get; set; }        
    }
}
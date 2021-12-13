using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionsAndAnswersDBContext.Models
{
    public partial class Roles
    {
        [Key]
        public int RoleId { get; set; }

        public string Rolename { get; set; }
    }
}

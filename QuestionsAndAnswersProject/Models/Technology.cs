using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionsAndAnswersProject.Models
{
    public class Technology
    {
        [Required]
        public string SelectedTechnology { get; set; }
      

        //C Sharp tecnology
         public FirstTechnology firstTechnology { get; set; }

        public SecondTechnology secondTechnology { get; set; }

        public ThirdTechnology thirdTechnology { get; set; }

        public FourthTechnology fourthTechnology { get; set; }

        public FifthTechnology fifthTechnology { get; set; }
    }

    public class FirstTechnology
    {
        public string Question1Answer { get; set; }
        public string Question2Answer { get; set; }
        public string Question3Answer { get; set; }
        public string Question4Answer { get; set; }
        public string Question5Answer { get; set; }
        public string Question6Answer { get; set; }
        public string Question7Answer { get; set; }
        public string Question8Answer { get; set; }
        public string Question9Answer { get; set; }
        public string Question10Answer { get; set; }
    }

    public class SecondTechnology
    {
        public string Question1Answer { get; set; }
        public string Question2Answer { get; set; }
        public string Question3Answer { get; set; }
        public string Question4Answer { get; set; }
        public string Question5Answer { get; set; }
        public string Question6Answer { get; set; }
        public string Question7Answer { get; set; }
        public string Question8Answer { get; set; }
        public string Question9Answer { get; set; }
        public string Question10Answer { get; set; }
    }

    public class ThirdTechnology
    {
        public string Question1Answer { get; set; }
        public string Question2Answer { get; set; }
        public string Question3Answer { get; set; }
        public string Question4Answer { get; set; }
        public string Question5Answer { get; set; }
        public string Question6Answer { get; set; }
        public string Question7Answer { get; set; }
        public string Question8Answer { get; set; }
        public string Question9Answer { get; set; }
        public string Question10Answer { get; set; }
    }

    public class FourthTechnology
    {
        public string Question1Answer { get; set; }
        public string Question2Answer { get; set; }
        public string Question3Answer { get; set; }
        public string Question4Answer { get; set; }
        public string Question5Answer { get; set; }
        public string Question6Answer { get; set; }
        public string Question7Answer { get; set; }
        public string Question8Answer { get; set; }
        public string Question9Answer { get; set; }
        public string Question10Answer { get; set; }
    }

    public class FifthTechnology
    {
        public string Question1Answer { get; set; }
        public string Question2Answer { get; set; }
        public string Question3Answer { get; set; }
        public string Question4Answer { get; set; }
        public string Question5Answer { get; set; }
        public string Question6Answer { get; set; }
        public string Question7Answer { get; set; }
        public string Question8Answer { get; set; }
        public string Question9Answer { get; set; }
        public string Question10Answer { get; set; }
    }
}

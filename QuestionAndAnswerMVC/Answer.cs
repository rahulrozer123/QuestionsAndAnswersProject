//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuestionAndAnswerMVC
{
    using System;
    using System.Collections.Generic;
    
    public partial class Answer
    {
        public int AnswersID { get; set; }
        public string ReceivedAnswers { get; set; }
        public Nullable<bool> Result { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> TechnologyID { get; set; }
        public Nullable<int> QuestionID { get; set; }
    
        public virtual QuestionandAnswer QuestionandAnswer { get; set; }
        public virtual MasterTechnology MasterTechnology { get; set; }
        public virtual UserRegistration UserRegistration { get; set; }
    }
}

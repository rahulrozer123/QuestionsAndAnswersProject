using QuestionsAndAnswersDBContext.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionsAndAnswersDBContext.Services
{
    public interface IQuestionAndAnswerDBService
    {
        //Gets all the data from the database
        public IEnumerable<QuestionsAndAnswers> GetAllQuestionsAndAnswers();

        //Get the questions and other data  by specifying the ID
        //QuestionsAndAnswersModel GetById(int id);
        public List<QuestionsAndAnswers> GetQuestionsByTechnologyId(int technologyId);

        //Add the questions and related data to db
        //it is similar to post operation
       //QuestionsAndAnswersModel Add(QuestionsAndAnswersModel questionsAndAnswersModel);

        //Removes the data by specifying the id
        //void Delete(int id);

        //Updates the data by speciying the ID
        public void Update(QuestionsAndAnswers questionsAndAnswersModel);

       
    }
}

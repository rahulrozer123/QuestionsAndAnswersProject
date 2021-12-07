using QuestionsAndAnswersWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionsAndAnswersWebAPI.Services
{
    public interface IQuestionAndAnswerService
    {
        //Gets all the data from the database
        IEnumerable<QuestionsAndAnswersModel> GetAllQuestionsAndAnswers();

        //Get the questions and other data  by specifying the ID
        //QuestionsAndAnswersModel GetById(int id);
        List<QuestionsAndAnswersModel> GetByTechnologyId(int id);

        //Add the questions and related data to db
        //it is similar to post operation
       //QuestionsAndAnswersModel Add(QuestionsAndAnswersModel questionsAndAnswersModel);

        //Removes the data by specifying the id
        //void Delete(int id);

        //Updates the data by speciying the ID
        void Update(int id, QuestionsAndAnswersModel questionsAndAnswersModel);
    }
}

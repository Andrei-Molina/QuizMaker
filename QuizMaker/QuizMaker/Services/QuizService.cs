using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuizMaker.Models;

namespace QuizMaker.Services
{
    public class QuizService
    {
        private readonly Quiz _quiz;
        public QuizService(Quiz quiz)
        {
            _quiz = quiz;    
        }

        public void AddQuestion(Question question)
        {
            _quiz.Questions.Add(question);
        }

        public IEnumerable<Question> GetQuestions()
        {
            return _quiz.Questions;
        }
    }
}

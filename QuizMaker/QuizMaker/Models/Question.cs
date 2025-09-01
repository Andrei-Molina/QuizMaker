using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaker.Models
{
    public abstract class Question
    {
        public string QuestionText { get; set; }
        public List<string> QuestionChoices { get; set; }
        public int Point { get; set; }

        public abstract bool CheckAnswer(string answer);

        public override string ToString()
        {
            return "MCQ" + QuestionText;
        }
    }
}

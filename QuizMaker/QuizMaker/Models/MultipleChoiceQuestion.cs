using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaker.Models
{
    public class MultipleChoiceQuestion : Question
    {
        public string CorrectAnswer { get; set; }

        public override bool CheckAnswer(string answer)
        {
            return string.Equals(answer, CorrectAnswer, StringComparison.OrdinalIgnoreCase);
        }

        public override string ToString()
        {
            return "MCQ" + QuestionText;
        }
    }
}

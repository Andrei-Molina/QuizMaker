using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaker.Models
{
    public class TrueOrFalseQuestion : Question
    {
        public bool CorrectAnswer { get; set; }
        public override bool CheckAnswer(string answer)
        {
            bool parsed;
            if (bool.TryParse(answer, out parsed))
            {
                return parsed == CorrectAnswer;
            }

            return false;
        }

        public override string ToString()
        {
            return "[True/False] " + QuestionText;
        }
    }
}

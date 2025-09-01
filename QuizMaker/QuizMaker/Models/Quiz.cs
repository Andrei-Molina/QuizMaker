using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaker.Models
{
    public class Quiz
    {
        public string Title { get; set; }
        public List<Question> Questions { get; set; }
        public Quiz()
        {
            Questions = new List<Question>();
        }

        public int GetTotalPoints()
        {
            int total = 0;
            foreach (var q in Questions)
            {
                total += q.Point;
            }

            return total;
        }
    }
}

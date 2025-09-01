using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuizMaker.Models;
using Newtonsoft.Json;
using System.IO;

namespace QuizMaker.Services
{
    public static class QuizStorage
    {
        public static void SaveQuiz(Quiz quiz, string filePath)
        {
            var settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            };

            string json = JsonConvert.SerializeObject(quiz, Formatting.Indented, settings);
            File.WriteAllText(filePath, json);
        }

        public static Quiz LoadQuiz(string filePath)
        {
            if (!File.Exists(filePath))
                return new Quiz();

            var settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            };

            string json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<Quiz>(json, settings);
        }
    }
}

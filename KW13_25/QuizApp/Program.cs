using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA23_M320_4.Semester.KW13_25.QuizApp
{
    class Program
    {
        static void Main(string[]args)
        {
            Question[] allQuestions = new Question[]
            {
                         // questionText, // Answers                            // AnswerIndex
                new Question ("Frage 1", new string[] {"Antwort1", "Antwort2"}, 0),
                new Question ("Frage 2", new string[] {"Antwort1", "Antwort2", "Antwort3"}, 2),
                new Question ("Frage 3", new string[] {"Antwort1", "Antwort2", "Antwort3"}, 1)
            };



            Quiz q = new Quiz(allQuestions);

            q.StartQuiz();

            Console.ReadKey();


        }
    }
}

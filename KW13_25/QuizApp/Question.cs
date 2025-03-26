using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA23_M320_4.Semester.KW13_25.QuizApp
{
    class Question
    {
        public string QuestionText { get; set; }

        public string[] Answers { get; set; }

        public int AnswerIndex { get; set; }

        public int ChooseAnswerIndex { get; set; }

        public Question (string questionText, string[] anwers, int answerIndex)
        {
            this.QuestionText = questionText;
            this.Answers = anwers;
            this.AnswerIndex = answerIndex;
        }
    }
}

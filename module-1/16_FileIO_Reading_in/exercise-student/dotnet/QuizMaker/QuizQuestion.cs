using System;
using System.Collections.Generic;
using System.Text;

namespace QuizMaker
{
    public class QuizQuestion
    {
        public string Question { get; private set; }
        public int CorrectAnswer { get; private set; }
        public QuizQuestion(string firstLine, List<string>allAnswers)
        {
            Question = firstLine;
            Console.WriteLine(Question);
            int selectAnswer = 0;
            for (int i = 0; i < (allAnswers.Count); i++)
            {
                if (allAnswers[i].Substring(allAnswers[i].Length - 1, 1) == "*")
                {
                    selectAnswer++;
                    Console.WriteLine($"{selectAnswer}. {allAnswers[i].Substring(0, allAnswers[i].Length - 1)}");
                    CorrectAnswer = selectAnswer;
                }
                else
                {
                    selectAnswer++;
                    Console.WriteLine($"{selectAnswer}. {allAnswers[i]}");
                }
            }
        }
    }
}

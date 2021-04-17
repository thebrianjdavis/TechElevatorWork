using System;
using System.IO;
using System.Collections.Generic;

namespace QuizMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the fully qualified file path to read for quiz questions:\n");
            string filePath = Console.ReadLine();
            Console.WriteLine();

            int answeredCorrect = 0;
            int questionsAsked = 0;
            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {

                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        
                        List<string> questionSplit = new List<string>(line.Split("|"));
                        string firstString = questionSplit[0];
                        
                        List<string> allAnswers = new List<string>();
                        
                        for (int i = 1; i < questionSplit.Count; i++)
                        {
                            allAnswers.Add(questionSplit[i]);
                        }
                        QuizQuestion question = new QuizQuestion(firstString, allAnswers);
                        
                        Console.Write("\nYour Answer: ");
                        string userAnswerString = Console.ReadLine();
                        int userAnswerInt = int.Parse(userAnswerString);
                        if (userAnswerInt == question.CorrectAnswer)
                        {
                            Console.WriteLine("RIGHT!\n");
                            answeredCorrect++;
                            questionsAsked++;
                        }
                        else
                        {
                            Console.WriteLine("WRONG!\n");
                            questionsAsked++;
                        }
                    }
                    Console.WriteLine($"You got {answeredCorrect} answer(s) correct out of the {questionsAsked} questions asked.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Not a valid file path or file type.");
            }
            Console.ReadLine();
            Console.Clear();
        }
    }
}

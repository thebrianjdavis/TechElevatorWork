using System;
using System.IO;

namespace FizzWriter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a fully qualified file path: \n");
            string filePath = Console.ReadLine();
            
            try
            {
                using (StreamWriter sw = new StreamWriter(filePath)) 
                {
                    for (int i = 1; i < 301; i++)
                    {
                        string intAsString = i.ToString();

                        if (i % 3 == 0 && i % 5 == 0)
                        {
                            sw.WriteLine("FizzBuzz");
                        }
                        else if (i % 5 == 0 || intAsString.Contains('5'))
                        {
                            sw.WriteLine("Buzz");
                        }
                        else if (i % 3 == 0 || intAsString.Contains('3'))
                        {
                            sw.WriteLine("Fizz");
                        }
                        else
                        {
                            sw.WriteLine($"{i}");
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Sorry, file path was not valid.");
            }
        }
    }
}

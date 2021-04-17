using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will list all of the \n Fibonacci numbers up to a provided value.");
            Console.WriteLine("\nEnter an ending value: ");
            string endingNumber = Console.ReadLine();
            int stopValue = int.Parse(endingNumber);

            int[] fibArray = new int[3];
            fibArray[0] = 1;
            fibArray[1] = fibArray[0];
            fibArray[2] = fibArray[0] + fibArray[1];

            Console.Write("1");

            while (fibArray[2] < stopValue)
            {
                Console.Write($" {fibArray[2]}");
                fibArray[0] = fibArray[1];
                fibArray[1] = fibArray[2];
                fibArray[2] = fibArray[0] + fibArray[1];
            }

            Console.ReadLine();
            Console.Clear();
        }
    }
}

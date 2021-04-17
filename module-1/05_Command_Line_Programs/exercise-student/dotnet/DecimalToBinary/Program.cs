using System;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter in a series of decimal values (separated by spaces): \n");
            string notBinary;
            notBinary = Console.ReadLine();

            string[] convToBinary;
            convToBinary = notBinary.Split(' ');

            for (int i = 0; i < convToBinary.Length; i++)
            {
                int numToConvert;
                numToConvert = int.Parse(convToBinary[i]);
                string binary;
                binary = Convert.ToString(numToConvert, 2);
                Console.WriteLine($"{numToConvert} in binary is {binary}");
            }
            Console.WriteLine("\n\nPress return to exit...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}

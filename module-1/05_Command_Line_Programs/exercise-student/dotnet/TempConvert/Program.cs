using System;

namespace TempConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a temperature to convert: ");
            string tempInput = Console.ReadLine();
            double tempToConvert = double.Parse(tempInput);
            Console.Clear();

            Console.WriteLine($"Enter whether you would like to \nconvert {tempToConvert} into (C)elcius or (F)ahrenheit: ");
            string convType = Console.ReadLine();
            char convLetter = char.Parse(convType);
            Console.Clear();

            if (convLetter == 'C')
            {
                double convertedTemp = (tempToConvert - 32) / 1.8;
                Console.WriteLine($"{tempToConvert}F is {convertedTemp}C.");
                Console.WriteLine("Press return to exit!");
                Console.ReadLine();
                Console.Clear();
            }
            else if (convLetter == 'F')
            {
                double convertedTemp = (tempToConvert * 1.8) + 32;
                Console.WriteLine($"{tempToConvert}C is {convertedTemp}F.");
                Console.WriteLine("\n\nPress return to exit!");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}

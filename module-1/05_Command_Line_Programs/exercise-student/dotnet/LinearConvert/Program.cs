using System;

namespace LinearConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Meters and Feet Conversion");
            Console.Write("Enter a numeric length to convert: ");
            string lengthInput = Console.ReadLine();
            double lengthToConvert = double.Parse(lengthInput);
            Console.Clear();

            Console.Write($"Is the measurement in (m)eters or (f)eet: ");
            string convType = Console.ReadLine();
            char convLetter = char.Parse(convType);
            Console.Clear();

            if (convLetter == 'm')
            {
                double convertedLength = (lengthToConvert * 3.2808399);
                Console.WriteLine($"{lengthToConvert}m is {convertedLength}f.");
                Console.WriteLine("\n\nPress return to exit!");
                Console.ReadLine();
                Console.Clear();
            }
            else if (convLetter == 'f')
            {
                double convertedLength = (lengthToConvert * 0.3048);
                Console.WriteLine($"{lengthToConvert}f is {convertedLength}m.");
                Console.WriteLine("\n\nPress return to exit!");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}

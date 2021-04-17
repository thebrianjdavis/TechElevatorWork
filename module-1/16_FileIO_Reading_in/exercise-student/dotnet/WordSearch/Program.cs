using System;
using System.IO;
using System.Collections.Generic;

namespace WordSearch
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //1. Ask the user for the file path

            Console.WriteLine("Please enter fully qualified file path for the file to be searched:\n");
            string filePath = Console.ReadLine();

            //2. Ask the user for the search string

            Console.WriteLine("Please enter the search string:\n");
            string searchString = Console.ReadLine();

            Console.WriteLine("Should the search be case sensitive (Y or N)?");
            string caseSensitive = Console.ReadLine();
            bool isCaseSensitive = true;

            if(caseSensitive.ToUpper() == "N")
            {
                isCaseSensitive = false;
            }

            //3. Open the file

            int lineNumber = 1;
            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    
                    //4. Loop through each line in the file
                    
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();

                        //5. If the line contains the search string, print it out along with its line number
                        
                        if (!isCaseSensitive && line.Contains(searchString, StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine($"{lineNumber.ToString()}) {line}");
                        }
                        else if(line.Contains(searchString))
                        {
                            Console.WriteLine($"{lineNumber.ToString()}) {line}");
                        }
                        lineNumber++;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Not a valid file path or file type.");
            }
            

            //5. If the line contains the search string, print it out along with its line number

        }
    }
}

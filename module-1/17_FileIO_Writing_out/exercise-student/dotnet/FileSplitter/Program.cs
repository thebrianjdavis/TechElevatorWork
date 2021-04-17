using System;
using System.IO;
using System.Collections.Generic;

namespace FileSplitter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Where is the input file (please include the path to the file)? [path-to-file]/input.txt ");
            string fileDir = Console.ReadLine();
            string fileName = "input.txt";
            string filePath = Path.Combine(fileDir, fileName);
            string justFileName = Path.GetFileNameWithoutExtension(fileName);
            string fileExtension = Path.GetExtension(fileName);

            Console.Write("How many lines of text (max) should there be in the split files? ");
            string lineSplitStr = Console.ReadLine();
            int lineSplitInt = int.Parse(lineSplitStr);

            int fileIteration = 0;
            int lineIteration = 0;

            List<string> generatedFileNames = new List<string>();

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    while (!sr.EndOfStream)
                    {
                        string currentFileName = justFileName + "-" + (fileIteration + 1).ToString() + fileExtension;
                        string fullQualified = Path.Combine(fileDir, currentFileName);
                        using (StreamWriter sw = new StreamWriter(fullQualified))
                        {
                            for (int i = 1; i <= lineSplitInt;)
                            {
                                if (sr.EndOfStream)
                                {
                                    i++;
                                }
                                else
                                {
                                    sw.WriteLine(sr.ReadLine());
                                    i++;
                                    lineIteration++;
                                }
                            }
                            generatedFileNames.Add(currentFileName);
                            fileIteration++;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Wrong file path!");
            }

            Console.WriteLine($"\nThe input file has {lineIteration} lines of text.");
            Console.WriteLine("\nEach file that is created must have a sequential number assigned to it.");
            Console.WriteLine($"\nFor a {lineIteration} line input file \"{fileName}\", this produces {fileIteration} output files.");
            Console.WriteLine("\n**GENERATING OUTPUT**\n");
            for (int i = 0; i < generatedFileNames.Count; i++)
            {
                Console.WriteLine($"Generating {generatedFileNames[i]}");
            }
        }
    }
}

using System;
using System.IO;
using System.Collections.Generic;

namespace Assessment
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Car> carList = new Dictionary<string, Car>();
            int keyIterator = 1;
            try
            {
                string fullPath = @"C:\Users\Student\workspace\bdavis-c\Assessments\module-1\student-assessment\dotnet\Assessment\Data\CarInput.csv";
                using (StreamReader sr = new StreamReader(fullPath))
                {
                    while(!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        string[] temp = line.Split(',');

                        int year = int.Parse(temp[0]);
                        string make = temp[1];
                        string classic = temp[2];
                        bool isClassic = false;

                        if (classic == "true")
                        {
                            isClassic = true;
                        }

                        string vehicle = "vehicle";

                        Car car = new Car(year, make, isClassic);
                        carList.Add((vehicle + keyIterator.ToString()), car);
                        keyIterator++;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            int totalVehicleAge = 0;
            int thisYear = DateTime.Now.Year;

            foreach(KeyValuePair<string, Car> car in carList)
            {
                int carAge = car.Value.YearManufactured;
                totalVehicleAge += (thisYear - carAge);
            }

            Console.WriteLine(totalVehicleAge);
        }
    }
}

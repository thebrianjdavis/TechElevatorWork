using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment
{
    public class Car
    {
        public int YearManufactured { get; set; }
        public string Make { get; set; }
        public bool IsClassicCar { get; set; }
        public int Age { get; set; }
        public Car(int yearManufactured, string make, bool isClassicCar)
        {
            YearManufactured = yearManufactured;
            Make = make;
            IsClassicCar = isClassicCar;
            Age = (DateTime.Now.Year - yearManufactured);
        }
        public bool NeedsECheck(int yearToCheck)
        {
            bool needsChecked = false;

            if ((YearManufactured % 2 == 0 && yearToCheck % 2 == 0) || (YearManufactured % 2 != 0 && yearToCheck % 2 != 0))
            {
                if (Age > 4 && Age < 25 && IsClassicCar == false)
                {
                    needsChecked = true;
                }
            }

            return needsChecked;
        }
        public override string ToString()
        {
            string output = "";

            output = $"CAR - {YearManufactured} - {Make}";

            return output;
        }
    }
}

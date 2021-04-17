using System;
using System.Collections.Generic;
using System.IO;

namespace Assessment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<FlowerShopOrder> orderList = new List<FlowerShopOrder>();
            try
            {
                string fullPath = @"C:\Users\Student\workspace\bdavis-c\Assessments\module-1\practice-assessment\dotnet\Assessment\Data\FlowerInput.csv";
                StreamReader sr = new StreamReader(fullPath);
                while(!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] temp = line.Split(',');

                    string bouquetType = temp[0];
                    int numberOfRoses = Convert.ToInt32(temp[1]);

                    FlowerShopOrder flowerShopOrder = new FlowerShopOrder(bouquetType, numberOfRoses);
                    orderList.Add(flowerShopOrder);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e}\n\nCome on...dummy!");
            }
            
            decimal orderSubtotal = 0;

            foreach (FlowerShopOrder order in orderList)
            {
                orderSubtotal += order.Subtotal;
            }

            Console.WriteLine($"The order subtotal is {orderSubtotal:C2}");
        }
    }
}

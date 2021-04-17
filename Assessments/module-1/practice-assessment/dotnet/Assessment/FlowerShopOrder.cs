using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment
{
    public class FlowerShopOrder
    {
        public string BouquetType { get; set; }
        public int NumberOfRoses { get; set; }
        public decimal Subtotal { get; set; }

        public FlowerShopOrder(string bouquetType, int numberOfRoses)
        {
            BouquetType = bouquetType;
            NumberOfRoses = numberOfRoses;

            decimal subtotal = 19.99M;

            if (numberOfRoses > 0)
            {
                subtotal += (Convert.ToDecimal(numberOfRoses) * 2.99M);
            }

            Subtotal = subtotal;
        }
        public decimal DeliveryTotal(bool sameDayDelivery, string zipCode)
        {
            decimal deliveryCost = 0;
            int zipInt = int.Parse(zipCode);

            if (sameDayDelivery && zipInt >= 10000 && zipInt <= 39999)
            {
                deliveryCost += 5.99M;
            }

            if (zipInt >= 20000 && zipInt <= 29999)
            {
                deliveryCost += 3.99M;
            }
            else if (zipInt >= 30000 && zipInt <= 39999)
            {
                deliveryCost += 6.99M;
            }
            else if (zipInt >= 10000 && zipInt <= 19999)
            {

            }
            else
            {
                deliveryCost += 19.99M;
            }

            return deliveryCost;
        }
        public override string ToString()
        {
            string output = $"Order - {BouquetType} - {NumberOfRoses} - {Subtotal}";

            return output;
        }
    }
}

﻿using System.Collections.Generic;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         * Given two Dictionaries, Dictionary<string, int>, merge the two into a new Dictionary, Dictionary<string, int> where keys in Dictionary2,
         * and their int values, are added to the int values of matching keys in Dictionary1. Return the new Dictionary.
         *
         * Unmatched keys and their int values in Dictionary2 are simply added to Dictionary1.
         *
         * ConsolidateInventory({"SKU1": 100, "SKU2": 53, "SKU3": 44} {"SKU2":11, "SKU4": 5})
         * 	 → {"SKU1": 100, "SKU2": 64, "SKU3": 44, "SKU4": 5}
         *
         */
        public Dictionary<string, int> ConsolidateInventory(Dictionary<string, int> mainWarehouse,
                                                            Dictionary<string, int> remoteWarehouse)
        {
            Dictionary<string, int> combinedWarehouses = new Dictionary<string, int>();

            foreach (KeyValuePair<string, int> itemSKU in mainWarehouse)
            {
                string itemName = itemSKU.Key;
                int itemQuantity = itemSKU.Value;
                combinedWarehouses[itemName] = itemQuantity;
            }

            foreach (KeyValuePair<string, int> itemSKU in remoteWarehouse)
            {
                string itemName = itemSKU.Key;
                int itemQuantity = itemSKU.Value;
                if (mainWarehouse.ContainsKey(itemName))
                {
                    combinedWarehouses[itemName] = mainWarehouse[itemName] + remoteWarehouse[itemName];
                }
                else
                {
                    combinedWarehouses[itemName] = itemQuantity;
                }
            }
            return combinedWarehouses;
        }
    }
}

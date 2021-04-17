﻿using System.Collections.Generic;

namespace Exercises
{
    public partial class Exercises
    {
        /*
        Given a list of Strings, return an array containing the same Strings in the same order
        List2Array( ["Apple", "Orange", "Banana"] )  ->  {"Apple", "Orange", "Banana"}
        List2Array( ["Red", "Orange", "Yellow"] )  ->  {"Red", "Orange", "Yellow"}
        List2Array( ["Left", "Right", "Forward", "Back"] )  ->  {"Left", "Right", "Forward", "Back"}
        */
        public string[] List2Array(List<string> stringList)
        {
            string[] isArrayNow = new string[stringList.Count];

            for (int i = 0; i < isArrayNow.Length; i++)
            {
                isArrayNow[i] = stringList[i];
            }
            
            return isArrayNow;
        }
    }
}

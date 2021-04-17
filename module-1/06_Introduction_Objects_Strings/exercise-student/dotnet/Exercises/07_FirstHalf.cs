﻿namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a string of even length, return the first half. So the string "WooHoo" yields "Woo".
        FirstHalf("WooHoo") → "Woo"
        FirstHalf("HelloThere") → "Hello"
        FirstHalf("abcdef") → "abc"
        */
        public string FirstHalf(string str)
        {
            string firstHalfSolve = "";

            firstHalfSolve = str.Substring(0, (str.Length / 2));

            return firstHalfSolve;
        }
    }
}

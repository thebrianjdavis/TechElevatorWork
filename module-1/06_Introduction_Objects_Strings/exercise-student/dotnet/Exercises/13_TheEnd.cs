﻿namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a string, return a string length 1 from its front, unless front is false, in which case
        return a string length 1 from its back. The string will be non-empty.
        TheEnd("Hello", true) → "H"
        TheEnd("Hello", false) → "o"
        TheEnd("oh", true) → "o"
        */
        public string TheEnd(string str, bool front)
        {
            string theEndSolve = "";
            
            if (front == true)
            {
                theEndSolve = str.Substring(0, 1);
            }
            else
            {
                theEndSolve = str.Substring(str.Length - 1, 1);
            }

            return theEndSolve;
        }
    }
}

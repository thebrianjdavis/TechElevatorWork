namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a string of odd length, return the string length 3 from its middle, so "Candy" yields "and".
        The string length will be at least 3.
        MiddleThree("Candy") → "and"
        MiddleThree("and") → "and"
        MiddleThree("solving") → "lvi"
        */
        public string MiddleThree(string str)
        {
            string middleThreeSolve = "";
            
            string beforeHalf = str.Substring(str.Length / 2 - 1, 1);
            string midPoint = str.Substring(str.Length / 2, 1);
            string afterHalf = str.Substring(str.Length / 2 + 1, 1);
            
            middleThreeSolve = beforeHalf + midPoint + afterHalf;

            return middleThreeSolve;
        }
    }
}

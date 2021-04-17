namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a string of even length, return a string made of the middle two chars, so the string "string"
        yields "ri". The string length will be at least 2.
        MiddleTwo("string") → "ri"
        MiddleTwo("code") → "od"
        MiddleTwo("Practice") → "ct"
        */
        public string MiddleTwo(string str)
        {
            string middleTwoSolve = "";
            
            string firstHalf = str.Substring(0, str.Length / 2);
            string secondHalf = str.Substring((str.Length / 2), str.Length / 2);

            middleTwoSolve = firstHalf.Substring(firstHalf.Length - 1, 1) + secondHalf.Substring(0, 1);

            return middleTwoSolve;
        }
    }
}

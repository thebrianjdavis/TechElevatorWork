namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a non-empty string like "Code" return a string like "CCoCodCode".
        StringSplosion("Code") → "CCoCodCode"
        StringSplosion("abc") → "aababc"
        StringSplosion("ab") → "aab"
        */
        public string StringSplosion(string str)
        {
            string increasingStr = "";

            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    increasingStr += str[j];
                }
            }

            return increasingStr;
        }
    }
}

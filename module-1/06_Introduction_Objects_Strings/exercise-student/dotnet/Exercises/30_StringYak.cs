namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Suppose the string "yak" is unlucky. Given a string, return a version where all the "yak" are removed.
        The "yak" strings will not overlap.
        StringYak("yakpak") → "pak"
        StringYak("pakyak") → "pak"
        StringYak("yak123ya") → "123ya"
        */
        public string StringYak(string str)
        {
            string stringYakSolve = "";

            if (str.Length > 2)
            {
                for (int i = 0; i < str.Length;)
                {
                    if (i + 3 <= str.Length && str[i] == 'y' && str[i + 1] == 'a' && str[i + 2] == 'k')
                    {
                        i = i + 3;
                    }
                    else
                    {
                        stringYakSolve += str[i];
                        i++;
                    }
                }
            }
            else
            {
                stringYakSolve = str;
            }
            return stringYakSolve;
        }
    }
}

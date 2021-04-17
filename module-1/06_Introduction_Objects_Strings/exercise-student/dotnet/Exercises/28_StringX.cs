namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a string, return a version where all the "x" have been removed. Except an "x" at the very start or end
        should not be removed.
        StringX("xxHxix") → "xHix"
        StringX("abxxxcd") → "abcd"
        StringX("xabxxxcdx") → "xabcdx"
        */
        public string StringX(string str)
        {
            string stringX = "";

            if (str.Length > 2)
            {
                string stringToTest = str.Substring(1, str.Length - 1);
                string stringGrow = "";
                for (int i = 0; i < str.Length - 2; i++)
                {
                    if (stringToTest[i] != 'x')
                    {
                        stringGrow += stringToTest[i];
                    }
                }
                stringX = str.Substring(0, 1) + stringGrow + str.Substring(str.Length - 1, 1);
            }
            else
            {
                stringX = str;
            }
            return stringX;
        }
    }
}

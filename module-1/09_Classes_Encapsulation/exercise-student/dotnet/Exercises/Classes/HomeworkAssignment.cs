namespace Exercises.Classes
{
    public class HomeworkAssignment
    {
        public int EarnedMarks { get; set; }
        public int PossibleMarks { get; private set; }
        public string SubmitterName { get; private set; }
        public string LetterGrade
        {
            get
            {
                string actualGrade = "F";
                double score = (double)EarnedMarks / (double)PossibleMarks;

                if (score >= .9)
                {
                    actualGrade = "A";
                }
                else if (score >= .8)
                {
                    actualGrade = "B";
                }
                else if (score >= .7)
                {
                    actualGrade = "C";
                }
                else if (score >= .6)
                {
                    actualGrade = "D";
                }

                return actualGrade;
            }
        }


        public HomeworkAssignment(int possibleMarks, string submitterName)
        {
            PossibleMarks = possibleMarks;
            SubmitterName = submitterName;
        }

    }
}

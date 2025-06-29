namespace forCodinginterviews._2025_interview_prep.Questions.ArrayBasedEasyQuestions
{
    //example:
    //* input :- 1 2 3 4 5 output :- 2 3 4 5 1 
    public class LeftCircularRoatation
    {
        public static int[] PerformArrayRotation(int[] givenArray)
        {
            List<int> rotatedArrayList = new List<int>();

            if (givenArray == null || givenArray.Length == 0)
            {
                return rotatedArrayList.ToArray();
            }

            int firstElement = givenArray[0];
            for (int i = 1; i < givenArray.Length; i++)
            {
                rotatedArrayList.Add(givenArray[i]);
            }

            rotatedArrayList.Add(firstElement);

            return rotatedArrayList.ToArray();
        }

    }
}

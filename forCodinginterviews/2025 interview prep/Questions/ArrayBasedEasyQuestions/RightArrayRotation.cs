using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forCodinginterviews._2025_interview_prep.Questions.ArrayBasedEasyQuestions
{
    /* input :- 1 2 3 4 5 output :- 5 1 2 3 4 
               * */
    public class RightArrayRotation
    {
        public static int[] PerformRightArrayRotation(int[] givenArray)
        {
            List<int> rotatedArrayList = new List<int>();
            int firstElement = givenArray[givenArray.Length - 1];
            rotatedArrayList.Add(firstElement);
            for (int i = 0; i < givenArray.Length-1; i++)
            {
                rotatedArrayList.Add(givenArray[i]);
            }
            return rotatedArrayList.ToArray();
        }
    }

}

using System;
using System.Linq;

namespace CodilityTraining
{
    class TapeEquilibrium
    {
        public int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int minimum = A[0];
            int arraySum = A.Sum();
            int eachSum = 0;

            for (int p = 1; p < A.Length; p++)
            {
                eachSum += A[p - 1];
                int value = arraySum - eachSum;
                if (p == 1)
                {
                    minimum = Math.Abs(eachSum - value);
                    continue;
                }

                int difference = Math.Abs(eachSum - value);
                if (difference < minimum)
                {
                    minimum = difference;
                }
            }

            return minimum;
        }

    }
}

using System;

namespace CodilityTraining
{
    class PermCheck
    {
        public int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            Array.Sort(A);
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] != i + 1)
                {
                    return 0;
                }
            }

            return 1;
        }

    }
}

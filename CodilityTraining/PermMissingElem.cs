using System;

namespace CodilityTraining
{
    class PermMissingElem
    {
        public int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int arrayLength = A.Length;
            if (arrayLength == 0)
            {
                return 1;
            }

            Array.Sort(A);
            for (int i = 0; i < arrayLength; i++)
            {
                if (A[i] == i + 1)
                {
                    continue;
                }
                else
                {
                    return i + 1;
                }
            }

            return A[arrayLength - 1] + 1;
        }

    }
}

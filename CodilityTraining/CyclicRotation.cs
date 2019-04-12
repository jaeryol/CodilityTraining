using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityTraining
{
    class CyclicRotation
    {
        public int solution(int X, int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            var set = new HashSet<int>();
            foreach (int value in A)
            {
                if (set.Contains(value))
                {
                    set.Remove(value);
                }
                else
                {
                    set.Add(value);
                }
            }

            return set.First();
        }

    }
}

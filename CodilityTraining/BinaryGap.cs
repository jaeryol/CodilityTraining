using System.Collections.Generic;

namespace CodilityTraining
{
    class BinaryGap
    {
        public int solution(int N)
        {
            var binary = ConvertIntegerToBinary(N);
            int gap = 0;
            int maximum = 0;
            foreach (var data in binary)
            {
                if (data == 0)
                {
                    gap++;
                }
                else
                {
                    if (gap > maximum)
                    {
                        maximum = gap;
                    }

                    gap = 0;
                }
            }

            return maximum;
        }

        private List<int> ConvertIntegerToBinary(int num)
        {
            var source = new List<int>();
            while (num >= 1)
            {
                source.Add(num % 2);
                num /= 2;
            }

            source.Reverse();

            bool flag = false;
            var binary = new List<int>();
            foreach (var value in source)
            {
                if (flag || value == 1)
                {
                    binary.Add(value);
                    flag = true;
                }
            }
            return binary;
        }
    }
}
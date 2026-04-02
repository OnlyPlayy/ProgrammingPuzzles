using System;

namespace BinaryGap
{
    public class Solution
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
        }

        public int solution(int N)
        {
            string binaryString = Convert.ToString(N, 2);
            char[] binary = binaryString.ToArray();

            int currentCount = 0;
            int maxCount = 0;

            foreach (var bin in binary)
            {
                if (bin == '0')
                    currentCount++;
                else
                {
                    if (currentCount > maxCount)
                        maxCount = currentCount;
                    currentCount = 0;
                }
            }

            return maxCount;
        }
    }
}
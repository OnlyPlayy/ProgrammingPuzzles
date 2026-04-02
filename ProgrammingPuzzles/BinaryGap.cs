namespace BinaryGap
{
    public class Solution
    {
        public int solution(int N)
        {
            if (N < 1 || N > 2147483647)
                return 0;

            string binaryString = Convert.ToString(N, 2);
            var binary = binaryString.ToArray();

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
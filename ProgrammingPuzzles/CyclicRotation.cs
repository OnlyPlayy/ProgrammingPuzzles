using System;
using System.Collections.Generic;
using System.Text;

namespace CyclicRotations
{
    class Solution
    {
        public int[] solution(int[] A, int K)
        {
            int[] result = new int[A.Length];
            for (int i = 0; i < K; i++)
            {
                int movedBy = i + K;
                if (movedBy >= A.Length)
                    movedBy -= A.Length;

                result[movedBy] = A[i];
            }

            return result;
        }

    }
}


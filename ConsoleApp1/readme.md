<details>
<summary>BinaryGap</summary>
A binary gap in a positive integer N is a maximal run of consecutive zeros in N’s binary form that is enclosed by ones on both ends.

Examples:

    9 → binary 1001 → one binary gap of length 2
    529 → binary 1000010001 → two gaps: lengths 4 and 3
    20 → binary 10100 → one gap of length 1
    15 → binary 1111 → no gaps
    32 → binary 100000 → no gaps

Implement:

class Solution { public int solution(int N); }

The method should return the length of the longest binary gap in N, or 0 if none exists.

Examples:

    N = 1041 → binary 10000010001 → return 5
    N = 32 → binary 100000 → return 0

Constraints:

    N is an integer in [1 .. 2,147,483,647]

Design an efficient algorithm.
</details>
# Instructions

A binary gap in a positive integer N is any maximal sequence of consecutive zeros in N’s binary representation that is bounded by ones on both sides.

Examples:

    9 → binary 1001 → longest binary gap = 2
    529 → binary 1000010001 → binary gaps = 4 and 3 (longest = 4)
    20 → binary 10100 → binary gap = 1
    15 → binary 1111 → no binary gaps → 0
    32 → binary 100000 → no binary gaps → 0

Task:
Implement the following method:

class Solution { public int solution(int N); }

Input: a positive integer N(1 ≤ N ≤ 2,147,483,647).
Output: the length of the longest binary gap in N; return 0 if none exists.

Example:

    N = 1041 → binary 10000010001 → return 5.

Requirement: provide an efficient algorithm that adheres to the input constraints.
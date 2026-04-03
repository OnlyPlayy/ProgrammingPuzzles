# Instructions:
<details>
<summary>Binary Gap</summary>
<br>
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

Input: a positive integer N (1 ≤ N ≤ 2,147,483,647).
Output: the length of the longest binary gap in N; return 0 if none exists.

Example:

    N = 1041 → binary 10000010001 → return 5.

Requirement: provide an efficient algorithm that adheres to the input constraints.
</details>

<details>
<summary>Cyclic Rotation</summary>
<br>
Given an array A of N integers, a single rotation moves every element one position to the right and places the last element at the front. For example, rotating A = [3, 8, 9, 7, 6] once yields [6, 3, 8, 9, 7].

Write a function:

class Solution { public int[] solution(int[] A, int K); }

that returns the array A after performing K such rotations.

Examples:

    A = [3, 8, 9, 7, 6], K = 3 -> [9, 7, 6, 3, 8] (three rotations: [3,8,9,7,6] -> [6,3,8,9,7] -> [7,6,3,8,9] -> [9,7,6,3,8])
    A = [0, 0, 0], K = 1 -> [0, 0, 0]
    A = [1, 2, 3, 4], K = 4 -> [1, 2, 3, 4]

Constraints:

    0 ≤ N, K ≤ 100
    Each element of A is between −1,000 and 1,000

Focus on correctness; performance is not evaluated.
</details>
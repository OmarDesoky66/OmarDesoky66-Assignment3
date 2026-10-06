# LeetCode 136 — Single Number

Given an array where every number appears twice except one, find the number that appears once.

### Solution

Use **XOR (`^`)** because:

```text
x ^ x = 0
x ^ 0 = x
```

So duplicate numbers cancel each other out, leaving the single number.

```csharp
static int FindSingleNumber(int[] nums)
{
    int result = 0;

    for (int i = 0; i < nums.Length; i++)
    {
        result ^= nums[i];
    }

    return result;
}
```

### Example

```text
Input:  [4, 1, 2, 1, 2]
Output: 4
```

### Complexity

* **Time:** O(n)
* **Space:** O(1)

### LeetCode Submission

[View my submission](https://leetcode.com/problems/single-number/submissions/2164593177/)

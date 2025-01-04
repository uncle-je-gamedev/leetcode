namespace problems.array_and_string.find_pivot_index;

// 724, https://leetcode.com/problems/find-pivot-index/description/
public class Solution
{
   public int PivotIndex(int[] arr)
   {
      if (arr.Length == 1)
         return 0;

      var pivotIndex = 0;
      var remainedSum = arr.Sum();
      var currentSum = 0;

      while (pivotIndex < arr.Length)
      {
         remainedSum -= arr[pivotIndex];

         if (remainedSum == currentSum)
            return pivotIndex;

         currentSum += arr[pivotIndex];
         pivotIndex++;
      }

      return -1;
   }
}
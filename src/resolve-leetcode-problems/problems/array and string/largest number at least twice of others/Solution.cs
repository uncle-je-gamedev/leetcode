namespace problems.array_and_string.largest_number_at_least_twice_of_others;

// 747, https://leetcode.com/problems/largest-number-at-least-twice-of-others/description/
public class Solution
{
   public int DominantIndex(int[] arr)
   {
      var largest = arr[0];
      var largestIndex = 0;
      var secondLargest = -1;

      var index = 1;
      while (index < arr.Length)
      {
         var next = arr[index];
         if (largest < next)
         {
            secondLargest = largest;
            largest = next;
            largestIndex = index;
         }
         else if (secondLargest < next)
            secondLargest = next;

         index++;
      }

      if (largest < 2 * secondLargest)
         return -1;

      return largestIndex;
   }
}

namespace problems.array_and_string.introduction_to_array.plus_one;

// 66, https://leetcode.com/problems/plus-one/description/
public class Solution
{
   public int[] PlusOne(int[] digits)
   {
      if (digits[^1] < 9)
         digits[^1] += 1;
      else
      {
         var carry = 1;
         for (var i = 1; i <= digits.Length; i++)
         {
            digits[^i] += carry;
            if (digits[^i] < 10)
            {
               carry = 0;
               break;
            }

            digits[^i] -= 10;
         }

         if (carry == 1)
            digits = [1, .. digits];
      }

      return digits;
   }
}
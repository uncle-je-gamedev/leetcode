using FluentAssertions;
using problems.array_and_string.largest_number_at_least_twice_of_others;

namespace tests.largest_number_at_least_twice_of_others;

internal class LargestNumberAtLeastTwiceOfOthers
{
   [Test]
   [TestCaseSource(nameof(two_elements))]
   public void All_two_elements_arrays(int[] arr, int expectedIndex)
   {
      var result = new Solution().DominantIndex(arr);

      result.Should().Be(expectedIndex);
   }

   private static readonly object[] two_elements =
   {
      new object[] { new[] { 1, 3 }, 1 },
      new object[] { new[] { 3, 1 }, 0 },
      new object[] { new[] { 2, 2 }, -1 },
   };

   [Test]
   [TestCaseSource(nameof(examples))]
   public void Should_match_to_examples(int[] arr, int expectedIndex)
   {
      var result = new Solution().DominantIndex(arr);

      result.Should().Be(expectedIndex);
   }

   private static readonly object[] examples =
   [
      new object[] { new[] { 3, 6, 1, 0 }, 1 },
      new object[] { new[] { 1, 2, 3, 4 }, -1 },
      new object[] { new[] { 0,0,3,2 }, -1 },
   ];

   [Test]
   [TestCaseSource(nameof(special_cases))]
   public void Special_cases(int[] arr, int expectedIndex)
   {
      var result = new Solution().DominantIndex(arr);

      result.Should().Be(expectedIndex);
   }

   private static readonly object[] special_cases =
   [
      new object[] { new[] { 0, 0, 3, 2 }, -1 }, // the second-largest changes from 0 to 2
   ];
}

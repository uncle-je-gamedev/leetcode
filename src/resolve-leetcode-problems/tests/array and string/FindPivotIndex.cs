using FluentAssertions;
using problems.array_and_string.find_pivot_index;

namespace tests.array_and_string;

internal class FindPivotIndex
{
   [Test]
   public void Should_return_zero_if_array_has_only_one_element()
   {
      var arr = new[] { 1 };

      var result = new Solution().PivotIndex(arr);

      result.Should().Be(0);
   }

   [Test]
   public void Should_return_minus_one_if_array_has_two_non_zero_elements()
   {
      var arr = new[] { 1, 2 };

      var result = new Solution().PivotIndex(arr);

      result.Should().Be(-1);
   }

   [Test]
   [TestCaseSource(nameof(two_elements))]
   public void Should_return_zero_if_array_has_two_elements(int[] arr, int expectedIndex)
   {
      var result = new Solution().PivotIndex(arr);

      result.Should().Be(expectedIndex);
   }

   private static readonly object[] two_elements =
   [
      new object[] { new[] { 1, 0 }, 0 },
      new object[] { new[] { 0, 2 }, 1 },
      new object[] { new[] { 0, 0 }, 0 },
   ];

   [Test]
   [TestCaseSource(nameof(examples))]
   public void Should_match_to_examples(int[] arr, int expectedIndex)
   {
      var result = new Solution().PivotIndex(arr);

      result.Should().Be(expectedIndex);
   }

   private static readonly object[] examples =
   [
      new object[] { new[] { 1, 7, 3, 6, 5, 6 }, 3 },
      new object[] { new[] { 1, 2, 3 }, -1 },
      new object[] { new[] { 2, 1, -1 }, 0 },
   ];

   // Should_return_the_leftmost_pivot_index()
}

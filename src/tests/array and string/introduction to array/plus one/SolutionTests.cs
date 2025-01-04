using FluentAssertions;
using problems.array_and_string.introduction_to_array.plus_one;

namespace tests.array_and_string.introduction_to_array.plus_one;

internal class SolutionTests
{
   [Test]
   [TestCaseSource(nameof(NoCarry))]
   public void The_length_of_array_should_be_the_same(int[] arr)
   {
      var result = new Solution().PlusOne(arr);

      result.Length.Should().Be(1);
   }
   private static readonly object[] NoCarry =
   [
      new object[] { new[] { 0 }, },
      new object[] { new[] { 1 }, },
      new object[] { new[] { 2 }, },
      new object[] { new[] { 3 }, },
      new object[] { new[] { 4 }, },
      new object[] { new[] { 5 }, },
      new object[] { new[] { 6 }, },
      new object[] { new[] { 7 }, },
      new object[] { new[] { 8 }, },
   ];

   [Test]
   [TestCaseSource(nameof(OneDigitWithoutCarry))]
   public void Should_return_plus_one_if_there_are_no_carry(int[] arr, int expectedResult)
   {
      var result = new Solution().PlusOne(arr);

      result[0].Should().Be(expectedResult);
   }

   private static readonly object[] OneDigitWithoutCarry =
   [
      new object[] { new[] { 0 }, 1 },
      new object[] { new[] { 1 }, 2 },
      new object[] { new[] { 2 }, 3 },
      new object[] { new[] { 3 }, 4 },
      new object[] { new[] { 4 }, 5 },
      new object[] { new[] { 5 }, 6 },
      new object[] { new[] { 6 }, 7 },
      new object[] { new[] { 7 }, 8 },
      new object[] { new[] { 8 }, 9 },
   ];

   [Test]
   [TestCaseSource(nameof(Carry))]
   public void Should_not_return_leading_zero(int[] input, int[] expected)
   {
      var result = new Solution().PlusOne(input);

      result.Should().BeEquivalentTo(expected);
   }
   private static readonly object[] Carry =
   [
      new object[] { new[] { 9 }, new[] { 1, 0 } },
      new object[] { new[] { 1, 9 }, new[] { 2, 0 } },
      new object[] { new[] { 9, 9 }, new[] { 1, 0, 0 } },
   ];

   [Test]
   public void Last_digit_must_become_0_if_it_is_9()
   {
      var result = new Solution().PlusOne([9]);

      result[^1].Should().Be(0);
   }

   [Test]
   public void First_digit_should_be_the_1_if_it_is_9()
   {
      var result = new Solution().PlusOne([9]);

      result[0].Should().Be(1);
   }

   [Test]
   [TestCaseSource(nameof(LeetCodeExamples))]
   public void CheckLeetCodeExamples(int[] input, int[] expected)
   {
      var result = new Solution().PlusOne(input);

      result.Should().BeEquivalentTo(expected);
   }

   private static readonly object[] LeetCodeExamples =
   [
      new object[] { new[] { 1, 2, 3 }, new[] { 1, 2, 4 } },
      new object[] { new[] { 4, 3, 2, 1 }, new[] { 4, 3, 2, 2 } },
      new object[] { new[] { 9 }, new[] { 1, 0 } },
   ];
}

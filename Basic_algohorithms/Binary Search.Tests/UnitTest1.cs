using Xunit;

namespace Binary_Search.Tests
{
	public class UnitTest1
	{
		[Theory]
		[InlineData(new int[] { }, 3, -1)]
		[InlineData(new int[] { 0, 0, 1, 2, 3 }, 3, 4)]
		[InlineData(new int[] { 0, 1 }, 0, 0)]
		[InlineData(new int[] { 0, 1 }, 1, 1)]
		public void BinarySearch(int[] sorted_array, int target, int expected_result)
		{
			int actual_result = Solution.binarySearch(sorted_array, target);

			Assert.Equal(actual_result, expected_result);

		}
	}
}
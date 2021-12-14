using Xunit;

namespace Two_Sum.Tests
{
	public class UnitTest1
	{

		[Theory]
		[InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
		[InlineData(new int[] { -3, 4, 3, 90 }, 0, new int[] { 0,2} )]
		public void TwoSum(int[] nums, int target, int[] a_expected)
		{
			var solve = new Solution();
			int[] actual_result = solve.TwoSum(nums, target);

			Assert.Equal(a_expected, actual_result);

		}
	}
}
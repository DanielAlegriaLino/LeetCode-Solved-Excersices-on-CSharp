using Xunit;

namespace Longest_Common_Prefix.Tests
{
	public class UnitTest1
	{
		[Theory]
		[InlineData( new string[] { "flower", "flow", "flight"} , "fl")]
		public void LongestCommonPrefix_ShouldReturnTheLongestCommonPrefix (string[] strs, string a_expected_result)
		{
			string actual_result = new Solution().LongestCommonPrefix(strs);

			Assert.Equal(a_expected_result, actual_result);
		}

	}

}
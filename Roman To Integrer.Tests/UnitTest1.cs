using Xunit;

namespace Roman_To_Integrer.Tests
{
	public class UnitTest1
	{
		[Theory]
		[InlineData("III",3)]
		[InlineData("IV", 4)]
		[InlineData("IX", 9)]
		[InlineData("LVIII", 58)]
		[InlineData("MCMXCIV",1994)]
		public void RomanToInt(string a_function_input1, int a_expected)
		{
			var solution = new Solution();
			int actual_result = solution.RomanToInt(a_function_input1);

			Assert.Equal(a_expected, actual_result);
		}






	}
}
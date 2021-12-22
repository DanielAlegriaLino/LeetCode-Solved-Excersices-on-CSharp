using Xunit;



public class UnitTest1
{

	[Theory]
	[InlineData(0)]
	[InlineData(5)]
	[InlineData(101)]
	[InlineData(9999)]
	[InlineData(123321)]
	[InlineData(12421)]
	void IsPalindrome_TestearNumerosQueSiSonPalindromos(long a_number2check)
	{
		bool resultado = Palindrome.IsPalindrome(a_number2check);
		Assert.True(resultado);
	}

	[Theory]
	[InlineData(12)]
	[InlineData(332)]
	[InlineData(1112)]
	[InlineData(1234564321)]
	[InlineData(5353425)]
	[InlineData(3534532321)]
	void IsPalindrome_TestearNumerosQueNoSonPalindromos(long a_number2check)
	{
		bool resultado = Palindrome.IsPalindrome(a_number2check);
		Assert.False(resultado);
	}




}
Console.WriteLine(Palindrome.IsPalindrome(23246234));


public static class Palindrome 
{

	public static bool IsPalindrome(long a_number2check)
	{
		string number_in_letters = a_number2check.ToString();

		for (int i = 0; i < number_in_letters.Length / 2; i++)
		{
			char first_number_for_check = number_in_letters[i];
			char second_number_for_check = number_in_letters[number_in_letters.Length - (i + 1)] ;

			if(first_number_for_check != second_number_for_check) { return false; }
		}
		return true;

	}

}



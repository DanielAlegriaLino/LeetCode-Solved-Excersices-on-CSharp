bool IsPalindrome(int a_number2check) 
{
	string number_in_letters = a_number2check.ToString();

	for (int i=0; i<number_in_letters.Length/2 ; i++) 
	{
		Console.WriteLine(number_in_letters[i]);
		Console.WriteLine(number_in_letters[number_in_letters.Length-(i+1)]);
	}


	return true;
}

Console.WriteLine( IsPalindrome (23246234) );
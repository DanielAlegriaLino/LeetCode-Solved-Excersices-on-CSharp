using System.Collections;

Console.WriteLine();



public class Solution
{
	public int MostWordsFound(string[] sentences)
	{
		int[] number_of_words_per_sentence = new int[sentences.Length];

		for (int i = 0; i < sentences.Length; i++)
		{
			string[] words = sentences[i].Split(' ');
			number_of_words_per_sentence[i] = words.Length;
		}

		//Bubble Sort One pass
		for (int i = 0; i < sentences.Length - 1; i++)
		{
			if (number_of_words_per_sentence[i] > number_of_words_per_sentence[i + 1])
			{
				int temp_var = number_of_words_per_sentence[i];
				number_of_words_per_sentence[i] = number_of_words_per_sentence[i + 1];
				number_of_words_per_sentence[i + 1] = temp_var;
			}
		}

		return number_of_words_per_sentence[number_of_words_per_sentence.Length - 1];

	}
}
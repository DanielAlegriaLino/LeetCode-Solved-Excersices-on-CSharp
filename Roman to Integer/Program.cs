Console.WriteLine("Hello World");

public class Solution
{
	public int RomanToInt(string s)
	{
		char[] text_in_array = s.ToArray();
		int valor_numerico_total = 0;

		Dictionary<char, int> valores_numericos_romanos = new Dictionary<char, int>
		{
			{'I',1 },
			{'V',5 },
			{'X',10 },
			{'L',50 },
			{'C',100 },
			{'D',500 },
			{'M',1000 },
		};

		bool isBeforeCharDivisibleBy10Or1 = false;
		bool isBeforeNumberHigherThanBefore = false;
		bool isCurrentCharTheFirstOne = false;
		bool isCurrentCharDivisibleBy5 = false;

		for (int i = 0; i < text_in_array.Length; i++)
		{

			char valor_romano_actual = text_in_array[i];

			try
			{
				isCurrentCharTheFirstOne = i > 0;
				isCurrentCharDivisibleBy5 = valores_numericos_romanos[valor_romano_actual] % 5 == 0;
				isBeforeCharDivisibleBy10Or1 = MathF.Log10(valores_numericos_romanos[text_in_array[i - 1]]) % 1 == 0;
				isBeforeNumberHigherThanBefore = valores_numericos_romanos[text_in_array[i - 1]] < valores_numericos_romanos[text_in_array[i]];
			} 
			catch (IndexOutOfRangeException) { }
			catch (Exception ex) { Console.WriteLine(ex.ToString()); }

			if (isBeforeCharDivisibleBy10Or1 && isCurrentCharTheFirstOne && isCurrentCharDivisibleBy5 && isBeforeNumberHigherThanBefore)
			{
				valor_numerico_total -= valores_numericos_romanos[text_in_array[i - 1]] * 2;
			}

			valor_numerico_total += valores_numericos_romanos[valor_romano_actual];

		}
		return valor_numerico_total;



	}
}


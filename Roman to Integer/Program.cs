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

		for (int i = 0; i < text_in_array.Length; i++)
		{
			char valor_romano_actual = text_in_array[i];

			if (i > 0)
			{
				if (valores_numericos_romanos[valor_romano_actual] % 5 == 0)
				{
					//Check if current number is 1 or divisible by 10 
					if (MathF.Log10(valores_numericos_romanos[text_in_array[i - 1]]) % 1 == 0 )
					{
						if(valores_numericos_romanos[text_in_array[i-1]] < valores_numericos_romanos[text_in_array[i]]) 
						{ 
						valor_numerico_total += valores_numericos_romanos[valor_romano_actual];
						valor_numerico_total -= valores_numericos_romanos[text_in_array[i - 1]] * 2;
						}
						else 
						{
						valor_numerico_total += valores_numericos_romanos[valor_romano_actual];
						}
					}
					else
					{
						valor_numerico_total += valores_numericos_romanos[valor_romano_actual];
					}
				}
				else
				{
					valor_numerico_total += valores_numericos_romanos[valor_romano_actual];
				}
			}
			else
			{
				valor_numerico_total += valores_numericos_romanos[valor_romano_actual];
			}

		}

		return valor_numerico_total;



	}
}


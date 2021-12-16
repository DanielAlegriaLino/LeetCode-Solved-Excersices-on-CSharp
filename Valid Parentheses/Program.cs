var sol = new Solution();

Console.WriteLine(sol.IsValid(")["));

public class Solution
{
	public bool IsValid(string s)
	{
		if (s.Length % 2 != 0) { return false; }

		Dictionary<char, char> brackets_pairing = new Dictionary<char, char>();
		brackets_pairing['{'] = '}';
		brackets_pairing['['] = ']';
		brackets_pairing['('] = ')';

		var brackets_proceced = new LinkedList<char>();

		foreach (char c in s)
		{
			try
			{
				if (brackets_pairing.Keys.Contains(c)) { brackets_proceced.AddLast(c); }
				else if (brackets_pairing.Values.Contains(c) && brackets_proceced.Count!=0 && brackets_pairing[brackets_proceced.Last()] == c) 
				{ 
					brackets_proceced.RemoveLast(); 
				}  else return false;
			}
			catch (KeyNotFoundException) { }
		}

		return brackets_proceced.Count == 0;

	}
}

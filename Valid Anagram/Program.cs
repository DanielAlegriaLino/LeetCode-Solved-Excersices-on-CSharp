var sol = new Solution();
Console.WriteLine(sol.IsAnagram("scoobydoo", "coobydoos"));


public class Solution
{
	public bool IsAnagram(string s, string t)
	{
		if (s.Length != t.Length) { return false; }

		Dictionary<char, int> dict_string_s = new Dictionary<char, int> { };
		Dictionary<char, int> dict_string_t = new Dictionary<char, int> { };


		foreach (char c in s)
		{
			try
			{
				dict_string_s[c] = dict_string_s[c] + 1;
			}
			catch (KeyNotFoundException)
			{
				dict_string_s.Add(c, 1);
			}
		}

		foreach (char c in t)
			try
			{
				dict_string_t[c] = dict_string_t[c] + 1;
			}
			catch (KeyNotFoundException)
			{
				dict_string_t.Add(c, 1);
			}

		try
		{
			foreach (char c in dict_string_s.Keys)
			{
				if (dict_string_s[c] != dict_string_t[c]) { return false; }
			}
		}
		catch (KeyNotFoundException) { return false; }


		return true;
	}
}
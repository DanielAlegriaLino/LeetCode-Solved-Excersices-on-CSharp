var solucion = new Solution();
solucion.LongestCommonPrefix(new string[] { "flower", "flow", "flight" });


public class Solution
{
	public string LongestCommonPrefix(string[] strs)
	{    
		string result = "" ;
		
		int max_lenght_search = GetShortestWordLenght(strs);

		for (int i = 0; i < max_lenght_search; i++)
		{
			char before_letter = (strs[0])[i];
			for (int j = 0; j < strs.Length; j++) 
			{
				char current_letter = (strs[j])[i];
				if (current_letter != before_letter) { return result; }
			}
			result  += (strs[0])[i] ;
		}
		
		return result;
	}

	public static int GetShortestWordLenght(string[] a_list_of_words) 
	{
		int shortest_length = int.MaxValue;

		foreach(string word in a_list_of_words) 
		{
			if (word.Length > int.MaxValue) { throw new IndexOutOfRangeException("La palabra introducida es demasiado grande"); }
			if (word.Length< shortest_length) { shortest_length = word.Length; }
		}

		return shortest_length;	
	}



}






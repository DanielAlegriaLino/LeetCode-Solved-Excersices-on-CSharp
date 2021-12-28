Solution solve = new Solution();
Console.WriteLine( solve.StrStr("sttr", "tr") );



public class Solution
{
  public int StrStr(string haystack, string needle)
  {
    int res = 0;

    int search_lenght_range = haystack.Length - needle.Length;

    //Check if needle is a empty string and return 0 if it is 
    if (needle.Length == 0) { return needle.Length; }

    //Check only first letters
    for (int i = 0; i <= search_lenght_range; i++)
    {
      if (haystack[i] == needle[0])
      {
        int continous_coincidences = 0;

        //Check full strings only if first letters are equals
        for (int j = 0; j < needle.Length; j++)
        {
          if (haystack[i + j] == needle[j])
          {
            continous_coincidences++;
          }
          else
          {
            //break loop
            j = needle.Length;
            continue;
          }
        }

        if (continous_coincidences >= needle.Length) { return i; }


      }
    }

    return -1;
  }
}
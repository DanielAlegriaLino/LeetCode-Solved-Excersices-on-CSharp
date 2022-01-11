var solve = new Solution();
solve.FinalValueAfterOperations(new string[] { "--X", "X++", "X++" } );


public class Solution
{
  public int FinalValueAfterOperations(string[] operations)
  {
    int result = 0;

    foreach (string operation in operations) 
    {
      if(operation[0] == '+' || operation[operation.Length-1] == '+') 
      {
        result+=1;
      } 
      else if (operation[0] == '-' || operation[operation.Length - 1] == '-')
      {
        result-=1;
      }

    }

    return result;
  }
}
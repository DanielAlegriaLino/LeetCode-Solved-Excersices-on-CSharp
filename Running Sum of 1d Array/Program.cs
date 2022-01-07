Console.WriteLine("");

public class Solution
{
  public int[] RunningSum(int[] nums)
  {

    int total_sum = 0;
    for (int i = 0; i < nums.Length; i++) 
    {
      total_sum+= nums[i];
      nums[i] = total_sum;
    }

    return nums; 

  }
}

Console.Write("");


public class Solution
{
	public int[] BuildArray(int[] nums)
	{
		int[] result = new int[nums.Length];

		for (int i = 0; i < result.Length; i++)
		{
			result[i] = nums[nums[i]];
		}

		return result;
	}


}
var solve = new Solution();
solve.TwoSum(new int[] { -3, 4, 3, 90 }, 0);


public class Solution
{
	public int[] TwoSum(int[] nums, int target)
	{
		int[] result = new int[2];

		for (int i=0; i< nums.Length-1; i++) 
		{
			for(int j=1+i; j< nums.Length; j++) 
			{
				if (nums[i] + nums[j] == target) 
				{
					result[0] = i;
					result[1] = j;
					return result;
				}
			}
		}



		return new int[] { };
	}
}
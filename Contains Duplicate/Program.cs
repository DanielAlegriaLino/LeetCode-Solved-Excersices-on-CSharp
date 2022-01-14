
int[] nums = new int[] { 0, 1, 2, 3, 4, 5, 0 };
var solve = new Solution();
Console.WriteLine(solve.ContainsDuplicate(nums));


public class Solution
{
	public bool ContainsDuplicate(int[] nums)
	{
		Dictionary<int, int> count_of_values = new Dictionary<int, int>();

		for (int i = 0; i < nums.Length; i++)
		{
			if (!count_of_values.ContainsKey(nums[i]))
			{
				count_of_values.Add(nums[i], 1);
			}
			else
			{
				count_of_values[nums[i]] += 1;

			}
		}

		for (int i = 0; i < count_of_values.Count; i++)
		{
			if (count_of_values[nums[i]] > 1)
			{
				return true;
			}
		}

		return false;
	}
}
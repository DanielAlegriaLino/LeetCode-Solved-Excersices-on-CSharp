// this code duplicate the full content of an array
// Example [1,2,3] will turn into [1,2,3,1,2,3]
Console.WriteLine("Solved");
public class Solution
{
	public int[] GetConcatenation(int[] nums)
	{
		int duplicated_array_lenght = nums.Length * 2;
		int[] duplicated_array = new int[duplicated_array_lenght];

		for (int i = 0; i < nums.Length; i++)
		{
			duplicated_array[i] = nums[i];
			duplicated_array[i + nums.Length] = nums[i];
		}

		return duplicated_array;
	}
}
//Testing zone
Solution solve = new Solution();
int[] numeros = new int[] { 1, 2, 2, 3, 3 ,5,4,3,1,2,3,4,5,6};
int k = solve.RemoveElement(numeros, 2);

for (int i = 0; i < k; i++) 
{
	Console.WriteLine(numeros[i]);
}


public class Solution
{
	public int RemoveElement(int[] nums, int val)
	{
		int left_numbers = nums.Length;

		for (int i = 0; i < left_numbers; i++)
		{
			if (nums[i] == val)
			{
				DeleteElementOnArray(nums, i, left_numbers);
				left_numbers--;
				i--;
			}
		}

		return left_numbers;

	}

	public void DeleteElementOnArray(int[] nums, int position, int array_lenght)
	{
		for (int i = position; i < array_lenght - 1; i++)
		{
			nums[i] = nums[i + 1];
		}
	}

}

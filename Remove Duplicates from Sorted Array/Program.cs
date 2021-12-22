Solution solve = new Solution();
int[] var_nums = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };

int k = solve.RemoveDuplicates(var_nums);

for (int i = 0; i < k; i++)
{
	Console.WriteLine(var_nums[i]);
}


Console.WriteLine($"La longityd es de {k}");


public class Solution
{
	public short RemoveDuplicates(int[] nums)
	{
		short left_elements = (short)(nums.Length);

		for (short i = 0; i < left_elements - 1; i++)
		{
			short j = (short)(i + 1);
			if (nums[i] == nums[j])
			{
				left_elements--;
				//Move all elements one positions before
				for (short h = j; h <= left_elements; h++)
				{
					nums[h - 1] = nums[h];
				}
				i--;
			}


		}



		return left_elements;
	}
}

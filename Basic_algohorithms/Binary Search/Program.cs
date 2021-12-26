// See https://aka.ms/new-console-template for more information
int[] sorted_array = new int[] { 0, 0, 0, 0, 0, 0, 1, 2, 2, 2 };

public class Solution
{
	public static int binarySearch(int[] sorted_array, int target)
	{
		int first_pivot = 0;
		int last_pivot = sorted_array.Length - 1;
		int mid_pivot = (first_pivot + last_pivot) / 2;

		int solution = 0;

		while (first_pivot <= last_pivot)
		{
			mid_pivot = (first_pivot + last_pivot) / 2;

			if(first_pivot == last_pivot) { return first_pivot; }
			else if (sorted_array[mid_pivot] == target) { return mid_pivot; }
			else if (sorted_array[mid_pivot] < target) { first_pivot = mid_pivot + 1; }
			else if (sorted_array[mid_pivot] > target) { last_pivot = mid_pivot - 1; }
		}

		return -1;

	}


}


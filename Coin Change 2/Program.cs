var solve = new Solution();

Console.WriteLine(solve.Change(5, new int[] { 1, 2, 5 }));

public class Solution
{
	public int Change(int amount, int[] coins)
	{
		quicksort(coins, 0, coins.Length - 1);
		string[,] nemo = new string[amount + 1, coins.Length];
		return GetCombinatonNumber(amount, coins, 0, nemo);
	}

	public void quicksort(int[] vec, int izq, int der)
	{
		int i, j, pivote, aux;
		i = izq;
		j = der;
		pivote = vec[(izq + der) / 2];
		do
		{
			while (vec[i] < pivote && i < der)
			{
				i++;
			}
			while (vec[j] > pivote && j > izq)
			{
				j--;
			}
			if (i <= j)
			{
				aux = vec[i];
				vec[i] = vec[j];
				vec[j] = aux;
				i++;
				j--;
			}
		} while (i <= j);
		if (izq < j)
			quicksort(vec, izq, j);
		if (i < der)
			quicksort(vec, i, der);
	}

	public int GetCombinatonNumber(int a_target, int[] a_numbers, int a_current_pos, string[,] a_nemo)
	{
		//Base cases
		if (a_target < 0) { return 0; }
		if (a_current_pos > a_numbers.GetUpperBound(0)) { return 0; };
		if (a_target == 0) { return 1; }
		if (a_target < a_numbers[a_current_pos]) { return 0; }

		if (a_nemo[a_target, a_current_pos] != null) { return Convert.ToInt32(a_nemo[a_target, a_current_pos]); }

		var tree_using_first_value_of_list = GetCombinatonNumber(a_target - a_numbers[a_current_pos], a_numbers, a_current_pos, a_nemo);

		var tree_without_using_first_value_of_list = GetCombinatonNumber(a_target, a_numbers, a_current_pos + 1, a_nemo);

		a_nemo[a_target, a_current_pos] = Convert.ToString(tree_using_first_value_of_list + tree_without_using_first_value_of_list);

		return Convert.ToInt32(a_nemo[a_target, a_current_pos]);


	}

}





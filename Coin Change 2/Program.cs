var solve = new Solution();

Console.WriteLine(solve.Change(5, new int[] { 1, 2, 5 }));

public class Solution
{
	public int Change(int amount, int[] coins)
	{
		quicksort(coins, 0, coins.Length - 1);

		int[,] nemo = new int[amount + 1, coins.Length + 1];
		for (int y = 0; y < coins.Length + 1; y++)
		{
			for (int x = 0; x < amount + 1; x++)
			{
				nemo[x, y] = -1;
			}
		}



		for (int y = 0; y < coins.Length + 1; y++)
		{
			for (int x = 0; x < amount + 1; x++)
			{
				if (x == 0) { nemo[x, y] = 1; continue; }
				if (y == 0) { nemo[x, y] = 0; continue; }

				if (amount + 1 < coins[y - 1])
				{
					nemo[x, y] = nemo[x, y - 1];
					continue;
				}

				try
				{
					nemo[x, y] = nemo[x - coins[y - 1], y] + nemo[x, y - 1];
				}
				catch (IndexOutOfRangeException)
				{
					nemo[x, y] = nemo[x, y - 1];
				}
			}
		}


		return nemo[nemo.GetUpperBound(0), nemo.GetUpperBound(1)]; ;


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

}





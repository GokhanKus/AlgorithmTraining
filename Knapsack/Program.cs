namespace Knapsack
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//silver => value: 60, weight: 5
			//diamond => value: 100, weight: 3
			//gold => value: 120, weight: 7


			int capacity = 10;
			int[] values = { 60, 100, 120 };
			int[] weights = { 5, 3, 7 };
			int n = values.Length;

			int maxValue = KnapsackDP(capacity, weights, values, n);
			Console.WriteLine("Çantanın en yüksek değeri: " + maxValue);
		}

		static int KnapsackDP(int capacity, int[] weights, int[] values, int n)
		{
			int[,] K = new int[n + 1, capacity + 1];

			for (int k = 0; k <= n; k++)
			{
				for (int w = 0; w <= capacity; w++)
				{
					if (k == 0 || w == 0)
						K[k, w] = 0;
					else if (weights[k - 1] <= w)
						K[k, w] = Math.Max(values[k - 1] + K[k - 1, w - weights[k - 1]], K[k - 1, w]);
					else
						K[k, w] = K[k - 1, w];
				}
			}

			return K[n, capacity]; //n. satir ve capacity. sütun yani 4'e 16
		}

	}
}

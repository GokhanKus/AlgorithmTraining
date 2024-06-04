
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
			int[] values = { 80, 50, 90 };
			int[] weights = { 7, 3, 5 };
			int n = values.Length;

			int maxValue = KnapsackDB(capacity, values, weights, n);
			Console.WriteLine("Çantanın en yüksek değeri: " + maxValue);
		}

		private static int KnapsackDB(int capacity, int[] values, int[] weights, int n)
		{
			int[,] K = new int[n + 1, capacity + 1];
			for (int k = 0; k <= n; k++)
			{
				for (int w = 0; w <= capacity; w++)
				{
					if (k == 0 || w == 0)
						K[k, w] = 0;
					else if (weights[k - 1] <= w)
					{
						int a = values[k - 1] + K[k - 1, w - weights[k - 1]];
						int b = K[k - 1, w]; //onceki satirin ayni sütunu
						K[k, w] = Math.Max(a, b);
					}
					else
						K[k, w] = K[k - 1, w];
				}
			}
			return K[n, capacity];
		}
	}
}

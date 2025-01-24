namespace FindTheLongestConsecutiveInArray
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] numbers = { 3, 94, 2, 6, 5, 15, 7, 4 };
			//en uzun ardısık dizi {4, 5, 6, 7} = 4 uzunlukta
			var result = FindTheLongestConsecutiveInArray(numbers);

			Console.Write($"the longest consecutive in array: {result.count}");
			Console.WriteLine();
			result.longestConsecutive.ForEach(x => Console.Write(x + " "));

		}
		static (int count, List<int> longestConsecutive) FindTheLongestConsecutiveInArray(int[] array)
		{
			int count = 0;
			var longestConsecutive = new List<int>();

			Array.Sort(array); // {2, 3, 4, 5, 6, 7, 15, 94}

			for (int i = 1; i < array.Length; i++)
			{
				if (i == 1 && array[i] - array[i - 1] == 1)
				{
					count++;
					longestConsecutive.Add(array[i-1]);
				}
				if (array[i] - array[i - 1] == 1)
				{
					count++;
					longestConsecutive.Add(array[i]);
				}
			}

			return (count, longestConsecutive);
		}
	}
}

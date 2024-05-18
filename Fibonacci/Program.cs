namespace Fibonacci
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//fibonacci 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89...
			int firstOne = 1;
			int secondOne = 1;
			List<int> fiboList = new List<int>();
			for (int i = 1; i < 20; i++)
			{
				//Console.Write($"{firstOne}, {secondOne}, ");
				fiboList.Add(firstOne);
				fiboList.Add(secondOne);
				firstOne = secondOne + firstOne;
				secondOne = firstOne + secondOne;
			}

			foreach (var fiboTerm in fiboList)
			{
				Console.WriteLine(fiboTerm);
			}
		}
	}
}

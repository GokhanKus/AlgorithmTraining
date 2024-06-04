namespace UglyNumbers
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//sayilari asal carpanlarına ayirdigimizda bolenleri 2, 3, 5 olan sayilar ugly numberdır orn;
			//1, 2, 3, 4, 5, 6, 8, 9, 10, 12, 15, 16, 18, 20, 24, 25, 27, 30, 32, 36, 40, 45, 48, 50, 54, 60, 64, 72, 75, 80,81, 90, 96, 100,
			int[] baseNumbers = { 2, 3, 5 };
			List<int> uglyNumbers = new List<int>();
			Dictionary<int, int> notUglyNumbers = new Dictionary<int, int>();
			for (int k = 1; k < 100; k++)
			{
				int sayi = k;
				for (int i = 0; i < baseNumbers.Length; i++)
				{
					while (sayi % baseNumbers[i] == 0)
					{
						sayi = sayi / baseNumbers[i];
					}
				}
				if (sayi == 1)
				{
					uglyNumbers.Add(k);
				}
				else
				{
					notUglyNumbers.Add(k, sayi);
				}
			}
			Console.WriteLine("UGLY NUMBERS");
			foreach (var uglyNumber in uglyNumbers)
			{
				Console.WriteLine($"{uglyNumber}");
			}

			Console.WriteLine("NOT UGLY NUMBERS");
			foreach (var notUglyNumber in notUglyNumbers)
			{
				Console.WriteLine($"{notUglyNumber.Key} ({notUglyNumber.Value}'e bolunebilir)");
			}
		}
	}
}

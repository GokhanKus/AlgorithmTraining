namespace PrintRandomNumbers
{
	internal class Program
	{
		static void Main(string[] args)
		{

			//1den 25e kadar olan sayıları rastgele yazdırma
			Random rnd = new Random();
			int randomIndex = 0;
			List<int> sayilar = new List<int>();
			for (int i = 1; i <= 25; i++)
			{
				sayilar.Add(i);
			}

			List<int> karisikSayilar = new List<int>();
			while (sayilar.Count > 0)
			{
				randomIndex = rnd.Next(0, sayilar.Count);
				int value = sayilar[randomIndex];
				karisikSayilar.Add(value);
				sayilar.RemoveAt(randomIndex);
			}
			foreach (int value in karisikSayilar) { Console.WriteLine(value); }

			//1den 25e kadar olan sayıları rastgele yazdırma
			//int index = 0;
			//List<int> numbers = new List<int>();
			//for (int i = 1; i <= 25; i++)
			//{
			//	numbers.Add(i);
			//}

			//Random rnd = new Random();

			//while (numbers.Count > 0)
			//{
			//	index = rnd.Next(0, numbers.Count); //index = 3 olsun
			//	int randomNumber = numbers[index]; //rNumber = 4 oldu

			//	Console.WriteLine(randomNumber);   //4 yazdırıldı
			//	numbers.RemoveAt(index);           //3.index olan 4 kaldırıldı ve numbers.Count 25ten 24e düştü
			//}
			

		}
	}
}

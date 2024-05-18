
namespace PerfectNumbers
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//bir sayinin bolenleri toplamı o sayiya eşitse o sayi perfect sayıdır orn: 28 perfect number => 1 + 2 + 4 + 7 + 14 = 28
			//mükemmel sayilar çok nadirdir işte bazıları: 6, 28, 496, 8128, 33550336


			//Console.WriteLine("sayi gir");
			//int sayi = Convert.ToInt32(Console.ReadLine());
			//int bolenlerToplam = 0;
			//List<int> sayiBolenleri = new List<int>();

			//for (int i = 1; i <= (sayi / 2) + 1; i++)
			//{
			//	if (sayi % i == 0)
			//	{
			//		sayiBolenleri.Add(i);
			//		Console.Write(i + " + ");
			//	}
			//	if (i == (sayi / 2) + 1)
			//	{
			//		Console.Write("= ");
			//	}
			//}
			//for (int j = 0; j < sayiBolenleri.Count; j++)
			//{
			//	bolenlerToplam += sayiBolenleri[j];
			//}
			//if (bolenlerToplam == sayi)
			//{
			//	Console.WriteLine(sayi + " IS A PERFECT NUMBER");
			//}
			//else
			//{
			//	Console.WriteLine(bolenlerToplam + " IS NOT A PERFECT NUMBER");
			//}

			//100 e kadar olan perfect sayıları yazdıralım
			for (int x = 1; x <= 1000; x++)
			{
				List<int> bolenSayilar = new List<int>();
				int bolenSayilarinToplami = 0;
				for (int i = 1; i < (x / 2) + 1; i++)
				{
					if (x % i == 0)
					{
						bolenSayilar.Add(i);
					}
				}
				for (int j = 0; j < bolenSayilar.Count; j++)
				{

					bolenSayilarinToplami += bolenSayilar[j];
				}

				if (bolenSayilarinToplami == x)
					Console.WriteLine(x);
			}
			Console.ReadLine();
		}
	}
}

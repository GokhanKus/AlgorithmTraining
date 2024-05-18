namespace PrimeFactorization
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region girilen sayinin asal carpanlarini yazdirma

			//girilen sayinin asal carpanlarini yazdirma
			Console.Write("Asal carpanlarina ayrilacak sayiyi gir :");
			int girilenSayi = int.Parse(Console.ReadLine());
			int sayi = (girilenSayi / 2) + 1;//2 ve 3 degerleri girilirse..
			bool asalmi = true;
			Dictionary<int, int> asalCarpanlar = new Dictionary<int, int>();
			for (int i = 2; i < sayi; i++)
			{
				int carpanAdedi = 0;
				while (girilenSayi % i == 0)
				{
					carpanAdedi++;
					if (asalCarpanlar.ContainsKey(i))
					{
						asalCarpanlar[i] = carpanAdedi;
					}
					else
					{
						asalCarpanlar.Add(i, carpanAdedi);
					}
					girilenSayi = girilenSayi / i;

					asalmi = false; //eger while dongusune girdiyse asal degildir
				}
			}
			if (asalmi)
			{
				asalCarpanlar.Add(girilenSayi, 1);
				Console.WriteLine($"{girilenSayi} bir asal sayidir.");
			}
			int bolenSayilarToplami = 1;
			foreach (var asalCarpan in asalCarpanlar)
			{
				bolenSayilarToplami *= asalCarpan.Value + 1;
				Console.WriteLine($"asal carpanlar: {asalCarpan}");
			}
			Console.WriteLine($"sayinin toplam {bolenSayilarToplami} adet boleni vardır");
			Console.ReadLine();
			#endregion

		}
	}
}

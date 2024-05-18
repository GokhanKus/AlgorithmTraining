namespace BlackJack
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Blackjack

			string response = string.Empty;

			int jack = 10;
			int queen = 10;
			int king = 10;
			int ace = 11;

			int[] sayilar = { 2, 3, 4, 5, 6, 7, 8, 9, 10, jack, queen, king, ace };
			Random rnd = new Random();

			int elimdekilerToplami = 0;
			int gelenSayi = 0;
			int bilgisayarinEli = 0;
			string bilgisayarinKartlari = "";
			do
			{
				for (int i = 0; i < 4; i++)
				{
					if (i < 2)
					{
						gelenSayi = rnd.Next(0, sayilar.Length);
						elimdekilerToplami += sayilar[gelenSayi];
						Console.WriteLine($"Kartlarim: {sayilar[gelenSayi]}");
					}
					else
					{
						while (bilgisayarinEli <= 11)
						{
							gelenSayi = rnd.Next(0, sayilar.Length);
							bilgisayarinKartlari += gelenSayi + ", ";
							bilgisayarinEli += sayilar[gelenSayi];
						}
					}
				}

				Console.WriteLine("Kart cek: Y\nsonucu gor: any tus");
				Console.WriteLine(new string('-', 60));
				response = Console.ReadLine();
				do
				{
					if (response == "y".ToLower() || response == "Y".ToLower())
					{
						gelenSayi = rnd.Next(0, sayilar.Length);
						Console.WriteLine("cektigin kart: " + sayilar[gelenSayi]);
						elimdekilerToplami += sayilar[gelenSayi];
						if (elimdekilerToplami > 21)
						{
							Console.WriteLine("elindekilerin toplami: " + elimdekilerToplami + " GAMEOVER");
							break;
						}
						else
						{
							Console.WriteLine("elindekiler toplami: " + elimdekilerToplami);
							Console.WriteLine("bir kart daha cekmek ister misin? E/H");
							response = Console.ReadLine();
						}
					}
					else
					{
						if (bilgisayarinEli >= elimdekilerToplami)
						{
							Console.WriteLine($"Bilgisayarin Kartlari: {bilgisayarinKartlari}"); //burasi duzgun calismiyor sonra bak.
							Console.WriteLine($"Bilgisayarin eli: {bilgisayarinEli} >= {elimdekilerToplami} GAMEOVER");
							break;
						}
						else
						{
							Console.WriteLine($"elimdekiler toplami: {elimdekilerToplami} > bilgisayarin eli{bilgisayarinEli} KAZANDIM");
							break;
						}
					}
				} while (response != "n");

				Console.WriteLine("1 el daha oynamak ister misin? E/H");
				Console.WriteLine(new string('-', 60));

				response = Console.ReadLine();

				elimdekilerToplami = 0;
				bilgisayarinEli = 0;

			} while (response != "H".ToLower());
			#endregion

		}
	}
}

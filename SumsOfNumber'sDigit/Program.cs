namespace SumsOfNumber_sDigit
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//int sayi = 25367;
			//int rakamlarToplam = 0;
			//while (sayi != 0)
			//{
			//	int kalan = sayi % 10;
			//	rakamlarToplam += kalan;
			//	sayi /= 10;
			//}
			//Console.WriteLine(rakamlarToplam);

			int sayi = 25243;
			string s = sayi.ToString();
			int basamakSayisi = s.Length - 1;
			int basamakToplam = 0;
			while (sayi != 0)
			{
				int bolen = Convert.ToInt32(Math.Pow(10, basamakSayisi)); 
				int basamakDeger = (sayi) / bolen;  
				sayi = sayi - (basamakDeger * bolen);  
				basamakToplam += basamakDeger;
				basamakSayisi--;
			}
            Console.WriteLine(basamakToplam);
        }
	}
}

namespace SumsOfNumber_sDigit
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int sayi = 25367;
			int rakamlarToplam = 0;
			while (sayi != 0)
			{
				int kalan = sayi % 10;
				rakamlarToplam += kalan;
				sayi /= 10;
			}
			Console.WriteLine(rakamlarToplam);
		}
	}
}

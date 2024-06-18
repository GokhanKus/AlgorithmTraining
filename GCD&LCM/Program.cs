
namespace GCD_LCM
{
	internal class Program
	{
		//GCD(Greatest Common Divisor)(EBOB) LCM(Least Common Multiple)(EKOK)
		static void Main(string[] args)
		{
			while (true)
			{
				Console.Write("ebob, ekok icin 1. sayiyi gir : ");
				int sayi1 = Convert.ToInt32(Console.ReadLine());
				Console.Write("ebob, ekok icin 2. sayiyi gir : ");
				int sayi2 = Convert.ToInt32(Console.ReadLine());

				Console.WriteLine($"ebob: {EBOB(sayi1, sayi2)}");
				Console.WriteLine($"ekok: {EKOK(sayi1, sayi2)}");
			}
		}
		private static int EBOB(int v1, int v2)
		{
			int ebob = 1;
			for (int i = v1; i >= 2; i--)
			{
				if ((v2 % i) == 0 && (v1 % i) == 0) // iki sayi da bolunebiliyorsa bolunen sayiyi alalim
				{
					ebob *= i;
					return ebob;
				}
			}
			return ebob;
		}
		private static int EKOK(int v1, int v2)
		{
			int ekok = 1;
			for (int i = 1; i <= v1; i++)
			{
				if ((v2 * i) % v1 == 0)
				{
					ekok = v2 * i;
					return ekok;
				}
			}
			return ekok;
		}
	}
}

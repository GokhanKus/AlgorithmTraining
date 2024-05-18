namespace DecimalToBinary
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//girilen sayiyi binary olarak yaz
			//         Console.WriteLine("binary'e cevrilecek sayiyi giriniz:");
			//         int sayi = Convert.ToInt32(Console.ReadLine());
			//string binaryReverse = "";
			//string binary = "";
			//while (sayi != 0)
			//{
			//	if (sayi % 2 == 1)
			//	{
			//		binaryReverse += "1";
			//	}
			//	else
			//	{
			//		binaryReverse += "0";
			//	}
			//	sayi /= 2;
			//}
			//for (int i = binaryReverse.Length - 1; i >= 0; i--)
			//{
			//	binary += binaryReverse[i];
			//}
			//Console.WriteLine(binary);

			//100e kadar olan sayilarin binary karşılıklarını yazdıralım
			for (int x = 1; x < 100; x++)
			{
				int sayi = x;
				string binaryReverse = "";
				string binary = "";
                Console.Write(sayi + "\t");
                while (sayi != 0)
				{
					if (sayi % 2 == 1)
					{
						binaryReverse += "1";
					}
					else
					{
						binaryReverse += "0";
					}
					sayi /= 2;
				}
				for (int i = binaryReverse.Length - 1; i >= 0; i--)
				{
					binary += binaryReverse[i];
				}
				Console.WriteLine(binary);
			}
		}
	}
}

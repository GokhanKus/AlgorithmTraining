namespace Sums2Numbers30Digits
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//long q = 9223372036854775807; long 8 byte'dır yani 64 bit ve alabilecegi max deger 2^64 -1 dir = 9223372036854775807 (19 basamaklı)
			//int w = 2147483647; int 4 byte'dır yani 32 bit ve alabilecegi max deger 2^32 -1 dir = 2147483647          (10 basamaklı)
			//biz bu 2 sayiyi veya daha büyük sayilari toplayamayiz ama string turunde yazarak toplayabiliriz;
			string sayi1 = "944545545477344078665";
			string sayi2 = "45045245454527963122878";

			Console.WriteLine(sayi1);
			Console.WriteLine(sayi2);
			Console.WriteLine("+");
			Console.WriteLine(new string('-', 60));
			string sonuc = "";
			int sayi1BasamakSayisi = sayi1.Length;
			int sayi2BasamakSayisi = sayi2.Length;
			int maxLength = Math.Max(sayi1BasamakSayisi, sayi2BasamakSayisi);
			int artan = 0;//ornegin 6 + 7 = 13 bu kisimda 3 degeri tutulur.
			bool eldeVarmi = false; //elde varsa bir sonraki basamak degerini bir artiracagiz.

			//toplama islemine baslamadan once basamak degerlerini esitleyelim
			if (sayi1BasamakSayisi > sayi2BasamakSayisi)
				while (sayi1.Length != sayi2.Length) //basamaklar eşit degilse eşit olana kadar sayilarin basina "0" ekleyelim
					sayi2 = $"0{sayi2}";

			else
				while (sayi1.Length != sayi2.Length) //basamaklar eşit degilse eşit olana kadar sayilarin basina "0" ekleyelim
					sayi1 = $"0{sayi1}";

			for (int i = maxLength - 1; i >= 0; i--)
			{
				int toplam = 0;
				int rakam1 = (byte)sayi1[i] - 48;
				int rakam2 = (byte)sayi2[i] - 48;

				if (eldeVarmi == true)
				{
					toplam = rakam1 + rakam2 + 1;
				}
				else
				{
					toplam = rakam1 + rakam2;
				}
				if (toplam < 10)
				{
					sonuc = toplam + sonuc;
					eldeVarmi = false;
				}
				else
				{
					artan = toplam % 10;
					sonuc = artan + sonuc;
					eldeVarmi = true;
				}

			}
			if (eldeVarmi)
			{
				sonuc = 1 + sonuc;
			}

			Console.WriteLine(sonuc);

			Console.ReadLine();

		}
	}
}

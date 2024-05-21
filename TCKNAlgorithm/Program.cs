namespace TCKNAlgorithm
{
	/*
	 TC Kimlik numaraları 11 basamaktan oluşmaktadır. İlk 9 basamak arasında kurulan bir algoritma bize 10. basmağı, 
	 ilk 10 basamak arasında kurulan algoritma ise bize 11. basamağı verir.
	 11 hanelidir.
	 Her hanesi rakamsal değer içerir.
	 İlk hane 0 olamaz.
	 1. 3. 5. 7. ve 9. hanelerin toplamının 7 katından, 2. 4. 6. ve 8. hanelerin toplamı çıkartıldığında, cikan sonucun 10′a bölümünden kalan,bize 10. haneyi verir.
	 1.2.3.4.5.6.7.8.9.ve 10. hanelerin toplamından elde edilen sonucun 10′a bölümünden kalan, yani Mod10′u bize 11. haneyi verir.
	*/
	internal class Program
	{
		static void Main(string[] args)
		{
			string tcKimlikCheck = "47123568512"; //rastgele algoritmayi saglayan bir numara
			bool tcFormat = isTcFormatCorrect(tcKimlikCheck);
			Console.WriteLine(tcFormat);

			string missingTc = "471235685"; //12 => algoritma dogrultusunda uretilen son iki rakam
			string getLastTwoDigits = Create10th11thNumber(missingTc);
			Console.WriteLine($"{missingTc} ve son iki rakami: {getLastTwoDigits}");
		}

		private static string Create10th11thNumber(string missingTc)
		{
			if (missingTc.Length != 9 || missingTc[0] == 0)
			{
				return "tc yanlis formatta girildi veya ilk rakam 0 girildi";
			}
			string lastTwoDigits = "";

			int[] eksikTc = new int[9]; //son iki rakami olmayan tc
			for (int i = 0; i < missingTc.Length; i++)
			{
				eksikTc[i] = int.Parse(missingTc[i].ToString());//harf girilme ihtimaline karsi burada try catch yapilabilir
			}
			int birUcBesYediDokuzToplam = GetOddNumbersSumsForTc(eksikTc);
			int ikiDortAltiSekizToplam = GetEvenNumbersSumsForTc(eksikTc);

			//ilk rakam 0 kontrolu
			int tc10thNumber = ((birUcBesYediDokuzToplam * 7) - ikiDortAltiSekizToplam) % 10; //burasi tcnin 10.hanesi ve 4 olmasi lazim
			lastTwoDigits += tc10thNumber;
			int tc11thNumber = (birUcBesYediDokuzToplam + ikiDortAltiSekizToplam + tc10thNumber) % 10; //burasi tcnin 11.hanesi ve 8 olmasi lazim
			lastTwoDigits += tc11thNumber;

			return lastTwoDigits;
		}

		static bool isTcFormatCorrect(string tcKimlikCheck)
		{
			//bool correctFormat = false;
			if (tcKimlikCheck.Length != 11 || tcKimlikCheck[0] == 0)
			{
				return false;
			}
			int[] tcKimlikRakamlar = new int[11];
			for (int i = 0; i < tcKimlikCheck.Length; i++)
			{
				tcKimlikRakamlar[i] = int.Parse(tcKimlikCheck[i].ToString());//harf girilme ihtimaline karsi burada try catch yapilabilir
			}
			int birUcBesYediDokuzToplam = GetOddNumbersSumsForTc(tcKimlikRakamlar);
			int ikiDortAltiSekizToplam = GetEvenNumbersSumsForTc(tcKimlikRakamlar);

			int tc10thNumber = ((birUcBesYediDokuzToplam * 7) - ikiDortAltiSekizToplam) % 10; //burasi tcnin 10.hanesi ve 4 olmasi lazim
			if (tc10thNumber == tcKimlikRakamlar[9])
			{
				int tc11thNumber = (birUcBesYediDokuzToplam + ikiDortAltiSekizToplam + tc10thNumber) % 10; //burasi tcnin 11.hanesi ve 8 olmasi lazim
				if (tc11thNumber == tcKimlikRakamlar[10])
				{
					return true;
				}
			}
			return false;
		}
		static int GetOddNumbersSumsForTc(int[] tcKimlikRakamlar)
		{
			int birUcBesYediDokuzToplam = 0;
			for (int i = 0; i <= tcKimlikRakamlar.Length; i += 2)
			{
				if (i != 10)
					birUcBesYediDokuzToplam += tcKimlikRakamlar[i]; //tcnin 1, 3, 5, 7, 9 hanelerinin toplamini verir
			}
			return birUcBesYediDokuzToplam;
		}
		static int GetEvenNumbersSumsForTc(int[] tcKimlikRakamlar)
		{
			int ikiDortAltiSekizToplam = 0;
			for (int i = 1; i <= tcKimlikRakamlar.Length; i += 2)
			{
				if (i != 9 && i != 11)
					ikiDortAltiSekizToplam += tcKimlikRakamlar[i]; //tcnin 2, 4, 6, 8,  hanelerinin toplamini verir
			}
			return ikiDortAltiSekizToplam;
		}
	}
}

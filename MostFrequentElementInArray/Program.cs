
namespace MostFrequentElementInArray
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//string text = "assdddadasss";
			//Dictionary<string, int> duplicateSayisi = new Dictionary<string, int>();
			//for (int i = 0; i < text.Length; i++)
			//{
			//	int tekrarEdenElemanSayisi = 0;
			//	for (int j = 0; j < text.Length; j++)
			//	{
			//		if (text[i] == text[j])
			//		{
			//			tekrarEdenElemanSayisi++;
			//			duplicateSayisi.TryAdd(text[i].ToString(), tekrarEdenElemanSayisi);
			//			duplicateSayisi[text[i].ToString()] = tekrarEdenElemanSayisi;
			//		}
			//	}
			//}
			//foreach (var harf in duplicateSayisi)
			//{
			//	Console.WriteLine($"{harf}");
			//}

			string text = "abssdddadasss";
			int[] alphabet = new int[26];
			for (int i = 0; i < text.Length; i++)
			{
				char c = text[i];
				alphabet[(byte)c - 97]++;	//harfin sayi karsiligi (a ilk harf oldugu icin 1 degerini alıyorz)
			}
			int maxEleman = 0;
			char mostFrequentChar = ' ';
			for (int x = 0; x < alphabet.Length; x++)
			{
				if (alphabet[x] > maxEleman)
				{
					maxEleman = alphabet[x];
					mostFrequentChar = (char)(x + 97); //harf karsiligi
				}
			}
			Console.WriteLine("En çok geçen harf: " + mostFrequentChar + " (" + maxEleman + " kere)");
		}
	}
}

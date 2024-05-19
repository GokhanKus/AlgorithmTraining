namespace MostFrequentElementInArray
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string text = "assdddadasss";
			Dictionary<string, int> duplicateSayisi = new Dictionary<string, int>();
			for (int i = 0; i < text.Length; i++)
			{
				int tekrarEdenElemanSayisi = 0;
				for (int j = 0; j < text.Length; j++)
				{
					if (text[i] == text[j])
					{
						tekrarEdenElemanSayisi++;
						duplicateSayisi.TryAdd(text[i].ToString(),tekrarEdenElemanSayisi);
						duplicateSayisi[text[i].ToString()] = tekrarEdenElemanSayisi;
					}
				}
			}
			foreach (var harf in duplicateSayisi)
			{
                Console.WriteLine($"{harf}");
            }
			
			Console.ReadLine();
		}
	}
}

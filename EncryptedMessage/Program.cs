namespace EncryptedMessage
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//a b c d e f g h i j  k  l  m  n  o  p  q  r  s  t  u  v  w  x  y  z
			//1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26
			/*a = 1, b = 2, ... z = 26 eşlemesi ve şifrelenmiş bir mesaj verildiğinde, şifresinin çözülebileceği yolların sayısını sayın.
			Örneğin '111' mesajı 'aaa', 'ka' ve 'ak' olarak çözülebildiği için 3 değerini verecektir.
			Mesajların kodunun çözülebileceğini varsayabilirsiniz. Örneğin '001'e izin verilmiyor*/

			string cozulenMesaj = MesajiCoz("111");
			Console.WriteLine(cozulenMesaj);
		}

		private static string MesajiCoz(string cozulecekMesaj)
		{
			char[] alphabet = new char[26];
			for (int i = 0; i < alphabet.Length; i++)
			{
				alphabet[i] = (char)(i + 97);
			}

			var splitedNumbers = 0; //burasi 1, 11, 2, 12 gibi degerler olacak 
			string result = string.Empty;
			List<string> results = new List<string>();
			//orn 123 girildiginde 1, 2, 3, 12, 23 degerlerine bakılır yani girilen sayinin 2 katinin 1 eksigi kadar ihtimal vardır

			int combinationNumbers = (cozulecekMesaj.Length * 2) - 1;
			for (int i = 0; i < cozulecekMesaj.Length; i++)
			{
				splitedNumbers = byte.Parse(cozulecekMesaj.Substring(i, 1)) - 1;
				result += (alphabet[splitedNumbers].ToString()) + " ";
			}
			for (int i = 0; i < cozulecekMesaj.Length - 1; i++)
			{
				splitedNumbers = byte.Parse(cozulecekMesaj.Substring(i, 2)) - 1;
				if (splitedNumbers < 26)
				{
					result += (alphabet[splitedNumbers].ToString()) + " ";
				}
			}
			return result;
		}
	}
}

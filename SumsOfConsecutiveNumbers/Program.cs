namespace SumsOfConsecutiveNumbers
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*
            * 1 + 2 = 3
            * 4 + 5 + 6 = 7 + 8
            * 9 + 10 + 11 + 12 = 13 + 14 + 15
            * 16 + 17 + 18 + 19 + 20 = 21 + 22 + 23 + 24
            
            * (n) + (n+1) + (n+2) + ... + (n+k) = (n+k+1) + (n+k+2) + ... + (n+k+)
            * 
            * n+k = soldaki sondaki terim
            * soldaki terim sayisi k + 1
            * 
            * sağdaki terim sayisi k
            * n = 16 ise k = 4, n = 9 ise k = 3 ..
            
            */

			Console.WriteLine("kaç satır görmek istiyorsunuz:");

			int row = Convert.ToInt32(Console.ReadLine());

			int countInRow = 0;
			for (int i = 1; i < row + 1; i++)
			{
				int firstTerm = i * i;
				countInRow = ((i - 1) * 2) + 3;
				for (int j = 0; j < countInRow; j++)
				{
					if (j == i * 2) //rowdaki son terimi ifade eder
					{
						Console.Write(firstTerm);
					}
					else if (j == i)
					{
						Console.Write($"{firstTerm} = ");
					}
					else
					{
						Console.Write($"{firstTerm} + ");
					}
					firstTerm++;
				}
				Console.WriteLine();
			}
			Console.ReadLine();
		}
	}
}

using System.Runtime.InteropServices;

namespace Radical_Numbers_Square_Root_
{
	internal class Program
	{
		//orn √40 = 2√10, √140 = 2√35, √72 = 6√2 ..
		static void Main(string[] args)
		{
			#region FirstApproach
			//while (true)
			//{
			//	int radicalNumber = Convert.ToInt32(Console.ReadLine());
			//	int squareRoot = radicalNumber;
			//	Dictionary<int, int> primeNumbers = new Dictionary<int, int>();
			//	int counter;

			//	for (int i = 2; i <= radicalNumber; i++)
			//	{
			//		counter = 0;
			//		while (radicalNumber % i == 0)
			//		{
			//			counter++;
			//			primeNumbers[i] = counter; //bolunebilen sayiyi kac kere bolunuyosa o kadar arttir
			//			radicalNumber /= i;
			//		}
			//	}
			//	//yukaridaki for ve while ile sayinin asal bolenleri ve kaç adet oldugunu dictionary'e atandi

			//	int tamKisim = 1;
			//	int kokluKisim = 1;
			//	foreach (var primeNumber in primeNumbers)
			//	{
			//		if (primeNumber.Value % 2 == 1)
			//		{
			//			if (primeNumber.Value != 1)
			//			{
			//				tamKisim *= primeNumber.Key * (primeNumber.Value / 2);
			//				kokluKisim *= primeNumber.Key;
			//			}
			//			else
			//			{
			//				kokluKisim *= primeNumber.Key;
			//			}
			//		}
			//		else
			//		{
			//			tamKisim *= primeNumber.Key * (primeNumber.Value / 2);
			//		}
			//	}
			//	if (tamKisim == 1)
			//		Console.WriteLine($"{squareRoot} = kök {kokluKisim}");

			//	else if (kokluKisim == 1)
			//		Console.WriteLine($"{squareRoot} = {tamKisim}");

			//	else
			//		Console.WriteLine($"{squareRoot} = {tamKisim} kök {kokluKisim}");
			//}
			#endregion

			#region SecondApproach
			bool tamKisimVarmi;
			while (true)
			{
				int radicalNumber = Convert.ToInt32(Console.ReadLine());
				tamKisimVarmi = false;
				double squareRoot;
				for (int i = 2; i <= radicalNumber / 2; i++)
				{
					squareRoot = Math.Sqrt(radicalNumber);
					if (squareRoot % 1 == 0)
					{
						tamKisimVarmi = true;
						Console.WriteLine(radicalNumber + " = " + squareRoot);
						break;
					}
					if (radicalNumber % i == 0)
					{
						squareRoot = Math.Sqrt(radicalNumber / i);
						if (squareRoot % 1 == 0)
						{
							tamKisimVarmi = true;
							Console.WriteLine($"{radicalNumber} = {squareRoot} kök {i}");
							break;
						}
					}
				}
				if (tamKisimVarmi == false)
				{
					Console.WriteLine($"{radicalNumber} = kök {radicalNumber}");
				}
			}
			#endregion
		}
	}
}

using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithm
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region BubbleSort 1

			//verilen dizideki örn:
			//[6, 2, 35, 61, 24, 5] [5,35,61,2,6,24] olarak sırala önce tekler sonra çiftleri sıralı olarak ata
			//Selection sort algorithm

			//int buyukEleman = 0;
			//int sayac = 0;
			//int[] unSorted = { 1, 5, 0, 6, 22, 7, 4, 73 };

			//for (int i = 0; i < unSorted.Length - 1; i++)
			//{
			//    for (int j = i + 1; j < unSorted.Length; j++)
			//    {
			//        if (unSorted[i] > unSorted[j])
			//        {
			//            buyukEleman = unSorted[i];
			//            unSorted[i] = unSorted[j];
			//            unSorted[j] = buyukEleman;
			//        }
			//        sayac++;
			//    }
			//}
			//Console.WriteLine();
			//Console.WriteLine(sayac);
			//foreach (int item in unSorted)
			//{
			//    Console.Write(" " + item);
			//}
			#endregion

			#region BubbleSort 2
			//BubbleSort Algorithm
			int[] unSorted = { 70, 1, 0, 5, 5, 0, 6, 22, 7, 4, 73 };
			//int[] unSorted = { 5, 1, 6, 0, 73, 22, 7, 4 };
			int sayac = 0;
			int buyukEleman = 0;
			for (int i = 0; i < unSorted.Length; i++)
			{
				for (int j = 0; j < unSorted.Length - 1 - i; j++)
				{
					if (unSorted[j] > unSorted[j + 1])
					{
						buyukEleman = Swap(unSorted, j);
					}
					sayac++;
				}
			}
			foreach (int item in unSorted)
			{
				Console.Write($" - {item}");
			}
			Console.WriteLine();
			Console.WriteLine(sayac);

			#endregion

		}

		private static int Swap(int[] unSorted, int j)
		{
			int buyukEleman = unSorted[j];
			unSorted[j] = unSorted[j + 1];
			unSorted[j + 1] = buyukEleman;
			return buyukEleman;
		}
	}
}

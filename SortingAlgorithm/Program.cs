﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

            //int[] diziler = { 1, 2, 56, 33, 74, 3 };
            //MaxSayi(diziler);

            //BubbleSort Algorithm
            //int[] unSorted = { 1, 5, 0, 6, 22, 7, 4, 73 };
            //int[] unSorted = { 5, 1, 6, 0, 73, 22, 7, 4 };
            //int sayac = 0;
            //int buyukEleman = 0;
            //for (int i = 0; i < unSorted.Length; i++)
            //{
            //    for (int j = 0; j < unSorted.Length - 1 - i; j++)
            //    {
            //        if (unSorted[j] > unSorted[j + 1])
            //        {
            //            buyukEleman = unSorted[j];
            //            unSorted[j] = unSorted[j + 1];
            //            unSorted[j + 1] = buyukEleman;
            //        }
            //        sayac++;
            //    }
            //}
            //foreach (int item in unSorted)
            //{
            //    Console.Write($" - {item}");
            //}
            //Console.WriteLine();
            //Console.WriteLine(sayac);


            //1den 25e kadar olan sayıları rastgele yazdırma
            //Random rnd = new Random();
            //int randomIndex = 0;
            //List<int> sayilar = new List<int>();
            //for (int i = 1; i <= 25; i++)
            //{
            //    sayilar.Add(i);
            //}

            //List<int> karisikSayilar = new List<int>();
            //while(sayilar.Count>0)
            //{ 
            //    randomIndex = rnd.Next(0,sayilar.Count);
            //    int value = sayilar[randomIndex];
            //    karisikSayilar.Add(value);
            //    sayilar.RemoveAt(randomIndex);
            //}
            //foreach (int value in karisikSayilar) { Console.WriteLine(value); }

            //1den 25e kadar olan sayıları rastgele yazdırma
            //int index = 0;
            //List<int> numbers = new List<int>();
            //for (int i = 1; i <= 25; i++)
            //{
            //    numbers.Add(i);
            //}

            //Random rnd = new Random();

            //while (numbers.Count > 0)
            //{
            //    index = rnd.Next(0, numbers.Count); //index = 3 olsun
            //    int randomNumber = numbers[index]; //rNumber = 4 oldu

            //    Console.WriteLine(randomNumber);   //4 yazdırıldı
            //    numbers.RemoveAt(index);           //3.index olan 4 kaldırıldı ve numbers.Count 25ten 24e düştü
            //}

            //film listesindeki duplicate olanlari listeden cikar
            //string splitingLine = new string('-', 60);
            //string movies =
            //    "Sleeping dogs (2024) \r\n\r\nSleeping dogs (2024) \r\n\r\nLand of Bad \r\n\r\nDogville\r\n\r\nSleeping dogs (2024)\r\n\r\nAs good as it gets \r\n\r\nReservoir dogs " +
            //    "\r\n\r\nAmelie \r\n\r\nPhantom thread \r\n\r\nThere will be blood \r\n\r\nThe beekeeper \r\n\r\nLife is beautiful \r\n\r\nDie welle" +
            //    "\r\n\r\nDas experiment \r\n\r\nHotel rwanda \r\n\r\nKingdom of heaven \r\n\r\nPsycho \r\n\r\nPrisoners \r\n\r\nBig lebowski " +
            //    "\r\n\r\nPulp fiction \r\n\r\n3 billboards \r\n\r\nSaving the private ryan \r\n\r\nThe fountain \r\n\r\nGladiator \r\n\r\nPrimal fear " +
            //    "\r\n\r\nThe lizard(marmoulak) \r\n\r\nWhen the evil lurks \r\n\r\nTrain to busan \r\n\r\nUntouchables \r\n\r\nThe lighthouse " +
            //    "\r\n\r\n3:10 to yuma \r\n\r\nscent of a woman \r\n\r\nthe father(antony hopkins) \r\n\r\nThe unbearable weight of massive talent " +
            //    "\r\n\r\nThe whale \r\n\r\nthe machinist \r\n\r\nUncut gems \r\n\r\nno country for old men \r\n\r\nLOCK, STOCK AND TWO SMOKING BARRELS " +
            //    "\r\n\r\nThe magnificent seven \r\n\r\nFargo \r\n\r\nBullet train \r\n\r\nGangs of new york \r\n\r\nMandariinid \r\n\r\nWrath of man " +
            //    "\r\n\r\nHeat \r\n\r\nThe host(yaratık) \r\n\r\nTaxi driver (1975) \r\n\r\nTaxi driver(korean) \r\n\r\nSearching \r\n\r\nThe treatment " +
            //    "\r\n\r\none flew over the cuckoo's nest \r\n\r\nSisu \r\n\r\n1917 \r\n\r\nReservoir dogs \r\n\r\nCorpse bride \r\n\r\nMary & Max " +
            //    "\r\n\r\nEjderha dovmeli kiz \r\n\r\nCennetin kralligi \r\n\r\nGodfather II \r\n\r\nGoodfellas \r\n\r\nScarface \r\n\r\nPiyanist " +
            //    "\r\n\r\nAmelie \r\n\r\nWrath of man \r\n\r\nMachinist \r\n\r\nEternal sunshine of the spotless mind \r\n\r\nThe shape of water  " +
            //    "\r\n\r\nZorro \r\n\r\nAs good as it gets \r\n\r\nThe treatment \r\n\r\nFlight \r\n\r\nBlood diamond \r\n\r\nOlu gelin" +
            //    "\r\n\r\nRoom 2015 \r\n\r\nThe terror \r\n\r\nThe fountain 2006 \r\n\r\nHeat \r\n\r\nX \r\n\r\ngangs of new york \r\n\r\nMidsommar " +
            //    "\r\n\r\nCovenant\r\n\r\nThe killer \r\n\r\nKillers of the moon \r\n\r\nRadical \r\n\r\nDream scenario \r\n\r\nKnives out " +
            //    "\r\n\r\nDeliver us \r\n\r\nHermana muerte \r\n\r\nNetwork 1976 \r\n\r\nSerpico \r\n\r\nRear window \r\n\r\nThe others " +
            //    "\r\n\r\nSaw series \r\n\r\nThe fly\r\n\r\nViva zapata \r\n\r\nGel ve gor (ww2) \r\n\r\nSchindler’s list \r\n\r\nStriped pajamas" +
            //    "\r\n\r\nMurder on the orient express\r\n\r\nAs good as it gets \r\n\r\nLast samurai \r\n\r\nChildren of men \r\n\r\nInside man " +
            //    "\r\n\r\nThree billboards \r\n\r\nPsycho\r\n\r\nThe gentlemen \r\n\r\nDog day afternoon \r\n\r\nThe gentlemen \r\n\r\nBefore the Devil knows you are dead" +
            //    "\r\n\r\nBefore the Devil knows you are dead\r\n\r\nSleeping dogs (2024)";

            //string splitMovies = "\r\n\r\n";
            //StringSplitOptions splitType = StringSplitOptions.RemoveEmptyEntries;

            //string[] splitedMovies = movies.Split(new string[] { splitMovies }, splitType);
            //int count = 1;
            //int totalMovieCount = splitedMovies.Length;
            //Console.WriteLine($"There are {totalMovieCount} movies found with duplicated ones");
            //Console.WriteLine(splitingLine);

            //List<string> movieList = new List<string>(splitedMovies);
            //Dictionary<string, int> duplicatedOnes = new Dictionary<string, int>();
            //for (int i = 0; i < movieList.Count; i++)
            //{
            //    movieList[i] = movieList[i].Trim().ToLower();
            //}
            //for (int i = movieList.Count - 1; i >= 0; i--)
            //{
            //    count = 1;
            //    for (int j = i - 1; j >= 0; j--)
            //    {
            //        if (movieList[i] == movieList[j])
            //        {
            //            count++;
            //            movieList.RemoveAt(j);
            //            i--;
            //            totalMovieCount--;
            //        }
            //    }
            //    Console.Write(movieList[i] + "\n");
            //    if (count > 1)
            //    {
            //        duplicatedOnes.Add(movieList[i], count);
            //    }
            //}
            //Console.WriteLine(splitingLine);
            //foreach (var duplicatedMovie in duplicatedOnes)
            //{
            //    Console.Write($"birden fazla eklenen filmler: {duplicatedMovie}\n");
            //}
            //Console.WriteLine(splitingLine);
            //Console.WriteLine($"duplikeleri sildikten sonra {totalMovieCount} adet film kaldi");

            //Console.ReadLine();

            //girilen sayinin asal carpanlarini yazdirma
            //75 - 3 
            //25 - 5
            //5 - 5
            Console.Write("Asal carpanlarina ayrilacak sayiyi gir :");
            int girilenSayi = int.Parse(Console.ReadLine());
            int sayi = (girilenSayi / 2) + 2;//2 ve 3 degerleri girilirse..
            //int kareKok = (int)Math.Sqrt(girilenSayi);
            Dictionary<int, int> asalCarpanlar = new Dictionary<int, int>();
            for (int i = 2; i <= sayi; i++)
            {
                int carpanAdedi = 0;
                while (girilenSayi % i == 0)
                {
                    carpanAdedi++;
                    if (asalCarpanlar.ContainsKey(i))
                    {
                        asalCarpanlar[i] = carpanAdedi;
                    }
                    else
                    {
                        asalCarpanlar.Add(i, carpanAdedi);
                    }
                    girilenSayi = girilenSayi / i;
                }
            }
            foreach (var asalCarpan in asalCarpanlar)
            {
                Console.WriteLine(asalCarpan);
            }
            Console.ReadLine();
        }

        //private static int MaxSayi(int[]sayilar)
        //{
        //    int enBuyukEleman = 0;
        //     //en buyuk elemanı bul
        //    for (int i = 0; i < sayilar.Length; i++)
        //    {
        //        if (sayilar[i] > enBuyukEleman)
        //        {
        //            enBuyukEleman = sayilar[i];
        //        }
        //    }
        //    Console.WriteLine(enBuyukEleman);
        //    return enBuyukEleman;

        //}
    }
}

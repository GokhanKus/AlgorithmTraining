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
            //int[] unSorted = { 1, 5, 0, 6, 22, 7, 4, 73 };
            ////int[] unSorted = { 5, 1, 6, 0, 73, 22, 7, 4 };
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

            #endregion

            #region 1'den 25'e kadar olan sayilari rastgele yazdir

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
            #endregion

            #region Film listesindeki duplikeleri discard etme

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
            #endregion

            #region girilen sayinin asal carpanlarini yazdirma

            //girilen sayinin asal carpanlarini yazdirma
            //Console.Write("Asal carpanlarina ayrilacak sayiyi gir :");
            //int girilenSayi = int.Parse(Console.ReadLine());
            //int sayi = (girilenSayi / 2) + 1;//2 ve 3 degerleri girilirse..
            //bool asalmi = true;
            //Dictionary<int, int> asalCarpanlar = new Dictionary<int, int>();
            //for (int i = 2; i < sayi; i++)
            //{
            //    int carpanAdedi = 0;
            //    while (girilenSayi % i == 0)
            //    {
            //        carpanAdedi++;
            //        if (asalCarpanlar.ContainsKey(i))
            //        {
            //            asalCarpanlar[i] = carpanAdedi;
            //        }
            //        else
            //        {
            //            asalCarpanlar.Add(i, carpanAdedi);
            //        }
            //        girilenSayi = girilenSayi / i;

            //        asalmi = false; //eger while dongusune girdiyse asal degildir
            //    }
            //}
            //if (asalmi)
            //{
            //    asalCarpanlar.Add(girilenSayi, 1);
            //    Console.WriteLine($"{girilenSayi} bir asal sayidir.");
            //}
            //int bolenSayilarToplami = 1;
            //foreach (var asalCarpan in asalCarpanlar)
            //{
            //    bolenSayilarToplami *= asalCarpan.Value + 1;
            //    Console.WriteLine($"asal carpanlar: {asalCarpan}");
            //}
            //Console.WriteLine($"sayinin toplam {bolenSayilarToplami} adet boleni vardır");
            //Console.ReadLine();
            #endregion

            #region Ardisik Sayilar Toplami

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

            //Console.WriteLine("kaç satır görmek istiyorsunuz:");

            //int row = Convert.ToInt32(Console.ReadLine());

            //int countInRow = 0;
            //for (int i = 1; i < row + 1; i++)
            //{
            //    int firstTerm = i * i;
            //    countInRow = ((i - 1) * 2) + 3;
            //    for (int j = 0; j < countInRow; j++)
            //    {
            //        if (j == i * 2) //rowdaki son terimi ifade eder
            //        {
            //            Console.Write(firstTerm);
            //        }
            //        else if (j == i)
            //        {
            //            Console.Write($"{firstTerm} = ");
            //        }
            //        else
            //        {
            //            Console.Write($"{firstTerm} + ");
            //        }
            //        firstTerm++;
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Blackjack

            //string response = string.Empty;

            //int jack = 10;
            //int queen = 10;
            //int king = 10;
            //int ace = 11;

            //int[] sayilar = { 2, 3, 4, 5, 6, 7, 8, 9, 10, jack, queen, king, ace };
            //Random rnd = new Random();

            //int elimdekilerToplami = 0;
            //int gelenSayi = 0;
            //int bilgisayarinEli = 0;
            //string bilgisayarinKartlari = "";
            //do
            //{
            //    for (int i = 0; i < 4; i++)
            //    {
            //        if (i < 2)
            //        {
            //            gelenSayi = rnd.Next(0, sayilar.Length);
            //            elimdekilerToplami += sayilar[gelenSayi];
            //            Console.WriteLine($"Kartlarim: {sayilar[gelenSayi]}");
            //        }
            //        else
            //        {
            //            while (bilgisayarinEli <= 11)
            //            {
            //                gelenSayi = rnd.Next(0, sayilar.Length);
            //                bilgisayarinKartlari += gelenSayi + ", ";
            //                bilgisayarinEli += sayilar[gelenSayi];
            //            }
            //        }
            //    }

            //    Console.WriteLine("Kart cek: Y\nsonucu gor: any tus");
            //    Console.WriteLine(new string('-',60));
            //    response = Console.ReadLine();
            //    do
            //    {
            //        if (response == "y".ToLower() || response == "Y".ToLower())
            //        {
            //            gelenSayi = rnd.Next(0, sayilar.Length);
            //            Console.WriteLine("cektigin kart: " + sayilar[gelenSayi]);
            //            elimdekilerToplami += sayilar[gelenSayi];
            //            if (elimdekilerToplami > 21)
            //            {
            //                Console.WriteLine("elindekilerin toplami: " + elimdekilerToplami + " GAMEOVER");
            //                break;
            //            }
            //            else
            //            {
            //                Console.WriteLine("elindekiler toplami: " + elimdekilerToplami);
            //                Console.WriteLine("bir kart daha cekmek ister misin? E/H");
            //                response = Console.ReadLine();
            //            }
            //        }
            //        else
            //        {
            //            if (bilgisayarinEli >= elimdekilerToplami)
            //            {
            //                Console.WriteLine($"Bilgisayarin Kartlari: {bilgisayarinKartlari}"); //burasi duzgun calismiyor sonra bak.
            //                Console.WriteLine($"Bilgisayarin eli: {bilgisayarinEli} >= {elimdekilerToplami} GAMEOVER");
            //                break;
            //            }
            //            else
            //            {
            //                Console.WriteLine($"elimdekiler toplami: {elimdekilerToplami} > bilgisayarin eli{bilgisayarinEli} KAZANDIM");
            //                break;
            //            }
            //        }
            //    } while (response != "n");

            //    Console.WriteLine("1 el daha oynamak ister misin? E/H");
            //    Console.WriteLine(new string('-',60));

            //    response = Console.ReadLine();

            //    elimdekilerToplami = 0;
            //    bilgisayarinEli = 0;

            //} while (response != "H".ToLower());
            #endregion

            #region Fibonacci
            //fibonacci 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89 ...
            //int firstOne = 1;
            //int secondOne = 1;
            //List<int> fiboList = new List<int>();
            //for (int i = 1; i < 20; i++)
            //{
            //    //Console.Write($"{firstOne}, {secondOne}, ");
            //    fiboList.Add(firstOne);
            //    fiboList.Add(secondOne);
            //    firstOne = secondOne + firstOne;
            //    secondOne = firstOne + secondOne;
            //}

            //foreach (var fiboTerm in fiboList)
            //{
            //    Console.WriteLine(fiboTerm);
            //}
            #endregion

            #region 30 basamaklı 2 sayiyi toplama

            //long q = 9223372036854775807; long 8 byte'dır yani 64 bit ve alabilecegi max deger 2^64 -1 dir = 9223372036854775807 (19 basamaklı)
            //int w = 2147483647;            int 4 byte'dır yani 32 bit ve alabilecegi max deger 2^32 -1 dir = 2147483647          (10 basamaklı)
            //biz bu 2 sayiyi veya daha büyük sayilari toplayamayiz ama string turunde yazarak toplayabiliriz;
            //string sayi1 = "956715610000351152015313331835";
            //string sayi2 = "654355561221313501333815129954";
            //Console.WriteLine(sayi1);
            //Console.WriteLine(sayi2);
            //Console.WriteLine("+");
            //Console.WriteLine(new string('-', 60));
            //string sonuc = "";
            //int sayi1BasamakSayisi = sayi1.Length;
            //int sayi2BasamakSayisi = sayi2.Length;
            //int maxLength = Math.Max(sayi1BasamakSayisi,sayi2BasamakSayisi);
            //int artan = 0;//ornegin 6 + 7 = 13 bu kisimda 3 degeri tutulur.
            //bool eldeVarmi = false; //elde varsa bir sonraki basamak degerini bir artiracagiz.


            ////toplama islemine baslamadan once basamak degerlerini esitleyelim
            //if (sayi1BasamakSayisi > sayi2BasamakSayisi)
            //    while (sayi1.Length != sayi2.Length) //basamaklar eşit degilse eşit olana kadar sayilarin basina "0" ekleyelim
            //        sayi2 = $"0{sayi2}";

            //else
            //    while (sayi1.Length != sayi2.Length) //basamaklar eşit degilse eşit olana kadar sayilarin basina "0" ekleyelim
            //        sayi1 = $"0{sayi1}";


            //for (int i = maxLength - 1; i >= 0; i--)
            //{
            //    int toplam = 0;
            //    if (eldeVarmi == true)
            //    {
            //        toplam = int.Parse(sayi1[i].ToString()) + int.Parse(sayi2[i].ToString()) + 1;
            //    }
            //    else
            //    {
            //        toplam = int.Parse(sayi1[i].ToString()) + int.Parse(sayi2[i].ToString());
            //    }
            //    if (toplam < 10)
            //    {
            //        sonuc += toplam;
            //        eldeVarmi = false;
            //    }
            //    else
            //    {
            //        artan = toplam % 10;
            //        sonuc += artan;
            //        eldeVarmi = true;
            //    }
            //    if (i == 0 && eldeVarmi)
            //    {
            //        sonuc += 1;
            //    }
            //}
            //string tersCevir = new string(sonuc.Reverse().ToArray());
            //Console.WriteLine(tersCevir);

            //    Console.ReadLine();

            #endregion

            /*Her asal icin pisagor uclusu vardır (2 hariç)
            x^2 = (y) + (y+1) burada y+1 hipotenus olsun
            x asali icin x^2 = (y) + (y+1) olur veya 
            kisacasi x asalinin karesi, ardisik 2 sayinin toplamidir
            */

            /* algoritmasi;
               1 - 100e kadar olan sayilari döngüyle kontrol et
               2 - asal olanları tut ve yazdır
            */
            bool asalmi = false;
            List<int> asalKisaKenarlar = new List<int>();
            List<int> ikinciKenarlar = new List<int>();
            List<int> HipotenusKenarlar = new List<int>();

            //burada 100'e kadar olan asal kisakenarlari bulduk ve listeye atadik.
            for (int kisaKenar = 3; kisaKenar < 100; kisaKenar += 2)
            {
                for (int kareKok = (int)Math.Sqrt(kisaKenar) + 1; kareKok >= 2; kareKok--)
                {
                    if (kisaKenar % kareKok == 0)
                    {
                        asalmi = false;
                        break;
                    }
                    else
                    {
                        asalmi = true;
                    }
                }
                if (asalmi)
                {
                    asalKisaKenarlar.Add(kisaKenar);
                }
            }
            //asalKisaKenarlar.ForEach(k => { Console.WriteLine(k); });

            //ikinci ve hipotenüs kenarlarını listeye atayalım
            for (int i = 0; i < asalKisaKenarlar.Count; i++)
            {
                ikinciKenarlar.Add((int)(Math.Pow(asalKisaKenarlar[i], 2)) / 2);
                HipotenusKenarlar.Add(ikinciKenarlar[i]);
                Console.WriteLine($"{asalKisaKenarlar[i]} - {ikinciKenarlar[i]} - {++HipotenusKenarlar[i]}");
            }

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü

            //int i;
            //for (i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //}

            //for (i = 1; i<=20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (i = 3; i < 50; i+=3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("Lütfen ekrana yazılmasını istediğiniz adedi giriniz: ");
            //int finishValue = int.Parse(Console.ReadLine());
            //int x = 0;
            //for (x = 1; x <= finishValue; x++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");
            //}

            #endregion

            #region For Döngüsü ile Karar Yapıları

            //int j = 1;
            //for (j = 1; j <= 100; j++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}

            //int totalValue = 0;
            //for (int l = 1; l <= 10 ; l++)
            //{
            //    totalValue += i;
            //}
            //Console.WriteLine(totalValue);

            //int totalValue2 = 0;
            //int m = 0;
            //for (m = 1; m < 20; m++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine(totalValue2);

            //int count = 0;
            //int n = 0;
            //for (n = 1; n <= 60; n++)
            //{
            //    if(i % 7 == 0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);

            //// 1-2-4-8-16-..
            //int bacterim = 1;
            //int a = 0;
            //for (a = 1; a <= 24; a++)
            //{
            //    bacterim *= 2;
            //    Console.WriteLine(i + ".Saat Sonunda: " + bacterim);
            //}

            #endregion

            #region While Döngüsü

            //int b = 0;
            //while (b <= 10)
            //{
            //    Console.WriteLine("Merhaba Döngüler!");
            //    b++;
            //}

            //int k = 1;
            //while (k <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            #endregion

            #region Örnek Sınav Sorusu 
            // Klavyeden girilen 3 basamaklı sayının basamakları toplamını hesaplayan program

            Console.WriteLine("Sayıyı giriniz: ");
            int number = int.Parse(Console.ReadLine());

            int ones, tens, hundreds;
            int sum;

            ones = number % 10;
            tens = (number % 100) / 10;
            hundreds = number / 100;

            Console.WriteLine(ones + " - " + tens + " - " + hundreds);

            sum = ones + tens + hundreds;
            Console.WriteLine(sum);

            #endregion

            Console.Read();
        }
    }
}

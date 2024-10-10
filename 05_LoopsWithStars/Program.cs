using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Alt Alta 10 Tane Yıldız Oluşturma

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("*");
            }

            #endregion

            Console.WriteLine();

            #region Yan Yana 10 Tane Yıldız Oluşturma

            for (int i = 0; i <= 10; i++)
            {
                Console.Write("*");
            }

            #endregion

            Console.WriteLine();

            #region Alt Alta 10 Tane Yıldız Oluşturma ve Her Satırda 10 Tane Yıldız Olsun

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("**********");
            }

            #endregion

            Console.WriteLine();

            #region Yıldızlarla Dik Üçgen Oluşturma

            for(int k = 1; k <= 5; k++)
            {
                for (int l = 1; l <= k ; l++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            #endregion

            Console.WriteLine();

            #region Yıldızlarla Ters Dik Üçgen Oluşturma

            //for (int m = 5; m >= 1; m--)
            //{
            //    for (int n = 1; n <= m; n++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            Console.WriteLine();

            #region Elmas

            //for (int k = 1; k <= 5; k++)
            //{
            //    for (int l = 1; l <= k; l++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for (int m = 5; m >= 1; m--)
            //{
            //    for (int n = 1; n <= m; n++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            Console.WriteLine();

            #region Baklava Dilimi

            //üst kısım
            //int n = 5;
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = n - 1; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine();
            //}

            ////alt kısım

            //for (int i = n - 1; i >= 1; i--)
            //{
            //    for (int j = n - 1; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            Console.WriteLine();

            #region Piramit

            //int n = 5;
            //for (int i = 1; i <= n; i++)
            //{
            //    //boşluklar
            //    for (int j = n - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    //yıldızlar
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            Console.WriteLine();

            #region Ters Piramit

            int n = 5;
            for (int i = n; i >= 1; i--)
            {
                //boşluklar
                for (int j = n - i; j > 0; j--)
                {
                    Console.Write(" ");
                }

                //yıldızlar
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            #endregion

            Console.Read();
        }
    }
}

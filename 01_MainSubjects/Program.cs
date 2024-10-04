using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma Komutları
            Console.Write("Merhaba Dünya");
            Console.WriteLine("Selam"); // WriteLine bir alt satıra yazar.

            Console.WriteLine("***** Yemek Kategorileri *****");
            Console.WriteLine("");
            Console.WriteLine("1-Çorbalar");
            Console.WriteLine("2-Ana Yemekler");
            Console.WriteLine("3-Soğuk Başlangıçlar");
            Console.WriteLine("4-Salatalar");
            Console.WriteLine("5-Tatlılar");
            Console.WriteLine("6-İçecekler");
            Console.WriteLine("");
            Console.WriteLine("***** Yemek Kategorileri *****");

            Console.WriteLine();
            Console.WriteLine();

            #endregion

            #region String Değişkenler
            // Değişken isimlendirmesi camelCase olarak adlandırılır.
            string customerName;
            string customerSurname;
            string customerPhone;
            string customerEmail, customerDistrict, customerCity;

            customerName = "Ahmet";
            customerSurname = "Ay";
            customerPhone = "+90 555 555 55 55";
            customerEmail = "deneme@gmail.com";
            customerDistrict = "Bandırma";
            customerCity = "Balıkesir";

            Console.WriteLine("**** Rezervasyon Kartı ****");
            Console.WriteLine("");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            Console.WriteLine("İletişim: " + customerPhone);
            Console.WriteLine("Email Adresi: " + customerEmail);
            Console.WriteLine("Adres: " + customerDistrict + "/" + customerCity);
            Console.WriteLine("--------------------------------");

            customerName = "Berkant";
            customerSurname = "Karaca";
            customerPhone = "+90 444 444 44 44";
            customerEmail = "test@gmail.com";
            customerDistrict = "Başakşehir";
            customerCity = "İstanbul";

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            Console.WriteLine("İletişim: " + customerPhone);
            Console.WriteLine("Email Adresi: " + customerEmail);
            Console.WriteLine("Adres: " + customerDistrict + "/" + customerCity);
            Console.WriteLine("--------------------------------");

            Console.WriteLine();
            Console.WriteLine();

            #endregion

            #region Int Değişkenler

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonatePrice = 30;

            Console.WriteLine("***** Restorant Menü Fiyatı *****");
            Console.WriteLine();
            Console.WriteLine("---------------------------------");
            Console.WriteLine("----- Hamburger: " + hamburgerPrice + " Tl");
            Console.WriteLine("----- Pizza: " + pizzaPrice + " Tl");
            Console.WriteLine("----- Kızartmalar: " + friesPrice + " Tl");
            Console.WriteLine("----- Kola: " + cokePrice + " Tl");
            Console.WriteLine("----- Limonata: " + lemonatePrice + " Tl");
            Console.WriteLine("----- Su: " + waterPrice + " Tl");
            Console.WriteLine(); 
            Console.WriteLine("***** Restorant Menü Fiyatı *****");
            Console.WriteLine();

            int hamburgerCount;
            int cokeCount;
            int lemonateCount;
            int waterCount; 
            int friesCount;
            int pizzaCount;

            int totalHamburgerPrice;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalLemonatePrice;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonateCount = 0; 

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalLemonatePrice = lemonateCount * lemonatePrice;
            totalWaterPrice = waterPrice * waterCount;

            Console.WriteLine("---------------------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + " Tl");
            Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + " Tl");
            Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice + " Tl");
            Console.WriteLine("Kola Tutarı: " + totalCokePrice + " Tl");
            Console.WriteLine("Limonata Tutarı: " + totalLemonatePrice + " Tl");
            Console.WriteLine("Su Tutarı: " + totalWaterPrice + " Tl");
            Console.WriteLine("---------------------------------");

            int totalPrice;
            totalPrice = totalHamburgerPrice + totalPizzaPrice + totalFriesPrice + totalCokePrice + totalLemonatePrice + totalWaterPrice;

            Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + " Tl");

            Console.WriteLine();
            Console.WriteLine();

            #endregion

            Console.Read(); // Açılan konsolun enter tuşuna basana kadar açık kalmasını sağlar.
        }
    }
}

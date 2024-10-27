using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar

            //()
            //Geriye Değer Döndürmeyen Metotlar
            //Customer--> Listele, Ekle, Sil, Güncelle
            //Void

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali");
            //    Console.WriteLine("Ayşe");
            //    Console.WriteLine("Mehmet");
            //    Console.WriteLine("Sultan");
            //}

            //CustomerList();
            //CustomerList();
            //CustomerList();
            //CustomerList();

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}

            //Sum();

            #endregion

            #region Geriye Değer Döndürmeyen Parametreli Metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethod("Aslan");


            //void CustomerCard(string name, string surname)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surname);
            //}

            //CustomerCard("Ali", "Kemal");
            //CustomerCard("Aslı", "Kuru");

            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            //void Sum(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}

            //Sum(34, 35, 36);

            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}

            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Akkaya";

            //    return name + " " + surname;
            //}

            //Console.WriteLine(StudentCard());

            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke: " + countryName + " - Başkent: " + capital + " - Bayrak Rengi: " + flagColor;

            //    return cardInfo;
            //}

            //string x, y, z;
            //Console.Write("Ülke Adını Giriniz: ");
            //x = Console.ReadLine();

            //Console.Write("Başkenti Giriniz: ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak Rengini Giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));

            //Console.WriteLine(CountryCard("Türkiye", "Ankara", "Kırmızı-Beyaz"));


            #endregion

            #region Geriye Değer Dödüren Int Parametreli Metorlar

            //int Sum(int number1, int number2)
            //{
            //    int result = number1+number2;

            //    return result;
            //}

            //Console.WriteLine(Sum(45,76));
            //Console.WriteLine(Sum(87,12));
            //Console.WriteLine(Sum(13,9));


            #endregion

            #region Örnek Uygulama

            //string examresult(string student, int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;

            //    if (result >= 50)
            //    {
            //        return student + " isimli öğrenci sınavı geçti. " + "ortalama: " + result;
            //    }
            //    else
            //    {
            //        return student + " isimli öğrenci sınavdan kaldı. " + "ortalama: " + result;
            //    }
            //}

            //Console.WriteLine(examresult("ali", 25, 41, 55));
            //Console.WriteLine(examresult("ahmet", 65, 76, 98));

            #endregion

            Console.Read();
        }
    }
}

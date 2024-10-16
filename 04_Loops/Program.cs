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

            //For(x;y;z)
            // x: başlangıç
            // y: bitiş
            // z: artış-azalış

            //int i;

            //for (i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //}

            //for (int i = 1; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 3; i < 50; i+=3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("Lütfen ekrana yazılmasını istediğiniz adedi giriniz: ");
            //int finishValue = int.Parse(Console.ReadLine());

            //for (int i = 1; i < finishValue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");
            //}

            #endregion

            #region For Döngüsü ile Karar Yapıları

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //} 

            //Console.Write("Deney süresini giriniz: ");
            //int time = int.Parse(Console.ReadLine());

            //int x = 1;

            //for (int i = 1; i <= time; i++)
            //{
            //    x *= 2;

            //    Console.WriteLine(i + ". saniye = " + x + " tane bakteri");
            //}

            //Console.WriteLine("-------------------------------");
            //Console.WriteLine("Toplam Bakteri Sayısı: " + x);

            #endregion

            #region While Döngüsü

            //While(Şart)
            //{
            //işlemler
            //}

            //int i = 1;

            //while (i <= 10)
            //{
            //    Console.WriteLine("Merhaba Döngüler");
            //    i++;
            //}

            //int i = 1;

            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //int i = 1;
            //int sum = 0;

            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;
            //}

            //Console.WriteLine(sum);

            #endregion

            #region Örnek Sınav Sorusu

            //Klavyeden girilen 3 basamaklı sayının basamakları toplamını hesaplayan kodu yazınız.

            //Console.Write("3 Basamaklı sayıyı giriniz: ");
            //int sayi = int.Parse(Console.ReadLine());
            //int basamakDegeri;
            //int basamakToplami = 0; 

            //while (sayi <= 0)
            //{
            //    basamakDegeri = sayi % 10;

            //    basamakToplami = basamakToplami + basamakDegeri;

            //    sayi = sayi - basamakDegeri;

            //    sayi = sayi / 10;

            //    Console.WriteLine(basamakToplami);
            //}



            #endregion

            Console.ReadLine();
        }
    }
}

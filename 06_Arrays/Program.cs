using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri

            //2,4,6
            //kırmız, sarı, mavi
            //DeğişkenTürü [] DiziAdı = new DeğişkenTürü[ElemanSayısı]

            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Mavi";
            //colors[3] = "Turuncu";

            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];
            //cities[0] = "Kars";
            //cities[1] = "Ardahan";
            //cities[2] = "Iğdır";
            //cities[3] = "İstanbul";
            //cities[4] = "Ankara";

            //Console.WriteLine(cities[5]);

            //int[] numbers = new int[10];
            //numbers[0] = 2;
            //numbers[8] = 3;
            //numbers[6] = 4;
            //numbers[5] = 5;
            //Console.WriteLine(numbers[3]);

            //string[] cities = {"Ankara", "İstanbul", "Kocaeli", "Elazığ" };

            //Console.WriteLine(cities[3]);

            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            //string[] colors = {"Sarı", "Kırmız", "Mavi", "Pembe", "Turuncu", "Siyah", "Yeşil", "Mor", "Lacivert" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 23, 24, 99, 565, 754, 34, 23, 7, 89, 546, 324, 13, 765, 976, 45, 76, 26, 37 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbols = { 'a', 'b', 'c', '/', '*', '<', '-' };
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //Dizideki en büyük elemanı bulma

            //int[] numbers = { 23, 24, 99, 565, 754, 34, 23, 7, 89, 546, 324, 13, 765, 976, 45, 76, 26, 37 };

            //int maxNumber = numbers[0];

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] > maxNumber)
            //    {
            //        maxNumber = numbers[i];
            //    }
            //}

            //Console.WriteLine("En Büyük Eleman: " + maxNumber);

            //string[] persons = { "Ali", "Ayşe", "Ahmet", "Buse", "Cem", "Deniz" };

            //Console.WriteLine(persons.Length);         

            #endregion

            #region Dizi Metotları

            //int[] numbers = { 23, 24, 99, 565, 754, 34, 23, 7, 89, 546, 324, 13, 765, 976, 45, 76, 26, 37 };

            //Array.Sort(numbers);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 23, 24, 99, 565, 754, 34, 23, 7, 89, 546, 324, 13, 765, 976, 45, 76, 26, 37 };

            //Array.Reverse(numbers);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //string[] customers = { "Ali", "Buse", "Ahmet", "Veli", "Orhan", "Osman", "Murat", "Mehmet", "Süleyman" };

            //int index = Array.IndexOf(customers, "Mehmet");
            //Console.WriteLine(index);

            //int[] numbers = { 23, 24, 99, 565, 754, 34, 23, 7, 89, 546, 324, 13, 765, 976, 45, 76, 26, 37 };

            //Console.WriteLine("Dizinin En Büyük Elemanı: " + numbers.Max() + " Dizinin En Küçük Elemanı: " + numbers.Min() );

            #endregion

            #region Kullanıcıdan Değer Alma

            //int[] numbers = new int[4];

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write($"Dizinin {i + 1}. Değerini Giriniz: ");
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine();

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write(numbers[i]);
            //    Console.Write(", ");
            //}

            //int[] numbers = { 1, 2, 3, 4, 5, 6 };

            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}

            //Console.WriteLine(sum);

            //int[] numbers = { 23, 24, 99, 565, 754, 34, 23, 7, 89, 546, 324, 13, 765, 976, 45, 76, 26, 37 };

            //Console.WriteLine("Çift Sayılar");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //Console.WriteLine("----------------------------");

            //Console.WriteLine("Tek Sayılar");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i]%2==1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }

            //}

            #endregion

            Console.ReadLine();
        }
    }
}

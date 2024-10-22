using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //Foreach(1;2;3;4)

            //1: Değişken Türü
            //2: Değişken Adı
            //3: In
            //4: Liste, Koleksiyoni Dizi

            //string[] cities = { "Milano", "Roma", "Budapeşte", "Ankara", "İstanbul", "Varşova" };

            //foreach (string x in cities)
            //{
            //    Console.WriteLine(x);
            //}

            //int[] numbers = { 23, 654, 76, 43, 9786, 43, 23, 76, 34, 223, 1, 3, 98, 564, 133 };

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}


            //int[] numbers = { 23, 654, 76, 43, 9786, 43, 23, 76, 34, 223, 1, 3, 98, 564, 133 };

            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //int[] numbers = { 23, 654, 76, 43, 9786, 43, 23, 76, 34, 223, 1, 3, 98, 564, 133 };

            //int total = 0;

            //foreach (int number in numbers)
            //{
            //    total += number;
            //}

            //Console.WriteLine(total);

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24
            //};

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number); 
            //}

            //string word = "HelloWorld";

            //foreach (char c in word) 
            //{
            //    Console.WriteLine(c);
            //}

            #endregion

            #region Örnek Sınav Sistemi 

            Console.WriteLine("----- Öğrenci Sınav Sistemi -----");
            Console.WriteLine();
            Console.Write("Öğrenci Sayısını Giriniz: ");
            int ogrenciSayi = int.Parse(Console.ReadLine());
            Console.WriteLine();

            string name;

            int vize, final;

            string[] studentNames = new string[ogrenciSayi];

            double[] ortalamaPuan = new double[ogrenciSayi];

            for (int i = 0; i < ogrenciSayi; i++)
            {
                Console.Write($"{i + 1}. Öğrencinin Adını Giriniz: ");
                name = Console.ReadLine();
                studentNames[i] = name;

                Console.Write(" Vize Notu: ");
                vize = int.Parse(Console.ReadLine());
                
                Console.Write(" Final Notu: ");
                final = int.Parse(Console.ReadLine());
                
                ortalamaPuan[i] = (vize * 0.4) + (final * 0.6);

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("--- Not Ortalamaları ---");
            Console.WriteLine();

            for (int j = 0; j < ogrenciSayi; j++)
            {
                if (ortalamaPuan[j] >= 50)
                {
                    Console.WriteLine($"{j + 1}. {studentNames[j]} Adlı Öğrencinin Not Ortalaması: {ortalamaPuan[j]} => Dersten Geçti");
                }
                else
                {
                    Console.WriteLine($"{j + 1}. {studentNames[j]} Adlı Öğrencinin Not Ortalaması: {ortalamaPuan[j]} => Dersten Kaldı");
                }
            }

            #endregion

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ado.net


            string tableNumber;

            Console.WriteLine("****** C# Veri Tabanlı Ürün-Kategori Bilgi Sistemi");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("1- Kategoriler");
            Console.WriteLine("2- Ürünler");
            Console.WriteLine("3- Siparişler");
            Console.WriteLine("4- Çıkış Yap");
            Console.WriteLine("----------------------------------------------");
            Console.Write("Lütfen getirmek istediğiniz tablo numarasını giriniz: ");
            tableNumber = Console.ReadLine();
            Console.WriteLine("----------------------------------------------");

            SqlConnection connection = new SqlConnection("Data Source=-BERKAYPC-\\SQLEXPRESS;initial Catalog=EgitimKampiDb; integrated security=true");

            switch (tableNumber)
            {
                case "1":

                    connection.Open();
                    SqlCommand command1 = new SqlCommand("Select * From TblCategory", connection);
                    SqlDataAdapter adapter1 = new SqlDataAdapter(command1);
                    DataTable dataTable1 = new DataTable();
                    adapter1.Fill(dataTable1);
                    connection.Close();

                    foreach (DataRow row in dataTable1.Rows)
                    {
                        foreach (var item in row.ItemArray)
                        {
                            Console.Write(item.ToString());
                        }
                        Console.WriteLine();
                    }

                    break;

                case "2":

                    connection.Open();
                    SqlCommand command2 = new SqlCommand("Select * From TblProduct", connection);
                    SqlDataAdapter adapter2 = new SqlDataAdapter(command2);
                    DataTable dataTable2 = new DataTable();
                    adapter2.Fill(dataTable2);
                    connection.Close();

                    foreach (DataRow row in dataTable2.Rows)
                    {
                        foreach (var item in row.ItemArray)
                        {
                            Console.Write(item.ToString());
                        }
                        Console.WriteLine();
                    }

                    break;

                case "3":

                    connection.Open();
                    SqlCommand command3 = new SqlCommand("Select * From TblOrder", connection);
                    SqlDataAdapter adapter3 = new SqlDataAdapter(command3);
                    DataTable dataTable3 = new DataTable();
                    adapter3.Fill(dataTable3);
                    connection.Close();

                    foreach (DataRow row in dataTable3.Rows)
                    {
                        foreach (var item in row.ItemArray)
                        {
                            Console.Write(item.ToString());
                        }
                        Console.WriteLine();
                    }

                    break;

                case "4":

                    break;
            }

            Console.Read();
        }
    }
}

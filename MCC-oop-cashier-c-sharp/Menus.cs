using System;
using System.Collections.Generic;
using System.Text;

namespace MCC_oop_cashier_c_sharp
{
    class Menus : Table
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public Menus()
        {

        }
        public Menus(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public static void PrintMenu(List<Menus> food)
        {
            Console.WriteLine("APLIKASI CASHIER SEDERHANA");
            Console.WriteLine("==========================");
            Console.WriteLine("DAFTAR MENU");
            Table table = new Table("No.", "Nama Menu", "Price");
            
            for (int i = 0; i < food.Count; i++)
            {
                //Console.Write(i + 1 + ". ");
                //Console.WriteLine($"{food[i].Name} = {food[i].Price}");
                int j = i + 1;
                string harga = table.ToRupiah(food[i].Price);
                string s = j.ToString();
                table.PrintRow(s, food[i].Name, harga);
                table.PrintLine();
            }
        }


    }

}

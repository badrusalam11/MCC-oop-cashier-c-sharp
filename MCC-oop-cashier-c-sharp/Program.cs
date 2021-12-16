using System;
using System.Collections.Generic;



namespace MCC_oop_cashier_c_sharp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
                //instantiation 
                int confirm = 1;
                Menus makanan1 = new Menus("Baso", 10000);
                Menus makanan2 = new Menus("Seblak", 20000);
                Menus makanan3 = new Menus("Sate Taichan", 30000);
                Table currency = new Table();
                List<Menus> food = new List<Menus>();
                List<Order> orderList = new List<Order>();
                food.Add(makanan1);
                food.Add(makanan2);
                food.Add(makanan3);
            do
            {
            // Menu
            menu:
                try
                {
                    Menus.PrintMenu(food);
                    Console.Write($"Silahkan Pilih Menu Anda (1-{food.Count}) : ");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Quantity                       : ");
                    int quantity = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("  ");
                    Console.WriteLine($"Anda memesan : {food[choice - 1].Name}");
                    Console.WriteLine($"Harga        : {currency.ToRupiah(food[choice - 1].Price)}");
                    Order orderan = new Order(food[choice - 1].Name, quantity, food[choice - 1].Price);
                    orderList.Add(orderan);
                    orderan.PrintOrder(orderList);
                    int totalPrice = orderan.CalculatePrice(orderList);
                    Console.WriteLine($"HARGA TOTAL  : {currency.ToRupiah(totalPrice)}");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Format Salah! Masukkan angka yang benar!");
                    goto menu;
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine("Pilihan anda salah!");
                    goto menu;
                }
            // Close Confirmation
            choose:
                try
                {
                    Console.WriteLine("  ");
                    Console.WriteLine("Beli lagi ?");
                    Console.WriteLine("1. Ya");
                    Console.WriteLine("2. Tidak");
                    Console.Write("jawab : ");
                    confirm = Convert.ToInt32(Console.ReadLine());
                    if (confirm > 2 || confirm < 1)
                    {
                        Console.WriteLine("Masukkan pilihan yang benar");
                        goto choose;
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Format Salah! Masukkan Format yang benar!");
                    goto choose;
                }
                Console.Clear();
            }
            while (confirm != 2);
            Console.WriteLine("TRANSAKSI SELESAI");
        }
        


    }
}

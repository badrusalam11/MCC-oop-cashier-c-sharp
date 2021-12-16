using System;
using System.Collections.Generic;
using System.Text;

namespace MCC_oop_cashier_c_sharp
{
    class Order : Menus
    {
        public int Quantity {get; set;}
        public Order()
        {

        }
        public Order(string name, int quantity, int price)
        {
            Name = name;
            Quantity = quantity;
            Price = price;
        }
        public void PrintOrder(List<Order> orderList)
        {
            Table table = new Table("No.", "Nama Menu","Quantity", "Price");
            for (int i = 0; i < orderList.Count; i++)
            {
                int j = i + 1;
                string harga = table.ToRupiah(orderList[i].Price);
                int quantity = orderList[i].Quantity;
                string s = j.ToString();
                string q = quantity.ToString();
                table.PrintRow(s, orderList[i].Name, q, harga);
                table.PrintLine();
            }
        }
        public int CalculatePrice(List<Order> orderList)
        {
            int totalPrice = 0;
            foreach (Order ol in orderList)
            {
                totalPrice = totalPrice + ol.Quantity * ol.Price;
                
            }
            return totalPrice;
            //Console.WriteLine($"HARGA TOTAL     : {totalPrice}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.Text.RegularExpressions;

namespace MCC_oop_cashier_c_sharp
{
    public class Table
    {
        public static int tableWidth = 73;
        public string Column1 { get; set; }
        public string Column2{ get; set; }
        public string Column3{ get; set; }
        public string Column4{ get; set; }

        public Table()
        {

        }
        public Table(string column1, string column2, string column3)
        {
            Column1 = column1;
            Column2 = column2;
            Column3 = column3;
            PrintLine();
            PrintRow(Column1, Column2, Column3);
            PrintLine();
            //PrintRow("", "", "", "");
            //PrintRow("", "", "", "");
            //PrintLine();
        }
        public Table(string column1, string column2, string column3, string column4)
        {
            Column1 = column1;
            Column2 = column2;
            Column3 = column3;
            Column4 = column4;
            PrintLine();
            PrintRow(Column1, Column2, Column3, Column4);
            PrintLine();
            //PrintRow("", "", "", "");
            //PrintRow("", "", "", "");
            //PrintLine();
        }
        

        public void PrintLine()
        {
            Console.WriteLine(new string('-', tableWidth));
        }

        public void PrintRow(params string[] columns)
        {
            int width = (tableWidth - columns.Length) / columns.Length;
            string row = "|";

            foreach (string column in columns)
            {
                row += AlignCentre(column, width) + "|";
            }

            Console.WriteLine(row);
        }

        public static string AlignCentre(string text, int width)
        {
            text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;

            if (string.IsNullOrEmpty(text))
            {
                return new string(' ', width);
            }
            else
            {
                return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
            }
        }
        public string ToRupiah(int angka)
        {
            return String.Format(CultureInfo.CreateSpecificCulture("id-id"), "Rp. {0:N}", angka);
        }
    }
}

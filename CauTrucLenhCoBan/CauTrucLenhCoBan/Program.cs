using System;

namespace CauTrucLenhCoBan
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] list = { "Man, Xoai, Chuoi, Tao"};


            foreach(var items in list)
            {
                Console.Write("Hoa qua: " + items);
            }
        }
    }
}

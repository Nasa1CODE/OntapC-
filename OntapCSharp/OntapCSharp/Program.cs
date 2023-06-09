using System;

namespace OntapCSharp
{
    class Program
    {

        static void Print(int[] A)
        {
            int n = A.Length;
            Console.Write("Mang hien tai cua A =[");

            for (int i = 0; i < n; i++)
            {
                Console.Write(A[i]);
                if (i < n - 1)
                {
                    Console.Write(",");
                }
            }

            Console.Write("]");

        }
        static void Main(string[] args)
        {
            int[] A = { 1, 3, 6, 8, 4, 3, 8, 6, 8, 4, 6 };
            Print(A);
            Console.WriteLine("");
            Console.WriteLine("Mang sau khi dc dao nguoc la:");
            Array.Reverse(A);
            Print(A);

            Console.WriteLine("");
            Console.WriteLine("Mang sau khi dc sap xep la:");
            Array.Sort(A);
            Print(A);
            Console.WriteLine("");

            int x = 3;
            int i = Array.LastIndexOf(A, x);// tra ra chi so phan tu cuoi cung tim dc trong mang
            if(i > -1)
            {
                Console.WriteLine("Tim thay phan tu co gia tri {0} tai vi tri {1}", x, i);
               
            }
            else
            {
                Console.WriteLine("Khong tim thay phan tu {0} trong mang A", x);
            }
        }
    }
}

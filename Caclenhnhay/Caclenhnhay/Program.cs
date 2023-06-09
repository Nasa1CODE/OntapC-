using System;

namespace Caclenhnhay
{

    class Program
    {
        static int Add(int a, int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
           
            //break vs continue
            for(int i = 0; i<= 10; i++)
            {
                if( i > 3)
                {
                    break;
                }
                Console.WriteLine("A["+i+"]=" + i);
            }

            Console.WriteLine("");
            for (int i = 0; i <= 10; i++)
            {
                if (i == 3)
                {
                    continue;
                }
                Console.WriteLine("A[" + i + "]=" + i);
            }


            //a+b
            Console.Write("Tong hai so 3 + 7 = " + Add(3,7));
        }
    }

}

using System;

namespace ClassObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 c1 = new Class1();
            Class1 c2 = new Class1(1, "Mô tả");
            c1.Print("1");
            c1.Sub(5, 7);

            //c1.Display();

            //Class1.Name;
            Class1.Display();

            int a = 0;
            int.TryParse("5", out a);

        }
    }

    public class Class1
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public  string Desc { get; set; }
        public string PP1 { get; set; }


        public Class1()
        {

        }

        public Class1(int id, string desc)
        {
            this.Id = id;
            this.Desc = desc;
        }

        public Class1(int id, string desc, string pp1) : this(id,desc)
        {
            PP1 = pp1;
        }

        public static void Display()
        {

        }

        public void Print(string s)
        {
            Console.WriteLine(s);
        }

        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public void Sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        public double Div(int a, int b)
        {
            double c = a / b;
            return c;
        }
    }
}

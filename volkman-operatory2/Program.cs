using System;

namespace volkman_operatory2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            string uvitani = "Vítejte";
            bool srovnani = a > b;
            bool rovnost = a == b;
            int soucet = a + b;
            int soucin = a * b;
            int rozdil = a - b;
            double x = a;
            double y = b;
            double podil = x / y;

            Console.WriteLine(uvitani);
            Console.WriteLine("srovnani " + srovnani);
            Console.WriteLine("negace rovnosti " + !rovnost);
            Console.WriteLine("soucet " + soucet);
            Console.WriteLine("soucin " + soucin);
            Console.WriteLine("rozdil " + rozdil);
            Console.WriteLine("podil " + podil);
            Console.ReadKey();
        }
    }
}
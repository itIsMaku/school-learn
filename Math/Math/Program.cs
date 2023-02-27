using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math
{
    class Program
    {

        static void Main(string[] args)
        {
            // x^2 + 20x + 3 = 0
            int a = 1;
            int b = 20;
            int c = 3;
            double x1 = System.Math.Round((-b + System.Math.Sqrt(System.Math.Pow(b, 2) - 4 * a * c)) / 2 * a);
            double x2 = System.Math.Round((-b - System.Math.Sqrt(System.Math.Pow(b, 2) - 4 * a * c)) / 2 * a);
            Console.WriteLine("x1 = " + x1);
            Console.WriteLine("x2 = " + x2);

            double r;
            double v;
            try
            {
                Console.WriteLine("Zadej průměr v cm.");
                r = Double.Parse(Console.ReadLine());
                Console.WriteLine("Zadej výšku v cm.");
                v = Double.Parse(Console.ReadLine());
            } catch
            {
                Console.WriteLine("Zadal jsi špatný typ.");
                Console.ReadKey();
                return;
            }
            // π r²
            double result = System.Math.PI * System.Math.Pow(r, 2) * v;
            Console.WriteLine("Objem sudu v litrech: " + result);
            Console.ReadKey();
        }
    }
}

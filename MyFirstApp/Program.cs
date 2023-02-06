using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    class Program
    {
        private static List<string> texts = new List<string>();

        static void Main(string[] args)
        {
            string text = "ja opravdu nevim co mam o te hodine delat, protoze se tu nudim jak kkt";
            string[] splittedText = text.Split(' ');
            texts.AddRange(splittedText);
            Console.Title = "cuspic";
            Console.BackgroundColor = ConsoleColor.Red;
            //Console.SetCursorPosition(Console.WindowWidth / 2, 1);
            for (int i = 0; i < texts.Count; i++)
            {
                Console.WriteLine(texts.ElementAt(i));
            }
            Console.ReadKey();
            
        }
    }
}

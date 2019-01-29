using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_3._7
{
    class Program
    {
        static void Main(string[] args)
        {
            string text, text2;

            Console.WriteLine("Vul in tekst: ");
            text = Convert.ToString(Console.ReadLine());

            text2 = text.Replace("a", "*").Replace("e", "*").Replace("u", "*").Replace("o", "*").Replace("i", "*");

            Console.WriteLine(text2);
            Console.ReadLine();


        }
    }
}

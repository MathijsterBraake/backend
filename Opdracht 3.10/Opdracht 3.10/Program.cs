using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_3._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch timer = new Stopwatch();
            string naam;
            int leeftijd;

            timer.Start();

            Console.WriteLine("Wat is je naam?");
            naam = Console.ReadLine();
            Console.WriteLine("Wat is je leeftijd?");
            leeftijd = Convert.ToInt32(Console.ReadLine());
            timer.Stop();
            var seconden = timer.ElapsedMilliseconds / 1000;
            Console.WriteLine("Je deed er: " + seconden + " seconden over!");
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal1;
            int getal2;
            Console.WriteLine("geef getal1:");
            getal1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("geef getal2:");
            getal2 = Convert.ToInt32(Console.ReadLine());

            if (getal1 > getal2)
            {
                Console.WriteLine("getal 1is het grootste");

            }
            if (getal1 == getal2)
            {
                Console.WriteLine("Getal1 en 2 zijn gelijk");
            }
            if(getal2 > getal1)
            {
                Console.WriteLine("Getal2 is het grootset");
            }

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            double breedte, lengte, prijs, vierkanteMeter;

            Console.WriteLine("Geef breedte camper?");
            breedte = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Geef lengte camper?");
            lengte = Convert.ToDouble(Console.ReadLine());

            vierkanteMeter = breedte * lengte;
            prijs = vierkanteMeter * 1.50 * 12;

            Console.WriteLine("stalling voor 1 jaar: " + prijs);
            Console.WriteLine("stalling voor 2 jaar: " + (prijs - (prijs / 100 * 5)));
            Console.WriteLine("stalling voor 3 jaar: " + (prijs - (prijs / 100 * 10)));

            Console.ReadKey();


        }
    }
}

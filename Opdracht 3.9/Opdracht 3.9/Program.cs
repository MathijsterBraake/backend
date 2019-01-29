using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_3._9
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime datum;
            int dagen, jaar, maand;

            Console.WriteLine("Vul een datum in:");
            datum = Convert.ToDateTime(Console.ReadLine());

            jaar = datum.Year;
            maand = datum.Month;
            dagen = DateTime.DaysInMonth(jaar, maand);

            Console.WriteLine(dagen);
            Console.ReadKey();

        }
    }
}

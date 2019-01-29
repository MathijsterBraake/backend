using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_3._6
{
    class Program
    {
        static void Main(string[] args)
        {

            int studentnummer;
            string naam;
            double NED1, NED2, ENG1, ENG2, WIS1, WIS2, PRG1, PRG2, DBD1, DBD2, ALG1, ALG2, gemiddeldeNED, gemiddeldeENG, gemiddeldeWIS, gemiddeldePRG, gemiddeldeDBD, gemiddeldeALG;

            Console.WriteLine("Studentnummer: ");
            studentnummer = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Wat is je volledige naam: ");
            naam = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Wat is je 1e NED cijfer");
            NED1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Wat is je 2e NED cijfer");
            NED2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Wat is je 1e ENG cijfer");
            ENG1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Wat is je 2e ENG cijfer");
            ENG2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Wat is je 1e WIS cijfer");
            WIS1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Wat is je 2e WIS cijfer");
            WIS2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Wat is je 1e PRG cijfer");
            PRG1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Wat is je 2e PRG cijfer");
            PRG2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Wat is je 1e DBD cijfer");
            DBD1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Wat is je 2e DBD cijfer");
            DBD2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Wat is je 1e ALG cijfer");
            ALG1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Wat is je 2e ALG cijfer");
            ALG2 = Convert.ToDouble(Console.ReadLine());

            gemiddeldeNED = ((NED1 + NED2) / 2);
            gemiddeldeENG = ((ENG1 + ENG2) / 2);
            gemiddeldeWIS = ((WIS1 + WIS2) / 2);
            gemiddeldePRG = ((PRG1 + PRG2 + PRG2) / 3);
            gemiddeldeDBD = ((DBD1 + DBD2 + DBD2) / 3);
            gemiddeldeALG = ((ALG1 + ALG2 + ALG2) / 3);
            Console.Clear();

            Console.WriteLine("studentnummer: " + studentnummer);
            Console.WriteLine("je naam is: " + naam);
            Console.WriteLine("je gemiddelde voor NED is: " + gemiddeldeNED);
            Console.WriteLine("je gemiddelde voor ENG is: " + gemiddeldeENG);
            Console.WriteLine("je gemiddelde voor WIS is: " + gemiddeldeWIS);
            Console.WriteLine("je gemiddelde voor PRG is: " + gemiddeldePRG);
            Console.WriteLine("je gemiddelde voor DBD is: " + gemiddeldeDBD);
            Console.WriteLine("je gemiddelde voor ALG is: " + gemiddeldeALG);

            Console.ReadKey();


        }
    }
}

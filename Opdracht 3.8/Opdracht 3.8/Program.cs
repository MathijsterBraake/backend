using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_3._8
{
    class Program
    {
        static void Main(string[] args)
        {
            string voornaam, achternaam, tussenvoegsel, username;
            int lengteNaam;

            Console.WriteLine("Vul je voornaam in:");
            voornaam = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Vul je tussenvoegsels in: ");
            tussenvoegsel = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Vul je achternaam in:");
            achternaam = Convert.ToString(Console.ReadLine());

            lengteNaam = voornaam.Length + tussenvoegsel.Length + achternaam.Length;
            username = voornaam.ToLower()[0] + achternaam.ToLower() + lengteNaam;

            Console.WriteLine("");
            Console.WriteLine("Uw persoonlijke username is: " + username);
            Console.ReadKey();

        }
    }
}

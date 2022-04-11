using System;
using jogoRpg.Entities;

namespace jogoRpg
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero arus = new Hero("Arus",42, "knight","469 / 749", "72 / 72 ");
            Hero wedge = new Hero("Wedge", 42, "Ninja", "292 / 574", "89 / 89 ");
            Wizard jenica = new Wizard("Jennica", 42, "White Wizard", "325 / 601","474 / 482");
            Wizard topapa = new Wizard("Topapa", 42, "Black Wizard", "106 / 385", "611 / 641");

            Console.WriteLine(arus.ToString());
            Console.WriteLine(arus.Attack());
            Console.WriteLine("\n---------------");
            Console.WriteLine(wedge.ToString());
            Console.WriteLine(wedge.Attack(5));
            Console.WriteLine("\n---------------");
            Console.WriteLine(jenica.ToString());
            Console.WriteLine(jenica.Attack(10));
            Console.WriteLine("\n---------------");
            Console.WriteLine(topapa.ToString());
            Console.WriteLine(topapa.Attack(960));
        }
    }
}

using System;
using static System.Console;
using POO.SRC.Entities;

namespace POO
{

    class Program
    {

        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 20, "Knight", 200, 1000);
            WhiteWizard jenica = new WhiteWizard("Jenica", 20, "White Wizard", 800, 450);
            Ninja wedge = new Ninja("Wedge", 20, "Ninja", 400, 600);
            BlackWizard topapa = new BlackWizard("Topapa", 20, "Black Wizard", 1000, 380);


            WriteLine("Seus heróis:\n");
            WriteLine(arus);
            WriteLine(jenica);
            WriteLine(wedge);
            WriteLine(topapa);

            WriteLine("ATAQUES:\n");
            WriteLine("ATAQUES DO ARUS:");
            WriteLine(arus.Attack(2));
            WriteLine(arus.Attack(6));

            WriteLine("ATAQUES DO JENICA:");
            WriteLine(jenica.Attack(3));
            WriteLine(jenica.Attack(10));

            WriteLine("ATAQUES DO WEDGE:");
            WriteLine(wedge.Attack(1));
            WriteLine(wedge.Attack(7));

            WriteLine("ATAQUES DO TOPAPA:");
            WriteLine(topapa.Attack(3));
            WriteLine(topapa.Attack(8));
        }
    }
}
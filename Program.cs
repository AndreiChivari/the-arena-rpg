using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheArenaRPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Jocul a pornit cu {Caracter.NumarTotalCaractere} jucatori!");

            Caracter erou = new Caracter("Hercule");
            erou.AfiseazaStatut();

            Caracter inamic = new Caracter("Minotaur", 500, 50);
            inamic.AfiseazaStatut();

            Caracter copieInamic = new Caracter(inamic);
            copieInamic.Nume = "Minotaur Jr.";
            copieInamic.AfiseazaStatut();

            Console.WriteLine($"Avem {Caracter.NumarTotalCaractere} jucatori!");

            Console.ReadKey();
        }
    }
}

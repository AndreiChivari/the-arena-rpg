using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheArenaRPG
{
    public class Caracter
    {
        public string Nume { get; set; }
        public int Viata { get; private set; }
        public int Putere { get; set; }

        public static int NumarTotalCaractere;

        static Caracter()
        {
            NumarTotalCaractere = 0;
            Console.WriteLine("[GAME]: Motorul jocului a initializat clasa Caracter");
        }

        //Constructor
        public Caracter(string nume, int viata, int putere)
        {
            Nume = nume;
            Viata = viata;
            Putere = putere;

            NumarTotalCaractere++;
        }

        public Caracter(string nume) : this(nume, 100, 10)
        {
        }

        public Caracter(Caracter original) : this(original.Nume, original.Viata, original.Putere)
        {
            Console.WriteLine($"[CLONARE]: S-a creat o copie a lui {original.Nume}");
        }

        // Metode

        public void AfiseazaStatut()
        {
            Console.WriteLine($"Fisa {Nume}: HP {Viata} | STR {Putere}");
        }

        public void IncaseazaLovitura(int damage)
        {
            if (damage < 0) return;
            Viata -= damage;

            Console.WriteLine($"{Nume} a fost lovit! A pierdut {damage} HP. Viata ramasa: {Viata}");
        
            if(Viata <= 0)
            {
                Viata = 0;
                Console.WriteLine($"{Nume} a lesinat!");
            }
        }
    }
}

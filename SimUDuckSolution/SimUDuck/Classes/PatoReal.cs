using System;
using SimUDuck.Interfaces;

namespace SimUDuck.Classes
{
    public class PatoReal : IPato
    {
        public void Grasnar()
        {
            Console.WriteLine("Pato Real está Grasnando...");
        }

        public void Nadar()
        {
            Console.WriteLine("Pato Real está Nadando...");
        }

        public void Nadar(string nome)
        {
            Console.WriteLine(nome + "Pato Real está Nadando...");
        }

        public void Voar()
        {
            Console.WriteLine("Pato Real está Voando...");
        }
    }
}

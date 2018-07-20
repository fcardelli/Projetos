using System;
using SimUDuck.Classes;
using SimUDuck.Interfaces;

namespace SimUDuck.Classes
{
    public class PatoSelvagem : IPato
    {
        public void Grasnar()
        {
            Console.WriteLine("Pato Selvagem está Grasnando...");
        }

        public void Nadar()
        {
            Console.WriteLine("Pato Selvagem está Nadando...");
        }

        public void Nadar(string nome)
        {
            Console.WriteLine(nome + "Pato Selvagem está Nadando...");
        }

        public void Voar()
        {
            Console.WriteLine("Pato Selvagem está Voando...");
        }
    }
}
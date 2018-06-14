using SimUDuck.Classes;
using SimUDuck.Interfaces;
using System;

namespace SimUDuck.Classes
{
    public class PatoCabecaVermelha : IPato
    {
        public void Grasnar()
        {
            Console.WriteLine("Pato Cabeça Vermelha está Grasnando...");
        }

        public void Nadar()
        {
            Console.WriteLine("Pato Cabeça Vermelha está Nadando...");
        }

        public void Nadar(string nome)
        {
            Console.WriteLine(nome + "Pato Cabeça Vermelha está Nadando...");
        }

        public void Voar()
        {
            Console.WriteLine("Pato Cabeça Vermelha está Voando...");
        }
    }

}
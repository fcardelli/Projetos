using System;
using SimUDuck.Classes;

namespace SimUDuck.Classes
{
    class PatoSelvagem : Pato
    {
        public override void Voar()
        {
            Console.WriteLine("Pato Selvagem está voado agora!");
        }
    }
}
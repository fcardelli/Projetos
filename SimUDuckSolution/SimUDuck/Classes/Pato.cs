using System;

namespace SimUDuck.Classes
{
    public abstract class Pato
    {
        private string nome;

        public Pato()
        {
        }

        public string Nome
        { 
            get{return nome;}
            set{nome = value;} 
            
        }

        public void Grasnar()
        {
            Console.WriteLine("Grasnando!! QUé QUé!! ");
        }

        public virtual void Voar()
        {
            Console.WriteLine("Voando...");
        }

        public void Nadar()
        {
            Console.WriteLine("Nadando...");
        }

        public void Nadar(string nome)
        {
            Console.WriteLine(nome + " Nadando...");
        }

    }

}

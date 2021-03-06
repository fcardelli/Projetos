﻿using System;
using System.Collections.Generic;
using SimUDuck.Classes;

namespace SimUDuck
{
    class Program
    {
        static void Main(string[] args)
        {

            Simulador simulador = new Simulador();
            simulador.Executar(new PatoSelvagem());
            simulador.Executar(new PatoCabecaVermelha());

            FabricaPatos fabrica = new FabricaPatos();
            var patos = fabrica.ObterPatos();
            foreach(var item in patos)
                simulador.Executar(item);

            Console.ReadLine();


            /*
            Pato pato = new Pato();
            PatoCabecaVermelha patoCabecaVermelha = new PatoCabecaVermelha();
            PatoSelvagem patoSelvagem = new PatoSelvagem(); */
            // Pato patoVermelho = new PatoCabecaVermelha();
            // Pato patoSelvagem = new PatoSelvagem();

            // /*Console.WriteLine("{0}",pato);
            // pato.Grasnar();
            // pato.Voar();
            // pato.Nadar();*/

            // Console.WriteLine("{0}",patoSelvagem);
            // patoSelvagem.Grasnar();
            // patoSelvagem.Voar();
            // patoSelvagem.Nadar();

            // Console.WriteLine("{0}",patoVermelho);
            // patoVermelho.Grasnar();
            // patoVermelho.Voar();
            // patoVermelho.Nadar();

            // patoSelvagem.Nadar("Pato Selvagem");
            // patoVermelho.Nadar("Pato Vermelho");
            // patoSelvagem.Voar();
            // patoVermelho.Voar();
        }
    }
}

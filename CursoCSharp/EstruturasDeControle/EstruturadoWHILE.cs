﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle {
    class EstruturadoWHILE {
        public static void Executar() {
            string entrada;

            do {
                Console.WriteLine("Qual o seu nome? ");
                entrada = Console.ReadLine();

                Console.WriteLine("Seja bem-vindo(a) {0}", entrada);
                Console.WriteLine("Deseja continuar? S/N ");
                entrada = Console.ReadLine();
            } while (entrada.ToLower() == "s");
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class OperadoresAritmeticos 
    {
        public static void Executar() 
        {
            // PREÇO DESCONTO
            var preco = 1000.0;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var totalComDesconto = total - (total * desconto);
            Console.WriteLine("O Preço final é {0} ", totalComDesconto);


            // IMC

            double peso = 91.2;
            double altura = 1.82;
            // math.pow base, expoente
            double imc = peso / Math.Pow(altura, 2);
            Console.WriteLine($"O IMC é {imc}. ");

            // numero par/impar
            int par = 24;
            int impar = 55;
            Console.WriteLine("{0}/2 tem resto {1}", par, par % 2);
            Console.WriteLine("{0}/2 tem resto {1}", impar, impar % 2); 
        }
    }
}

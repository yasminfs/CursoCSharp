using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle {
    class EstruturaFOR {
        public static void Executar() {
            //for (int i = 1; i <= 10; i++) {
            //    Console.WriteLine($"O valor de i é {i}.");
            //}

            double somatorio = 0;
            string entrada;

            Console.WriteLine("Informe o tamanho da turma: ");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out int tamanhodaturma);

            for (int i = 1; i <= tamanhodaturma; i++) {
                Console.WriteLine("Informe a nota do aluno {0}: ", i);
                entrada = Console.ReadLine();
                double.TryParse(entrada, out double notaatual);

                somatorio += notaatual; 
            }

            // uso do ? explicação do que foi feito abaixo ---->
            //  condition ? consequent : alternative

            double media = tamanhodaturma > 0 ? somatorio / tamanhodaturma : 0;
            Console.WriteLine("Média da turma: {0} ", media);
        }
    }
}

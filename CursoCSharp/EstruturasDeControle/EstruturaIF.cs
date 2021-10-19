using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle {
    class EstruturaIF 
    {
        public static void Executar() 
        {
            bool bomcomportamento = false;
            string entrada;

            Console.WriteLine("Digite a nota do aluno: ");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            Console.WriteLine("Possui bom comportamento? (S/N): ");
            entrada = Console.ReadLine();

            //if (entrada == "S" || entrada == "s")
            //    bomcomportamento = true;

            //bomcomportamento = entrada == "S" || entrada == "s";

            bomcomportamento = entrada.ToLower() == "s";

            if(nota >= 9.0 && bomcomportamento) {
                Console.WriteLine("Quadro de Honra");
            }

        }
    }
}

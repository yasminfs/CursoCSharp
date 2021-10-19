using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos 
{
    class OperadorTernario 
    {

        public static void Executar() 
        {
            var nota = 5.0;
            bool bomcomportamento = true;
            string resultado = nota >= 7.0 && bomcomportamento
                ? "Aprovado" : "Reprovado";
            Console.WriteLine(resultado);

        }
    }
}

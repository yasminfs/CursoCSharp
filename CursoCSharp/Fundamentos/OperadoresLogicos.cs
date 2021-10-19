using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos 
{
    class OperadoresLogicos 
    {
        public static void Executar() 
        {
            var executouTrabalho1 = true;
            var executoutrabalho2 = true;

            bool comprouTV50 = executouTrabalho1 && executoutrabalho2;
            Console.WriteLine("Comprou a tv 50pol? {0}", comprouTV50);

            var comprousorvete = executouTrabalho1 || executoutrabalho2;
            Console.WriteLine("Comprou sorvete? {0}", comprousorvete);

            var comproutv32 = executouTrabalho1 ^ executoutrabalho2;
            Console.WriteLine("Comprou a tv de 32? {0}", comproutv32);

            Console.WriteLine("Mais saudável? {0}", !comprousorvete);
        }
    }
}

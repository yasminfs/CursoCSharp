using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle {
    class UsandoBreak {
        public static void Executar () {
            Random random = new Random();
            int numero = random.Next(1, 51);

            Console.WriteLine("O númeroque queremos é {0}", numero);

            for (int i = 1; i<=50; i++) {
                Console.Write("{0} é o número que queremos? ", i);
                if (i == numero) {
                    Console.WriteLine("SIM!!!!!!!");
                    break;
                } else {
                    Console.WriteLine("NAOOOO :( ");
                }
            }

            Console.WriteLine("FIM!");
        }
    }
}

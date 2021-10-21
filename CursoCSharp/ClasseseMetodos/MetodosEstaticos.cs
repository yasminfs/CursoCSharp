using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClasseseMetodos 
{ 

    public class CalculadoraEstatica {
        // método de instância
        public int Somar(int a, int b) {
            return a + b;
        }
        // método de Classe ou método estático
        public static int Multiplicar(int a, int b) {
            return a * b;
        }
        class MetodosEstaticos {
            public static void Executar() {
                var resultado = CalculadoraEstatica.Multiplicar(2, 2);
                Console.WriteLine("Resultado: {0}", resultado);

                CalculadoraEstatica calc = new CalculadoraEstatica();
                Console.WriteLine(calc.Somar(2, 2));

            }
        }
    }
}

namespace CursoCSharp {
    class MetodosEstaticos {
        internal static void Executar() {
            throw new NotImplementedException();
        }
    }
}
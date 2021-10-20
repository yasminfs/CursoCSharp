using System;


namespace CursoCSharp.ClasseseMetodos 
{
    class CalculadoraComum 
    {
        public int Somar(int a, int b) {
            return a + b;
        }
        
        public int Subtrair(int a, int b) {
            return a - b;
        }
        
        public int Multiplicar(int a, int b) {
            return a * b;
        }
        
        public int Dividir(int a, int b) {
            return a / b;
        }
        
    }

    class CalculadoraCadeia {
        int memoria;

        public CalculadoraCadeia Somar(int a) {
            memoria += a;
            return this;
        }
        public CalculadoraCadeia Multiplicar(int a) {
            memoria *= a;
            return this;
        }

        public CalculadoraCadeia Limpar() {
            memoria = 0;
            return this;
        }

        public CalculadoraCadeia Imprimir() {
            Console.WriteLine(memoria);
            return this;
        }

        public int Resultado() {
            return memoria;
        }
    }
    class MetodosComRetorno 
    {
        public static void Executar () {
            var calculadoracomum = new CalculadoraComum();
            var resultado = calculadoracomum.Somar(5, 5);

            Console.WriteLine(resultado);
            Console.WriteLine(calculadoracomum.Subtrair(2, 7));
            Console.WriteLine(calculadoracomum.Multiplicar(4, 4));
            Console.WriteLine(calculadoracomum.Dividir(4, 4));

                var calculadoracadeia = new CalculadoraCadeia();
                calculadoracadeia.Somar(3).Multiplicar(3).Imprimir()
                    .Limpar().Imprimir();

                resultado = calculadoracadeia.Somar(3).Multiplicar(2)
                    .Resultado();
                Console.WriteLine(resultado);
        }
    }
}

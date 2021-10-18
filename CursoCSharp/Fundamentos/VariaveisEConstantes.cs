using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class VariaveisEConstantes {
        public static void Executar() {
            //area da circunferencia
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            // PI = 3.1415;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("área é " + area);

            // tipos internos 
            bool estachovendo = true;
            Console.WriteLine("esta chovendo " + estachovendo);

            byte idade = 45;
            Console.WriteLine("idade " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de Gols " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salário" + salario);

            int menorValorInt = int.MinValue;
            Console.WriteLine("Menor int " + menorValorInt);

            uint populacaoBrasileira = 2007_600_000;
            Console.WriteLine("população brasileira " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("menor long " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("população mundial " + populacaoMundial);

            float precoComputador = 1299.99f;
            Console.WriteLine("preço computador " + precoComputador);

            double valorDeMercadoDaApple = 1_000_000_000_000.00;
            Console.WriteLine("Valor apple " + valorDeMercadoDaApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("distancia estrelas " + distanciaEntreEstrelas);

            char letra = 'b';
            Console.WriteLine("letra " + letra);

            string texto = "Seja bem vindo ao curso de C#";
            Console.WriteLine(texto);

        }
    }
}

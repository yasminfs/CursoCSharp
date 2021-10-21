﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClasseseMetodos 
{   
    public class Dependente { // basta trocar o class aqui por struct para ver a diferença
        public string Nome;
        public int Idade;
    }
    class ValorvsReferencia {
        public static void Executar() {
            int numero = 3;
            int copiaNumero = numero;
            Console.WriteLine($"{numero} {copiaNumero}");

            numero++;
            Console.WriteLine($"{numero} {copiaNumero}");

            Dependente dep = new Dependente {
                Nome = "Beto",
                Idade = 20
            };

            Dependente copiadep = dep;

            Console.WriteLine($"{dep.Nome} {copiadep.Nome}");
            Console.WriteLine($"{dep.Idade} {copiadep.Idade}");

            copiadep.Nome = "Renato";
            dep.Idade = 21;

            Console.WriteLine($"{dep.Nome} {copiadep.Nome}");
            Console.WriteLine($"{dep.Idade} {copiadep.Idade}");


        }
    }
            
}

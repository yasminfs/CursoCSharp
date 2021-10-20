using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClasseseMetodos 
{
    class Pessoa 
    {
        public string Nome; // string tem valor padrão null
        public int Idade;  // int tem valor padrão 0

        public string Apresentar() 
        {
            return string.Format(
                $"Olá! Me chamo {Nome} e tenho {Idade} anos.");
        }

        public void ApresentarNoConsole() {
            Console.WriteLine(Apresentar());
        }

        public void Zerar() {
            Nome = "";
            Idade = 0;
        }
    }
}

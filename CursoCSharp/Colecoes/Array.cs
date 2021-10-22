using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes {
    class Array 
{                   // array é uma estrutura homogênea e estática -
                   // todos dados sao do mesmo tipo e com dados fixos
        public static void Executar() {
            string[] alunos = new string[5];
            alunos[0] = "Anderson";
            alunos[1] = "Bia";
            alunos[2] = "Carol";
            alunos[3] = "Diana";
            alunos[4] = "Elias";

            foreach(var aluno in alunos) {
                Console.WriteLine(aluno);
            }

            double somatorio = 0;
            double[] notas = { 9.7, 4.8, 8.4, 8.2, 6.8 };

            foreach (var nota in notas) {
                somatorio += nota;
            }

            double media = somatorio / notas.Length;
            Console.WriteLine(media);

            char[] letras = { 'a', 'b', 'c', 'd' };
            string palavra = new string(letras);
            Console.WriteLine(palavra);
        }
    }
}

using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Variaveis e constantes", VariaveisEConstantes.Executar},
                {"Inferência - Fundamentos ", Inferencia.Executar},
                {"Interpolacao - fundamento ", Interpolacao.Executar},
                {"NotacaoPonto - fundamento ", NotacaoPonto.Executar},
                {"LendoDados - fundamento ", LendoDados.Executar},
                {"FormatandoNumero - fundamento ", FormatandoNumero.Executar},
                {"Conversões - fundamento ", Conversoes.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}
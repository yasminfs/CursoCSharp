using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;

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
                {"Operadores Aritmeticos - fundamento ", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - fundamento ", OperadoresRelacionais.Executar},
                {"Operadores Logicos - fundamento ", OperadoresLogicos.Executar},
                {"Operadores Atribuição- fundamento ", OperadoresAtribuicao.Executar},
                {"Operadores Unários- fundamento ", OperadoresUnarios.Executar},
                {"Operadores Ternário- fundamento ", OperadorTernario.Executar},
                // Estruturas de controle
                {"Estrutura IF- Estruturas de Controle ", EstruturaIF.Executar},
                {"Estrutura IF ELSE- Estruturas de Controle ", EstruturaIFELSE.Executar},
                {"Estrutura IF ELSE IF- Estruturas de Controle ", EstruturaIfElseIf.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}
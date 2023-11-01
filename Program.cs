using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"VariaveisEConstantes - Fundamentos", VariaveisEConstantes.Executar },
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatar Números - Fundamentos", FormatarNumeros.Executar},
                {"Operadores Aritméticos ", OperadoresAritmeticos.Executar },
            });

            central.SelecionarEExecutar();
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class LendoDados
    {
        public static void Executar()
        {
            Console.WriteLine("Qual seu nome? ");
            string nome = Console.ReadLine();
            Console.WriteLine("Qual sua idade? ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual sua Altura? ");
            double altura = double.Parse(Console.ReadLine());
            Console.WriteLine($"Olá {nome} você tem {idade} anos e possui {altura}");
        }
        
        
    }
}

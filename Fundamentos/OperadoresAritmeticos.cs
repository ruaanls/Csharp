using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAritmeticos
    {
        public static void Executar()
        {
            /*
             * 
             * 
             * Console.WriteLine("Digite o primeiro valor: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Segundo Valor: ");
            int n2 = int.Parse(Console.ReadLine());

            int soma = n1 + n2;
            Console.WriteLine($"A soma dos valores é {soma}");
             * 
             * 
             * 
             */

            Console.WriteLine("Digite o valor da base");
            var Base = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da altura");
            var Altura = double.Parse(Console.ReadLine());

            var area = Base * Altura / 2;

            Console.WriteLine($"A área é {area}");

            

        }
    }
}

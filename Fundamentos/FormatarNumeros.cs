﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class FormatarNumeros
    {
        public static void Executar()   
        {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1"));

            Console.WriteLine(valor.ToString("C"));

            Console.WriteLine(valor.ToString("#.##"));
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1___98
{
    class Program
    {
        static void Main(string[] args)
        {
            float gradosC = 0;

            Console.WriteLine("Digite los grados Centigrados");
            Console.ReadLine();

            gradosC = int.Parse(Console.ReadLine());
            CaFa grados = new CaFa();
            Console.WriteLine(CaFa.obtenerfahrenheit(gradosC));

            Console.ReadLine();
        }
    }
}

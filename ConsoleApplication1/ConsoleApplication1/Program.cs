﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Console.WriteLine("Hola Mundo");
            //System.Console.WriteLine("Ejemplo");
            //System.Console.ReadKey();

            Fibonacci Fibo = new Fibonacci();
            System.Console.WriteLine(Fibonacci.Calcular(2));
            System.Console.ReadKey();
        }
    }
}

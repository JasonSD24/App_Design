using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    class Program
    {
        static void Main(string[] args)
        {

            fibonacci(56);
            System.Console.ReadKey();
        }

        public static void fibonacci(int n)
        {
            int num = 1;
            int temp = 0;
            int resultado;

            while (num < n)
            {
                Console.WriteLine(num);
                resultado = num + temp;
                temp = num;
                num = resultado;
            }
        }
    }
}

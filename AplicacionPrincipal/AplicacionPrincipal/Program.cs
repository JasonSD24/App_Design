using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AplicacionPrincipal
{
    class Program
    {
        static void Main(string[] args)
        {

            LogicaDeAplicacion.CarritoDeCompras producto1 = new LogicaDeAplicacion.CarritoDeCompras();

            producto1.AgregarIdentificador("10199");
            producto1.AgregarNombre("iPod Touch 64GB");
            producto1.AgregarFecha("2015-06-06");

            LogicaDeAplicacion.CarritoDeCompras producto2 = new LogicaDeAplicacion.CarritoDeCompras();

            producto2.AgregarIdentificador("13100");
            producto2.AgregarNombre("ChromeCast");
            producto2.AgregarFecha("2015-03-06");


            LogicaDeAplicacion.CarritoDeCompras producto3 = new LogicaDeAplicacion.CarritoDeCompras();

            producto3.AgregarIdentificador("10299");
            producto3.AgregarNombre("Laptop HB 256GB");
            producto3.AgregarFecha("2015-07-06");


            Console.ReadKey();
        }

    }
        }
    


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeAplicacion
{
   public class CarritoDeCompras
    {
        private List<string> listaProductos = new List<string>();

        public void AgregarIdentificador(string ProductoPorAgregar)
        {
            listaProductos.Add(ProductoPorAgregar);
        }
        public void AgregarNombre(string ProductoPorAgregar)
        {
            listaProductos.Add(ProductoPorAgregar);

        }
        public void AgregarFecha(string ProductoPorAgregar)
        {
            listaProductos.Add(ProductoPorAgregar);
        }    
    }
}

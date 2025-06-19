using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Ventas_2
{
    internal class Venta
    {
        ///ATRIBUTOS///
        private int codigoArticulo;
        private int cantidad;
        private int codigoCliente;

        ///METODOS///
        public int CodigoArticulo
        {
            get { return codigoArticulo; }
            set {codigoArticulo = value; }
        }
        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        public int CodigoCliente
        {
            get { return codigoCliente; }
            set { codigoCliente = value; }
        }

    }
}

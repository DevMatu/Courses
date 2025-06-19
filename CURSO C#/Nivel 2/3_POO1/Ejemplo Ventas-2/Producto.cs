using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Ventas_2
{
    internal class Producto
    {
        ///ATRIBUTOS///
        private int codigoArticulo;
        private float precio;
        private int codigoMarca;

        ///METODOS///
        public int CodigoArticulo
        {
            get { return codigoArticulo; }
            set { codigoArticulo = value; }
        }
        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public int CodigoMarca
        {
            get { return codigoMarca; }
            set 
            {
                if (codigoMarca > 0 && codigoMarca < 11)
                    codigoMarca = value;
                else
                    codigoMarca = - 1;
            }
        }
    }
}

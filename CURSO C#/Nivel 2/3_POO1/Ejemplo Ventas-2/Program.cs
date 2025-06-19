using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Ventas_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int CANTIDAD_PRODUCTOS = 10;
            Producto[] productos = new Producto[CANTIDAD_PRODUCTOS];

            

            for (int i = 0; i < productos.Length; i++)
            {
                productos[i] = new Producto();
                Console.WriteLine("INGRESE LOS DATOS DEL PRODUCTO...");

                Console.WriteLine("CODIGO:");
                productos[i].CodigoArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("PRECIO:");
                productos[i].Precio = float.Parse(Console.ReadLine());
                Console.WriteLine("CODIGO DE MARCA (1-10):");
                productos[i].CodigoMarca = int.Parse(Console.ReadLine());

                Console.WriteLine("==========================================");

            }

            Venta venta = new Venta();

            Console.WriteLine("INGRESE LOS DATOS DE LA VENTA...");
            Console.WriteLine("CODIGO DE CLIENTE:");
            venta.CodigoCliente = int.Parse(Console.ReadLine());

            while (venta.CodigoCliente != 0)
            {
                Console.WriteLine("CODIGO DE ARTICULO:");
                venta.CodigoArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("CANIDAD:");
                venta.Cantidad = int.Parse(Console.ReadLine());

                ///TRABAJAMOS...

                ///PIDO CODIGO DE CLIENTE NUEVAMENTE.
                Console.WriteLine("INGRESE LOS DATOS DE LA VENTA...");
                Console.WriteLine("CODIGO DE CLIENTE:");
                venta.CodigoCliente = int.Parse(Console.ReadLine());
            }
        }
    }
}

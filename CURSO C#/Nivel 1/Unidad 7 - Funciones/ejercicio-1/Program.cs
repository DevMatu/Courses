using System;

namespace ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int precioArticulo;
            int cantidadVendida;
            Console.WriteLine("INGRESE EL PRECIO DEL ARTICULO:");
            precioArticulo = int.Parse(Console.ReadLine());
            Console.WriteLine("INGRESE LA CANTIDAD VENDIDA: ");
            cantidadVendida = int.Parse(Console.ReadLine());

            
            Console.WriteLine("TOTAL A PAGAR: " + producto(ref precioArticulo,ref cantidadVendida));
        }

        static int producto (ref int n1, ref int n2)
        {
            int producto = n1*n2;
            return producto;
        }
    }
}

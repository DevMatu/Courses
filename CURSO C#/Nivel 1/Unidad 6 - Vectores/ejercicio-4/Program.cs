using System;

namespace ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            const int TIPOS_DE_ARTICULOS = 15;
            int numeroDeArticulo;
            int cantidadVendida;
            int numeroDeArticuloActual;
            int[] cantidadesPorArticulo = new int[TIPOS_DE_ARTICULOS];
            int articuloMasVendido = 0;
            int maximaCantidadVendida = 0;

            Console.WriteLine("INGRESE EL NUMERO DE ARTICULO:");
            numeroDeArticulo = int.Parse(Console.ReadLine());
            ///TIPO DE ARTICULO//
            while(numeroDeArticulo >= 1 && numeroDeArticulo <= 15 && numeroDeArticulo != 0)
            {
                numeroDeArticuloActual = numeroDeArticulo;

                ///VENTAS///
                Console.WriteLine("\nVENTAS DEL ARTICULO N° "+numeroDeArticuloActual);
                while(numeroDeArticulo == numeroDeArticuloActual)
                {
                    Console.WriteLine("CANTIDAD VENDIDA:");
                    cantidadVendida = int.Parse(Console.ReadLine());

                    cantidadesPorArticulo[numeroDeArticulo-1] += cantidadVendida;

                    Console.WriteLine("NUMERO DE ARTICULO:");
                    numeroDeArticulo = int.Parse(Console.ReadLine());
                }
            }

            ///PUNTO A///
            for(int i = 0; i<TIPOS_DE_ARTICULOS; i++)
            {
                if(articuloMasVendido == 0)
                {
                    maximaCantidadVendida = cantidadesPorArticulo[i];
                    articuloMasVendido = i+1;
                }
                else if(cantidadesPorArticulo[i] > maximaCantidadVendida)
                {
                    maximaCantidadVendida = cantidadesPorArticulo[i];
                    articuloMasVendido = i+1;
                }
            }
            Console.WriteLine("\n===================================================");
            Console.WriteLine("ARTICULO QUE MAS SE VENDIÓ: "+articuloMasVendido);
            Console.WriteLine("===================================================");

            ///PUNTO B///
            Console.WriteLine("\n===================================================");
            Console.WriteLine("ARTICULOS SIN VENTAS:");
            int indice = 0;
            for(int i = 0; i<TIPOS_DE_ARTICULOS; i++)
            {
                if(cantidadesPorArticulo[i] == 0)
                {
                    indice = i+1;
                    Console.WriteLine("EL ARTICULO " + indice + " NO PRESENTÓ VENTAS");
                }
            }
            Console.WriteLine("===================================================");

            ///PUNTO C///
            Console.WriteLine("\n===================================================");
            Console.WriteLine("VENTAS DEL ARTICULO N°10");
            if(cantidadesPorArticulo[9] <= 0)
            {
                Console.WriteLine("EL ARTICULO N°10 NO PRESENTÓ VENTAS");
            }
            else
            {
                Console.WriteLine("EL ARTICULO N°10 TIENE "+cantidadesPorArticulo[9]+" VENTA/S");
            }
            Console.WriteLine("===================================================");
        }
    }
}

using System;

namespace ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            float importeDeVenta, descuento=0, precioFinal;
            
            const int importeMil = 1000;
            const int importeCincoMil = 5000;
            const int descuentoDiez = 10;
            const int descuentoDiezYocho = 18;
            const int porcentaje = 100;
            
            Console.WriteLine("INGRESE EL IMPORTE DE LA VENTA:");
            importeDeVenta = int.Parse(Console.ReadLine());

            if(importeDeVenta >= importeCincoMil){

               descuento = (importeDeVenta * descuentoDiezYocho)/porcentaje;
               precioFinal = importeDeVenta - descuento;
               Console.WriteLine("DESCUENTO DEL " + descuentoDiezYocho + "% APLICADO.");
               Console.WriteLine("IMPORTE FINAL: " + precioFinal);

            }else if(importeDeVenta >= importeMil){

                descuento = (importeDeVenta * descuentoDiez)/porcentaje;
                precioFinal = importeDeVenta - descuento;
                Console.WriteLine("DESCUENTO DEL " + descuentoDiez + "% APLICADO.");
                Console.WriteLine("IMPORTE FINAL: " + precioFinal);

            }else{
                Console.WriteLine("NO HAY DESCUENTO");
            }
        }
    }
}

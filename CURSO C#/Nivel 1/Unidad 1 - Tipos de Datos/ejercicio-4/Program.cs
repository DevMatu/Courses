using System;

namespace ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            const int porcentaje = 100;
            const int sueldo = 150000;
            const int comision = 5;
            float facturado, resultado;

            Console.WriteLine("INGRESE EL TOTAL FACTURADO:");
            facturado = int.Parse(Console.ReadLine());

            resultado = (facturado*comision) / porcentaje;
            resultado += sueldo;
            Console.WriteLine("TOTAL A COBRAR: " + resultado);
        }
    }
}

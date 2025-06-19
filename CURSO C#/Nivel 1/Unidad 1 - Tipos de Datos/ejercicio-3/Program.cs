using System;

namespace ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //DECLARAR VARIABLES//
            float distancia, velocidad, tiempoAproximado;
            const int Minutos = 60;

            //PEDIR DATOS//
            Console.WriteLine("INGRESE LA DISTANCIA, EN KM, ENTRE DOS CIUDADES:");
            distancia = float.Parse(Console.ReadLine());

            Console.WriteLine("INGRESE LA VELOCIDAD DEL VEHICULO:");
            velocidad = float.Parse(Console.ReadLine());

            //OPERACION//
            tiempoAproximado = distancia/velocidad;
            tiempoAproximado = tiempoAproximado*Minutos;

            //LISTAR POR PANTALLA//
            Console.WriteLine("EL TIEMPO APROXIMADO DE LLEGADA ES DE: " + tiempoAproximado);
        }
    }
}

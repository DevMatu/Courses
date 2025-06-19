using System;

namespace ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad, contador = 0, acumulador = 0, promedio;
            const int MayorQue = 18;
            Console.WriteLine("INGRESE 20 EDADES: ");

            for(int i=0; i<20; i++)
            {
                edad = int.Parse(Console.ReadLine());
                if(edad > MayorQue && edad > 0)
                {
                    contador++;
                    acumulador+=edad;
                }
            }

            promedio = acumulador/contador;
            Console.WriteLine("EL PROMEDIO DE LAS EDADES MAYORES DE 18 ES: " + promedio);
        }
    }
}

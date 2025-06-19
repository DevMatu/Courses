using System;

namespace ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            const int mayorQue = 10;
            Console.WriteLine("INGRESE UN NUMERO:");
            
            numero = int.Parse(Console.ReadLine());

            if(numero > mayorQue){
                Console.WriteLine("EL NUMERO INGRESADO ES MAYOR A 10.");
            }
            else{
                Console.WriteLine("EL NUMERO INGRESADO NO ES MAYOR A 10.");
            }
        }
    }
}

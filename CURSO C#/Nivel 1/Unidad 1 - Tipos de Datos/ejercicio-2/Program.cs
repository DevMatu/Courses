using System;

namespace ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //DECLARAMOS VARIABLES//
            int numero, resultado1, resultado2;

            //INGRESAMOS DATOS//
            Console.WriteLine("INGRESE UN NUMERO:");
            numero = int.Parse(Console.ReadLine());

            //REALIZAMOS LA OPERACION//
            resultado1 = numero * numero;
            resultado2 = resultado1 * numero;

            //LISTAMOS RESULTADO//
            Console.WriteLine("EL CUBO DEL NUMERO INGRESADO ES:" + resultado2);
        }
    }
}

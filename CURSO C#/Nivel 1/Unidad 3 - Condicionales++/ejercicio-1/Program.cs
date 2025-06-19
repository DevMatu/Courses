using System;

namespace ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            float numero1, numero2, resultado;
            Console.WriteLine("INGRESE DOS NUMEROS:");
            numero1 = float.Parse(Console.ReadLine());
            numero2 = float.Parse(Console.ReadLine());

            if(numero1 > numero2)
                resultado = numero1 - numero2;
            else if(numero1 == numero2)
                resultado = numero1 + numero2;
            else
                resultado = numero1 * numero2;
            
            Console.WriteLine("RESULTADO: " + resultado);
        }
    }
}

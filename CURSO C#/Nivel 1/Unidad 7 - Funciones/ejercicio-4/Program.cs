using System;

namespace ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int variable=0;
            float numero;
            Console.WriteLine("INGRESE UN NUMERO:");
            numero = float.Parse(Console.ReadLine());

            PositivoNegativoCero(numero, ref variable);

            Console.WriteLine(variable);
        }

        static void PositivoNegativoCero(float numero, ref int variable)
        {
            if(numero > 0)
            {
                variable = 1;
            }
            else if(numero < 0)
            {
                variable = -1;
            }
        }
    }
}

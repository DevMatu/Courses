using System;

namespace ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            int maximo = 0, pos = 0;

            Console.WriteLine("INGRESE 10 NUMEROS ENTEROS:");
            for(int i=0; i<10; i++)
            {
                numeros[i] = int.Parse(Console.ReadLine());

                if(maximo == 0)
                {
                    maximo = numeros[i];
                    pos = i+1;
                }
                else if(numeros[i] > maximo)
                {
                    maximo = numeros[i];
                    pos = i+1;
                }
                
            }

            Console.WriteLine("EL MAYOR NUMERO INGRESADO FUE "+ maximo +" EN LA POSICION "+ pos);
        }
    }
}

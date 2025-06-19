using System;

namespace ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int listaConMasImpares;
            int listasOrdenadas = 0;
            int maximoImpares = 0;
            
            for(int i=0; i<5; i++)
            {
                int impares = 0;
                int maximo = 0;
                int numeroAnterior = 0;
                bool estaOrdenado = true;
                Console.WriteLine("LISTA N°" + i+1);

                numero = int.Parse(Console.ReadLine());
                while(numero != 0)
                {
                    if(numero%2 != 0)
                    {
                        impares++;
                    }

                    if(numeroAnterior == 0)
                    {
                        numeroAnterior = numero;
                    }
                    else if(numeroAnterior > numero)
                    {
                        numeroAnterior = numero;
                    }
                    else
                    {
                        estaOrdenado = false; 
                    }

                    numero = int.Parse(Console.ReadLine());
                }

                if(maximoImpares == 0)
                {
                    listaConMasImpares = i+1;
                    maximoImpares = impares;
                }
                else if(impares > maximoImpares)
                {
                    listaConMasImpares = i+1;
                    maximoImpares = impares;
                }
                
                if(estaOrdenado)
                {
                    listasOrdenadas++; 
                }
            }

            Console.WriteLine("LISTA CON MAYOR CANTIDAD DE IMPARES: " + listaConMasImpares);
            Console.WriteLine("LISTA ORDENADAS DE MAYOR A MENOR: " + listasOrdenadas);

        }
    }
}

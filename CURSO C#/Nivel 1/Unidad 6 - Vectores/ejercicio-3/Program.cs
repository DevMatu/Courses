using System;

namespace ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //DECLARAMOS LAS VARIABLES Y CONSTANTES//
            const int LARGO_CADENA = 31;
            char[] cadena = new char[LARGO_CADENA];
            int indice = 0;
            char letra;
            char caracterUno, caracterDos;
            
            //CARGAMOS LA CADENA//
            Console.WriteLine("INGRESE UNA CADENA DE CARACTERES:");
            letra = char.Parse(Console.ReadLine());
            while(letra != '.' && indice < LARGO_CADENA)
            {
                cadena[indice] = letra;
                letra = char.Parse(Console.ReadLine());
                indice++;
            }
            cadena[indice] = '\0';

            //CARGAMOS LOS CARACTERES//
            Console.WriteLine("\nINGRESE DOS CARACTERES:");
            caracterUno = char.Parse(Console.ReadLine());
            caracterDos = char.Parse(Console.ReadLine());

            //MOSTRAMOS LA CADENA ORIGINAL//
            Console.WriteLine("\n");
            indice = 0;
            while(cadena[indice] != '\0')
            {
                Console.Write(cadena[indice]);
                indice++;
            }

            //REEMPLAZAMOS LOS CARACTERES//
            indice = 0;
            while(cadena[indice] != '\0')
            {
                if(cadena[indice] == caracterUno)
                {
                    cadena[indice] = caracterDos;
                }
                indice++;
            }

            //MOSTRAMOS LA CADENA REEMPLAZADA//
            Console.WriteLine("\n");
            indice = 0;
            while(cadena[indice] != '\0')
            {
                Console.Write(cadena[indice]);
                indice++;
            }

        }
    }
}

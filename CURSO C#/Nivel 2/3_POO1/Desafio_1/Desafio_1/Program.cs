using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Telefono telefono_1 = new Telefono("G72", "Motorola");

            Console.WriteLine("PROPIEDADES DEL TELEFONO:");
            Console.WriteLine("MARCA:");
            Console.WriteLine(telefono_1.Marca);
            Console.WriteLine("MODELO:");
            Console.WriteLine(telefono_1.Modelo);

            Console.WriteLine("INGRESE SU NUMERO DE TELEFONO:");
            telefono_1.NumeroTelefonico = Console.ReadLine();

            Console.WriteLine("INGRESE SU NUMERO DE OPERADOR (1-3):");
            telefono_1.CodigOperador = int.Parse(Console.ReadLine());

            Console.WriteLine("NUMERO DE TELEFONO:");
            Console.WriteLine(telefono_1.NumeroTelefonico);

            Console.WriteLine("CODIGO DE OPERADOR:");
            Console.WriteLine(telefono_1.CodigOperador);

            telefono_1.llamar("Matu");

            Console.ReadKey();
        }
    }
}

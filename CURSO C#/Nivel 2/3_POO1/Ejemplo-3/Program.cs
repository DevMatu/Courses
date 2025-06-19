using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Botella botella_1 = new Botella("Light Blue", "stainless steel");
            int capacidad;
            Console.WriteLine("INGRESE LA CAPACIDAD DE LA BOTELLA (L):");
            capacidad = int.Parse(Console.ReadLine());

            Console.WriteLine("");
            botella_1.Capacidad = capacidad;
            Console.WriteLine("CAPACIDAD DE LA BOTELLA (L): " + botella_1.Capacidad);
            Console.WriteLine("MATERIAL: " + botella_1.Material);
            Console.WriteLine("COLOR: " + botella_1.Color);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobreescritura_de_Métodos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Gato gato_1 = new Gato();

            gato_1.Nombre = "SOSHU";
            Console.WriteLine(gato_1.ToString() + " DICE:");
            Console.WriteLine(gato_1.comunicarse());

            Perro perro_1 = new Perro();
            perro_1.Nombre = "LOBA";
            Console.WriteLine(perro_1.ToString() + " DICE:");
            Console.WriteLine(perro_1.comunicarse());


            /// POLIMORFISMO ///
            List<Animal> animales = new List<Animal>();
            animales.Add(new Aguila());
            animales.Add(new Tigre());
            animales.Add(perro_1);
            animales.Add(gato_1);

            foreach (Animal item in animales)
            {
                Console.WriteLine(item.comunicarse());
            }

            Console.ReadKey();
        }
    }
}

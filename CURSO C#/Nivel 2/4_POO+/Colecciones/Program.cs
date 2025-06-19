using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Deportivo deportivo_1 = new Deportivo();
            Camioneta camioneta_1 = new Camioneta();
            Camioneta camioneta_2 = new Camioneta();
            Camioneta camioneta_3 = new Camioneta();

            camioneta_1.color = "Negro";
            camioneta_2.color = "Rojo";
            camioneta_3.color = "Blanco";

            List<Camioneta> listaCamionetas = new List<Camioneta>(); //<--- variable de tipo "lista de camionetas"
            listaCamionetas.Add(camioneta_1); //<--- agregamos el objeto a la lista;
            listaCamionetas.Add(camioneta_2);
            listaCamionetas.Add(camioneta_3);

            Console.WriteLine("LA CANTIDAD DE CAMIONETAS ES: " + listaCamionetas.Count);
            Console.WriteLine("EL COLOR ES: " + listaCamionetas[1].color);

            foreach (Camioneta item in listaCamionetas)
            {
                Console.WriteLine("COLOR: " + item.color);
            }

            listaCamionetas.Remove(camioneta_3);

            Console.WriteLine("LA CANTIDAD DE CAMIONETAS ES: " + listaCamionetas.Count);

            Console.ReadKey();
        }
    }
}

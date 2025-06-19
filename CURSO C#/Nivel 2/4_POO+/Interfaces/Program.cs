using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aguila aguila_1 = new Aguila();

            Canario canario_1 = new Canario();  

            Console.WriteLine("EL ÁGUILA ESTÁ " + aguila_1.volar());

            Console.WriteLine("EL CANARIO ESTÁ " + canario_1.volar());

            Console.ReadKey();
        }
    }
}

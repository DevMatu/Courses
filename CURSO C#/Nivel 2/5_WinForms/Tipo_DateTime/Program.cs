 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipo_DateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha = DateTime.Now;

            Console.WriteLine(fecha.ToString());

            Console.ReadKey();
        }
    }
}

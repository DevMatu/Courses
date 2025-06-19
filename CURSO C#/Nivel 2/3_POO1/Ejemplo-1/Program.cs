using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///PERSONA = EDAD, SUELDO, NOMBRE.///
            Persona persona1 = new Persona();

            persona1.setNombre("Matusalen");
            persona1.Edad = 22;
            persona1.setSueldo(450000);

            Console.WriteLine("NOMBRE: " + persona1.getNombre());
            Console.WriteLine("EDAD: " + persona1.Edad);
            Console.WriteLine("SUELDO: " + persona1.getSueldo());

            Console.WriteLine(persona1.saludar());

            Console.ReadKey();

            
        }
    }
}

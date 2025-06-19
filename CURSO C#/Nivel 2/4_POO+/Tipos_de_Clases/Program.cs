using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipos_de_Clases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CLASES ABTRACTAS//
            // De las clases abtractas no se pueden instanciar objetos.
            Persona persona_1 = new Persona(); //<----

            //CLASES SEALED//
            // esta no permite heredar ni metodos ni atributos, es una clase "sellada".
            // y solo se podran instanciar objetos de la misma.

            //CLASES ESTATICAS//
            // su caracteristica mas relevante es que no puede instanciar objetos y no puede heredar
            // es una clase que directamente se puede usar sin instanciar nada.
            // denominadas tambien clases helper, que normalmente contienen metodos que 
            // se usan directamente y consecutivamente.
            // "Console." <--- console es una clase estatica.
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asociación
{
    internal class Auto : Vehiculo
    {
        public Auto() 
        {
            chasis = new Chasis();
        }
        public string marca { get; set; }
        public string modelo { get; set; }
        public string color { get; set; }

        //Composición//
        //(relacion bien cercana con el objeto, este debe nacer con ese otro objeto que lo compone)
        public Chasis chasis { get; }

        //Agregación//
        //(relacion no cercana con el objeto, no es necesario que naznca
        //con ese otro objeto que se le agrega)
        public Motor motor { get; set; }
    }
}

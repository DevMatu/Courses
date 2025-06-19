using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_1
{
    internal class Persona
    {
        ///PERSONA = EDAD, SUELDO, NOMBRE.///

        ///ATRIBUTOS///
        private int edad;
        private float sueldo;
        private string nombre;

        ///METODOS///
        
        /// setters ///
        public void setSueldo(float sueldo) {this.sueldo = sueldo;}
        public void setNombre(string nombre) {this.nombre = nombre;}

        /// getters ///
        public string getNombre() {return nombre;}
        public float getSueldo() {return sueldo;}

        /// propiedades ///
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        /// metodo saludar ///
        public string saludar()
        {
            return "Hola soy " + nombre;
        }

    }
}

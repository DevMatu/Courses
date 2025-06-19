using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_3
{
    internal class Botella
    {

        // CONSRUCTOR // 
        public Botella(string color, string material) 
        {
            this.color = color;
            this.material = material;
        }

        // SOBRECARGA DEL CONSTRUCTOR // 
        public Botella() { }

        // DESTRUCTOR //
        ~Botella() 
        { 
            //La Logica//
        }

        // ATRIBUTOS //
        private int capacidad;
        private string color;
        private string material;

        // METODOS // 
        public int Capacidad
        {
            get { return capacidad; }
            set { capacidad = value; }
        }
        public string Material
        {
            get { return material; }
        }
        public string Color
        {
            get { return color; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1
{
    internal class Telefono
    {
        //ATRIBUTOS
        private string modelo;
        private string marca;
        private string numeroTelefonico;
        private int codigOperador;

        //PROPIEDADES
        public string Modelo
        {
            get { return modelo; }
        }

        public string Marca
        {
            get { return marca; } 
        }

        public string NumeroTelefonico
        {
            get { return numeroTelefonico; }
            set { numeroTelefonico = value; }
        }

        public int CodigOperador
        {
            get { return codigOperador; }
            set
            {
                if (codigOperador >= 1 && codigOperador <= 3)
                { codigOperador = value; }
                else {  codigOperador = 0; }
            }
        }

        //CONSTRUCTOR//
        public Telefono(string modelo, string marca) 
        {
            this.marca = marca;
            this.modelo = modelo;
        }

        //METODOS//
        public string llamar()
        { return "Realizando LLamado...";}

        public string llamar(string contacto)
        { return "llamando a" +  contacto; }
    }
}

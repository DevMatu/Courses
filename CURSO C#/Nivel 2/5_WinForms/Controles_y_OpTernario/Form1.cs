using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controles_y_OpTernario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string fecha = dtpFechaNacimiento.Text;
            string estaadoCivil = cmbEstadoCivil.Text;
            string exp = ckbExperiencia.Text = true ? "Tiene Experiencia Previa." : "No Tiene Experiencia Previa.";

            lwElementos.Items.Add("Nombre: " + nombre);
            lwElementos.Items.Add("");
            lwElementos.Items.Add("Fecha De Nacimiento: " + fecha);
            lwElementos.Items.Add("");
            lwElementos.Items.Add("Estado Civil: " + estaadoCivil);
            lwElementos.Items.Add("");
            lwElementos.Items.Add("Experiencia: " + exp);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbEstadoCivil.Items.Add("Soltero/a");
            cmbEstadoCivil.Items.Add("Casado/a");
            cmbEstadoCivil.Items.Add("Divorciado/a");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_2
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            lvResultado.Items.Clear();

            string Apellido = txtApellido.Text;
            string Nombre = txtNombre.Text;
            string Edad = txtEdad.Text;
            string Direccion = txtDireccion.Text;

            if (!string.IsNullOrWhiteSpace(Apellido) && !string.IsNullOrWhiteSpace(Nombre))
            {
                lvResultado.Items.Add("Apellido Y Nombre: " + Apellido + " " + Nombre);
                if (lblApellido.ForeColor == Color.Red || lblNombre.ForeColor == Color.Red)
                {
                    lblApellido.ForeColor = SystemColors.ControlText;
                    lblNombre.ForeColor = SystemColors.ControlText;
                }
            }
            else
            {
                lblApellido.ForeColor = Color.Red;
                lblNombre.ForeColor = Color.Red;
            }

            if (!string.IsNullOrWhiteSpace(Edad) && !string.IsNullOrWhiteSpace(Direccion))
            {
                lvResultado.Items.Add("Edad: " + Edad);
                lvResultado.Items.Add("Direccion: " + Direccion);
                if (lblEdad.ForeColor == Color.Red || lblDireccion.ForeColor == Color.Red)
                {
                    lblEdad.ForeColor = SystemColors.ControlText;
                    lblDireccion.ForeColor = SystemColors.ControlText;
                }
            }
            else
            {
                lblEdad.ForeColor = Color.Red;
                lblDireccion.ForeColor = Color.Red;
            }
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

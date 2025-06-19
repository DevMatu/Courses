using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_1
{
    public partial class frmPrincipal : Form
    {
        bool hayCambio = false;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenidos a C# :)");
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Chau Chau...");
        }

        
        private void button1_Click(object sender, EventArgs e)
        {

            if (hayCambio == false)
            {
                MessageBox.Show("Dice 'NO TOCAR'...");
                this.BackColor = Color.DarkSeaGreen;
                txtNombre.BackColor = Color.DarkGreen;
                hayCambio = true;
            }
            else 
            {
                MessageBox.Show("Vas a seguir?...");
                this.BackColor = Color.DarkGreen;
                txtNombre.BackColor = Color.DarkSeaGreen;
                hayCambio = false;
            }
            
        }
        private void lblTexto_1_MouseMove(object sender, MouseEventArgs e)
        {
            lblTexto_1.BackColor = Color.DarkGray;
        }

        private void lblTexto_1_MouseLeave(object sender, EventArgs e)
        {
            lblTexto_1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
        }

        private void btnBoton1_MouseMove(object sender, MouseEventArgs e)
        {
            btnBoton1.Cursor = Cursors.Hand;
        }

        private void btnBoton1_MouseLeave(object sender, EventArgs e)
        {
            btnBoton1.Cursor = Cursors.Arrow;
        }

        private void lklEtiquetaLink1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = e.Link.LinkData.ToString();
            if (!string.IsNullOrEmpty(url))
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }

            lklEtiquetaLink1.LinkColor = Color.Fuchsia;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void txtApellido_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Tiene " + txtApellido.Text.Length + " Caracteres");
        }
    }
}

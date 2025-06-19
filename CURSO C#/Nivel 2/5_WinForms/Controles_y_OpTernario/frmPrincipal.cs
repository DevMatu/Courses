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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(var item in Application.OpenForms)
            {
                if(item.GetType() == typeof(Form1))
                {
                    MessageBox.Show("YA EXISTE UNA VENTANA DE ESTE TIPO.");
                    return;
                }
            }

            Form1 ventana = new Form1();
            ventana.MdiParent = this;
            ventana.Show();
        }
    }
}

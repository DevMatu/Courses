using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tipo_DateTime_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrueba1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("La fecha es " + dtpFecha.Value.ToString("dd/MM/yyyy"));
            DateTime fecha;
            fecha = dtpFecha.Value;
            MessageBox.Show("La fecha es " + fecha.ToString("dd/MM/yyyy"));
        }
    }
}

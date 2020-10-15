using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJERCICIOS_DE_LA_SEMANA_3.Formularios
{
    public partial class frmlempirasadolar : Form
    {
        public frmlempirasadolar()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            Double lempiras, resultado;

            lempiras = int.Parse(txtlempiras.Text);
            resultado = lempiras / 24.61;
            txtdolares.Text = resultado.ToString();


        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtdolares.Clear();
            txtlempiras.Clear();

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}

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
    public partial class frmdiasandminutos : Form
    {
        public frmdiasandminutos()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtdias.Clear();
            txtminutos.Clear();

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int Dias, resultado;
            Dias = int.Parse(txtdias.Text);
            resultado = Dias * 1440;
            txtminutos.Text = resultado.ToString();

        }
    }
}

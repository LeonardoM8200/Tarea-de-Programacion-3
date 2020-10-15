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
    public partial class frmdobledenumero : Form
    {
        public frmdobledenumero()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtnumero.Clear();
            txtresultado.Clear();

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            Double numero, resultado;
            numero = int.Parse(txtnumero.Text);
            resultado = numero * 2;
            txtresultado.Text = resultado.ToString();

        }
    }
}

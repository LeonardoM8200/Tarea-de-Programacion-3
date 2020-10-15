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
    public partial class frmlempirasaeuros : Form
    {
        public frmlempirasaeuros()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txteuros.Clear();
            txtlempiras.Clear();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            Double Lempiras, resultado;
            Lempiras = int.Parse(txtlempiras.Text);
            resultado = Lempiras * 0.035;
            txteuros.Text = resultado.ToString();


        }
    }
}

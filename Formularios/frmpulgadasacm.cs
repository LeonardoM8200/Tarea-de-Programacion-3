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
    public partial class frmpulgadasacm : Form
    {
        public frmpulgadasacm()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtcentimetros.Clear();
            txtpulgadas.Clear();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            Double pulgadas, resultado;
            pulgadas = int.Parse(txtpulgadas.Text);
            resultado = pulgadas * 2.54;
            txtcentimetros.Text = resultado.ToString();
        }
    }
}

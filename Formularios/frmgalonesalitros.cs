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
    public partial class frmgalonesalitros : Form
    {
        public frmgalonesalitros()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Double galones, litros;
            galones = int.Parse(txtgalones.Text);
            litros = galones * 3.78541;
            txtlitros.Text = litros.ToString();

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtgalones.Clear();
            txtlitros.Clear();
        }
    }
}

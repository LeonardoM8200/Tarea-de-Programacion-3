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
    public partial class frmpagodellantas : Form
    {
        public frmpagodellantas()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtcantidad.Clear();
            txtpagar.Clear();
            txtprecio.Clear();

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            Double cantidad, precio, total;
            cantidad = int.Parse(txtcantidad.Text);
            precio = int.Parse(txtprecio.Text);
            total = cantidad * precio;

            txtpagar.Text = total.ToString();

        }
    }
}

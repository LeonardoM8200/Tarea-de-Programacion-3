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
    public partial class frmtotalapagarconstructor : Form
    {
        public frmtotalapagarconstructor()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtmetrostrabajados.Clear();
            txtpagopormetro.Clear();
            txttotal.Clear();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            Double pagoxmetro, metros, respuesta;
            pagoxmetro = int.Parse(txtpagopormetro.Text);
            metros = int.Parse(txtmetrostrabajados.Text);
            respuesta = pagoxmetro * metros;
            txttotal.Text = respuesta.ToString();

        }
    }
}

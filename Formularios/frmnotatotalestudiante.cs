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
    public partial class frmnotatotalestudiante : Form
    {
        public frmnotatotalestudiante()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtacumulativos.Clear();
            txtnombre.Clear();
            txtnotadeexamen.Clear();
            txttotal.Clear();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int acumulativos, examen, resultado;
            acumulativos = int.Parse(txtacumulativos.Text);
            examen = int.Parse(txtnotadeexamen.Text);
            resultado = acumulativos + examen;
            txttotal.Text = resultado.ToString();
        }
    }
}

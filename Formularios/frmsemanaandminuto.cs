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
    public partial class frmsemanaandminuto : Form
    {
        public frmsemanaandminuto()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtminutos.Clear();
            txtsemana.Clear();

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            Double semanas, resultado;
            semanas = int.Parse(txtsemana.Text);
            resultado = semanas * 10080;
            txtminutos.Text= resultado.ToString();


        }
    }
}

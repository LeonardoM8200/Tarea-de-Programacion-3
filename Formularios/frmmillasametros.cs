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
    public partial class frmmillasametros : Form
    {
        public frmmillasametros()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtmetros.Clear();
            txtmillas.Clear();

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            Double millas, resultado;
            millas = int.Parse(txtmillas.Text);

            resultado = millas * 1609.34;

            txtmetros.Text = resultado.ToString();



        }
    }
}

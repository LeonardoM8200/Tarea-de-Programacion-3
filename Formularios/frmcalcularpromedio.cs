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
    public partial class frmcalcularpromedio : Form
    {
        public frmcalcularpromedio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
	
		}

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtedad1.Clear();
            txtedad2.Clear();
            txtedad3.Clear();
            txtedad4.Clear();
            txtedad5.Clear();
            txtedad6.Clear();
            txtedad7.Clear();
            txtedad8.Clear();
            txtedad9.Clear();
            txtedad10.Clear();

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int edad1, edad2, edad3, edad4, edad5, edad6, edad7, edad8, edad9, edad10, resultado;
            edad1 = int.Parse(txtedad1.Text);
            edad2= int.Parse(txtedad2.Text);
            edad3 = int.Parse(txtedad3.Text);
            edad4 = int.Parse(txtedad4.Text);
            edad5 = int.Parse(txtedad5.Text);
            edad6 = int.Parse(txtedad6.Text);
            edad7 = int.Parse(txtedad7.Text);
            edad8 = int.Parse(txtedad8.Text);
            edad9 = int.Parse(txtedad9.Text);
            edad10 = int.Parse(txtedad10.Text);

            resultado = (edad1 + edad2 + edad3 + edad4 + edad5 + edad6 + edad7 + edad8 + edad9 + edad10) / 10;
            txtpromedio.Text = resultado.ToString();


        }
    }
}

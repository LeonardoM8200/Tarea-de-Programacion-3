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
    public partial class frmmillasakilometros : Form
    {
        public frmmillasakilometros()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtkilometros.Clear();
            txtmillas.Clear();

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            Double millas, km;
            millas = int.Parse(txtmillas.Text);

            km = millas * 1.609;
            txtkilometros.Text = km.ToString();


        }
    }
}

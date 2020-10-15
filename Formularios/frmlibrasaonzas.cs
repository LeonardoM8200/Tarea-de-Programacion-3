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
    public partial class frmlibrasaonzas : Form
    {
        public frmlibrasaonzas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtlibras.Clear();
            txtonzas.Clear();

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int libras, resultado;
            libras = int.Parse(txtlibras.Text);
            resultado = libras * 16;
            txtonzas.Text = resultado.ToString();

        }
    }
}

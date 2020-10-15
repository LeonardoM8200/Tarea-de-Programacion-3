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
    public partial class frmsalariomasaunmentox : Form
    {
        public frmsalariomasaunmentox()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtaumento.Clear();
            txtmontodeaunmento.Clear();
            txtpagofinal.Clear();
            txtsalario.Clear();


        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            float salario, aumento, ganancia, resultado;
            salario = float.Parse(txtsalario.Text);
            aumento = float.Parse(txtaumento.Text);
            ganancia = (salario * aumento);
            txtmontodeaunmento.Text = ganancia.ToString();
            resultado = salario + ganancia;
            txtpagofinal.Text = resultado.ToString();








        }
    }
}

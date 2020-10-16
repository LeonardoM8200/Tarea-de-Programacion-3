﻿using System;
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
    public partial class frmcuadradodeunnum : Form
    {
        public frmcuadradodeunnum()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtcuadrado.Clear();
            txtnumero.Clear();
            txtresultado.Clear();


        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double valor, potencia, resultado;
            valor = Convert.ToDouble(txtnumero.Text);
            potencia = Convert.ToDouble(txtcuadrado.Text);
            resultado = Math.Pow(valor, potencia);
            txtresultado.Text = resultado.ToString();



        }
    }
}
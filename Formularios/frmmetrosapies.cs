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
    public partial class frmmetrosapies : Form
    {
        public frmmetrosapies()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtmetros.Clear();
            txtpies.Clear();

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            Double metros, resultado;
            metros = int.Parse(txtmetros.Text);
            resultado = metros * 3.28084;
            txtpies.Text = resultado.ToString();

        }
    }
}

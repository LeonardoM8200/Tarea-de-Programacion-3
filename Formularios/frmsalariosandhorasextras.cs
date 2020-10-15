using System;
using System.Windows.Forms;

namespace EJERCICIOS_DE_LA_SEMANA_3.Formularios
{
    public partial class frmsalariosandhorasextras : Form
    {
        public frmsalariosandhorasextras()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtdiastrabajados.Clear();
            txthorasextras.Clear();
            txtpagoxdia.Clear();
            txttotal.Clear();
            txtpagoxhora.Clear();
            txtpagoxhoraextra.Clear();


        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double pagoxdia, pagoxhora, horasextras, pagoxhoraextra, diastrabajados, total;
            pagoxdia = int.Parse(txtpagoxdia.Text);
            pagoxhora = int.Parse(txtpagoxhora.Text);
            horasextras = int.Parse(txthorasextras.Text);
            pagoxhoraextra = pagoxhora * horasextras * 2;
            txtpagoxhoraextra.Text = pagoxhoraextra.ToString();
            diastrabajados = int.Parse(txtdiastrabajados.Text);
            total = pagoxdia * diastrabajados + pagoxhoraextra;
            txttotal.Text = total.ToString();
            
        }
    }
}

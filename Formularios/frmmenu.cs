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
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }

        private void frmmenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formularios.frmsumadenumeros numeros = new Formularios.frmsumadenumeros();
            numeros.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Formularios.frmpromedio promedio = new Formularios.frmpromedio();
            promedio.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Formularios.frmmillasametros millas = new Formularios.frmmillasametros();
            millas.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Formularios.frmmillasakilometros millasandmetros = new Formularios.frmmillasakilometros();
            millasandmetros.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Formularios.frmlempirasadolar lempirasanddolares = new Formularios.frmlempirasadolar();
            lempirasanddolares.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Formularios.frmlempirasaeuros lempirasandeuros = new Formularios.frmlempirasaeuros();
            lempirasandeuros.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Formularios.frmpagodellantas llantas = new Formularios.frmpagodellantas();
            llantas.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {

            Formularios.frmpagodeempleado Empleados = new Formularios.frmpagodeempleado();
            Empleados.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Formularios.frmsalariosandhorasextras pagosandextras = new Formularios.frmsalariosandhorasextras();
            pagosandextras.ShowDialog();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Formularios.frmsalariomasaunmentox pagosmaspagox = new Formularios.frmsalariomasaunmentox();
            pagosmaspagox.ShowDialog();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Formularios.frmgalonesalitros galonesalitros = new Formularios.frmgalonesalitros();
            galonesalitros.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Formularios.frmpulgadasacm pulgadasacm = new Formularios.frmpulgadasacm();
            pulgadasacm.ShowDialog();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Formularios.frmcuadradodeunnum cuadrado = new Formularios.frmcuadradodeunnum();
            cuadrado.ShowDialog();

        }

        private void button13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Edwin Leonardo Molina Flores");
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Formularios.frmsemanaandminuto semanaxminutos = new Formularios.frmsemanaandminuto();
            semanaxminutos.ShowDialog();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Formularios.frmdiasandminutos diasxminutos = new Formularios.frmdiasandminutos();
            diasxminutos.ShowDialog();

        }

        private void button17_Click(object sender, EventArgs e)
        {
            Formularios.frmlibrasaonzas librasaonzas = new Formularios.frmlibrasaonzas();
            librasaonzas.ShowDialog();

        }

        private void button18_Click(object sender, EventArgs e)
        {
            Formularios.frmcalcularpromedio edadpromedio = new Formularios.frmcalcularpromedio();
            edadpromedio.ShowDialog();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Formularios.frmcubo cubo = new Formularios.frmcubo();
            cubo.ShowDialog();

        }

        private void button21_Click(object sender, EventArgs e)
        {
            Formularios.frmdobledenumero doble = new frmdobledenumero();
            doble.ShowDialog();

        }

        private void button22_Click(object sender, EventArgs e)
        {
            Formularios.frmmetrosapies metrosxpies = new frmmetrosapies();
            metrosxpies.ShowDialog();

        }

        private void button23_Click(object sender, EventArgs e)
        {
            Formularios.frmtotalapagarconstructor pagoxconstructor = new frmtotalapagarconstructor();
            pagoxconstructor.ShowDialog();

        }

        private void button24_Click(object sender, EventArgs e)
        {
            Formularios.frmnotatotalestudiante totalestudiante = new frmnotatotalestudiante();
            totalestudiante.ShowDialog();

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FrmDatosPersonales : Form
    {
        public FrmDatosPersonales()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola: " + this.txtApellidos.Text + " " + this.txtNombre);
        }

        private void txtApellidos_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            //estructura secuencial
            String saludo = " ";//Cadena de caracteres
            saludo=this.txtNombre.Text+ " " + this.txtApellidos.Text;

            MessageBox.Show("Hola: " + saludo);
        }
    }
}

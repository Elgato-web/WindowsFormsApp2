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
            // estructuras repetitivas 
            for(int i=1; i<=10; i++)
            {
                saludo = saludo + System.Environment.NewLine;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //estructura secuencial
            String saludo = " ";//Cadena de caracteres
            
            saludo = this.txtNombre.Text + " " + this.txtApellidos.Text;

            MessageBox.Show("Hola: " + saludo);
            // estructuras repetitivas 
            string aux = " ";
            for (int i = 1; i <= 10; i++)
            {
                aux += saludo  + System.Environment.NewLine ;
            }
            this.txtResultado.Text = aux;
            //estructuras selectivas (condicionales)
            int a = 100;
            int b = 20;
            if (a > b)
                aux = aux + "a mayo b";
            else
                aux = aux + "a menor b";

            this.txtResultado.Text = aux;
        }
    }
}

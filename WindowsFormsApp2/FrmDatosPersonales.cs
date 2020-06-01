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
            string aux = "";
            for(int i=1; i<=10; i++)
            {
                aux += saludo + System.Environment.NewLine;
            }
            this.txtResultado.Text = aux;
            //estructuras selectivas (condicionales)
            int a = 100;
            int b = 20;
            if (a > b)
                aux = aux + "a mayor que  b";
            else
                aux = aux + "a menor que  b";

            this.txtResultado.Text = aux;
            this.getsaludos(saludo);//llama a la funcion 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
        //Procedimientos - funciones 
        //Las funciones devuelven valores
        //el procedimeinto es una funcion que no devuelve valor
        void getsaludos(string nombres){
            this.Nombres.Text = "Uso de funcion que no devueve valor(" + nombres + ")";


        }
        void ejemploporvalor (int x)
        {
            x = x + 5;
            MessageBox.Show("El nuevo valor de x: " + x.ToString());
                }
           
                
        void ejemploporreferencia (ref int a)
        {//la funcion recibe la variable original (direccion de memoria )//cualquier cambio en esta variable se refleja en la original
            a = a + 100;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int x = 5;
            int y = 200;
            //ejemplopasoporvalor(x);
            // ejemploporreferencia(ref x);
            //this.txtvalor.Text = x.ToString();
            ejemploporParametrosOpcionales(20, y);
            this.txtvalor.Text = x.ToString();

        }
        //paso de parametros opcionales
        void ejemploporParametrosOpcionales(int x, int y=10)
        {
            x = x + y;
            MessageBox.Show("Parametro Opcional " + y.ToString());
            MessageBox.Show("El nuevo de valor de x " + x.ToString());
        }
}
}

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
    public partial class FrmdeBinarioaenteros : Form
    {
        public FrmdeBinarioaenteros()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cantidad = 0;
            
            string modus = "";
            if (checkBox1.Checked == true)
            {
                int  k=2,equivalencia=0;
                equivalencia =(int)Math.Pow(k, 9);
                cantidad += equivalencia;

            }
            if (checkBox2.Checked == true)
            {
                int k = 2, equivalencia = 0;
                equivalencia = (int)Math.Pow(k, 8);
                cantidad += equivalencia;

            }
            if (checkBox3.Checked == true)
            {
                int k = 2, equivalencia = 0;
                equivalencia = (int)Math.Pow(k, 7);
                cantidad += equivalencia;

            }
            if (checkBox4.Checked == true)
            {
                int k = 2, equivalencia = 0;
                equivalencia = (int)Math.Pow(k, 6);
                cantidad += equivalencia;

            }
            if (checkBox5.Checked == true)
            {
                int k = 2, equivalencia = 0;
                equivalencia = (int)Math.Pow(k,5);
                cantidad += equivalencia;

            }
            if (checkBox6.Checked == true)
            {
                int k = 2, equivalencia = 0;
                equivalencia = (int)Math.Pow(k, 4);
                cantidad += equivalencia;

            }
            if (checkBox7.Checked == true)
            {
                int k = 2, equivalencia = 0;
                equivalencia = (int)Math.Pow(k, 3);
                cantidad += equivalencia;

            }
            if (checkBox8.Checked == true)
            {
                int k = 2, equivalencia = 0;
                equivalencia = (int)Math.Pow(k, 2);
                cantidad += equivalencia;

            }
            if (checkBox9.Checked == true)
            {
                int k = 2, equivalencia = 0;
                equivalencia = (int)Math.Pow(k, 1);
                cantidad += equivalencia;

            }
            if (checkBox10.Checked == true )
            {
                int k = 2, equivalencia = 0;
                equivalencia = (int)Math.Pow(k, 0);
                cantidad += equivalencia;

            }

            modus = cantidad.ToString();
            textBox1.Text = modus;
           
        }
      
        
    }
}

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
    public partial class FrmNumerosEnteros : Form
    {
        public FrmNumerosEnteros()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
        void Checkbox_entero(int num)
        {
            int[] vector = new int[8];
            int posicion = 0, i = 0;
            while (num >= 0)
            {
                posicion = (int)Math.Pow(num, i);
                vector[i++] = posicion;

            }
            i = 0;
            foreach (int j in vector)
            {
                if (i == 0) this.checkBox1.Checked = j == 0 ? true : false;
                if (i == 1) this.checkBox2.Checked = j == 1 ? true : false;
                if (i == 2) this.checkBox3.Checked = j == 2 ? true : false;
                if (i == 3) this.checkBox4.Checked = j == 3 ? true : false;
                if (i == 4) this.checkBox5.Checked = j == 4 ? true : false;
                if (i == 5) this.checkBox6.Checked = j == 5 ? true : false;
                if (i == 6) this.checkBox7.Checked = j == 6 ? true : false;
                if (i == 7) this.checkBox8.Checked = j == 7 ? true : false;
                i++;
            }
        }

        private void btbcalcular_Click(object sender, EventArgs e)
        {
            int num =int.Parse(this.groupBox1.Text);
            Checkbox_entero(num);
        }
    }
}

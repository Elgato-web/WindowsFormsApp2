﻿using System;
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
    public partial class FrmBinario : Form
    {
        public FrmBinario()
        {
            InitializeComponent();
        }

        private void FrmBinario_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        void binario (int num)
        {
            int[] vector = new int[8];
            int residuo =0, i=0;
            while (num > 0)
            {
                residuo = num % 2;
                vector[i++] = residuo;
                num /= 2;
            }
            i = 0;
            foreach (int k in vector)
            {
                if (i == 7) this.checkBox1.Checked = k == 1 ? true : false;
                if (i == 6) this.checkBox2.Checked = k == 1 ? true : false;
                if (i == 5) this.checkBox3.Checked = k == 1 ? true : false;
                if (i == 4) this.checkBox4.Checked = k == 1 ? true : false;
                if (i == 3) this.checkBox5.Checked = k == 1 ? true : false;
                if (i == 2) this.checkBox6.Checked = k == 1 ? true : false;
                if (i == 1) this.checkBox7.Checked = k == 1 ? true : false;
                if (i == 0) this.checkBox8.Checked = k == 1 ? true : false;
                i++;
            }
        }

        private void btnconvertir_Click(object sender, EventArgs e)
        {
            if (this.txtnumero.Text.Length == 0)
            {
                MessageBox.Show("Debe Ingresar un entero...");
                return;//Abandonar ejecución
            }

            int num =int.Parse( this.txtnumero.Text);
            binario(num);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }
    }
}

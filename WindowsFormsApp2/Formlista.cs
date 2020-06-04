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
    public partial class Formlista : Form
    {
        public Formlista()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (this.txtnombre.Text.Length > 0)
            {
                this.lstNombres.Items.Add(this.txtnombre.Text);
                this.txtnombre.Text = "";
            }
        }

        private void text_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnagregar_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            

        }

        private void txtnombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                if (this.txtnombre.Text.Length > 0)
                {
                    this.lstNombres.Items.Add(this.txtnombre.Text);
                    this.txtnombre.Text = "";
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalsChooseApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            var animalist = "Choosen Animals: ";

            foreach (Control c in Controls)
            {
                if ((c is CheckBox) && ((CheckBox)c).Checked)
                    animalist += c.Text + ", ";
            }
            textBox1.Text = animalist;
        }
    }
}

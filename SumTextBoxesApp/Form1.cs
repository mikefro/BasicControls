using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SumTextBoxesApp
{
    public partial class form : Form
    {
        public form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(short.Parse(textBox2.Text) + short.Parse(textBox1.Text));
        }

        internal static void ClearAllControls(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
            }
        }

                private void button2_Click(object sender, EventArgs e)
        {
            ClearAllControls(this);
        }

        private void SumTextBoxApp_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBoxStatusApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
   
        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                MessageBox.Show("Checkbox is checked");
            }
            else
            {
                MessageBox.Show("Checkbox is unchecked");
            }
        }
   
        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                MessageBox.Show("Checkbox is checked");
            }
            else
            {
                MessageBox.Show("Checkbox is unchecked");
            }
        }
    }
}

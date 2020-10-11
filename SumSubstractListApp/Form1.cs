﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SumSubstractApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
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
        }
        private void button3_Click(object sender, EventArgs e)
        {
            ClearAllControls(this);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox3.Text = listBox1.SelectedItem.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var result = new Int32();
            var op1 = new Int32();
            var op2 = new Int32();

            op1 = Int32.Parse(textBox2.Text);
            op2 = Int32.Parse(textBox1.Text);

            if (textBox3.Text == "+")
                result = op1 + op2;

            if (textBox3.Text == "-")
                result = op1 - op2;

            textBox4.Text = Convert.ToString(result);
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            textBox3.Text = listBox1.SelectedItem.ToString();


        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBoxClassroomApp
{


    public partial class Form1 : Form
    {
        public static List<string> classroom1 = new List<string> { "Ana", "Julian", "Juan", "Vicente", "Alfredo" };
        public static List<string> classroom2 = new List<string> { "Monica", "Marta", "Roberto", "Pilar", "Alejandro" };

        public Form1()
        {
            InitializeComponent();
            
        }

        /// <summary>
        /// A method that can clear any Listbox; just put the Listbox name that you want clean like argument 
        /// Also clean the textbox1 in this app
        /// </summary>
        /// <param name="lb"></param>
        private void ClearListbox(ListBox lb)
        {
            lb.DataSource = null;
            lb.Items.Clear();
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearListbox(listBox1);
            listBox1.DataSource = classroom2;
        }

        public void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearListbox(listBox1);
            listBox1.DataSource = classroom1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClearListbox(listBox1);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.DataSource != null)
                textBox1.Text = listBox1.SelectedItem.ToString();
            else
                textBox1.Text = "";
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("you just clicked a button");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var firstName = textBoxfirstname.Text;
           
            {
                MessageBox.Show(firstName == ""?" please fill in the first name":firstName);
            }
            
            
        }
    }
}

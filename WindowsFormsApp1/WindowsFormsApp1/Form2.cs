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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            var FirstNumber = Convert.ToDouble(textBox1.Text);
                var SecondNumber = Convert.ToDouble(textBox2.Text);
            textBox3.Text = (FirstNumber + SecondNumber).ToString();
                

        }
   
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

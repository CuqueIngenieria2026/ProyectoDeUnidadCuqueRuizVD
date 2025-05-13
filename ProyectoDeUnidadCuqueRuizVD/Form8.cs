using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDeUnidadCuqueRuizVD
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        Double g=0, lb=0, op1=0,op2=0;

        private void button3_Click(object sender, EventArgs e)
        {
     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 cambio17 = new Form1();
            this.Hide();
            cambio17.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            g=Convert.ToDouble(textBox1.Text);
            op1 = g * 0.0022046;
            textBox2.Text = ("" + op1);
        }
    }
}

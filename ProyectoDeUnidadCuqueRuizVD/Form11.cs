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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }
        Double t=0, kg=0, op1=0, op2=0;

        private void button3_Click(object sender, EventArgs e)
        {
      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 cambio20 = new Form1();
            this.Hide();
            cambio20.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            t=Convert.ToDouble(textBox1.Text);
            op1 = t * 1000;
            textBox2.Text = ("" + op1);
        }
    }
}

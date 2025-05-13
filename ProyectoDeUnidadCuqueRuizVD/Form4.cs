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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        Double lb=0, kg=0, op1=0, op2=0;

        private void button3_Click(object sender, EventArgs e)
        {
     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 cambio13 = new Form1();
            this.Hide();
            cambio13.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lb=Convert.ToDouble(textBox1.Text);
            op1 = lb * 0.4536;
            textBox2.Text = ("" + op1);
        }
    }
}

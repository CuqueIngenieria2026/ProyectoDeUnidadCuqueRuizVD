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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        Double kg=0, mg=0, op1=0, op2=0;

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 cambio18 = new Form1();
            this.Hide();
            cambio18.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kg = Convert.ToDouble(textBox1.Text);
            op1 = kg * 1000000;
            textBox2.Text = ("" + op1);
        }
    }
}

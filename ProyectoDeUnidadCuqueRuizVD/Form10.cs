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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }
        Double oz=0, lb=0, op1=0, op2=0;

        private void button3_Click(object sender, EventArgs e)
        {
        

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 cambio19 = new Form1();
            this.Close();
            cambio19.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            oz=Convert.ToDouble(textBox1.Text);
            op1 = oz * 0.0625;
            textBox2.Text = ("" + op1);
        }
    }
}

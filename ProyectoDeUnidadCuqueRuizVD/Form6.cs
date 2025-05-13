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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        Double oz=0, t=0, op1=0, op2=0;

        private void button3_Click(object sender, EventArgs e)
        {
  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 cambio15 = new Form1();
            this.Hide();    
            cambio15.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            oz=Convert.ToDouble(textBox1.Text);
            op1 = oz * 0.00002835;
            textBox2.Text = ("" + op1);
        }
    }
}

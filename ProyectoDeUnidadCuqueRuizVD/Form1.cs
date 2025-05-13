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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kilogramoskgAGramosgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 cambio1 = new Form2();
            this.Hide();
            cambio1.Show();
           
        }

        private void gramosgAMiligramosmgToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Form3 cambio2 = new Form3();
            this.Hide();
            cambio2.Show();
          
        }

        private void librasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 cambio3 = new Form4();
            this.Hide();
            cambio3.Show();
            
        }

        private void kilogramoskgAOnzasozToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 cambio4 = new Form5();
            this.Hide();
            cambio4.Show();
            
        }

        private void libraslbToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 cambio5 = new Form6();
            this.Hide();
            cambio5.Show();
            
        }

        private void onzasozAGramosgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 cambio6 = new Form7();
            this.Hide();
            cambio6.Show();
          
        }

        private void gramosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 cambio7 = new Form8();
            this.Hide();
            cambio7.Show();
            
        }
        
        private void kilogramoskgALibraslbToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 cambio8 = new Form9();
            this.Hide();
            cambio8.Show();
            
        }

        private void onzasozALibraslbToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 cambio9 = new Form10();
            this.Hide();
            cambio9.Show();
           
        }

        private void toneladatAKilogramoskgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11 cambio10 = new Form11();
            this.Hide();
            cambio10.Show();
            
        }
    }
}

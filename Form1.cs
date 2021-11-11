using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C_sharp_vj2;

namespace C_sharp_vj2
{
    public partial class Form1 : Form
    {
        // instanciramo objekt 
        QuadraticEquation qe;
        
        public Form1()
        {
            InitializeComponent();
            // konstruktor defaultni prazni od qe
            qe = new QuadraticEquation();

            // dodajemo u konstruktor
            functionPanel1.Function = new Function(qe.Y);
            functionPanel1.Invalidate(); // što znači invaldate? 
            // postoji refreshing rate, osježi se slika/panel 
        }

        // nova metoda
        public void FillResults()
        {
            //kreirali smo u QuadraticEq public double a, b i c i metode get i set
            qe.A = (double)numericUpDown1.Value; // NumericUpDown barata s decimal, pa moramo castati u double
            qe.B = (double)numericUpDown2.Value;
            qe.C = (double)numericUpDown3.Value;
            textBox1.Text = qe.Discriminant.ToString();
            textBox2.Text = qe.Roots[0].ToString(); // Roots vraća u double, a textbox prima samo string
            textBox3.Text = qe.Roots[1].ToString();
            functionPanel1.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FillResults();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            FillResults();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            FillResults();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            FillResults();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_Лабораторна
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textL1.Text);
            double b = Convert.ToDouble(textL2.Text);
            a = a + b;
            textL1.Text = Convert.ToString(a);
            textL2.Text = Convert.ToString(a);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textL1.Text);
            double b = Convert.ToDouble(textL2.Text);
            a = a - b;
            textL1.Text = Convert.ToString(a);
            textL2.Text = Convert.ToString(a);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textL1.Text);
            double b = Convert.ToDouble(textL2.Text);
            a = a * b;
            textL1.Text = Convert.ToString(a);
            textL2.Text = Convert.ToString(a);
        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double[] masiv = new double[2];
            TPTriangle l = new TPTriangle(textL1.Text, textL2.Text);
            masiv = l.S();
            toolStripStatusLabel1.Text = "S1 = " + masiv[0];
            toolStripStatusLabel2.Text = "P2 = " + masiv[1];
        }

        private void vToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double[] masiv = new double[2];
            TPTriangle l = new TPTriangle(textL1.Text, textL2.Text);
            masiv = l.P();
            toolStripStatusLabel1.Text = "P1 = " + masiv[0];
            toolStripStatusLabel2.Text = "P2 = " + masiv[1];
        }

        private void comprasionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TPTriangle l = new TPTriangle(textL1.Text, textL2.Text);
            toolStripStatusLabel1.Text = "Result : ";
            toolStripStatusLabel2.Text = l.comprasion().ToString();
        }

        private void sToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            double[] masiv = new double[2];
            TPPiramid l = new TPPiramid(textL1.Text, textL2.Text);
            masiv = l.Spiramid();
            toolStripStatusLabel1.Text = "S piramid1 = " + masiv[0];
            toolStripStatusLabel2.Text = "S piramid2 = " + masiv[1];
        }

        private void pToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double[] masiv = new double[2];
            TPPiramid l = new TPPiramid(textL1.Text, textL2.Text);
            masiv = l.Ppiramid();
            toolStripStatusLabel1.Text = "P piramid1 = " + masiv[0];
            toolStripStatusLabel2.Text = "P piramid2 = " + masiv[1];
        }

        private void vToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            double[] masiv = new double[2];
            TPPiramid l = new TPPiramid(textL1.Text, textL2.Text);
            masiv = l.Vpiramid();
            toolStripStatusLabel1.Text = "V piramid1 = " + masiv[0];
            toolStripStatusLabel2.Text = "V piramid2 = " + masiv[1];
        }
    }
}

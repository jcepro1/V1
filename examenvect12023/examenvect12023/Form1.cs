using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examenvect12023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Vector v1, v2, v3;
        Nent n1, n2, n3;

        private void Form1_Load(object sender, EventArgs e)
        {
            v1 = new Vector();
            v2 = new Vector();
            v3 = new Vector();
            n1 = new Nent();
            n2 = new Nent();
            n3 = new Nent();

        }

        //CARGAR1

        private void cARGARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.cargardato(int.Parse(textBox1.Text));
            textBox6.Text = string.Concat(v1.descargar());

        }

        private void cARGARRNDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.Cargar_rnd(int.Parse(textBox1.Text), int.Parse(textBox4.Text), int.Parse(textBox5.Text));
            textBox6.Text = string.Concat(v1.descargar());
        }

        private void dESCARGARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox7.Text = string.Concat(v1.descargar());
        }
        //P1
        private void pREGUNTA1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v2 = new Vector();
            v3 = new Vector();
            int m, a, b;
            m = Int32.Parse(textBox1.Text);
            a = Int32.Parse(textBox2.Text);
            b = Int32.Parse(textBox3.Text);
            v1.examen7p1(v2, v3, a, b);
            textBox8.Text = v2.descargar();
            textBox9.Text = v3.descargar();
        }
        //P2
        private void pREGUNTA2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

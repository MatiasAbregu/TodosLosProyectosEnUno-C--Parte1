using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * DESARROLLADO POR MATIAS ABREGÚ
 * 
 */

namespace TodosLosProyectosEnUno_C__Parte1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cursorPorEncima(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Form2().Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new Form3().Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new Form4().Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            new Form5().Visible = true;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            new Form6().Visible = true;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            new Form7().Visible = true;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            new Form8().Visible = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            new Form9().Visible = true;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            new Form10().Visible = true;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            new Form11().Visible = true;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            new Form12().Visible = true;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            new Form13().Visible = true;
        }
    }
}

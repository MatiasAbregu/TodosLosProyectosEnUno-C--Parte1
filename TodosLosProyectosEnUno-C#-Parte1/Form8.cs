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
 * 7) Formulario de alta de asientos de gastos pagados en efectivo. Se requiere datos de nombre 
 * cuenta de gasto, valor y fecha. Al presionar el boton debe mostrarse en una Label. El formato
 * del asiento es:
 *  fecha
 *  gasto			    debe	haber
 *  nombreCuentaDeGasto	 x	      0
 *  a Caja			     0        x
 * 
 */

namespace TodosLosProyectosEnUno_C__Parte1
{
    public partial class Form8 : Form
    {

        private int numFila = 0;

        public Form8()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsPunctuation(e.KeyChar) || Char.IsNumber(e.KeyChar))
            {
                MessageBox.Show("No se admiten números ni signos de puntuación en este campo.");
                e.Handled = true;
                return;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("No se admiten letras en este campo.");
                e.Handled = true;
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            if (textBox1.Text == "" || textBox2.Text == "")
                MessageBox.Show("Falta rellenar uno o varios de los campos.");
            else
            {
                if(dateTimePicker1.Value.Date > DateTime.Now.Date)
                {
                    MessageBox.Show("No se pueden registrar fechas a futuro.");
                    return;
                }

                dataGridView1.Rows.Add();
                dataGridView1.Rows.Add();
                dataGridView1.Rows[numFila].Cells[0].Value = dateTimePicker1.Value.ToShortDateString();
                dataGridView1.Rows[numFila].Cells[1].Value = textBox1.Text;
                dataGridView1.Rows[numFila].Cells[2].Value = "---";
                dataGridView1.Rows[numFila].Cells[3].Value = textBox2.Text;
                numFila++;
                dataGridView1.Rows[numFila].Cells[0].Value = dateTimePicker1.Value.ToShortDateString();
                dataGridView1.Rows[numFila].Cells[1].Value = "Caja";
                dataGridView1.Rows[numFila].Cells[2].Value = textBox2.Text;
                dataGridView1.Rows[numFila].Cells[3].Value = "---";
                numFila++;

            }
        }
    }
}

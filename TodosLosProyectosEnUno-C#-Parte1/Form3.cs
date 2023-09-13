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
 * 2) Formulario de carga de datos de una persona con datos: nombre, apellido, 
 * fecha de nacimiento. Al agregar debe anexarse (nombre, apellido, edad) a los demás dados de 
 * alta, visualizados en una Label.
 * 
 */

namespace TodosLosProyectosEnUno_C__Parte1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(dateTimePicker1.Value.Year > DateTime.Now.Year) {
                MessageBox.Show("Por favor... Una fecha válida...");
                return;
            }

            if(textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Falta rellenar uno/varios de los campos.");
            } else
            {
                textBox4.AppendText($"Nombre: {textBox1.Text}\r\n" +
                    $"Apellido: {textBox2.Text}\r\n" +
                    $"Edad: {DateTime.Now.Year - dateTimePicker1.Value.Year} \r\n\r\n");
                textBox1.Text = "";
                textBox2.Text = "";
                dateTimePicker1.Value = DateTime.Now;
            }
        }

        private void ControlarNumerosYPuntuacion(object sender, KeyPressEventArgs e)
        {
            if(Char.IsNumber(e.KeyChar) || Char.IsPunctuation(e.KeyChar))
            {
                MessageBox.Show("No se admiten números o signos de puntuación.");
                e.Handled = true;
                return;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

/*
 * DESARROLLADO POR MATIAS ABREGÚ
 * 
 * 4) Formulario de carga de los datos de un automóvil: Patente, Modelo y año. Al presionar 
 * Agregar debe anexarse a los demás dados de alta (junto a la antigüedad), visualizados en una 
 * Label.
 * 
 */

namespace TodosLosProyectosEnUno_C__Parte1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
                MessageBox.Show("Falta rellenar uno/varios de los campos.");
            else
            {
                if (dateTimePicker1.Value.Date > DateTime.Now.Date)
                {
                    MessageBox.Show("No se puede registrar un auto futurista.");
                    return;
                }

                textBox4.AppendText(
                    $"Patente: {textBox1.Text}\r\n" +
                    $"Modelo: {textBox2.Text}\r\n" +
                    $"Antigüedad: {DateTime.Now.Year - dateTimePicker1.Value.Year} \r\n\r\n");
                textBox1.Text = "";
                textBox2.Text = "";
                dateTimePicker1.Value = DateTime.Now;
            }
        }
    }
}

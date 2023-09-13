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
 * 3) Formulario de carga de notas de un alumno con datos: nombre, apellido, fecha y nota. 
 * Al presionar Agregar debe anexarse a los demás dados de alta, visualizados en una Label. 
 * Al final de los registros tiene que calcular un promedio general de todas las notas.
 * 
 */

namespace TodosLosProyectosEnUno_C__Parte1
{
    public partial class Form4 : Form
    {

        private float promedioGen, cantRegistros = 0, sumaDeNotas;

        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {       

            try
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
                    MessageBox.Show("Falta rellenar uno/varios de los campos.");
                else
                {
                    if (dateTimePicker1.Value.Date > DateTime.Now)
                    {
                        MessageBox.Show("No se puede registrar una fecha del futuro.");
                        return;
                    }
                    else if (float.Parse(textBox3.Text) > 10 || float.Parse(textBox3.Text) < 0)
                    {
                        MessageBox.Show("Este sistema no admite notas mayores a 10 ni tampoco menores a 0.");
                        return;
                    }

                    if (textBox3.Text.Contains(".")) textBox3.Text = textBox3.Text.Replace(".", ",");

                    textBox4.AppendText($"Nombre del Alumno: {textBox1.Text} \r\n" +
                    $"Apellido del Alumno: {textBox2.Text} \r\n" +
                    $"Nota: {textBox3.Text} \r\n" +
                    $"Nota registada el: {dateTimePicker1.Value.ToShortDateString()} \r\n\r\n");
                    cantRegistros++;
                    sumaDeNotas += float.Parse(textBox3.Text);
                    promedioGen = sumaDeNotas / cantRegistros;
                    label5.Text = $"Promedio General: {promedioGen}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Uno de los campos no es válido.");
            }
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("No se admiten letras.");
                e.Handled = true;
                return;
            }
        }

        private void NoAdmitirNumeros(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                MessageBox.Show("No se admiten números.");
                e.Handled = true;
                return;
            }
        }
    }
}

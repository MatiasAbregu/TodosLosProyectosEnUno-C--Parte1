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
 * 8) Formulario de alta de partidos de un deporte donde pida nombre del equipo A, nombre del 
 * Equipo B, cantidad de puntos de A y cantidad de puntos de B. Hay 2 botones (ganaMenor 
 * ganaMayor) Al presionar el boton alguno debe agregarse el partido a los cargados 
 * anteriormente en una Label (ademas de la diferencia de puntos entre A y B, el criterio 
 * -ganaMenor o ganaMayor- y quien fue el ganador).
 * 
 */

namespace TodosLosProyectosEnUno_C__Parte1
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void ControlarLetras(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsSymbol(e.KeyChar))
            {
                MessageBox.Show("¡No se admiten letras ni signos de puntuación en este campo!");
                e.Handled = true;
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" ||
                textBox4.Text == "")
                MessageBox.Show("Todos los campos deben ser rellenados.");
            else
            {
                try
                {
                    textBox5.AppendText(
                    $"Nombre Equipo A: {textBox1.Text} \r\n" +
                    $"Nombre Equipo B: {textBox2.Text} \r\n" +
                    $"Puntaje Equipo A: {textBox3.Text} \r\n" +
                    $"Puntaje Equipo B: {textBox4.Text} \r\n" +
                    $"Criterio de victoria: GANA EL PUNTAJE MENOR\r\n");
                    if (int.Parse(textBox3.Text) < int.Parse(textBox4.Text))
                        textBox5.AppendText($"Ganador: {textBox1.Text}\r\n\r\n");
                    else if (int.Parse(textBox3.Text) > int.Parse(textBox4.Text))
                        textBox5.AppendText($"Ganador: {textBox2.Text}\r\n\r\n");
                    else
                        textBox5.AppendText($"¡¡EMPATE!! \r\n\r\n");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Uno de los campos tiene un valor no válido.");
                };
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" ||
                textBox4.Text == "")
                MessageBox.Show("Todos los campos deben ser rellenados.");
            else
            {
                try
                {
                    textBox5.AppendText(
                    $"Nombre Equipo A: {textBox1.Text} \r\n" +
                    $"Nombre Equipo B: {textBox2.Text} \r\n" +
                    $"Puntaje Equipo A: {textBox3.Text} \r\n" +
                    $"Puntaje Equipo B: {textBox4.Text} \r\n" +
                    $"Criterio de victoria: GANA EL PUNTAJE MAYOR\r\n");
                    if (int.Parse(textBox3.Text) > int.Parse(textBox4.Text))
                        textBox5.AppendText($"Ganador: {textBox1.Text}\r\n\r\n");
                    else if (int.Parse(textBox3.Text) < int.Parse(textBox4.Text)) 
                        textBox5.AppendText($"Ganador: {textBox2.Text}\r\n\r\n");
                    else
                        textBox5.AppendText($"¡¡EMPATE!! \r\n\r\n");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Uno de los campos tiene un valor no válido.");
                };

            }
        }
    }
}

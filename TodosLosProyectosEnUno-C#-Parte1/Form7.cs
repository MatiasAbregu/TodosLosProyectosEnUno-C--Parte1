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
 * 6) Formulario que tenga 2 TextBox (menor y mayor) para ingresar valores enteros. Debe 
 * verificar que el valor de uno sea menor al otro. Debe haber 2 botones (rango aumentado de a 
 * 1 y rango aumentado de a 2) que muestre el rango de números entre menor y mayor (aumentado de
 * a 1 o de a 2, dependiendo cual boton se presiono).
 * 
 */

namespace TodosLosProyectosEnUno_C__Parte1
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void VerificarSoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsSymbol(e.KeyChar))
            {
                MessageBox.Show("No se admiten letras, signos de puntuación o simbolos.");
                e.Handled = true;
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Uno o ambos campos no pueden estar vacios.");
            }
            else
            {
                textBox4.Text = "";

                if (int.Parse(textBox1.Text) == int.Parse(textBox2.Text))
                {
                    MessageBox.Show("Los números no deben ser iguales.");
                    return;
                }
                else if (int.Parse(textBox1.Text) > int.Parse(textBox2.Text))
                {
                    for (int i = int.Parse(textBox2.Text); i <= int.Parse(textBox1.Text); i++)
                    {
                        textBox4.AppendText(i.ToString() + ", ");
                    }
                }
                else
                {
                    for (int i = int.Parse(textBox1.Text); i <= int.Parse(textBox2.Text); i++)
                    {
                        textBox4.AppendText(i.ToString() + ", ");
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Uno o ambos campos no pueden estar vacios.");
            }
            else
            {
                textBox4.Text = "";

                if (int.Parse(textBox1.Text) == int.Parse(textBox2.Text))
                {
                    MessageBox.Show("Los números no deben ser iguales.");
                    return;
                }
                else if (int.Parse(textBox1.Text) > int.Parse(textBox2.Text))
                {
                    for (int i = int.Parse(textBox2.Text); i <= int.Parse(textBox1.Text); i+=2)
                    {
                        textBox4.AppendText(i.ToString() + ", ");
                    }
                }
                else
                {
                    for (int i = int.Parse(textBox1.Text); i <= int.Parse(textBox2.Text); i+=2)
                    {
                        textBox4.AppendText(i.ToString() + ", ");
                    }
                }
            }
        }
    }
}

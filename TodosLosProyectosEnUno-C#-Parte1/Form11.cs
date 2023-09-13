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
 * 10) Generar un formulario que tenga un TextBox para cargar un valor y un boton (dividir). Al
 * presionar debe mostrar en una Label 2 mitades del valor cargado. Cada vez que se presiona el
 * boton parte las mitades en mitades Ej:									
 *  veces presionadas	valorTextBox 
 *  1	label =	valorTextBox/2	valorTextBox/2
 *  2	label =	valorTextBox/4	valorTextBox/4	valorTextBox/4	valorTextBox/4
 *  n	label =	partir 2n veces valorTextBox en partes de valor= valorTextBox/2n
 * 
 */

namespace TodosLosProyectosEnUno_C__Parte1
{
    public partial class Form11 : Form
    {
        private int numVecesPres = 0;
        private double valor;

        public Form11()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsSymbol(e.KeyChar))
            {
                MessageBox.Show("No se admiten ni simbolos ni letras.");
                e.Handled = true;
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("Rellena el campo.");
            else
            {
                try
                {
                    if (textBox1.Text.Contains(".")) textBox1.Text = textBox1.Text.Replace(".", ",");
                    if(numVecesPres == 0) valor = double.Parse(textBox1.Text);
                    
                    numVecesPres++;
                    valor /= 2; 
                    textBox4.AppendText($"Veces presionado: {numVecesPres}\r\n" +
                        $"Valor: {valor}\r\n\r\n");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ingresa un valor válido.");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox4.Text = "";
            numVecesPres = 0;
            valor = 0;
        }
    }
}

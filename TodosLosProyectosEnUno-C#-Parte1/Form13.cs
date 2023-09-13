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
 * 12) Formulario de registro de pago: 2 TextBox (1 que permita ingresar un monto y otro el 
 * nombre) y 2 Botones (en efectivo y con tarjeta). Al presionar en efectivo debe tener un 
 * descuento del 10%, con tarjeta el precio de lista. Esto se ve en una label provisoria. Debe 
 * haber otro boton que diga agregar que debe agregar en otra Label (junto con las cargadas 
 * anteriormente) y vaciar la label provisoria donde esta el calculo.
 * 
 */

namespace TodosLosProyectosEnUno_C__Parte1
{
    public partial class Form13 : Form
    {

        private double total = 0;

        public Form13()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
                MessageBox.Show("Falta rellenar uno o varios de los campos.");
            else
            {
                try
                {
                    if (textBox2.Text.Contains(".")) textBox2.Text = textBox2.Text.Replace(".", ",");
                    textBox3.Text = $"Nombre del Producto: {textBox1.Text} \r\n" +
                        $"Precio del producto: {textBox2.Text} \r\n" +
                        $"Precio del producto con descuento por usar efectivo: " +
                        $"{double.Parse(textBox2.Text) - (double.Parse(textBox2.Text) * 10) / 100}";
                    total += double.Parse(textBox2.Text) - (double.Parse(textBox2.Text) * 10) / 100;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El monto es invalido.");
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
                MessageBox.Show("Falta rellenar uno o varios de los campos.");
            else
            {
                try
                {
                    if (textBox2.Text.Contains(".")) textBox2.Text = textBox2.Text.Replace(".", ",");
                    textBox3.Text = $"Nombre del Producto: {textBox1.Text} \r\n" +
                        $"Precio del producto: {textBox2.Text} \r\n";
                    total += double.Parse(textBox2.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El monto es invalido.");
                }
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

        private void button3_Click(object sender, EventArgs e)
        {
            if(textBox3.Text == "") MessageBox.Show("El campo temporal está vacio. Introduce un producto");
            else
            {
                label3.Text = $"Total: {total}";
                textBox4.AppendText(textBox3.Text + "\r\n\r\n");
                textBox3.Text = "";
                textBox2.Text = "";
                textBox1.Text = "";
            }
        }
    }
}

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
 * 1) Hacer un formulario de carga de compras de producto con datos: nombre, cantidad, precio.
 * Al agregar debe anexarse a los demás dados de alta, visualizados en una Label, junto al 
 * importe total (precio * cantidad) por renglon.
 * 
 */

namespace TodosLosProyectosEnUno_C__Parte1
{
    public partial class Form2 : Form
    {
        
        private double total;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Falta rellenar uno/varios de los campos.");
            } else
            {
                try {

                    if (textBox2.Text.Contains(".")) textBox2.Text = textBox2.Text.Replace(".", ",");
                    if (textBox3.Text.Contains(".")) textBox3.Text = textBox3.Text.Replace(".", ","); 

                    total += double.Parse(textBox3.Text) * double.Parse(textBox2.Text);
                    textBox4.AppendText($"Nombre de Producto: {textBox1.Text} \r\n" +
                                    $"Cantidad: {textBox2.Text} \r\n" +
                                    $"Precio: ${textBox3.Text} \r\n" +
                                    $"Importe total: ${double.Parse(textBox3.Text) * double.Parse(textBox2.Text)}\r\n\r\n");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    label4.Text = $"Importe final: ${total}";
                } catch(Exception ex) {
                    MessageBox.Show("En uno de los campos se introdujo algo no válido.");
                }       
            }
        }

        private void ControlarLetras(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("En estos campos no se admiten letras.");
                e.Handled = true;
                return;
            }
        }
    }
}

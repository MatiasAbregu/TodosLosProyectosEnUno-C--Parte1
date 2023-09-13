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
 * 5) Formulario de contacto que tome un nickname, mail y mensaje. Al agregar debe anexarse a 
 * los demás dados de alta (nickname, mail, mensaje y fecha de envio de mensaje) visualizados 
 * en una Label.
 * 
 */

namespace TodosLosProyectosEnUno_C__Parte1
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Falta rellenar uno/varios de los campos.");
            }
            else
            {
                if (!textBox2.Text.Contains("@"))
                {
                    MessageBox.Show("El email debe contener un arroba.");
                    return;
                }

                textBox4.AppendText(
                    $"Nickname: {textBox1.Text} \r\n" +
                    $"Email: {textBox2.Text} \r\n" +
                    $"Hora y Fecha enviado: {DateTime.Now.ToShortDateString()} {DateTime.Now.ToShortTimeString()} \r\n" +
                    $"Mensaje: {textBox3.Text} \r\n\r\n");
            }
        }
    }
}

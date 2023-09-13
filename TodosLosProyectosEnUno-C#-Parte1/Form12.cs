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
 * 11) Hacer un formulario que baraje 3 cartas de manera aleatoria (las cartas posibles tienen 
 * valor de 1 a 12 y pueden ser 4 variedades -espada, basto, copas, oro-). Las cartas barajadas
 * debe visualizarse en una label (formato valorCarta - palo) 
 * 
 */

namespace TodosLosProyectosEnUno_C__Parte1
{
    public partial class Form12 : Form
    {

        private static Random tipo = new Random();
        private static Random valor = new Random();

        public Form12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.AppendText($"{obtenerTipoCarta()}\r\n" +
                $"{valorDeCarta()}");

            textBox2.Text = "";
            textBox2.AppendText($"{obtenerTipoCarta()}\r\n" +
                $"{valorDeCarta()}");

            textBox3.Text = "";
            textBox3.AppendText($"{obtenerTipoCarta()}\r\n" +
                $"{valorDeCarta()}");
        }

        private String obtenerTipoCarta()
        { 
            if (tipo.Next(1, 5) == 1) return "Espada";
            else if (tipo.Next(1, 5) == 2) return "Basto";
            else if (tipo.Next(1, 5) == 3) return "Copa";
            else return "Oro";
        }

        private int valorDeCarta()
        {
            return valor.Next(1, 13);
        }
    }
}

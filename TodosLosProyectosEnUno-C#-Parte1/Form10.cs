using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * DESARROLLADO POR MATIAS ABREGÚ
 * 
 * 9) Generar: Boton "tirar dados" genera 5 valores aleatorios (que van de 1 a 6) visualizados 
 * en label. Solo hay 3 intentos.
 * 
 */

namespace TodosLosProyectosEnUno_C__Parte1
{
    public partial class Form10 : Form
    {
        private int intentos = 3;

        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (intentos > 0)
            {
                Random rnd = new Random(); //Objeto creado acá para evitar repetición de números
                textBox4.Text = "";
                textBox4.AppendText($"Primer número que tocó: {rnd.Next(1, 7)}\r\n" +
                $"Segundo número que tocó: {rnd.Next(1, 7)}\r\n" +
                $"Tercer número que tocó: {rnd.Next(1, 7)}\r\n" +
                $"Cuarto número que tocó: {rnd.Next(1, 7)}\r\n" +
                $"Quinto número que tocó: {rnd.Next(1, 7)}\r\n");
                intentos--;
                label2.Text = $"Intentos Restantes: {intentos}";
            } else
            {
                MessageBox.Show("¡Se te acabaron los intentos!");
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Semana14BCClass2ejer1;

namespace Semana14WFClass2Ejer1
{
    public partial class Form1 : Form
    {

        Intercambiar inter = new Intercambiar();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string palabra = textBox1.Text;
            string resultado = inter.IntercambiarCaracter(palabra);
            MessageBox.Show(resultado);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

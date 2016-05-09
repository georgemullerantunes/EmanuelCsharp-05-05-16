using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio1_CalculaQuadrado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btQuadrado_Click(object sender, EventArgs e) {             
            decimal quadrado;
            CalculaQuadrado(Convert.ToDecimal(textBoxValor.Text), out quadrado);
            lbResultado.Text = Convert.ToString(quadrado);

        }

        public void CalculaQuadrado(decimal valor, out decimal quadrado) {
            quadrado = valor * valor;
        }
    }
}

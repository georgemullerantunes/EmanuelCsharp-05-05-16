using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio2_FuncaoQuadrado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btQuadrado_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Convert.ToString(Quadrado(Convert.ToDecimal(txtValor.Text)));
        }

        private decimal Quadrado(decimal valor)
        {
            valor *= valor;
            return valor;
        }
    }
}

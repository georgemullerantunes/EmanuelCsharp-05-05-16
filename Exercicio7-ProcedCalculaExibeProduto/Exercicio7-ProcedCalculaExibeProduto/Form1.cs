using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio7_ProcedCalculaExibeProduto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btMultiplica_Click(object sender, EventArgs e)
        {
            CalculaExibeProduto(Convert.ToDecimal(txtValor1.Text), 
                                Convert.ToDecimal(txtValor2.Text), 
                                Convert.ToDecimal(txtValor3.Text));
        }

        private void CalculaExibeProduto (decimal v1, decimal v2, decimal v3) {
            lbMult.Text = Convert.ToString(v1 * v2 * v3);
        }
    }
}

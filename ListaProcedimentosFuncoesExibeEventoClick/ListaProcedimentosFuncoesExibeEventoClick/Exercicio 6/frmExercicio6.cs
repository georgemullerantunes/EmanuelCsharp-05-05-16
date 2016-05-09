using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio6
{
    public partial class frmExercicio6 : Form
    {
        public frmExercicio6()
        {
            InitializeComponent();
        }

        private void btProcessar_Click(object sender, EventArgs e)
        {
            decimal soma;

            CalculaExibeSoma(Convert.ToDecimal(txtValor1.Text), Convert.ToDecimal(txtValor2.Text), out soma);
            lblSoma.Text = Convert.ToString(soma);

        }

        public void CalculaExibeSoma(decimal v1, decimal v2, out decimal soma) {
            soma = v1 + v2;
        }

    }
}

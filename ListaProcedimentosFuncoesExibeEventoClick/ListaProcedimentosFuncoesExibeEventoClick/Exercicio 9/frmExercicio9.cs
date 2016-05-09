using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio9
{
    public partial class frmExercicio9 : Form
    {
        public frmExercicio9()
        {
            InitializeComponent();
        }

        private void btDividir_Click(object sender, EventArgs e)
        {
            CalculaDivisao(Convert.ToDecimal(txtValor1.Text) , 
                            Convert.ToDecimal(txtValor2.Text), txtDivisao);
        }

        private void CalculaDivisao(decimal v1, decimal v2, TextBox result) {
            result.Text = Convert.ToString(v1 / v2);
        }
    }
}

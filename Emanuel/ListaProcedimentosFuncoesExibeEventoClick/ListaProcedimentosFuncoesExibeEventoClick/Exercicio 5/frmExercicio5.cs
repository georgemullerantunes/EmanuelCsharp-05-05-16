using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio5
{
    public partial class frmExercicio5 : Form
    {
        public frmExercicio5()
        {
            InitializeComponent();
        }

        private void btProcessar_Click(object sender, EventArgs e)
        {
            lblSoma.Text = Convert.ToString(Calcular(Convert.ToDecimal(txtValor1.Text), Convert.ToDecimal(txtValor2.Text)));
        }

        private decimal Calcular (decimal v1, decimal v2) {
            return v1 + v2;
        }
    }
}

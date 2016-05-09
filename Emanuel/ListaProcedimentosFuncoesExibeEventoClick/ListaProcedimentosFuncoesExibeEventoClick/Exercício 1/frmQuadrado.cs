using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio1
{
    public partial class frmQuadrado : Form
    {
        public frmQuadrado()
        {
            InitializeComponent();
        }

        private void btQuadrado_Click(object sender, EventArgs e)
        {
            exibeQuadrado(Convert.ToDecimal(textValor.Text));
        }

        private void exibeQuadrado (decimal v1)
        {
            textResultado.Text = Convert.ToString(v1 * v1);
        }
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio8
{
    public partial class frmExercicio8: Form
    {
        public frmExercicio8()
        {
            InitializeComponent();
        }

        private void btMultiplica_Click(object sender, EventArgs e)
        {
            lblMultip.Text =CalculaProduto(Convert.ToDecimal(txtValor1.Text),
                                Convert.ToDecimal(txtValor2.Text),
                                Convert.ToDecimal(txtValor2.Text)
                );
        }

        private String CalculaProduto(decimal v1, decimal v2, decimal v3) {
            return Convert.ToString(v1 * v2 * v3);
        }
    }
}

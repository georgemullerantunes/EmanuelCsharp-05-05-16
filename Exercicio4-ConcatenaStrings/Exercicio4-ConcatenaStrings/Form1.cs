using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio4_ConcatenaStrings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btConcatena_Click(object sender, EventArgs e)
        {
            lbfrase.Text = ConcatenaStrings(txtValor1.Text, txtValor2.Text, txtValor3.Text);
        }

        private String ConcatenaStrings(String v1, String v2, String v3) {
            return v1 +" "+ v2 +" "+ v3;
        }

    }
}

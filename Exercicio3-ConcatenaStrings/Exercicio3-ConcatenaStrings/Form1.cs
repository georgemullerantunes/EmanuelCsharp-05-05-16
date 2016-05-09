using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio3_ConcatenaStrings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btConcatena_Click(object sender, EventArgs e)
        {
            String frase;
            ConcatenaStrings(txtValor1.Text, txtValor2.Text, txtValor3.Text, out frase);
            lbfrase.Text = frase;
        }

        private void ConcatenaStrings(String valor1, String valor2, String valor3, out String frase) {
            frase = valor1 +" "+ valor2 +" "+ valor3;
        }

    }
}

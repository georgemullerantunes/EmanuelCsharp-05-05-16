using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio10_ProcedTodasOperacoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btProcessa_Click(object sender, EventArgs e)
        {
            decimal operacao = 0;

            if (cbxOperacao.SelectedIndex == 0)
                CalculaSoma(Convert.ToDecimal(txtValor1.Text), Convert.ToDecimal(txtValor2.Text), out operacao);

            else if (cbxOperacao.SelectedIndex == 1)
                CalculaSubtracao(Convert.ToDecimal(txtValor1.Text), Convert.ToDecimal(txtValor2.Text), out operacao);

            else if (cbxOperacao.SelectedIndex == 2)
                CalculaMultiplicacao(Convert.ToDecimal(txtValor1.Text), Convert.ToDecimal(txtValor2.Text), out operacao);

            else if (cbxOperacao.SelectedIndex == 3)
                CalculaDivisao(Convert.ToDecimal(txtValor1.Text), Convert.ToDecimal(txtValor2.Text), out operacao);


            else if (cbxOperacao.SelectedIndex == 4)
                CalculaConcatenacao(Convert.ToDecimal(txtValor1.Text), Convert.ToDecimal(txtValor2.Text), out operacao);


            else if (cbxOperacao.SelectedIndex == 5)
                CalculaPotencia(Convert.ToDecimal(txtValor1.Text), Convert.ToDecimal(txtValor2.Text), out operacao);

            lblResultado.Text = Convert.ToString(operacao);

        }

        private void CalculaSoma (decimal v1, decimal v2, out decimal operacao)
        {
            operacao = v1 + v2;
        }

        private void CalculaSubtracao(decimal v1, decimal v2, out decimal operacao)
        {
            operacao = v1 - v2;
        }

        private void CalculaMultiplicacao(decimal v1, decimal v2, out decimal operacao)
        {
            operacao = v1 * v2;
        }

        private void CalculaDivisao(decimal v1, decimal v2, out decimal operacao)
        {
            operacao = v1 / v2;
        }

        private void CalculaConcatenacao(decimal v1, decimal v2, out decimal operacao)
        {
            String join = Convert.ToString(v1) + Convert.ToString(v2);
            operacao = Convert.ToDecimal(join);
        }

        private void CalculaPotencia(decimal v1, decimal v2, out decimal operacao)
        {
            operacao = Convert.ToDecimal(Math.Pow(Convert.ToDouble(v1), Convert.ToDouble(v2)));
        }

    }
}

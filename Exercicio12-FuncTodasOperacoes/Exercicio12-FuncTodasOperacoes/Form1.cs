using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio12_FuncTodasOperacoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btProcessar_Click(object sender, EventArgs e)
        {

            if (cbxOperacao.SelectedIndex == 0)
                lblResultado.Text = CalculaSoma(Convert.ToDecimal(txtValor1.Text), Convert.ToDecimal(txtValor2.Text));

            else if (cbxOperacao.SelectedIndex == 1)
                lblResultado.Text = CalculaSubtracao(Convert.ToDecimal(txtValor1.Text), Convert.ToDecimal(txtValor2.Text));

            else if (cbxOperacao.SelectedIndex == 2)
                lblResultado.Text = CalculaMultiplicacao(Convert.ToDecimal(txtValor1.Text), Convert.ToDecimal(txtValor2.Text));

            else if (cbxOperacao.SelectedIndex == 3)
                lblResultado.Text = CalculaDivisao(Convert.ToDecimal(txtValor1.Text), Convert.ToDecimal(txtValor2.Text));


            else if (cbxOperacao.SelectedIndex == 4)
                lblResultado.Text = CalculaConcatenacao(Convert.ToDecimal(txtValor1.Text), Convert.ToDecimal(txtValor2.Text));


            else if (cbxOperacao.SelectedIndex == 5)
               lblResultado.Text = CalculaPotencia(Convert.ToDecimal(txtValor1.Text), Convert.ToDecimal(txtValor2.Text));

        } // fim Evento Click

        private String CalculaSoma(decimal v1, decimal v2)
        {
             return Convert.ToString(v1 + v2);
        }

        private String CalculaSubtracao(decimal v1, decimal v2)
        {
            return Convert.ToString(v1 - v2);
        }

        private String CalculaMultiplicacao(decimal v1, decimal v2)
        {
            return Convert.ToString(v1 * v2);
        }

        private String CalculaDivisao(decimal v1, decimal v2)
        {
            return Convert.ToString(v1 / v2);
        }

        private String CalculaConcatenacao(decimal v1, decimal v2)
        {
            String join = Convert.ToString(v1) + Convert.ToString(v2);
            return join;
        }

        private String CalculaPotencia(decimal v1, decimal v2)
        {
            return Convert.ToString(Math.Pow(Convert.ToDouble(v1), Convert.ToDouble(v2)));
        }


    }
}

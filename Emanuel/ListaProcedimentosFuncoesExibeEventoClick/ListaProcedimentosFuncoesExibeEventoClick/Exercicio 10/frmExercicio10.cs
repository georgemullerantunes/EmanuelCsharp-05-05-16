﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio10
{
    public partial class frmExercicio10 : Form
    {
        public frmExercicio10()
        {
            InitializeComponent();
        }

        private void btDividir_Click(object sender, EventArgs e)
        {
            CalculaDivisao(Convert.ToDecimal(txtValor1.Text),
                           Convert.ToDecimal(txtValor2.Text), lblDivisao);
        }

        private void CalculaDivisao(decimal v1, decimal v2, Label result)
        {
            result.Text = Convert.ToString(v1 / v2);
        }

    }
}
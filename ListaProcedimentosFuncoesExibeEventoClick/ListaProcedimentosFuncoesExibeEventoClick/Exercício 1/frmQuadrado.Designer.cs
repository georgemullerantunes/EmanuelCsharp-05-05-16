namespace Exercicio1
{
    partial class frmQuadrado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btQuadrado = new System.Windows.Forms.Button();
            this.textValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textResultado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btQuadrado
            // 
            this.btQuadrado.Location = new System.Drawing.Point(103, 173);
            this.btQuadrado.Name = "btQuadrado";
            this.btQuadrado.Size = new System.Drawing.Size(75, 23);
            this.btQuadrado.TabIndex = 0;
            this.btQuadrado.Text = "&Processar";
            this.btQuadrado.UseVisualStyleBackColor = true;
            this.btQuadrado.Click += new System.EventHandler(this.btQuadrado_Click);
            // 
            // textValor
            // 
            this.textValor.Location = new System.Drawing.Point(35, 91);
            this.textValor.Name = "textValor";
            this.textValor.Size = new System.Drawing.Size(90, 20);
            this.textValor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Valor";
            // 
            // textResultado
            // 
            this.textResultado.Location = new System.Drawing.Point(157, 91);
            this.textResultado.Name = "textResultado";
            this.textResultado.ReadOnly = true;
            this.textResultado.Size = new System.Drawing.Size(90, 20);
            this.textResultado.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quadrado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textResultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textValor);
            this.Controls.Add(this.btQuadrado);
            this.Name = "Form1";
            this.Text = "Exercício 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btQuadrado;
        private System.Windows.Forms.TextBox textValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textResultado;
        private System.Windows.Forms.Label label2;
    }
}


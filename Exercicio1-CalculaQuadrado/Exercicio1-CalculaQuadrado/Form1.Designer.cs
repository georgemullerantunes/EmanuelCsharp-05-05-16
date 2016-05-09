namespace Exercicio1_CalculaQuadrado
{
    partial class Form1
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
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.lbResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btQuadrado
            // 
            this.btQuadrado.Location = new System.Drawing.Point(102, 146);
            this.btQuadrado.Name = "btQuadrado";
            this.btQuadrado.Size = new System.Drawing.Size(75, 23);
            this.btQuadrado.TabIndex = 0;
            this.btQuadrado.Text = "&Processar";
            this.btQuadrado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btQuadrado.UseVisualStyleBackColor = true;
            this.btQuadrado.Click += new System.EventHandler(this.btQuadrado_Click);
            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new System.Drawing.Point(90, 100);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(100, 20);
            this.textBoxValor.TabIndex = 1;
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Location = new System.Drawing.Point(119, 199);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(16, 13);
            this.lbResultado.TabIndex = 2;
            this.lbResultado.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 262);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.textBoxValor);
            this.Controls.Add(this.btQuadrado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btQuadrado;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.Label lbResultado;
    }
}


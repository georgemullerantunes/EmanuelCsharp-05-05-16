namespace Exercicio3_ConcatenaStrings
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
            this.btConcatena = new System.Windows.Forms.Button();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.txtValor3 = new System.Windows.Forms.TextBox();
            this.lbfrase = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btConcatena
            // 
            this.btConcatena.Location = new System.Drawing.Point(100, 160);
            this.btConcatena.Name = "btConcatena";
            this.btConcatena.Size = new System.Drawing.Size(75, 23);
            this.btConcatena.TabIndex = 0;
            this.btConcatena.Text = "Join";
            this.btConcatena.UseVisualStyleBackColor = true;
            this.btConcatena.Click += new System.EventHandler(this.btConcatena_Click);
            // 
            // txtValor1
            // 
            this.txtValor1.Location = new System.Drawing.Point(24, 86);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(100, 20);
            this.txtValor1.TabIndex = 1;
            // 
            // txtValor2
            // 
            this.txtValor2.Location = new System.Drawing.Point(162, 86);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(100, 20);
            this.txtValor2.TabIndex = 2;
            // 
            // txtValor3
            // 
            this.txtValor3.Location = new System.Drawing.Point(90, 121);
            this.txtValor3.Name = "txtValor3";
            this.txtValor3.Size = new System.Drawing.Size(100, 20);
            this.txtValor3.TabIndex = 3;
            // 
            // lbfrase
            // 
            this.lbfrase.AutoSize = true;
            this.lbfrase.Location = new System.Drawing.Point(132, 213);
            this.lbfrase.Name = "lbfrase";
            this.lbfrase.Size = new System.Drawing.Size(16, 13);
            this.lbfrase.TabIndex = 4;
            this.lbfrase.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lbfrase);
            this.Controls.Add(this.txtValor3);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.txtValor1);
            this.Controls.Add(this.btConcatena);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btConcatena;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.TextBox txtValor3;
        private System.Windows.Forms.Label lbfrase;
    }
}


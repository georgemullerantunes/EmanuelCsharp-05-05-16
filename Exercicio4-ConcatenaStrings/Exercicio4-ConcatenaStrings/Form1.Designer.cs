namespace Exercicio4_ConcatenaStrings
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
            this.lbfrase = new System.Windows.Forms.Label();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.txtValor3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btConcatena
            // 
            this.btConcatena.Location = new System.Drawing.Point(105, 162);
            this.btConcatena.Name = "btConcatena";
            this.btConcatena.Size = new System.Drawing.Size(75, 23);
            this.btConcatena.TabIndex = 0;
            this.btConcatena.Text = "&Join";
            this.btConcatena.UseVisualStyleBackColor = true;
            this.btConcatena.Click += new System.EventHandler(this.btConcatena_Click);
            // 
            // lbfrase
            // 
            this.lbfrase.AutoSize = true;
            this.lbfrase.Location = new System.Drawing.Point(25, 212);
            this.lbfrase.Name = "lbfrase";
            this.lbfrase.Size = new System.Drawing.Size(16, 13);
            this.lbfrase.TabIndex = 1;
            this.lbfrase.Text = "...";
            this.lbfrase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtValor1
            // 
            this.txtValor1.Location = new System.Drawing.Point(28, 76);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(100, 20);
            this.txtValor1.TabIndex = 2;
            // 
            // txtValor2
            // 
            this.txtValor2.Location = new System.Drawing.Point(158, 76);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(100, 20);
            this.txtValor2.TabIndex = 3;
            // 
            // txtValor3
            // 
            this.txtValor3.Location = new System.Drawing.Point(94, 117);
            this.txtValor3.Name = "txtValor3";
            this.txtValor3.Size = new System.Drawing.Size(100, 20);
            this.txtValor3.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 254);
            this.Controls.Add(this.txtValor3);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.txtValor1);
            this.Controls.Add(this.lbfrase);
            this.Controls.Add(this.btConcatena);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btConcatena;
        private System.Windows.Forms.Label lbfrase;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.TextBox txtValor3;
    }
}


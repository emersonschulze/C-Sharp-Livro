namespace ConstrucaoCasa
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPosicaoAtual = new System.Windows.Forms.TextBox();
            this.GoTo = new System.Windows.Forms.Button();
            this.ComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtPosicaoAtual
            // 
            this.txtPosicaoAtual.Location = new System.Drawing.Point(13, 13);
            this.txtPosicaoAtual.Multiline = true;
            this.txtPosicaoAtual.Name = "txtPosicaoAtual";
            this.txtPosicaoAtual.Size = new System.Drawing.Size(380, 148);
            this.txtPosicaoAtual.TabIndex = 0;
            // 
            // GoTo
            // 
            this.GoTo.Location = new System.Drawing.Point(13, 182);
            this.GoTo.Name = "GoTo";
            this.GoTo.Size = new System.Drawing.Size(81, 23);
            this.GoTo.TabIndex = 1;
            this.GoTo.Text = "Vá para";
            this.GoTo.UseVisualStyleBackColor = true;
            this.GoTo.Click += new System.EventHandler(this.GoTo_Click);
            // 
            // ComboBox
            // 
            this.ComboBox.FormattingEnabled = true;
            this.ComboBox.Location = new System.Drawing.Point(112, 182);
            this.ComboBox.Name = "ComboBox";
            this.ComboBox.Size = new System.Drawing.Size(281, 21);
            this.ComboBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 265);
            this.Controls.Add(this.ComboBox);
            this.Controls.Add(this.GoTo);
            this.Controls.Add(this.txtPosicaoAtual);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPosicaoAtual;
        private System.Windows.Forms.Button GoTo;
        private System.Windows.Forms.ComboBox ComboBox;
    }
}


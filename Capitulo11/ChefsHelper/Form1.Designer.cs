namespace ChefsHelper
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
            this.useIngredient = new System.Windows.Forms.Button();
            this.amount = new System.Windows.Forms.NumericUpDown();
            this.getSuzzane = new System.Windows.Forms.Button();
            this.getAmy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.amount)).BeginInit();
            this.SuspendLayout();
            // 
            // useIngredient
            // 
            this.useIngredient.Location = new System.Drawing.Point(24, 53);
            this.useIngredient.Name = "useIngredient";
            this.useIngredient.Size = new System.Drawing.Size(145, 23);
            this.useIngredient.TabIndex = 0;
            this.useIngredient.Text = "Consiga os ingredientes";
            this.useIngredient.UseVisualStyleBackColor = true;
            this.useIngredient.Click += new System.EventHandler(this.useIngredient_Click);
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(176, 55);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(96, 20);
            this.amount.TabIndex = 1;
            // 
            // getSuzzane
            // 
            this.getSuzzane.Location = new System.Drawing.Point(24, 93);
            this.getSuzzane.Name = "getSuzzane";
            this.getSuzzane.Size = new System.Drawing.Size(248, 23);
            this.getSuzzane.TabIndex = 2;
            this.getSuzzane.Text = "Use o delegado de Suzanne";
            this.getSuzzane.UseVisualStyleBackColor = true;
            this.getSuzzane.Click += new System.EventHandler(this.getSuzzane_Click);
            // 
            // getAmy
            // 
            this.getAmy.Location = new System.Drawing.Point(24, 134);
            this.getAmy.Name = "getAmy";
            this.getAmy.Size = new System.Drawing.Size(248, 23);
            this.getAmy.TabIndex = 3;
            this.getAmy.Text = "Use o delegado de Amy";
            this.getAmy.UseVisualStyleBackColor = true;
            this.getAmy.Click += new System.EventHandler(this.getAmy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 206);
            this.Controls.Add(this.getAmy);
            this.Controls.Add(this.getSuzzane);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.useIngredient);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.amount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button useIngredient;
        private System.Windows.Forms.NumericUpDown amount;
        private System.Windows.Forms.Button getSuzzane;
        private System.Windows.Forms.Button getAmy;
    }
}


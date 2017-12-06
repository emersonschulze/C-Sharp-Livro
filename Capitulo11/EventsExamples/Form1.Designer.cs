namespace EventsExamples
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Trajetoria = new System.Windows.Forms.NumericUpDown();
            this.Distancia = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Trajetoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Distancia)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trajetória";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Distância";
            // 
            // Trajetoria
            // 
            this.Trajetoria.Location = new System.Drawing.Point(122, 70);
            this.Trajetoria.Name = "Trajetoria";
            this.Trajetoria.Size = new System.Drawing.Size(120, 20);
            this.Trajetoria.TabIndex = 2;
            // 
            // Distancia
            // 
            this.Distancia.Location = new System.Drawing.Point(122, 133);
            this.Distancia.Name = "Distancia";
            this.Distancia.Size = new System.Drawing.Size(120, 20);
            this.Distancia.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(75, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Jogue a bola!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Distancia);
            this.Controls.Add(this.Trajetoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Trajetoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Distancia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Trajetoria;
        private System.Windows.Forms.NumericUpDown Distancia;
        private System.Windows.Forms.Button button1;
    }
}


namespace Capitulo3
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bobGivestoJoe = new System.Windows.Forms.Button();
            this.joeGivestoBob = new System.Windows.Forms.Button();
            this.Bob = new System.Windows.Forms.Button();
            this.Joe = new System.Windows.Forms.Button();
            this.banksCash = new System.Windows.Forms.Label();
            this.bobsCash = new System.Windows.Forms.Label();
            this.joesCash = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Diga isso:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(178, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 31);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "N. de vezes:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(178, 70);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 31);
            this.numericUpDown1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(145, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "Fala comigo!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(35, 178);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 65);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Desafio";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(131, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 30);
            this.button2.TabIndex = 0;
            this.button2.Text = "Clica aqui!";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bobGivestoJoe);
            this.groupBox2.Controls.Add(this.joeGivestoBob);
            this.groupBox2.Controls.Add(this.Bob);
            this.groupBox2.Controls.Add(this.Joe);
            this.groupBox2.Controls.Add(this.banksCash);
            this.groupBox2.Controls.Add(this.bobsCash);
            this.groupBox2.Controls.Add(this.joesCash);
            this.groupBox2.Location = new System.Drawing.Point(89, 260);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 192);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Doação de dinheiro";
            // 
            // bobGivestoJoe
            // 
            this.bobGivestoJoe.Location = new System.Drawing.Point(159, 133);
            this.bobGivestoJoe.Name = "bobGivestoJoe";
            this.bobGivestoJoe.Size = new System.Drawing.Size(84, 41);
            this.bobGivestoJoe.TabIndex = 6;
            this.bobGivestoJoe.Text = "Bob dá R$ 5 para Joe";
            this.bobGivestoJoe.UseVisualStyleBackColor = true;
            this.bobGivestoJoe.Click += new System.EventHandler(this.bobGivestoJoe_Click);
            // 
            // joeGivestoBob
            // 
            this.joeGivestoBob.Location = new System.Drawing.Point(25, 133);
            this.joeGivestoBob.Name = "joeGivestoBob";
            this.joeGivestoBob.Size = new System.Drawing.Size(80, 41);
            this.joeGivestoBob.TabIndex = 5;
            this.joeGivestoBob.Text = "Joe dá R$ 10 para Bob";
            this.joeGivestoBob.UseVisualStyleBackColor = true;
            this.joeGivestoBob.Click += new System.EventHandler(this.joeGivestoBob_Click);
            // 
            // Bob
            // 
            this.Bob.Location = new System.Drawing.Point(159, 73);
            this.Bob.Name = "Bob";
            this.Bob.Size = new System.Drawing.Size(84, 39);
            this.Bob.TabIndex = 4;
            this.Bob.Text = "Receba R$ 5 de Bob";
            this.Bob.UseVisualStyleBackColor = true;
            this.Bob.Click += new System.EventHandler(this.Bob_Click);
            // 
            // Joe
            // 
            this.Joe.Location = new System.Drawing.Point(159, 19);
            this.Joe.Name = "Joe";
            this.Joe.Size = new System.Drawing.Size(84, 39);
            this.Joe.TabIndex = 3;
            this.Joe.Text = "Dê  R$ 10 para Joe";
            this.Joe.UseVisualStyleBackColor = true;
            this.Joe.Click += new System.EventHandler(this.Joe_Click);
            // 
            // banksCash
            // 
            this.banksCash.AutoSize = true;
            this.banksCash.Location = new System.Drawing.Point(22, 99);
            this.banksCash.Name = "banksCash";
            this.banksCash.Size = new System.Drawing.Size(35, 13);
            this.banksCash.TabIndex = 2;
            this.banksCash.Text = "label3";
            // 
            // bobsCash
            // 
            this.bobsCash.AutoSize = true;
            this.bobsCash.Location = new System.Drawing.Point(22, 67);
            this.bobsCash.Name = "bobsCash";
            this.bobsCash.Size = new System.Drawing.Size(35, 13);
            this.bobsCash.TabIndex = 1;
            this.bobsCash.Text = "label3";
            // 
            // joesCash
            // 
            this.joesCash.AutoSize = true;
            this.joesCash.Location = new System.Drawing.Point(22, 33);
            this.joesCash.Name = "joesCash";
            this.joesCash.Size = new System.Drawing.Size(35, 13);
            this.joesCash.TabIndex = 0;
            this.joesCash.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 475);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Testador Falante";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Bob;
        private System.Windows.Forms.Button Joe;
        private System.Windows.Forms.Label banksCash;
        private System.Windows.Forms.Label bobsCash;
        private System.Windows.Forms.Label joesCash;
        private System.Windows.Forms.Button bobGivestoJoe;
        private System.Windows.Forms.Button joeGivestoBob;
    }
}


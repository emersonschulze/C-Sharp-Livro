namespace Colmeia
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Tarefa = new System.Windows.Forms.ComboBox();
            this.btnAtribuirTarefa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Turnos = new System.Windows.Forms.NumericUpDown();
            this.btnProximoTurno = new System.Windows.Forms.Button();
            this.Relatorio = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Turnos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Turnos);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnAtribuirTarefa);
            this.groupBox1.Controls.Add(this.Tarefa);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 130);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Atribuição de tarefas de Operários";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tarefa da operária";
            // 
            // Tarefa
            // 
            this.Tarefa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Tarefa.FormattingEnabled = true;
            this.Tarefa.Items.AddRange(new object[] {
            "Coletar néctar",
            "Produção de mel",
            "Cuidar dos ovos",
            "Ensinar às abelhas bebês",
            "Manutenção da colméia",
            "Patrulha"});
            this.Tarefa.Location = new System.Drawing.Point(9, 45);
            this.Tarefa.Name = "Tarefa";
            this.Tarefa.Size = new System.Drawing.Size(188, 21);
            this.Tarefa.TabIndex = 1;
            // 
            // btnAtribuirTarefa
            // 
            this.btnAtribuirTarefa.Location = new System.Drawing.Point(9, 83);
            this.btnAtribuirTarefa.Name = "btnAtribuirTarefa";
            this.btnAtribuirTarefa.Size = new System.Drawing.Size(188, 23);
            this.btnAtribuirTarefa.TabIndex = 2;
            this.btnAtribuirTarefa.Text = "Atribuir esta terafa a uma abelha";
            this.btnAtribuirTarefa.UseVisualStyleBackColor = true;
            this.btnAtribuirTarefa.Click += new System.EventHandler(this.btnAtribuirTarefa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Turnos";
            // 
            // Turnos
            // 
            this.Turnos.Location = new System.Drawing.Point(248, 45);
            this.Turnos.Name = "Turnos";
            this.Turnos.Size = new System.Drawing.Size(120, 20);
            this.Turnos.TabIndex = 5;
            // 
            // btnProximoTurno
            // 
            this.btnProximoTurno.Location = new System.Drawing.Point(418, 42);
            this.btnProximoTurno.Name = "btnProximoTurno";
            this.btnProximoTurno.Size = new System.Drawing.Size(88, 80);
            this.btnProximoTurno.TabIndex = 1;
            this.btnProximoTurno.Text = "Próximo turno";
            this.btnProximoTurno.UseVisualStyleBackColor = true;
            this.btnProximoTurno.Click += new System.EventHandler(this.btnProximoTurno_Click);
            // 
            // Relatorio
            // 
            this.Relatorio.Location = new System.Drawing.Point(13, 164);
            this.Relatorio.Multiline = true;
            this.Relatorio.Name = "Relatorio";
            this.Relatorio.Size = new System.Drawing.Size(493, 195);
            this.Relatorio.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 380);
            this.Controls.Add(this.Relatorio);
            this.Controls.Add(this.btnProximoTurno);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Sistema de Gerenciamento de Colméia";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Turnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown Turnos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAtribuirTarefa;
        private System.Windows.Forms.ComboBox Tarefa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProximoTurno;
        private System.Windows.Forms.TextBox Relatorio;
    }
}


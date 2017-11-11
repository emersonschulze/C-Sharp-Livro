namespace Decks
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
            this.listBoxDeck1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxDeck2 = new System.Windows.Forms.ListBox();
            this.moveToDeck2 = new System.Windows.Forms.Button();
            this.moveToDeck1 = new System.Windows.Forms.Button();
            this.organizeDeck1 = new System.Windows.Forms.Button();
            this.shuffleDeck2 = new System.Windows.Forms.Button();
            this.shuffleDeck1 = new System.Windows.Forms.Button();
            this.organizeDeckTwo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = " Deck 1 (9 cards)";
            // 
            // listBoxDeck1
            // 
            this.listBoxDeck1.FormattingEnabled = true;
            this.listBoxDeck1.Location = new System.Drawing.Point(33, 45);
            this.listBoxDeck1.Name = "listBoxDeck1";
            this.listBoxDeck1.Size = new System.Drawing.Size(180, 303);
            this.listBoxDeck1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Deck 2 (52 cards)";
            // 
            // listBoxDeck2
            // 
            this.listBoxDeck2.FormattingEnabled = true;
            this.listBoxDeck2.Location = new System.Drawing.Point(280, 45);
            this.listBoxDeck2.Name = "listBoxDeck2";
            this.listBoxDeck2.Size = new System.Drawing.Size(173, 303);
            this.listBoxDeck2.TabIndex = 3;
            // 
            // moveToDeck2
            // 
            this.moveToDeck2.Location = new System.Drawing.Point(219, 93);
            this.moveToDeck2.Name = "moveToDeck2";
            this.moveToDeck2.Size = new System.Drawing.Size(55, 23);
            this.moveToDeck2.TabIndex = 4;
            this.moveToDeck2.Text = ">>";
            this.moveToDeck2.UseVisualStyleBackColor = true;
            this.moveToDeck2.Click += new System.EventHandler(this.moveToDeck2_Click);
            // 
            // moveToDeck1
            // 
            this.moveToDeck1.Location = new System.Drawing.Point(220, 133);
            this.moveToDeck1.Name = "moveToDeck1";
            this.moveToDeck1.Size = new System.Drawing.Size(54, 23);
            this.moveToDeck1.TabIndex = 5;
            this.moveToDeck1.Text = "<<";
            this.moveToDeck1.UseVisualStyleBackColor = true;
            this.moveToDeck1.Click += new System.EventHandler(this.moveToDeck1_Click);
            // 
            // organizeDeck1
            // 
            this.organizeDeck1.Location = new System.Drawing.Point(33, 374);
            this.organizeDeck1.Name = "organizeDeck1";
            this.organizeDeck1.Size = new System.Drawing.Size(180, 23);
            this.organizeDeck1.TabIndex = 6;
            this.organizeDeck1.Text = "Organize Deck One";
            this.organizeDeck1.UseVisualStyleBackColor = true;
            this.organizeDeck1.Click += new System.EventHandler(this.organizeDeck1_Click);
            // 
            // shuffleDeck2
            // 
            this.shuffleDeck2.Location = new System.Drawing.Point(280, 373);
            this.shuffleDeck2.Name = "shuffleDeck2";
            this.shuffleDeck2.Size = new System.Drawing.Size(173, 23);
            this.shuffleDeck2.TabIndex = 7;
            this.shuffleDeck2.Text = "Shuffle Deck Two";
            this.shuffleDeck2.UseVisualStyleBackColor = true;
            this.shuffleDeck2.Click += new System.EventHandler(this.shuffleDeck2_Click);
            // 
            // shuffleDeck1
            // 
            this.shuffleDeck1.Location = new System.Drawing.Point(33, 420);
            this.shuffleDeck1.Name = "shuffleDeck1";
            this.shuffleDeck1.Size = new System.Drawing.Size(180, 23);
            this.shuffleDeck1.TabIndex = 8;
            this.shuffleDeck1.Text = "Shuffle Deck One";
            this.shuffleDeck1.UseVisualStyleBackColor = true;
            this.shuffleDeck1.Click += new System.EventHandler(this.shuffleDeck1_Click);
            // 
            // organizeDeckTwo
            // 
            this.organizeDeckTwo.Location = new System.Drawing.Point(280, 420);
            this.organizeDeckTwo.Name = "organizeDeckTwo";
            this.organizeDeckTwo.Size = new System.Drawing.Size(173, 23);
            this.organizeDeckTwo.TabIndex = 9;
            this.organizeDeckTwo.Text = "Organize Deck Two";
            this.organizeDeckTwo.UseVisualStyleBackColor = true;
            this.organizeDeckTwo.Click += new System.EventHandler(this.organizeDeckTwo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 465);
            this.Controls.Add(this.organizeDeckTwo);
            this.Controls.Add(this.shuffleDeck1);
            this.Controls.Add(this.shuffleDeck2);
            this.Controls.Add(this.organizeDeck1);
            this.Controls.Add(this.moveToDeck1);
            this.Controls.Add(this.moveToDeck2);
            this.Controls.Add(this.listBoxDeck2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxDeck1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxDeck1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxDeck2;
        private System.Windows.Forms.Button moveToDeck2;
        private System.Windows.Forms.Button moveToDeck1;
        private System.Windows.Forms.Button organizeDeck1;
        private System.Windows.Forms.Button shuffleDeck2;
        private System.Windows.Forms.Button shuffleDeck1;
        private System.Windows.Forms.Button organizeDeckTwo;
    }
}


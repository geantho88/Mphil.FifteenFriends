namespace Mphil.FifteenFriends.UI
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
            this.GameStartButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CardPlayersInput = new System.Windows.Forms.NumericUpDown();
            this.DicePlayersInput = new System.Windows.Forms.NumericUpDown();
            this.CardDicePlayersInput = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.CardPlayersInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DicePlayersInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardDicePlayersInput)).BeginInit();
            this.SuspendLayout();
            // 
            // GameStartButton
            // 
            this.GameStartButton.Location = new System.Drawing.Point(926, 353);
            this.GameStartButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GameStartButton.Name = "GameStartButton";
            this.GameStartButton.Size = new System.Drawing.Size(128, 44);
            this.GameStartButton.TabIndex = 0;
            this.GameStartButton.Text = "΄Εναρξη Παιχνιδιού";
            this.GameStartButton.UseVisualStyleBackColor = true;
            this.GameStartButton.Click += new System.EventHandler(this.GameStartButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Card Players";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dice Players";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "CardDice Players";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 380);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(308, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Επιλέξτε παιχνίδι με μέγιστο αριθμό παικτών 15 ";
            // 
            // CardPlayersInput
            // 
            this.CardPlayersInput.Location = new System.Drawing.Point(20, 62);
            this.CardPlayersInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CardPlayersInput.Name = "CardPlayersInput";
            this.CardPlayersInput.Size = new System.Drawing.Size(160, 22);
            this.CardPlayersInput.TabIndex = 4;
            // 
            // DicePlayersInput
            // 
            this.DicePlayersInput.Location = new System.Drawing.Point(20, 128);
            this.DicePlayersInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DicePlayersInput.Name = "DicePlayersInput";
            this.DicePlayersInput.Size = new System.Drawing.Size(160, 22);
            this.DicePlayersInput.TabIndex = 4;
            // 
            // CardDicePlayersInput
            // 
            this.CardDicePlayersInput.Location = new System.Drawing.Point(20, 196);
            this.CardDicePlayersInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CardDicePlayersInput.Name = "CardDicePlayersInput";
            this.CardDicePlayersInput.Size = new System.Drawing.Size(160, 22);
            this.CardDicePlayersInput.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 409);
            this.Controls.Add(this.CardDicePlayersInput);
            this.Controls.Add(this.DicePlayersInput);
            this.Controls.Add(this.CardPlayersInput);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GameStartButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Mphil Fifteen Friends";
            ((System.ComponentModel.ISupportInitialize)(this.CardPlayersInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DicePlayersInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardDicePlayersInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GameStartButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown CardPlayersInput;
        private System.Windows.Forms.NumericUpDown DicePlayersInput;
        private System.Windows.Forms.NumericUpDown CardDicePlayersInput;
    }
}


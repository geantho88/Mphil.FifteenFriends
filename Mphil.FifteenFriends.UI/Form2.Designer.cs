namespace Mphil.FifteenFriends.UI
{
    partial class Form2
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
            this.PickCardBtn = new System.Windows.Forms.Button();
            this.RollBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.player_fullname_lbl = new System.Windows.Forms.Label();
            this.CardCollection = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Roll_Result = new System.Windows.Forms.Label();
            this.RollResult = new System.Windows.Forms.Label();
            this.OpenCards = new System.Windows.Forms.Button();
            this.DeckCards = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PickCardBtn
            // 
            this.PickCardBtn.Location = new System.Drawing.Point(663, 257);
            this.PickCardBtn.Name = "PickCardBtn";
            this.PickCardBtn.Size = new System.Drawing.Size(125, 33);
            this.PickCardBtn.TabIndex = 0;
            this.PickCardBtn.Text = "Pick Card";
            this.PickCardBtn.UseVisualStyleBackColor = true;
            this.PickCardBtn.Visible = false;
            this.PickCardBtn.Click += new System.EventHandler(this.PickCardBtn_Click);
            // 
            // RollBtn
            // 
            this.RollBtn.Location = new System.Drawing.Point(472, 257);
            this.RollBtn.Name = "RollBtn";
            this.RollBtn.Size = new System.Drawing.Size(125, 33);
            this.RollBtn.TabIndex = 0;
            this.RollBtn.Text = "Roll";
            this.RollBtn.UseVisualStyleBackColor = true;
            this.RollBtn.Visible = false;
            this.RollBtn.Click += new System.EventHandler(this.RollBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Mphil.FifteenFriends.UI.Properties.Resources.player;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 242);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // player_fullname_lbl
            // 
            this.player_fullname_lbl.AutoSize = true;
            this.player_fullname_lbl.Location = new System.Drawing.Point(57, 257);
            this.player_fullname_lbl.Name = "player_fullname_lbl";
            this.player_fullname_lbl.Size = new System.Drawing.Size(130, 17);
            this.player_fullname_lbl.TabIndex = 2;
            this.player_fullname_lbl.Text = "player_fullname_lbl";
            // 
            // CardCollection
            // 
            this.CardCollection.BackColor = System.Drawing.SystemColors.Menu;
            this.CardCollection.FormattingEnabled = true;
            this.CardCollection.ItemHeight = 16;
            this.CardCollection.Location = new System.Drawing.Point(235, 42);
            this.CardCollection.Name = "CardCollection";
            this.CardCollection.Size = new System.Drawing.Size(177, 212);
            this.CardCollection.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cards";
            // 
            // Roll_Result
            // 
            this.Roll_Result.AutoSize = true;
            this.Roll_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Roll_Result.Location = new System.Drawing.Point(512, 138);
            this.Roll_Result.Name = "Roll_Result";
            this.Roll_Result.Size = new System.Drawing.Size(39, 42);
            this.Roll_Result.TabIndex = 5;
            this.Roll_Result.Text = "0";
            // 
            // RollResult
            // 
            this.RollResult.AutoSize = true;
            this.RollResult.Location = new System.Drawing.Point(491, 22);
            this.RollResult.Name = "RollResult";
            this.RollResult.Size = new System.Drawing.Size(76, 17);
            this.RollResult.TabIndex = 4;
            this.RollResult.Text = "Roll Result";
            // 
            // OpenCards
            // 
            this.OpenCards.Location = new System.Drawing.Point(256, 257);
            this.OpenCards.Name = "OpenCards";
            this.OpenCards.Size = new System.Drawing.Size(125, 33);
            this.OpenCards.TabIndex = 0;
            this.OpenCards.Text = "Open Cards";
            this.OpenCards.UseVisualStyleBackColor = true;
            this.OpenCards.Visible = false;
            this.OpenCards.Click += new System.EventHandler(this.OpenCards_Click);
            // 
            // DeckCards
            // 
            this.DeckCards.AutoSize = true;
            this.DeckCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeckCards.Location = new System.Drawing.Point(705, 138);
            this.DeckCards.Name = "DeckCards";
            this.DeckCards.Size = new System.Drawing.Size(39, 42);
            this.DeckCards.TabIndex = 5;
            this.DeckCards.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(660, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Remaining Cards";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeckCards);
            this.Controls.Add(this.Roll_Result);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RollResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CardCollection);
            this.Controls.Add(this.player_fullname_lbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.OpenCards);
            this.Controls.Add(this.RollBtn);
            this.Controls.Add(this.PickCardBtn);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PickCardBtn;
        private System.Windows.Forms.Button RollBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label player_fullname_lbl;
        private System.Windows.Forms.ListBox CardCollection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Roll_Result;
        private System.Windows.Forms.Label RollResult;
        private System.Windows.Forms.Button OpenCards;
        private System.Windows.Forms.Label DeckCards;
        private System.Windows.Forms.Label label2;
    }
}
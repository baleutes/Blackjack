namespace L1
{
    partial class GameScreen
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
            this.playerNameLabel = new System.Windows.Forms.Label();
            this.dealerNameLabel = new System.Windows.Forms.Label();
            this.playerScoreLabel = new System.Windows.Forms.Label();
            this.playerCardsLabel = new System.Windows.Forms.Label();
            this.dealerScoreLabel = new System.Windows.Forms.Label();
            this.dealerCardsLabel = new System.Windows.Forms.Label();
            this.showPlayerScoreLabel = new System.Windows.Forms.Label();
            this.showPlayerCardsLabel = new System.Windows.Forms.Label();
            this.showDealerScoreLabel = new System.Windows.Forms.Label();
            this.showDealerCardsLabel = new System.Windows.Forms.Label();
            this.dealButton = new System.Windows.Forms.Button();
            this.hitButton = new System.Windows.Forms.Button();
            this.stayButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playerNameLabel
            // 
            this.playerNameLabel.AutoSize = true;
            this.playerNameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.playerNameLabel.Location = new System.Drawing.Point(25, 36);
            this.playerNameLabel.Name = "playerNameLabel";
            this.playerNameLabel.Size = new System.Drawing.Size(35, 20);
            this.playerNameLabel.TabIndex = 0;
            this.playerNameLabel.Text = "You";
            // 
            // dealerNameLabel
            // 
            this.dealerNameLabel.AutoSize = true;
            this.dealerNameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dealerNameLabel.Location = new System.Drawing.Point(25, 192);
            this.dealerNameLabel.Name = "dealerNameLabel";
            this.dealerNameLabel.Size = new System.Drawing.Size(54, 20);
            this.dealerNameLabel.TabIndex = 1;
            this.dealerNameLabel.Text = "Dealer";
            // 
            // playerScoreLabel
            // 
            this.playerScoreLabel.AutoSize = true;
            this.playerScoreLabel.Location = new System.Drawing.Point(25, 76);
            this.playerScoreLabel.Name = "playerScoreLabel";
            this.playerScoreLabel.Size = new System.Drawing.Size(49, 20);
            this.playerScoreLabel.TabIndex = 2;
            this.playerScoreLabel.Text = "Score:";
            // 
            // playerCardsLabel
            // 
            this.playerCardsLabel.AutoSize = true;
            this.playerCardsLabel.Location = new System.Drawing.Point(25, 115);
            this.playerCardsLabel.Name = "playerCardsLabel";
            this.playerCardsLabel.Size = new System.Drawing.Size(49, 20);
            this.playerCardsLabel.TabIndex = 3;
            this.playerCardsLabel.Text = "Cards:";
            // 
            // dealerScoreLabel
            // 
            this.dealerScoreLabel.AutoSize = true;
            this.dealerScoreLabel.Location = new System.Drawing.Point(25, 235);
            this.dealerScoreLabel.Name = "dealerScoreLabel";
            this.dealerScoreLabel.Size = new System.Drawing.Size(49, 20);
            this.dealerScoreLabel.TabIndex = 4;
            this.dealerScoreLabel.Text = "Score:";
            // 
            // dealerCardsLabel
            // 
            this.dealerCardsLabel.AutoSize = true;
            this.dealerCardsLabel.Location = new System.Drawing.Point(24, 275);
            this.dealerCardsLabel.Name = "dealerCardsLabel";
            this.dealerCardsLabel.Size = new System.Drawing.Size(49, 20);
            this.dealerCardsLabel.TabIndex = 5;
            this.dealerCardsLabel.Text = "Cards:";
            // 
            // showPlayerScoreLabel
            // 
            this.showPlayerScoreLabel.AutoSize = true;
            this.showPlayerScoreLabel.Location = new System.Drawing.Point(119, 76);
            this.showPlayerScoreLabel.Name = "showPlayerScoreLabel";
            this.showPlayerScoreLabel.Size = new System.Drawing.Size(17, 20);
            this.showPlayerScoreLabel.TabIndex = 6;
            this.showPlayerScoreLabel.Text = "0";
            // 
            // showPlayerCardsLabel
            // 
            this.showPlayerCardsLabel.AutoSize = true;
            this.showPlayerCardsLabel.Location = new System.Drawing.Point(119, 115);
            this.showPlayerCardsLabel.Name = "showPlayerCardsLabel";
            this.showPlayerCardsLabel.Size = new System.Drawing.Size(15, 20);
            this.showPlayerCardsLabel.TabIndex = 7;
            this.showPlayerCardsLabel.Text = "-";
            // 
            // showDealerScoreLabel
            // 
            this.showDealerScoreLabel.AutoSize = true;
            this.showDealerScoreLabel.Location = new System.Drawing.Point(119, 235);
            this.showDealerScoreLabel.Name = "showDealerScoreLabel";
            this.showDealerScoreLabel.Size = new System.Drawing.Size(17, 20);
            this.showDealerScoreLabel.TabIndex = 8;
            this.showDealerScoreLabel.Text = "0";
            // 
            // showDealerCardsLabel
            // 
            this.showDealerCardsLabel.AutoSize = true;
            this.showDealerCardsLabel.Location = new System.Drawing.Point(119, 275);
            this.showDealerCardsLabel.Name = "showDealerCardsLabel";
            this.showDealerCardsLabel.Size = new System.Drawing.Size(15, 20);
            this.showDealerCardsLabel.TabIndex = 9;
            this.showDealerCardsLabel.Text = "-";
            // 
            // dealButton
            // 
            this.dealButton.Location = new System.Drawing.Point(24, 355);
            this.dealButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dealButton.Name = "dealButton";
            this.dealButton.Size = new System.Drawing.Size(86, 31);
            this.dealButton.TabIndex = 10;
            this.dealButton.Text = "Deal";
            this.dealButton.UseVisualStyleBackColor = true;
            this.dealButton.Click += new System.EventHandler(this.dealButton_Click);
            // 
            // hitButton
            // 
            this.hitButton.Location = new System.Drawing.Point(137, 355);
            this.hitButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hitButton.Name = "hitButton";
            this.hitButton.Size = new System.Drawing.Size(86, 31);
            this.hitButton.TabIndex = 11;
            this.hitButton.Text = "Hit";
            this.hitButton.UseVisualStyleBackColor = true;
            this.hitButton.Click += new System.EventHandler(this.hitButton_Click);
            // 
            // stayButton
            // 
            this.stayButton.Location = new System.Drawing.Point(249, 355);
            this.stayButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stayButton.Name = "stayButton";
            this.stayButton.Size = new System.Drawing.Size(86, 31);
            this.stayButton.TabIndex = 12;
            this.stayButton.Text = "Stay";
            this.stayButton.UseVisualStyleBackColor = true;
            this.stayButton.Click += new System.EventHandler(this.stayButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(367, 355);
            this.resetButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(86, 31);
            this.resetButton.TabIndex = 13;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 411);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.stayButton);
            this.Controls.Add(this.hitButton);
            this.Controls.Add(this.dealButton);
            this.Controls.Add(this.showDealerCardsLabel);
            this.Controls.Add(this.showDealerScoreLabel);
            this.Controls.Add(this.showPlayerCardsLabel);
            this.Controls.Add(this.showPlayerScoreLabel);
            this.Controls.Add(this.dealerCardsLabel);
            this.Controls.Add(this.dealerScoreLabel);
            this.Controls.Add(this.playerCardsLabel);
            this.Controls.Add(this.playerScoreLabel);
            this.Controls.Add(this.dealerNameLabel);
            this.Controls.Add(this.playerNameLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GameScreen";
            this.Text = "Blackjack";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label playerNameLabel;
        private Label dealerNameLabel;
        private Label playerScoreLabel;
        private Label playerCardsLabel;
        private Label dealerScoreLabel;
        private Label dealerCardsLabel;
        private Label showPlayerScoreLabel;
        private Label showPlayerCardsLabel;
        private Label showDealerScoreLabel;
        private Label showDealerCardsLabel;
        private Button dealButton;
        private Button hitButton;
        private Button stayButton;
        private Button resetButton;
    }
}
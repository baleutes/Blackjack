namespace L1
{
    partial class WelcomeScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.newGameButton = new System.Windows.Forms.Button();
            this.quitGameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.welcomeLabel.Location = new System.Drawing.Point(46, 39);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(166, 20);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome to Blackjack!";
            // 
            // newGameButton
            // 
            this.newGameButton.Location = new System.Drawing.Point(75, 96);
            this.newGameButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(104, 31);
            this.newGameButton.TabIndex = 1;
            this.newGameButton.Text = "New game";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // quitGameButton
            // 
            this.quitGameButton.Location = new System.Drawing.Point(75, 151);
            this.quitGameButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.quitGameButton.Name = "quitGameButton";
            this.quitGameButton.Size = new System.Drawing.Size(104, 31);
            this.quitGameButton.TabIndex = 2;
            this.quitGameButton.Text = "Quit";
            this.quitGameButton.UseVisualStyleBackColor = true;
            this.quitGameButton.Click += new System.EventHandler(this.quitGameButton_Click);
            // 
            // WelcomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 235);
            this.Controls.Add(this.quitGameButton);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.welcomeLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "WelcomeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blackjack";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label welcomeLabel;
        private Button newGameButton;
        private Button quitGameButton;
    }
}
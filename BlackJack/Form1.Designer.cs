namespace BlackJack
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox playerCardsListBox;
        private System.Windows.Forms.ListBox dealerCardsListBox;
        private System.Windows.Forms.Label playerCardsLabel;
        private System.Windows.Forms.Button hitButton;
        private System.Windows.Forms.Button standButton;
        private System.Windows.Forms.PictureBox backgroundPictureBox;
        private System.Windows.Forms.Label playerBalanceLabel;
        private System.Windows.Forms.Label currentBetLabel;
        private System.Windows.Forms.Button bet5Button;
        private System.Windows.Forms.Button bet10Button;
        private System.Windows.Forms.Button bet20Button;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.playerBalanceLabel = new System.Windows.Forms.Label();
            this.currentBetLabel = new System.Windows.Forms.Label();
            this.playerCardsListBox = new System.Windows.Forms.ListBox();
            this.dealerCardsListBox = new System.Windows.Forms.ListBox();
            this.playerCardsLabel = new System.Windows.Forms.Label();
            this.hitButton = new System.Windows.Forms.Button();
            this.standButton = new System.Windows.Forms.Button();
            this.bet5Button = new System.Windows.Forms.Button();
            this.bet10Button = new System.Windows.Forms.Button();
            this.bet20Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.backgroundPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // playerBalanceLabel
            // 
            this.playerBalanceLabel.AutoSize = true;
            this.playerBalanceLabel.BackColor = System.Drawing.Color.White;
            this.playerBalanceLabel.ForeColor = System.Drawing.Color.Black;
            this.playerBalanceLabel.Location = new System.Drawing.Point(119, 100);
            this.playerBalanceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.playerBalanceLabel.Name = "playerBalanceLabel";
            this.playerBalanceLabel.Size = new System.Drawing.Size(52, 13);
            this.playerBalanceLabel.TabIndex = 7;
            this.playerBalanceLabel.Text = "Баланс: ";
            // 
            // currentBetLabel
            // 
            this.currentBetLabel.AutoSize = true;
            this.currentBetLabel.BackColor = System.Drawing.Color.White;
            this.currentBetLabel.ForeColor = System.Drawing.Color.Black;
            this.currentBetLabel.Location = new System.Drawing.Point(332, 100);
            this.currentBetLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currentBetLabel.Name = "currentBetLabel";
            this.currentBetLabel.Size = new System.Drawing.Size(84, 13);
            this.currentBetLabel.TabIndex = 8;
            this.currentBetLabel.Text = "Поточна ставка:";
            // 
            // playerCardsListBox
            // 
            this.playerCardsListBox.BackColor = System.Drawing.Color.White;
            this.playerCardsListBox.ForeColor = System.Drawing.Color.Black;
            this.playerCardsListBox.FormattingEnabled = true;
            this.playerCardsListBox.Location = new System.Drawing.Point(421, 332);
            this.playerCardsListBox.Margin = new System.Windows.Forms.Padding(2);
            this.playerCardsListBox.Name = "playerCardsListBox";
            this.playerCardsListBox.Size = new System.Drawing.Size(127, 147);
            this.playerCardsListBox.TabIndex = 0;
            // 
            // dealerCardsListBox
            // 
            this.dealerCardsListBox.BackColor = System.Drawing.Color.White;
            this.dealerCardsListBox.ForeColor = System.Drawing.Color.Black;
            this.dealerCardsListBox.FormattingEnabled = true;
            this.dealerCardsListBox.Location = new System.Drawing.Point(156, 315);
            this.dealerCardsListBox.Margin = new System.Windows.Forms.Padding(2);
            this.dealerCardsListBox.Name = "dealerCardsListBox";
            this.dealerCardsListBox.Size = new System.Drawing.Size(128, 147);
            this.dealerCardsListBox.TabIndex = 1;
            // 
            // playerCardsLabel
            // 
            this.playerCardsLabel.AutoSize = true;
            this.playerCardsLabel.BackColor = System.Drawing.Color.White;
            this.playerCardsLabel.ForeColor = System.Drawing.Color.Black;
            this.playerCardsLabel.Location = new System.Drawing.Point(423, 315);
            this.playerCardsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.playerCardsLabel.Name = "playerCardsLabel";
            this.playerCardsLabel.Size = new System.Drawing.Size(52, 13);
            this.playerCardsLabel.TabIndex = 2;
            this.playerCardsLabel.Text = "Гравець:";
            // 
            // hitButton
            // 
            this.hitButton.BackColor = System.Drawing.Color.Gray;
            this.hitButton.ForeColor = System.Drawing.Color.White;
            this.hitButton.Location = new System.Drawing.Point(421, 483);
            this.hitButton.Margin = new System.Windows.Forms.Padding(2);
            this.hitButton.Name = "hitButton";
            this.hitButton.Size = new System.Drawing.Size(56, 19);
            this.hitButton.TabIndex = 4;
            this.hitButton.Text = "Взяти";
            this.hitButton.UseVisualStyleBackColor = false;
            this.hitButton.Click += new System.EventHandler(this.HitButton_Click);
            // 
            // standButton
            // 
            this.standButton.BackColor = System.Drawing.Color.Gray;
            this.standButton.ForeColor = System.Drawing.Color.White;
            this.standButton.Location = new System.Drawing.Point(492, 483);
            this.standButton.Margin = new System.Windows.Forms.Padding(2);
            this.standButton.Name = "standButton";
            this.standButton.Size = new System.Drawing.Size(56, 19);
            this.standButton.TabIndex = 5;
            this.standButton.Text = "Стоп";
            this.standButton.UseVisualStyleBackColor = false;
            this.standButton.Click += new System.EventHandler(this.StandButton_Click);
            // 
            // bet5Button
            // 
            this.bet5Button.BackColor = System.Drawing.Color.Gray;
            this.bet5Button.ForeColor = System.Drawing.Color.White;
            this.bet5Button.Location = new System.Drawing.Point(75, 250);
            this.bet5Button.Margin = new System.Windows.Forms.Padding(2);
            this.bet5Button.Name = "bet5Button";
            this.bet5Button.Size = new System.Drawing.Size(56, 19);
            this.bet5Button.TabIndex = 9;
            this.bet5Button.Text = "5";
            this.bet5Button.UseVisualStyleBackColor = false;
            this.bet5Button.Click += new System.EventHandler(this.BetButton_Click);
            // 
            // bet10Button
            // 
            this.bet10Button.BackColor = System.Drawing.Color.Gray;
            this.bet10Button.ForeColor = System.Drawing.Color.White;
            this.bet10Button.Location = new System.Drawing.Point(135, 250);
            this.bet10Button.Margin = new System.Windows.Forms.Padding(2);
            this.bet10Button.Name = "bet10Button";
            this.bet10Button.Size = new System.Drawing.Size(56, 19);
            this.bet10Button.TabIndex = 10;
            this.bet10Button.Text = "10";
            this.bet10Button.UseVisualStyleBackColor = false;
            this.bet10Button.Click += new System.EventHandler(this.BetButton_Click);
            // 
            // bet20Button
            // 
            this.bet20Button.BackColor = System.Drawing.Color.Gray;
            this.bet20Button.ForeColor = System.Drawing.Color.White;
            this.bet20Button.Location = new System.Drawing.Point(195, 250);
            this.bet20Button.Margin = new System.Windows.Forms.Padding(2);
            this.bet20Button.Name = "bet20Button";
            this.bet20Button.Size = new System.Drawing.Size(56, 19);
            this.bet20Button.TabIndex = 11;
            this.bet20Button.Text = "20";
            this.bet20Button.UseVisualStyleBackColor = false;
            this.bet20Button.Click += new System.EventHandler(this.BetButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(651, 604);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(566, 552);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(637, 552);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(708, 552);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(65, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // backgroundPictureBox
            // 
            this.backgroundPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backgroundPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("backgroundPictureBox.Image")));
            this.backgroundPictureBox.Location = new System.Drawing.Point(0, 0);
            this.backgroundPictureBox.Name = "backgroundPictureBox";
            this.backgroundPictureBox.Size = new System.Drawing.Size(976, 626);
            this.backgroundPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backgroundPictureBox.TabIndex = 6;
            this.backgroundPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(976, 626);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.standButton);
            this.Controls.Add(this.hitButton);
            this.Controls.Add(this.playerCardsLabel);
            this.Controls.Add(this.dealerCardsListBox);
            this.Controls.Add(this.playerCardsListBox);
            this.Controls.Add(this.backgroundPictureBox);
            this.Controls.Add(this.bet5Button);
            this.Controls.Add(this.bet10Button);
            this.Controls.Add(this.bet20Button);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "BlackJack";
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

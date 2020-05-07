namespace Cards
{
    partial class BlackJack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlackJack));
            this.Deal = new System.Windows.Forms.Button();
            this.CurrentCard = new System.Windows.Forms.TextBox();
            this.PlayersHand = new System.Windows.Forms.TextBox();
            this.DealersHand = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.PlayerWins = new System.Windows.Forms.TextBox();
            this.PlayerName = new System.Windows.Forms.TextBox();
            this.DealerName = new System.Windows.Forms.TextBox();
            this.DealerWins = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.betBtn = new System.Windows.Forms.Button();
            this.BetOptions = new System.Windows.Forms.ComboBox();
            this.Bank = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Deal
            // 
            this.Deal.BackColor = System.Drawing.Color.DimGray;
            this.Deal.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deal.Location = new System.Drawing.Point(193, 192);
            this.Deal.Name = "Deal";
            this.Deal.Size = new System.Drawing.Size(138, 71);
            this.Deal.TabIndex = 0;
            this.Deal.Text = "Deal";
            this.Deal.UseVisualStyleBackColor = false;
            this.Deal.Click += new System.EventHandler(this.Deal_Click);
            // 
            // CurrentCard
            // 
            this.CurrentCard.BackColor = System.Drawing.Color.Black;
            this.CurrentCard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CurrentCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentCard.ForeColor = System.Drawing.Color.DarkRed;
            this.CurrentCard.Location = new System.Drawing.Point(12, 269);
            this.CurrentCard.Name = "CurrentCard";
            this.CurrentCard.ReadOnly = true;
            this.CurrentCard.Size = new System.Drawing.Size(500, 27);
            this.CurrentCard.TabIndex = 1;
            this.CurrentCard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PlayersHand
            // 
            this.PlayersHand.AcceptsReturn = true;
            this.PlayersHand.BackColor = System.Drawing.Color.Black;
            this.PlayersHand.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PlayersHand.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayersHand.ForeColor = System.Drawing.Color.Silver;
            this.PlayersHand.Location = new System.Drawing.Point(12, 107);
            this.PlayersHand.Multiline = true;
            this.PlayersHand.Name = "PlayersHand";
            this.PlayersHand.ReadOnly = true;
            this.PlayersHand.Size = new System.Drawing.Size(500, 79);
            this.PlayersHand.TabIndex = 2;
            this.PlayersHand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PlayersHand.WordWrap = false;
            // 
            // DealersHand
            // 
            this.DealersHand.BackColor = System.Drawing.Color.Black;
            this.DealersHand.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DealersHand.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DealersHand.ForeColor = System.Drawing.Color.Silver;
            this.DealersHand.Location = new System.Drawing.Point(12, 12);
            this.DealersHand.Multiline = true;
            this.DealersHand.Name = "DealersHand";
            this.DealersHand.ReadOnly = true;
            this.DealersHand.Size = new System.Drawing.Size(500, 65);
            this.DealersHand.TabIndex = 3;
            this.DealersHand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 192);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 71);
            this.button2.TabIndex = 4;
            this.button2.Text = "Hit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Hit_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DimGray;
            this.button3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(337, 192);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(175, 71);
            this.button3.TabIndex = 5;
            this.button3.Text = "Stand";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Stand_Click);
            // 
            // PlayerWins
            // 
            this.PlayerWins.BackColor = System.Drawing.Color.Black;
            this.PlayerWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerWins.ForeColor = System.Drawing.Color.DarkRed;
            this.PlayerWins.Location = new System.Drawing.Point(472, 164);
            this.PlayerWins.Name = "PlayerWins";
            this.PlayerWins.ReadOnly = true;
            this.PlayerWins.Size = new System.Drawing.Size(40, 27);
            this.PlayerWins.TabIndex = 6;
            this.PlayerWins.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PlayerName
            // 
            this.PlayerName.BackColor = System.Drawing.Color.Black;
            this.PlayerName.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerName.ForeColor = System.Drawing.Color.DarkRed;
            this.PlayerName.Location = new System.Drawing.Point(12, 164);
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.ReadOnly = true;
            this.PlayerName.Size = new System.Drawing.Size(100, 27);
            this.PlayerName.TabIndex = 7;
            // 
            // DealerName
            // 
            this.DealerName.BackColor = System.Drawing.Color.Black;
            this.DealerName.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DealerName.ForeColor = System.Drawing.Color.DarkRed;
            this.DealerName.Location = new System.Drawing.Point(12, 12);
            this.DealerName.Name = "DealerName";
            this.DealerName.ReadOnly = true;
            this.DealerName.Size = new System.Drawing.Size(100, 27);
            this.DealerName.TabIndex = 8;
            // 
            // DealerWins
            // 
            this.DealerWins.BackColor = System.Drawing.Color.Black;
            this.DealerWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DealerWins.ForeColor = System.Drawing.Color.DarkRed;
            this.DealerWins.Location = new System.Drawing.Point(472, 12);
            this.DealerWins.Name = "DealerWins";
            this.DealerWins.ReadOnly = true;
            this.DealerWins.Size = new System.Drawing.Size(40, 27);
            this.DealerWins.TabIndex = 9;
            this.DealerWins.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1.Location = new System.Drawing.Point(146, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 46);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "BLVCK JVCK";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // betBtn
            // 
            this.betBtn.BackColor = System.Drawing.Color.DimGray;
            this.betBtn.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betBtn.Location = new System.Drawing.Point(116, 164);
            this.betBtn.Name = "betBtn";
            this.betBtn.Size = new System.Drawing.Size(70, 27);
            this.betBtn.TabIndex = 11;
            this.betBtn.Text = "Bet";
            this.betBtn.UseVisualStyleBackColor = false;
            this.betBtn.Click += new System.EventHandler(this.betBtn_Click);
            // 
            // BetOptions
            // 
            this.BetOptions.BackColor = System.Drawing.Color.Black;
            this.BetOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BetOptions.ForeColor = System.Drawing.Color.DarkRed;
            this.BetOptions.FormattingEnabled = true;
            this.BetOptions.Items.AddRange(new object[] {
            "1",
            "2",
            "5",
            "10",
            "25",
            "50"});
            this.BetOptions.Location = new System.Drawing.Point(337, 163);
            this.BetOptions.Name = "BetOptions";
            this.BetOptions.Size = new System.Drawing.Size(132, 28);
            this.BetOptions.TabIndex = 12;
            // 
            // Bank
            // 
            this.Bank.BackColor = System.Drawing.Color.Black;
            this.Bank.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Bank.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bank.ForeColor = System.Drawing.Color.DarkRed;
            this.Bank.Location = new System.Drawing.Point(12, 138);
            this.Bank.Name = "Bank";
            this.Bank.Size = new System.Drawing.Size(80, 20);
            this.Bank.TabIndex = 13;
            // 
            // BlackJack
            // 
            this.AcceptButton = this.betBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(528, 307);
            this.Controls.Add(this.Bank);
            this.Controls.Add(this.BetOptions);
            this.Controls.Add(this.betBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DealerWins);
            this.Controls.Add(this.DealerName);
            this.Controls.Add(this.PlayerName);
            this.Controls.Add(this.PlayerWins);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.DealersHand);
            this.Controls.Add(this.PlayersHand);
            this.Controls.Add(this.CurrentCard);
            this.Controls.Add(this.Deal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(546, 354);
            this.MinimumSize = new System.Drawing.Size(546, 354);
            this.Name = "BlackJack";
            this.Text = "Blvck Jvck";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BlackJack_FormClosing);
            this.Shown += new System.EventHandler(this.BlackJack_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        #region WF Objects
        private System.Windows.Forms.Button Deal;
        private System.Windows.Forms.TextBox CurrentCard;
        private System.Windows.Forms.TextBox PlayersHand;
        private System.Windows.Forms.TextBox DealersHand;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox PlayerWins;
        private System.Windows.Forms.TextBox PlayerName;
        private System.Windows.Forms.TextBox DealerName;
        private System.Windows.Forms.TextBox DealerWins;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button betBtn;
        private System.Windows.Forms.ComboBox BetOptions;
        private System.Windows.Forms.TextBox Bank;
        #endregion
    }
}

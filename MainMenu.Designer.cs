namespace Cards
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.blackjack = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.Button();
            this.loginStatus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.log_button = new System.Windows.Forms.Button();
            this.roulette = new System.Windows.Forms.Button();
            this.checkFunds = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // blackjack
            // 
            this.blackjack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.blackjack.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blackjack.ForeColor = System.Drawing.Color.DarkRed;
            this.blackjack.Location = new System.Drawing.Point(12, 79);
            this.blackjack.Name = "blackjack";
            this.blackjack.Size = new System.Drawing.Size(250, 50);
            this.blackjack.TabIndex = 0;
            this.blackjack.Text = "Play BlvckJvck";
            this.blackjack.UseVisualStyleBackColor = false;
            this.blackjack.Click += new System.EventHandler(this.blackjack_Click);
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.login.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.ForeColor = System.Drawing.Color.DarkRed;
            this.login.Location = new System.Drawing.Point(163, 12);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(99, 28);
            this.login.TabIndex = 1;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // loginStatus
            // 
            this.loginStatus.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.loginStatus.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginStatus.ForeColor = System.Drawing.Color.DarkRed;
            this.loginStatus.Location = new System.Drawing.Point(12, 12);
            this.loginStatus.Name = "loginStatus";
            this.loginStatus.ReadOnly = true;
            this.loginStatus.Size = new System.Drawing.Size(134, 27);
            this.loginStatus.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Virtual Casino";
            // 
            // log_button
            // 
            this.log_button.Location = new System.Drawing.Point(12, 191);
            this.log_button.Name = "log_button";
            this.log_button.Size = new System.Drawing.Size(100, 32);
            this.log_button.TabIndex = 4;
            this.log_button.Text = "View Log";
            this.log_button.UseVisualStyleBackColor = true;
            this.log_button.Click += new System.EventHandler(this.log_button_Click);
            // 
            // roulette
            // 
            this.roulette.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.roulette.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roulette.ForeColor = System.Drawing.Color.DarkRed;
            this.roulette.Location = new System.Drawing.Point(12, 135);
            this.roulette.Name = "roulette";
            this.roulette.Size = new System.Drawing.Size(250, 50);
            this.roulette.TabIndex = 5;
            this.roulette.Text = "Play Roulette";
            this.roulette.UseVisualStyleBackColor = false;
            this.roulette.Click += new System.EventHandler(this.roulette_Click);
            // 
            // checkFunds
            // 
            this.checkFunds.Location = new System.Drawing.Point(163, 191);
            this.checkFunds.Name = "checkFunds";
            this.checkFunds.Size = new System.Drawing.Size(100, 32);
            this.checkFunds.TabIndex = 6;
            this.checkFunds.Text = "View Funds";
            this.checkFunds.UseVisualStyleBackColor = true;
            this.checkFunds.Click += new System.EventHandler(this.checkFunds_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(275, 231);
            this.Controls.Add(this.checkFunds);
            this.Controls.Add(this.roulette);
            this.Controls.Add(this.log_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginStatus);
            this.Controls.Add(this.login);
            this.Controls.Add(this.blackjack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(293, 278);
            this.MinimumSize = new System.Drawing.Size(293, 278);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Virtual Casino";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenu_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button blackjack;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.TextBox loginStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button log_button;
        private System.Windows.Forms.Button roulette;
        private System.Windows.Forms.Button checkFunds;
    }
}
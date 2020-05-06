namespace Cards
{
    partial class Roulette
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Roulette));
            this.wheel = new System.Windows.Forms.PictureBox();
            this.placeBets = new System.Windows.Forms.Button();
            this.spin = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.bank = new System.Windows.Forms.Label();
            this.resultText = new System.Windows.Forms.TextBox();
            this.playerName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.wheel)).BeginInit();
            this.SuspendLayout();
            // 
            // wheel
            // 
            this.wheel.Image = ((System.Drawing.Image)(resources.GetObject("wheel.Image")));
            this.wheel.InitialImage = ((System.Drawing.Image)(resources.GetObject("wheel.InitialImage")));
            this.wheel.Location = new System.Drawing.Point(12, 12);
            this.wheel.Name = "wheel";
            this.wheel.Size = new System.Drawing.Size(400, 400);
            this.wheel.TabIndex = 0;
            this.wheel.TabStop = false;
            // 
            // placeBets
            // 
            this.placeBets.BackColor = System.Drawing.Color.Black;
            this.placeBets.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeBets.ForeColor = System.Drawing.Color.DarkRed;
            this.placeBets.Location = new System.Drawing.Point(12, 321);
            this.placeBets.Name = "placeBets";
            this.placeBets.Size = new System.Drawing.Size(394, 54);
            this.placeBets.TabIndex = 1;
            this.placeBets.Text = "Place Bets";
            this.placeBets.UseVisualStyleBackColor = false;
            this.placeBets.Click += new System.EventHandler(this.placeBets_Click);
            // 
            // spin
            // 
            this.spin.BackColor = System.Drawing.Color.Black;
            this.spin.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spin.ForeColor = System.Drawing.Color.DarkRed;
            this.spin.Location = new System.Drawing.Point(138, 277);
            this.spin.Name = "spin";
            this.spin.Size = new System.Drawing.Size(139, 38);
            this.spin.TabIndex = 2;
            this.spin.Text = "Spin";
            this.spin.UseVisualStyleBackColor = false;
            this.spin.Click += new System.EventHandler(this.button1_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.BackColor = System.Drawing.Color.Transparent;
            this.result.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.ForeColor = System.Drawing.Color.DarkRed;
            this.result.Location = new System.Drawing.Point(12, 12);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(45, 33);
            this.result.TabIndex = 3;
            this.result.Text = "  ";
            // 
            // bank
            // 
            this.bank.AutoSize = true;
            this.bank.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bank.ForeColor = System.Drawing.Color.DarkRed;
            this.bank.Location = new System.Drawing.Point(352, 37);
            this.bank.Name = "bank";
            this.bank.Size = new System.Drawing.Size(54, 23);
            this.bank.TabIndex = 4;
            this.bank.Text = "$XXX";
            // 
            // resultText
            // 
            this.resultText.BackColor = System.Drawing.Color.Black;
            this.resultText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultText.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultText.ForeColor = System.Drawing.Color.DarkRed;
            this.resultText.Location = new System.Drawing.Point(16, 381);
            this.resultText.Name = "resultText";
            this.resultText.ReadOnly = true;
            this.resultText.Size = new System.Drawing.Size(390, 24);
            this.resultText.TabIndex = 5;
            // 
            // playerName
            // 
            this.playerName.BackColor = System.Drawing.Color.Black;
            this.playerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playerName.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerName.ForeColor = System.Drawing.Color.DarkRed;
            this.playerName.Location = new System.Drawing.Point(287, 10);
            this.playerName.Name = "playerName";
            this.playerName.ReadOnly = true;
            this.playerName.Size = new System.Drawing.Size(125, 24);
            this.playerName.TabIndex = 7;
            this.playerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Roulette
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(418, 415);
            this.Controls.Add(this.playerName);
            this.Controls.Add(this.resultText);
            this.Controls.Add(this.bank);
            this.Controls.Add(this.result);
            this.Controls.Add(this.spin);
            this.Controls.Add(this.placeBets);
            this.Controls.Add(this.wheel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Roulette";
            this.Text = "Roulette";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Roulette_FormClosed);
            this.Shown += new System.EventHandler(this.Roulette_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.wheel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox wheel;
        private System.Windows.Forms.Button placeBets;
        private System.Windows.Forms.Button spin;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label bank;
        private System.Windows.Forms.TextBox resultText;
        private System.Windows.Forms.TextBox playerName;
    }
}
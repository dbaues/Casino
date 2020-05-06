namespace Cards
{
    partial class VirtualCasinoLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VirtualCasinoLogin));
            this.uname = new System.Windows.Forms.TextBox();
            this.pwd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.confirmLogin = new System.Windows.Forms.Button();
            this.newAcct = new System.Windows.Forms.Button();
            this.text1 = new System.Windows.Forms.TextBox();
            this.guest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uname
            // 
            this.uname.Location = new System.Drawing.Point(17, 40);
            this.uname.Name = "uname";
            this.uname.Size = new System.Drawing.Size(328, 22);
            this.uname.TabIndex = 0;
            this.uname.TextChanged += new System.EventHandler(this.uname_TextChanged);
            // 
            // pwd
            // 
            this.pwd.Location = new System.Drawing.Point(17, 96);
            this.pwd.MaxLength = 32;
            this.pwd.Name = "pwd";
            this.pwd.PasswordChar = '*';
            this.pwd.Size = new System.Drawing.Size(328, 22);
            this.pwd.TabIndex = 1;
            this.pwd.TextChanged += new System.EventHandler(this.pwd_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // confirmLogin
            // 
            this.confirmLogin.BackColor = System.Drawing.Color.SlateGray;
            this.confirmLogin.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmLogin.Location = new System.Drawing.Point(257, 132);
            this.confirmLogin.Name = "confirmLogin";
            this.confirmLogin.Size = new System.Drawing.Size(88, 27);
            this.confirmLogin.TabIndex = 4;
            this.confirmLogin.Text = "Login";
            this.confirmLogin.UseVisualStyleBackColor = false;
            this.confirmLogin.Click += new System.EventHandler(this.confirmLogin_Click);
            // 
            // newAcct
            // 
            this.newAcct.BackColor = System.Drawing.Color.SlateGray;
            this.newAcct.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newAcct.Location = new System.Drawing.Point(17, 132);
            this.newAcct.Name = "newAcct";
            this.newAcct.Size = new System.Drawing.Size(138, 27);
            this.newAcct.TabIndex = 5;
            this.newAcct.Text = "New Account";
            this.newAcct.UseVisualStyleBackColor = false;
            this.newAcct.Click += new System.EventHandler(this.newAcct_Click);
            // 
            // text1
            // 
            this.text1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.text1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text1.ForeColor = System.Drawing.Color.DarkRed;
            this.text1.Location = new System.Drawing.Point(137, 13);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(207, 15);
            this.text1.TabIndex = 6;
            this.text1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // guest
            // 
            this.guest.BackColor = System.Drawing.Color.SlateGray;
            this.guest.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guest.Location = new System.Drawing.Point(161, 132);
            this.guest.Name = "guest";
            this.guest.Size = new System.Drawing.Size(90, 27);
            this.guest.TabIndex = 7;
            this.guest.Text = "Guest";
            this.guest.UseVisualStyleBackColor = false;
            this.guest.Click += new System.EventHandler(this.guest_Click);
            // 
            // VirtualCasinoLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(366, 171);
            this.Controls.Add(this.guest);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.newAcct);
            this.Controls.Add(this.confirmLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pwd);
            this.Controls.Add(this.uname);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VirtualCasinoLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VirtualCasinoLogin_FormClosed);
            this.Shown += new System.EventHandler(this.VirtualCasinoLogin_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uname;
        private System.Windows.Forms.TextBox pwd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button confirmLogin;
        private System.Windows.Forms.Button newAcct;
        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.Button guest;
    }
}
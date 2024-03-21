namespace KursReady
{
    partial class Auth
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
            AuthLog = new TextBox();
            AuthPwd = new TextBox();
            MakeAuth = new Button();
            goReg = new Button();
            SuspendLayout();
            // 
            // AuthLog
            // 
            AuthLog.Location = new Point(26, 12);
            AuthLog.Name = "AuthLog";
            AuthLog.PlaceholderText = "Login";
            AuthLog.Size = new Size(328, 23);
            AuthLog.TabIndex = 0;
            // 
            // AuthPwd
            // 
            AuthPwd.Location = new Point(26, 41);
            AuthPwd.Name = "AuthPwd";
            AuthPwd.PasswordChar = '*';
            AuthPwd.PlaceholderText = "Password";
            AuthPwd.Size = new Size(328, 23);
            AuthPwd.TabIndex = 1;
            // 
            // MakeAuth
            // 
            MakeAuth.AutoSize = true;
            MakeAuth.Location = new Point(198, 70);
            MakeAuth.Name = "MakeAuth";
            MakeAuth.Size = new Size(75, 25);
            MakeAuth.TabIndex = 2;
            MakeAuth.Text = "Auth";
            MakeAuth.UseVisualStyleBackColor = true;
            MakeAuth.Click += button1_Click;
            // 
            // goReg
            // 
            goReg.AutoSize = true;
            goReg.Location = new Point(279, 70);
            goReg.Name = "goReg";
            goReg.Size = new Size(75, 25);
            goReg.TabIndex = 3;
            goReg.Text = "Reg";
            goReg.UseVisualStyleBackColor = true;
            goReg.Click += goReg_Click;
            // 
            // Auth
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 217);
            Controls.Add(goReg);
            Controls.Add(MakeAuth);
            Controls.Add(AuthPwd);
            Controls.Add(AuthLog);
            Name = "Auth";
            Text = "Auth";
            FormClosing += Auth_FormClosing;
            FormClosed += Auth_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox AuthLog;
        private TextBox AuthPwd;
        private Button MakeAuth;
        private Button goReg;
    }
}
namespace KursReady
{
    partial class Reg
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
            MakeReg = new Button();
            RegLogin = new TextBox();
            regPwd = new TextBox();
            SuspendLayout();
            // 
            // MakeReg
            // 
            MakeReg.Location = new Point(213, 96);
            MakeReg.Name = "MakeReg";
            MakeReg.Size = new Size(93, 23);
            MakeReg.TabIndex = 0;
            MakeReg.Text = "Regist";
            MakeReg.UseVisualStyleBackColor = true;
            MakeReg.Click += MakeReg_Click;
            // 
            // RegLogin
            // 
            RegLogin.Location = new Point(84, 21);
            RegLogin.Name = "RegLogin";
            RegLogin.Size = new Size(222, 23);
            RegLogin.TabIndex = 1;
            // 
            // regPwd
            // 
            regPwd.Location = new Point(84, 67);
            regPwd.Name = "regPwd";
            regPwd.Size = new Size(222, 23);
            regPwd.TabIndex = 2;
            // 
            // Reg
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 247);
            Controls.Add(regPwd);
            Controls.Add(RegLogin);
            Controls.Add(MakeReg);
            Name = "Reg";
            Text = "Reg";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button MakeReg;
        private TextBox RegLogin;
        private TextBox regPwd;
    }
}
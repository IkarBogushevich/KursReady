namespace KursReady
{
    partial class Form1
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
            MakeSort = new Button();
            output = new Label();
            input = new TextBox();
            SuspendLayout();
            // 
            // MakeSort
            // 
            MakeSort.Location = new Point(98, 148);
            MakeSort.Name = "MakeSort";
            MakeSort.Size = new Size(278, 23);
            MakeSort.TabIndex = 0;
            MakeSort.Text = "Encr";
            MakeSort.UseVisualStyleBackColor = true;
            MakeSort.Click += MakeSort_Click;
            // 
            // output
            // 
            output.AutoSize = true;
            output.Location = new Point(98, 92);
            output.Name = "output";
            output.Size = new Size(44, 15);
            output.TabIndex = 1;
            output.Text = "Results";
            // 
            // input
            // 
            input.Location = new Point(98, 32);
            input.Name = "input";
            input.Size = new Size(278, 23);
            input.TabIndex = 2;
            input.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 348);
            Controls.Add(input);
            Controls.Add(output);
            Controls.Add(MakeSort);
            Name = "Form1";
            Text = "Encrypt";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button MakeSort;
        private Label output;
        private TextBox input;
    }
}

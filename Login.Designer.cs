namespace e_booking
{
    partial class Login
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
            submit_btn = new Button();
            Password = new TextBox();
            Email = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // submit_btn
            // 
            submit_btn.Location = new Point(251, 153);
            submit_btn.Name = "submit_btn";
            submit_btn.Size = new Size(94, 29);
            submit_btn.TabIndex = 9;
            submit_btn.Text = "Submit";
            submit_btn.UseVisualStyleBackColor = true;
            submit_btn.Click += submit_btn_Click;
            // 
            // Password
            // 
            Password.Location = new Point(154, 99);
            Password.Name = "Password";
            Password.Size = new Size(191, 27);
            Password.TabIndex = 8;
            Password.UseSystemPasswordChar = true;
            // 
            // Email
            // 
            Email.Location = new Point(154, 42);
            Email.Name = "Email";
            Email.Size = new Size(191, 27);
            Email.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 99);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 6;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 42);
            label1.Name = "label1";
            label1.Size = new Size(42, 25);
            label1.TabIndex = 5;
            label1.Text = "Email";
            label1.UseCompatibleTextRendering = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 450);
            Controls.Add(submit_btn);
            Controls.Add(Password);
            Controls.Add(Email);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button submit_btn;
        private TextBox Password;
        private TextBox Email;
        private Label label2;
        private Label label1;
    }
}
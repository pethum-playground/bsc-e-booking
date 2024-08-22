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
            submit_btn.BackColor = Color.Gold;
            submit_btn.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            submit_btn.Location = new Point(97, 201);
            submit_btn.Margin = new Padding(3, 2, 3, 2);
            submit_btn.Name = "submit_btn";
            submit_btn.Size = new Size(103, 36);
            submit_btn.TabIndex = 9;
            submit_btn.Text = "Submit";
            submit_btn.UseVisualStyleBackColor = false;
            submit_btn.Click += submit_btn_Click;
            // 
            // Password
            // 
            Password.Location = new Point(19, 124);
            Password.Margin = new Padding(3, 2, 3, 2);
            Password.Name = "Password";
            Password.Size = new Size(272, 23);
            Password.TabIndex = 8;
            Password.UseSystemPasswordChar = true;
            // 
            // Email
            // 
            Email.Location = new Point(19, 57);
            Email.Margin = new Padding(3, 2, 3, 2);
            Email.Name = "Email";
            Email.Size = new Size(272, 23);
            Email.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 103);
            label2.Name = "label2";
            label2.Size = new Size(80, 19);
            label2.TabIndex = 6;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 35);
            label1.Name = "label1";
            label1.Size = new Size(49, 25);
            label1.TabIndex = 5;
            label1.Text = "Email";
            label1.UseCompatibleTextRendering = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._444945114_1001481525099302_5186990335017209024_n1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(312, 442);
            Controls.Add(submit_btn);
            Controls.Add(Password);
            Controls.Add(Email);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
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
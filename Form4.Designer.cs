namespace e_booking
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            pictureBox1 = new PictureBox();
            panelUsername = new Panel();
            txtUsername = new TextBox();
            UsernamePic = new PictureBox();
            pictureBox2 = new PictureBox();
            panelPassword = new Panel();
            txtPassword = new TextBox();
            PasswordPic = new PictureBox();
            panelMain = new Panel();
            warning = new Label();
            forgotpwd = new LinkLabel();
            btnLogin = new Button();
            eyeIcon = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelUsername.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UsernamePic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PasswordPic).BeginInit();
            panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)eyeIcon).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(186, 186);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelUsername
            // 
            panelUsername.BackColor = Color.White;
            panelUsername.Controls.Add(txtUsername);
            panelUsername.Controls.Add(UsernamePic);
            panelUsername.Location = new Point(277, 50);
            panelUsername.Name = "panelUsername";
            panelUsername.Size = new Size(300, 50);
            panelUsername.TabIndex = 1;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(49, 12);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(238, 27);
            txtUsername.TabIndex = 6;
            // 
            // UsernamePic
            // 
            UsernamePic.Image = (Image)resources.GetObject("UsernamePic.Image");
            UsernamePic.Location = new Point(4, 5);
            UsernamePic.Name = "UsernamePic";
            UsernamePic.Size = new Size(40, 40);
            UsernamePic.SizeMode = PictureBoxSizeMode.StretchImage;
            UsernamePic.TabIndex = 5;
            UsernamePic.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(424, 324);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(0, 0);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // panelPassword
            // 
            panelPassword.BackColor = Color.White;
            panelPassword.Controls.Add(eyeIcon);
            panelPassword.Controls.Add(txtPassword);
            panelPassword.Controls.Add(PasswordPic);
            panelPassword.Location = new Point(277, 119);
            panelPassword.Name = "panelPassword";
            panelPassword.Size = new Size(300, 50);
            panelPassword.TabIndex = 7;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(49, 12);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(238, 27);
            txtPassword.TabIndex = 6;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // PasswordPic
            // 
            PasswordPic.Image = (Image)resources.GetObject("PasswordPic.Image");
            PasswordPic.Location = new Point(4, 5);
            PasswordPic.Name = "PasswordPic";
            PasswordPic.Size = new Size(40, 40);
            PasswordPic.SizeMode = PictureBoxSizeMode.StretchImage;
            PasswordPic.TabIndex = 5;
            PasswordPic.TabStop = false;
            // 
            // panelMain
            // 
            panelMain.Anchor = AnchorStyles.None;
            panelMain.Controls.Add(warning);
            panelMain.Controls.Add(forgotpwd);
            panelMain.Controls.Add(btnLogin);
            panelMain.Controls.Add(panelUsername);
            panelMain.Controls.Add(panelPassword);
            panelMain.Controls.Add(pictureBox1);
            panelMain.Location = new Point(102, 76);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(600, 330);
            panelMain.TabIndex = 9;
            // 
            // warning
            // 
            warning.AutoSize = true;
            warning.ForeColor = Color.Red;
            warning.Location = new Point(326, 284);
            warning.Name = "warning";
            warning.Size = new Size(0, 20);
            warning.TabIndex = 10;
            // 
            // forgotpwd
            // 
            forgotpwd.AutoSize = true;
            forgotpwd.Location = new Point(375, 248);
            forgotpwd.Name = "forgotpwd";
            forgotpwd.Size = new Size(118, 20);
            forgotpwd.TabIndex = 9;
            forgotpwd.TabStop = true;
            forgotpwd.Text = "forgot password";
            forgotpwd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgotpwd_clicked);
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.RoyalBlue;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderColor = Color.RoyalBlue;
            btnLogin.FlatAppearance.BorderSize = 2;
            btnLogin.FlatAppearance.MouseOverBackColor = Color.Blue;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = SystemColors.ButtonHighlight;
            btnLogin.Location = new Point(361, 186);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(150, 50);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "Log in";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // eyeIcon
            // 
            eyeIcon.Image = (Image)resources.GetObject("eyeIcon.Image");
            eyeIcon.Location = new Point(261, 16);
            eyeIcon.Name = "eyeIcon";
            eyeIcon.Size = new Size(20, 20);
            eyeIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            eyeIcon.TabIndex = 7;
            eyeIcon.TabStop = false;
            eyeIcon.Click += new EventHandler(eyeIcon_Click);
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox2);
            Controls.Add(panelMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Log in";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelUsername.ResumeLayout(false);
            panelUsername.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UsernamePic).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelPassword.ResumeLayout(false);
            panelPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PasswordPic).EndInit();
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)eyeIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panelUsername;
        private TextBox txtUsername;
        private PictureBox UsernamePic;
        private PictureBox pictureBox2;
        private Panel panelPassword;
        private TextBox txtPassword;
        private PictureBox PasswordPic;
        private Panel panelMain;
        private Button btnLogin;
        private LinkLabel forgotpwd;
        private Label warning;
        private PictureBox eyeIcon;
    }
}

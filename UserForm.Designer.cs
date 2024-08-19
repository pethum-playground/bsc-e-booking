namespace e_booking
{
    partial class UserForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView userTable;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnDisableUser;
        private System.Windows.Forms.Button btnRemoveUser;
        private System.Windows.Forms.ProgressBar progressBar;

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
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.progressBar.Location = new System.Drawing.Point(12, 350);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(600, 23);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar.Visible = false;

            this.Controls.Add(this.progressBar);

            this.userTable = new System.Windows.Forms.DataGridView();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnDisableUser = new System.Windows.Forms.Button();
            this.btnRemoveUser = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.userTable)).BeginInit();
            this.SuspendLayout();

            // 
            // userTable
            // 
            this.userTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                new System.Windows.Forms.DataGridViewTextBoxColumn() { Name = "Email", HeaderText = "Email" },
                new System.Windows.Forms.DataGridViewTextBoxColumn() { Name = "Status", HeaderText = "Status" }
            });
            this.userTable.Location = new System.Drawing.Point(12, 12);
            this.userTable.Name = "userTable";
            this.userTable.Size = new System.Drawing.Size(600, 300);
            this.userTable.TabIndex = 0;

            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(620, 20);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(150, 30);
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);

            // 
            // btnDisableUser
            // 
            this.btnDisableUser.Location = new System.Drawing.Point(620, 60);
            this.btnDisableUser.Name = "btnDisableUser";
            this.btnDisableUser.Size = new System.Drawing.Size(150, 30);
            this.btnDisableUser.Text = "Disable User";
            this.btnDisableUser.Click += new System.EventHandler(this.btnDisableUser_Click);

            // 
            // btnRemoveUser
            // 
            this.btnRemoveUser.Location = new System.Drawing.Point(620, 100);
            this.btnRemoveUser.Name = "btnRemoveUser";
            this.btnRemoveUser.Size = new System.Drawing.Size(150, 30);
            this.btnRemoveUser.Text = "Remove User";
            this.btnRemoveUser.Click += new System.EventHandler(this.btnRemoveUser_Click);

            // 
            // UserForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userTable);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.btnDisableUser);
            this.Controls.Add(this.btnRemoveUser);
            this.Text = "User Management";
            this.Load += new System.EventHandler(this.UserForm_Load);

            ((System.ComponentModel.ISupportInitialize)(this.userTable)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
    }
}

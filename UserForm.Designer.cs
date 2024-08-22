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
            progressBar = new ProgressBar();
            userTable = new DataGridView();
            btnAddUser = new Button();
            btnDisableUser = new Button();
            btnRemoveUser = new Button();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)userTable).BeginInit();
            SuspendLayout();
            // 
            // progressBar
            // 
            progressBar.Location = new Point(12, 350);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(600, 23);
            progressBar.Style = ProgressBarStyle.Marquee;
            progressBar.TabIndex = 0;
            progressBar.Visible = false;
            // 
            // userTable
            // 
            userTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userTable.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2 });
            userTable.Location = new Point(12, 12);
            userTable.Name = "userTable";
            userTable.Size = new Size(600, 300);
            userTable.TabIndex = 0;
            // 
            // btnAddUser
            // 
            btnAddUser.BackColor = Color.Gold;
            btnAddUser.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnAddUser.Location = new Point(620, 20);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(150, 30);
            btnAddUser.TabIndex = 1;
            btnAddUser.Text = "Add User";
            btnAddUser.UseVisualStyleBackColor = false;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // btnDisableUser
            // 
            btnDisableUser.BackColor = Color.Gold;
            btnDisableUser.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnDisableUser.Location = new Point(620, 60);
            btnDisableUser.Name = "btnDisableUser";
            btnDisableUser.Size = new Size(150, 30);
            btnDisableUser.TabIndex = 2;
            btnDisableUser.Text = "Disable User";
            btnDisableUser.UseVisualStyleBackColor = false;
            btnDisableUser.Click += btnDisableUser_Click;
            // 
            // btnRemoveUser
            // 
            btnRemoveUser.BackColor = Color.Gold;
            btnRemoveUser.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnRemoveUser.Location = new Point(620, 100);
            btnRemoveUser.Name = "btnRemoveUser";
            btnRemoveUser.Size = new Size(150, 30);
            btnRemoveUser.TabIndex = 3;
            btnRemoveUser.Text = "Remove User";
            btnRemoveUser.UseVisualStyleBackColor = false;
            btnRemoveUser.Click += btnRemoveUser_Click;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // UserForm
            // 
            BackColor = Color.Cornsilk;
            ClientSize = new Size(800, 450);
            Controls.Add(progressBar);
            Controls.Add(userTable);
            Controls.Add(btnAddUser);
            Controls.Add(btnDisableUser);
            Controls.Add(btnRemoveUser);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "UserForm";
            Text = "User Management";
            Load += UserForm_Load;
            ((System.ComponentModel.ISupportInitialize)userTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}

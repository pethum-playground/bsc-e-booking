namespace e_booking
{
    partial class Dashboard
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnUserManagement;

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

        private void InitializeComponent()
        {
            panelSidebar = new Panel();
            btnUpload = new Button();
            btn_reservation = new Button();
            btnDashboard = new Button();
            btnUserManagement = new Button();
            panelMain = new Panel();
            panelSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = SystemColors.ActiveCaption;
            panelSidebar.Controls.Add(btnUpload);
            panelSidebar.Controls.Add(btn_reservation);
            panelSidebar.Controls.Add(btnDashboard);
            panelSidebar.Controls.Add(btnUserManagement);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Margin = new Padding(3, 2, 3, 2);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(175, 338);
            panelSidebar.TabIndex = 0;
            // 
            // btnUpload
            // 
            btnUpload.BackColor = Color.Gold;
            btnUpload.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnUpload.Location = new Point(18, 184);
            btnUpload.Margin = new Padding(3, 2, 3, 2);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(140, 30);
            btnUpload.TabIndex = 3;
            btnUpload.Text = "Hall Details";
            btnUpload.UseVisualStyleBackColor = false;
            btnUpload.Click += btnUpload_Click;
            // 
            // btn_reservation
            // 
            btn_reservation.BackColor = Color.Gold;
            btn_reservation.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btn_reservation.Location = new Point(18, 90);
            btn_reservation.Margin = new Padding(3, 2, 3, 2);
            btn_reservation.Name = "btn_reservation";
            btn_reservation.Size = new Size(140, 30);
            btn_reservation.TabIndex = 2;
            btn_reservation.Text = "Reservation";
            btn_reservation.UseVisualStyleBackColor = false;
            btn_reservation.Click += btnReservation_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Gold;
            btnDashboard.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.Location = new Point(18, 38);
            btnDashboard.Margin = new Padding(3, 2, 3, 2);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(140, 30);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnUserManagement
            // 
            btnUserManagement.BackColor = Color.Gold;
            btnUserManagement.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnUserManagement.Location = new Point(18, 136);
            btnUserManagement.Margin = new Padding(3, 2, 3, 2);
            btnUserManagement.Name = "btnUserManagement";
            btnUserManagement.Size = new Size(140, 30);
            btnUserManagement.TabIndex = 1;
            btnUserManagement.Text = "User Management";
            btnUserManagement.UseVisualStyleBackColor = false;
            btnUserManagement.Click += btnUserManagement_Click;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.Cornsilk;
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(175, 0);
            panelMain.Margin = new Padding(3, 2, 3, 2);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(700, 338);
            panelMain.TabIndex = 1;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 338);
            Controls.Add(panelMain);
            Controls.Add(panelSidebar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Dashboard";
            Text = "Dashboard";
            panelSidebar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btn_reservation;
        private Button btnUpload;
    }
}

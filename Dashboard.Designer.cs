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
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(200, 589);
            panelSidebar.TabIndex = 0;
            // 
            // btnUpload
            // 
            btnUpload.BackColor = Color.Gold;
            btnUpload.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnUpload.Location = new Point(21, 245);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(160, 40);
            btnUpload.TabIndex = 3;
            btnUpload.Text = "Hall Details";
            btnUpload.UseVisualStyleBackColor = false;
            btnUpload.Click += btnUpload_Click;
            // 
            // btn_reservation
            // 
            btn_reservation.BackColor = Color.Gold;
            btn_reservation.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btn_reservation.Location = new Point(21, 120);
            btn_reservation.Name = "btn_reservation";
            btn_reservation.Size = new Size(160, 40);
            btn_reservation.TabIndex = 2;
            btn_reservation.Text = "Reservation";
            btn_reservation.UseVisualStyleBackColor = false;
            btn_reservation.Click += btnReservation_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Gold;
            btnDashboard.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.Location = new Point(21, 51);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(160, 40);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnUserManagement
            // 
            btnUserManagement.BackColor = Color.Gold;
            btnUserManagement.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnUserManagement.Location = new Point(21, 181);
            btnUserManagement.Name = "btnUserManagement";
            btnUserManagement.Size = new Size(160, 40);
            btnUserManagement.TabIndex = 1;
            btnUserManagement.Text = "User Management";
            btnUserManagement.UseVisualStyleBackColor = false;
            btnUserManagement.Click += btnUserManagement_Click;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.Cornsilk;
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(200, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(800, 589);
            panelMain.TabIndex = 1;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 589);
            Controls.Add(panelMain);
            Controls.Add(panelSidebar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
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

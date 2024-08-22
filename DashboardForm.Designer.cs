namespace e_booking
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelUserCards;
        private System.Windows.Forms.Panel panelReservationCards;
        private System.Windows.Forms.Panel panelMainContent;

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
            panelUserCards = new Panel();
            panelReservationCards = new Panel();
            panelMainContent = new Panel();
            SuspendLayout();
            // 
            // panelUserCards
            // 
            panelUserCards.AutoScroll = true;
            panelUserCards.BackColor = SystemColors.MenuBar;
            panelUserCards.Dock = DockStyle.Left;
            panelUserCards.Location = new Point(257, 0);
            panelUserCards.Margin = new Padding(4, 3, 4, 3);
            panelUserCards.Name = "panelUserCards";
            panelUserCards.Padding = new Padding(12);
            panelUserCards.Size = new Size(257, 519);
            panelUserCards.TabIndex = 0;
            // 
            // panelReservationCards
            // 
            panelReservationCards.AutoScroll = true;
            panelReservationCards.BackColor = Color.Cornsilk;
            panelReservationCards.Dock = DockStyle.Left;
            panelReservationCards.Location = new Point(0, 0);
            panelReservationCards.Margin = new Padding(4, 3, 4, 3);
            panelReservationCards.Name = "panelReservationCards";
            panelReservationCards.Padding = new Padding(12);
            panelReservationCards.Size = new Size(257, 519);
            panelReservationCards.TabIndex = 1;
            // 
            // panelMainContent
            // 
            panelMainContent.BackColor = Color.Cornsilk;
            panelMainContent.Dock = DockStyle.Fill;
            panelMainContent.Location = new Point(0, 0);
            panelMainContent.Margin = new Padding(4, 3, 4, 3);
            panelMainContent.Name = "panelMainContent";
            panelMainContent.Size = new Size(933, 519);
            panelMainContent.TabIndex = 2;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(panelUserCards);
            Controls.Add(panelReservationCards);
            Controls.Add(panelMainContent);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            Name = "DashboardForm";
            Text = "Dashboard";
            Load += DashboardForm_Load;
            ResumeLayout(false);
        }

        #endregion
    }
}

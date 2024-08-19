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
            this.panelUserCards = new System.Windows.Forms.Panel();
            this.panelReservationCards = new System.Windows.Forms.Panel();
            this.panelMainContent = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelUserCards
            // 
            this.panelUserCards.AutoScroll = true;
            this.panelUserCards.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelUserCards.Size = new System.Drawing.Size(220, this.ClientSize.Height / 2);
            this.panelUserCards.Padding = new System.Windows.Forms.Padding(10);
            this.Controls.Add(this.panelUserCards);
            // 
            // panelReservationCards
            // 
            this.panelReservationCards.AutoScroll = true;
            this.panelReservationCards.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelReservationCards.Size = new System.Drawing.Size(220, this.ClientSize.Height / 2);
            this.panelReservationCards.Padding = new System.Windows.Forms.Padding(10);
            this.panelReservationCards.Location = new System.Drawing.Point(0, this.ClientSize.Height / 2);
            this.Controls.Add(this.panelReservationCards);
            // 
            // panelMainContent
            // 
            this.panelMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Controls.Add(this.panelMainContent);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "DashboardForm";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
    }
}

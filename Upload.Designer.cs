namespace e_booking
{
    partial class Upload
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.DataGridView dataGridView;

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

        private void InitializeComponent()
        {
            btnUpload = new Button();
            dataGridView = new DataGridView();
            btnDownloadSample = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // btnUpload
            // 
            btnUpload.BackColor = Color.Gold;
            btnUpload.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnUpload.Location = new Point(18, 15);
            btnUpload.Margin = new Padding(3, 2, 3, 2);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(140, 30);
            btnUpload.TabIndex = 0;
            btnUpload.Text = "Upload Excel";
            btnUpload.UseVisualStyleBackColor = false;
            btnUpload.Click += btnUpload_Click;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(18, 60);
            dataGridView.Margin = new Padding(3, 2, 3, 2);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(665, 262);
            dataGridView.TabIndex = 1;
            // 
            // btnDownloadSample
            // 
            btnDownloadSample.BackColor = Color.Gold;
            btnDownloadSample.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnDownloadSample.Location = new Point(183, 15);
            btnDownloadSample.Margin = new Padding(3, 2, 3, 2);
            btnDownloadSample.Name = "btnDownloadSample";
            btnDownloadSample.Size = new Size(140, 30);
            btnDownloadSample.TabIndex = 2;
            btnDownloadSample.Text = "Export";
            btnDownloadSample.UseVisualStyleBackColor = false;
            btnDownloadSample.Click += btnDownloadSample_Click;
            // 
            // Upload
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(700, 338);
            Controls.Add(btnDownloadSample);
            Controls.Add(dataGridView);
            Controls.Add(btnUpload);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Upload";
            Text = "Upload Data";
            Load += Upload_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnDownloadSample;
    }
}

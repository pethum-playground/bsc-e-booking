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
            btnUpload.Location = new Point(20, 20);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(160, 40);
            btnUpload.TabIndex = 0;
            btnUpload.Text = "Upload Excel";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(20, 80);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(760, 350);
            dataGridView.TabIndex = 1;
            // 
            // btnDownloadSample
            // 
            btnDownloadSample.Location = new Point(209, 20);
            btnDownloadSample.Name = "btnDownloadSample";
            btnDownloadSample.Size = new Size(160, 40);
            btnDownloadSample.TabIndex = 2;
            btnDownloadSample.Text = "Export";
            btnDownloadSample.UseVisualStyleBackColor = true;
            btnDownloadSample.Click += btnDownloadSample_Click;
            // 
            // Upload
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDownloadSample);
            Controls.Add(dataGridView);
            Controls.Add(btnUpload);
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

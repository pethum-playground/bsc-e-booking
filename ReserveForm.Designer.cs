using Org.BouncyCastle.Asn1.Crmf;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace e_booking
{
    partial class ReserveForm
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
            label1 = new Label();
            label2 = new Label();
            date_picker = new DateTimePicker();
            panel1 = new Panel();
            reset_btn = new Button();
            end_time = new DateTimePicker();
            label8 = new Label();
            label7 = new Label();
            start_time = new DateTimePicker();
            filter_btn = new Button();
            label6 = new Label();
            checkedListBox1 = new CheckedListBox();
            label5 = new Label();
            computerLab_btn = new RadioButton();
            lectureHall_btn = new RadioButton();
            label4 = new Label();
            label3 = new Label();
            listView1 = new ListView();
            search_btn = new Button();
            sort_label = new Label();
            label9 = new Label();
            label10 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Coral;
            label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(170, 19);
            label1.Name = "label1";
            label1.Size = new Size(251, 25);
            label1.TabIndex = 0;
            label1.Text = "Search Entries/ Booking";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += Form1_Load;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(35, 63);
            label2.Name = "label2";
            label2.Size = new Size(37, 16);
            label2.TabIndex = 1;
            label2.Text = "Date";
            // 
            // date_picker
            // 
            date_picker.Location = new Point(81, 59);
            date_picker.Margin = new Padding(3, 2, 3, 2);
            date_picker.Name = "date_picker";
            date_picker.Size = new Size(212, 23);
            date_picker.TabIndex = 2;
            date_picker.ValueChanged += date_picker_ValueChanged;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.AutoScrollMargin = new Size(0, 20);
            panel1.BackColor = Color.Cornsilk;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(reset_btn);
            panel1.Controls.Add(end_time);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(start_time);
            panel1.Controls.Add(filter_btn);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(checkedListBox1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(computerLab_btn);
            panel1.Controls.Add(lectureHall_btn);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(449, 19);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(201, 375);
            panel1.TabIndex = 3;
            // 
            // reset_btn
            // 
            reset_btn.BackColor = Color.Gold;
            reset_btn.Font = new System.Drawing.Font("Century Gothic", 9.75F, FontStyle.Bold);
            reset_btn.Location = new Point(108, 39);
            reset_btn.Margin = new Padding(3, 2, 3, 2);
            reset_btn.Name = "reset_btn";
            reset_btn.Size = new Size(60, 22);
            reset_btn.TabIndex = 15;
            reset_btn.Text = "Reset";
            reset_btn.UseVisualStyleBackColor = false;
            reset_btn.Click += reset_btn_Click;
            // 
            // end_time
            // 
            end_time.CustomFormat = "HH:mm tt";
            end_time.Format = DateTimePickerFormat.Custom;
            end_time.Location = new Point(66, 287);
            end_time.Margin = new Padding(3, 2, 3, 2);
            end_time.Name = "end_time";
            end_time.ShowUpDown = true;
            end_time.Size = new Size(85, 23);
            end_time.TabIndex = 14;
            end_time.Value = new DateTime(2024, 6, 20, 21, 56, 53, 0);
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.ImageAlign = ContentAlignment.TopCenter;
            label8.Location = new Point(28, 287);
            label8.Name = "label8";
            label8.Size = new Size(19, 15);
            label8.TabIndex = 13;
            label8.Text = "To";
            label8.TextAlign = ContentAlignment.TopCenter;
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.ImageAlign = ContentAlignment.TopCenter;
            label7.Location = new Point(24, 249);
            label7.Name = "label7";
            label7.Size = new Size(35, 15);
            label7.TabIndex = 12;
            label7.Text = "From";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // start_time
            // 
            start_time.CustomFormat = "HH:mm tt";
            start_time.Format = DateTimePickerFormat.Custom;
            start_time.Location = new Point(66, 249);
            start_time.Margin = new Padding(3, 2, 3, 2);
            start_time.Name = "start_time";
            start_time.ShowUpDown = true;
            start_time.Size = new Size(85, 23);
            start_time.TabIndex = 11;
            start_time.Value = new DateTime(2024, 6, 20, 0, 0, 0, 0);
            // 
            // filter_btn
            // 
            filter_btn.BackColor = Color.Gold;
            filter_btn.Font = new System.Drawing.Font("Century Gothic", 9.75F, FontStyle.Bold);
            filter_btn.Location = new Point(20, 324);
            filter_btn.Margin = new Padding(3, 2, 3, 2);
            filter_btn.Name = "filter_btn";
            filter_btn.Size = new Size(147, 22);
            filter_btn.TabIndex = 9;
            filter_btn.Text = "Filter";
            filter_btn.UseVisualStyleBackColor = false;
            filter_btn.Click += filter_btn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ImageAlign = ContentAlignment.TopCenter;
            label6.Location = new Point(10, 218);
            label6.Name = "label6";
            label6.Size = new Size(34, 15);
            label6.TabIndex = 10;
            label6.Text = "Time";
            label6.TextAlign = ContentAlignment.TopCenter;
            label6.Click += label6_Click;
            // 
            // checkedListBox1
            // 
            checkedListBox1.BackColor = SystemColors.Control;
            checkedListBox1.BorderStyle = BorderStyle.None;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Projector", "WhiteBoard", "Marking Pen", "Microphone" });
            checkedListBox1.Location = new Point(20, 150);
            checkedListBox1.Margin = new Padding(3, 2, 3, 2);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(147, 36);
            checkedListBox1.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ImageAlign = ContentAlignment.TopCenter;
            label5.Location = new Point(10, 125);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 7;
            label5.Text = "Equements";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // computerLab_btn
            // 
            computerLab_btn.AutoSize = true;
            computerLab_btn.Location = new Point(19, 94);
            computerLab_btn.Margin = new Padding(3, 2, 3, 2);
            computerLab_btn.Name = "computerLab_btn";
            computerLab_btn.Size = new Size(101, 19);
            computerLab_btn.TabIndex = 6;
            computerLab_btn.TabStop = true;
            computerLab_btn.Text = "Computer Lab";
            computerLab_btn.UseVisualStyleBackColor = true;
            // 
            // lectureHall_btn
            // 
            lectureHall_btn.AutoSize = true;
            lectureHall_btn.Location = new Point(19, 71);
            lectureHall_btn.Margin = new Padding(3, 2, 3, 2);
            lectureHall_btn.Name = "lectureHall_btn";
            lectureHall_btn.Size = new Size(88, 19);
            lectureHall_btn.TabIndex = 5;
            lectureHall_btn.TabStop = true;
            lectureHall_btn.Text = "Lecture Hall";
            lectureHall_btn.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ImageAlign = ContentAlignment.TopCenter;
            label4.Location = new Point(10, 46);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 4;
            label4.Text = "Hall type";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ImageAlign = ContentAlignment.TopCenter;
            label3.Location = new Point(68, 14);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 1;
            label3.Text = "Filter";
            label3.TextAlign = ContentAlignment.TopCenter;
            label3.Click += label3_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(33, 112);
            listView1.Margin = new Padding(3, 2, 3, 2);
            listView1.Name = "listView1";
            listView1.Size = new Size(388, 272);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.Click += listView1_Click;
            // 
            // search_btn
            // 
            search_btn.BackColor = Color.Gold;
            search_btn.Font = new System.Drawing.Font("Century Gothic", 9.75F, FontStyle.Bold);
            search_btn.Location = new Point(300, 59);
            search_btn.Margin = new Padding(3, 2, 3, 2);
            search_btn.Name = "search_btn";
            search_btn.Size = new Size(91, 22);
            search_btn.TabIndex = 5;
            search_btn.Text = "Search";
            search_btn.UseVisualStyleBackColor = false;
            search_btn.Click += search_btn_Click;
            // 
            // sort_label
            // 
            sort_label.AutoSize = true;
            sort_label.BackColor = SystemColors.ActiveCaption;
            sort_label.Location = new Point(86, 94);
            sort_label.Name = "sort_label";
            sort_label.Size = new Size(12, 15);
            sort_label.TabIndex = 6;
            sort_label.Text = "-";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.ActiveCaption;
            label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, FontStyle.Bold);
            label9.Location = new Point(33, 93);
            label9.Name = "label9";
            label9.Size = new Size(52, 16);
            label9.TabIndex = 7;
            label9.Text = "Sort by";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.GradientActiveCaption;
            label10.Font = new System.Drawing.Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.Location = new Point(312, 94);
            label10.Name = "label10";
            label10.Size = new Size(70, 16);
            label10.TabIndex = 8;
            label10.Text = "(free slots)";
            // 
            // ReserveForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._1pa_650x400;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(674, 411);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(sort_label);
            Controls.Add(search_btn);
            Controls.Add(listView1);
            Controls.Add(panel1);
            Controls.Add(date_picker);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ReserveForm";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DateTimePicker date_picker;
        private Panel panel1;
        private Label label3;
        private RadioButton computerLab_btn;
        private RadioButton lectureHall_btn;
        private Label label4;
        private ListView listView1;
        private Button search_btn;
        private CheckedListBox checkedListBox1;
        private Label label5;
        private Button filter_btn;
        private Label label6;
        private DateTimePicker start_time;
        private Label label7;
        private DateTimePicker end_time;
        private Label label8;
        private Button reset_btn;
        private Label sort_label;
        private Label label9;
        private Label label10;
    }
}

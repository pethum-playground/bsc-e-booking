using Org.BouncyCastle.Asn1.Crmf;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace e_booking
{
    partial class ReserveInputForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            label1 = new Label();
            label2 = new Label();
            studentID = new TextBox();
            eventName = new TextBox();
            submit_btn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Cornsilk;
            label1.Font = new System.Drawing.Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(52, 58);
            label1.Name = "label1";
            label1.Size = new Size(85, 19);
            label1.TabIndex = 0;
            label1.Text = "Student ID";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Cornsilk;
            label2.Font = new System.Drawing.Font("Century Gothic", 12F, FontStyle.Bold);
            label2.Location = new Point(42, 100);
            label2.Name = "label2";
            label2.Size = new Size(103, 19);
            label2.TabIndex = 1;
            label2.Text = "Event Name";
            // 
            // studentID
            // 
            studentID.Location = new Point(162, 57);
            studentID.Margin = new Padding(3, 2, 3, 2);
            studentID.Name = "studentID";
            studentID.Size = new Size(196, 23);
            studentID.TabIndex = 2;
            // 
            // eventName
            // 
            eventName.Location = new Point(162, 100);
            eventName.Margin = new Padding(3, 2, 3, 2);
            eventName.Name = "eventName";
            eventName.Size = new Size(196, 23);
            eventName.TabIndex = 3;
            // 
            // submit_btn
            // 
            submit_btn.BackColor = Color.Gold;
            submit_btn.Font = new System.Drawing.Font("Century Gothic", 14F, FontStyle.Bold);
            submit_btn.ForeColor = SystemColors.ControlText;
            submit_btn.Location = new Point(151, 161);
            submit_btn.Margin = new Padding(3, 2, 3, 2);
            submit_btn.Name = "submit_btn";
            submit_btn.Size = new Size(99, 35);
            submit_btn.TabIndex = 4;
            submit_btn.Text = "Submit";
            submit_btn.UseVisualStyleBackColor = false;
            submit_btn.Click += submit_btn_Click;
            // 
            // ReserveInputForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._445422976_1001481445099310_4223153017563866116_n;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(422, 259);
            Controls.Add(submit_btn);
            Controls.Add(eventName);
            Controls.Add(studentID);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ReserveInputForm";
            Text = "InputForm";
            Load += InputForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox studentID;
        private TextBox eventName;
        private Button submit_btn;
    }
}
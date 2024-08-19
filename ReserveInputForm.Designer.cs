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
            label1.Location = new Point(48, 76);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 0;
            label1.Text = "Student ID";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 133);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 1;
            label2.Text = "Event Name";
            // 
            // studentID
            // 
            studentID.Location = new Point(185, 76);
            studentID.Name = "studentID";
            studentID.Size = new Size(191, 27);
            studentID.TabIndex = 2;
            // 
            // eventName
            // 
            eventName.Location = new Point(185, 133);
            eventName.Name = "eventName";
            eventName.Size = new Size(191, 27);
            eventName.TabIndex = 3;
            // 
            // submit_btn
            // 
            submit_btn.Location = new Point(282, 187);
            submit_btn.Name = "submit_btn";
            submit_btn.Size = new Size(94, 29);
            submit_btn.TabIndex = 4;
            submit_btn.Text = "Submit";
            submit_btn.UseVisualStyleBackColor = true;
            submit_btn.Click += submit_btn_Click;
            // 
            // InputForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 303);
            Controls.Add(submit_btn);
            Controls.Add(eventName);
            Controls.Add(studentID);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "InputForm";
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
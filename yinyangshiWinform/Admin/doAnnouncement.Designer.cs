namespace yinyangshiWinform.Admin
{
    partial class doAnnouncement
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.feedbackListBtn = new System.Windows.Forms.Button();
            this.announcementBtn = new System.Windows.Forms.Button();
            this.userListBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.commitBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(406, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 24;
            this.label1.Text = "发布公告";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.feedbackListBtn);
            this.panel2.Controls.Add(this.announcementBtn);
            this.panel2.Controls.Add(this.userListBtn);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(119, 426);
            this.panel2.TabIndex = 26;
            // 
            // feedbackListBtn
            // 
            this.feedbackListBtn.Location = new System.Drawing.Point(17, 250);
            this.feedbackListBtn.Name = "feedbackListBtn";
            this.feedbackListBtn.Size = new System.Drawing.Size(75, 38);
            this.feedbackListBtn.TabIndex = 23;
            this.feedbackListBtn.Text = "反馈列表";
            this.feedbackListBtn.UseVisualStyleBackColor = true;
            this.feedbackListBtn.Click += new System.EventHandler(this.feedbackListBtn_Click);
            // 
            // announcementBtn
            // 
            this.announcementBtn.Location = new System.Drawing.Point(17, 163);
            this.announcementBtn.Name = "announcementBtn";
            this.announcementBtn.Size = new System.Drawing.Size(75, 41);
            this.announcementBtn.TabIndex = 22;
            this.announcementBtn.Text = "发布公告";
            this.announcementBtn.UseVisualStyleBackColor = true;
            this.announcementBtn.Click += new System.EventHandler(this.announcementBtn_Click);
            // 
            // userListBtn
            // 
            this.userListBtn.Location = new System.Drawing.Point(17, 78);
            this.userListBtn.Name = "userListBtn";
            this.userListBtn.Size = new System.Drawing.Size(75, 40);
            this.userListBtn.TabIndex = 21;
            this.userListBtn.Text = "用户列表";
            this.userListBtn.UseVisualStyleBackColor = true;
            this.userListBtn.Click += new System.EventHandler(this.userListBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.commitBtn);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(172, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 388);
            this.panel1.TabIndex = 25;
            // 
            // commitBtn
            // 
            this.commitBtn.Location = new System.Drawing.Point(382, 361);
            this.commitBtn.Name = "commitBtn";
            this.commitBtn.Size = new System.Drawing.Size(75, 23);
            this.commitBtn.TabIndex = 17;
            this.commitBtn.Text = "提交";
            this.commitBtn.UseVisualStyleBackColor = true;
            this.commitBtn.Click += new System.EventHandler(this.commitBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 20;
            this.label5.Text = "内容:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(68, 117);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(442, 235);
            this.richTextBox1.TabIndex = 19;
            this.richTextBox1.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.phoneTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(64, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 51);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.ForeColor = System.Drawing.Color.Black;
            this.phoneTextBox.Location = new System.Drawing.Point(143, 20);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(161, 21);
            this.phoneTextBox.TabIndex = 1;
            this.phoneTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "管理员ID";
            // 
            // doAnnouncement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "doAnnouncement";
            this.Text = "doAnnouncement";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.doAnnouncement_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.doAnnouncement_FormClosed);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button feedbackListBtn;
        private System.Windows.Forms.Button announcementBtn;
        private System.Windows.Forms.Button userListBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button commitBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label label2;
    }
}
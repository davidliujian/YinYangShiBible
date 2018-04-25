namespace yinyangshiWinform
{
    partial class feedback
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.AnnounceBtn = new System.Windows.Forms.Button();
            this.remindBtn = new System.Windows.Forms.Button();
            this.feedbackBtn = new System.Windows.Forms.Button();
            this.computeBtn = new System.Windows.Forms.Button();
            this.queryBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.commitBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.AnnounceBtn);
            this.panel2.Controls.Add(this.remindBtn);
            this.panel2.Controls.Add(this.feedbackBtn);
            this.panel2.Controls.Add(this.computeBtn);
            this.panel2.Controls.Add(this.queryBtn);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(167, 426);
            this.panel2.TabIndex = 27;
            // 
            // AnnounceBtn
            // 
            this.AnnounceBtn.Location = new System.Drawing.Point(46, 368);
            this.AnnounceBtn.Name = "AnnounceBtn";
            this.AnnounceBtn.Size = new System.Drawing.Size(75, 38);
            this.AnnounceBtn.TabIndex = 25;
            this.AnnounceBtn.Text = "公告";
            this.AnnounceBtn.UseVisualStyleBackColor = true;
            this.AnnounceBtn.Click += new System.EventHandler(this.AnnounceBtn_Click);
            // 
            // remindBtn
            // 
            this.remindBtn.Location = new System.Drawing.Point(46, 286);
            this.remindBtn.Name = "remindBtn";
            this.remindBtn.Size = new System.Drawing.Size(75, 40);
            this.remindBtn.TabIndex = 24;
            this.remindBtn.Text = "副本提醒";
            this.remindBtn.UseVisualStyleBackColor = true;
            this.remindBtn.Click += new System.EventHandler(this.remindBtn_Click);
            // 
            // feedbackBtn
            // 
            this.feedbackBtn.Location = new System.Drawing.Point(46, 197);
            this.feedbackBtn.Name = "feedbackBtn";
            this.feedbackBtn.Size = new System.Drawing.Size(75, 38);
            this.feedbackBtn.TabIndex = 23;
            this.feedbackBtn.Text = "反馈";
            this.feedbackBtn.UseVisualStyleBackColor = true;
            this.feedbackBtn.Click += new System.EventHandler(this.feedbackBtn_Click);
            // 
            // computeBtn
            // 
            this.computeBtn.Location = new System.Drawing.Point(46, 105);
            this.computeBtn.Name = "computeBtn";
            this.computeBtn.Size = new System.Drawing.Size(75, 41);
            this.computeBtn.TabIndex = 22;
            this.computeBtn.Text = "伤害计算";
            this.computeBtn.UseVisualStyleBackColor = true;
            this.computeBtn.Click += new System.EventHandler(this.computeBtn_Click);
            // 
            // queryBtn
            // 
            this.queryBtn.Location = new System.Drawing.Point(46, 20);
            this.queryBtn.Name = "queryBtn";
            this.queryBtn.Size = new System.Drawing.Size(75, 40);
            this.queryBtn.TabIndex = 21;
            this.queryBtn.Text = "查询";
            this.queryBtn.UseVisualStyleBackColor = true;
            this.queryBtn.Click += new System.EventHandler(this.queryBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.commitBtn);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(244, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 426);
            this.panel1.TabIndex = 26;
            // 
            // commitBtn
            // 
            this.commitBtn.Location = new System.Drawing.Point(346, 376);
            this.commitBtn.Name = "commitBtn";
            this.commitBtn.Size = new System.Drawing.Size(75, 23);
            this.commitBtn.TabIndex = 2;
            this.commitBtn.Text = "提交";
            this.commitBtn.UseVisualStyleBackColor = true;
            this.commitBtn.Click += new System.EventHandler(this.commitBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "反馈:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(32, 132);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(442, 235);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.phoneTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(28, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 51);
            this.groupBox1.TabIndex = 10;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "手机号";
            // 
            // feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "feedback";
            this.Text = "feedback";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.feedback_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.feedback_FormClosed);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button AnnounceBtn;
        private System.Windows.Forms.Button remindBtn;
        private System.Windows.Forms.Button feedbackBtn;
        private System.Windows.Forms.Button computeBtn;
        private System.Windows.Forms.Button queryBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button commitBtn;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}
namespace yinyangshiWinform
{
    partial class remind
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.remindBegin = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.panel2.TabIndex = 23;
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
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(247, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 404);
            this.panel1.TabIndex = 22;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.remindBegin);
            this.groupBox2.Controls.Add(this.checkedListBox1);
            this.groupBox2.Location = new System.Drawing.Point(85, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 381);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "副本提醒";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(26, 211);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(48, 16);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "全选";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // remindBegin
            // 
            this.remindBegin.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.remindBegin.Location = new System.Drawing.Point(100, 289);
            this.remindBegin.Name = "remindBegin";
            this.remindBegin.Size = new System.Drawing.Size(109, 42);
            this.remindBegin.TabIndex = 13;
            this.remindBegin.Text = "确定";
            this.remindBegin.UseVisualStyleBackColor = false;
            this.remindBegin.Click += new System.EventHandler(this.remindBegin_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.ForeColor = System.Drawing.Color.Gray;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "领取体力（早-每日12：00）",
            "领取体力（晚-每日20：00）",
            "斗技    （早-每日11：00）",
            "斗技    （晚-每日20：00）",
            "逢魔之时（每日17：00）",
            "狩猎战  （每日19：00）",
            "悬赏封印（早-每日9：00）",
            "悬赏封印（晚-每日18：00）"});
            this.checkedListBox1.Location = new System.Drawing.Point(26, 25);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(254, 180);
            this.checkedListBox1.TabIndex = 0;
            // 
            // remind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "remind";
            this.Text = "remind";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.remind_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.remind_FormClosed);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.Button remindBegin;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
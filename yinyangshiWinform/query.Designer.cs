namespace yinyangshiWinform
{
    partial class query
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
            this.yuhunQuery = new System.Windows.Forms.Button();
            this.shishenQuery = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.panel2.TabIndex = 25;
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
            this.panel1.Controls.Add(this.yuhunQuery);
            this.panel1.Controls.Add(this.shishenQuery);
            this.panel1.Location = new System.Drawing.Point(244, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 426);
            this.panel1.TabIndex = 24;
            // 
            // yuhunQuery
            // 
            this.yuhunQuery.Location = new System.Drawing.Point(282, 161);
            this.yuhunQuery.Name = "yuhunQuery";
            this.yuhunQuery.Size = new System.Drawing.Size(107, 105);
            this.yuhunQuery.TabIndex = 1;
            this.yuhunQuery.Text = "御魂查询";
            this.yuhunQuery.UseVisualStyleBackColor = true;
            this.yuhunQuery.Click += new System.EventHandler(this.yuhunQuery_Click);
            // 
            // shishenQuery
            // 
            this.shishenQuery.Location = new System.Drawing.Point(113, 161);
            this.shishenQuery.Name = "shishenQuery";
            this.shishenQuery.Size = new System.Drawing.Size(105, 105);
            this.shishenQuery.TabIndex = 0;
            this.shishenQuery.Text = "式神查询";
            this.shishenQuery.UseVisualStyleBackColor = true;
            this.shishenQuery.Click += new System.EventHandler(this.shishenQuery_Click);
            // 
            // query
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "query";
            this.Text = "query";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.query_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.query_FormClosed);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Button yuhunQuery;
        private System.Windows.Forms.Button shishenQuery;
    }
}
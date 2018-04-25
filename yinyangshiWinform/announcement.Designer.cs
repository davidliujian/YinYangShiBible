namespace yinyangshiWinform
{
    partial class announcement
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
            this.queryBtn = new System.Windows.Forms.Button();
            this.computeBtn = new System.Windows.Forms.Button();
            this.feedbackBtn = new System.Windows.Forms.Button();
            this.remindBtn = new System.Windows.Forms.Button();
            this.AnnounceBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // queryBtn
            // 
            this.queryBtn.Location = new System.Drawing.Point(22, 34);
            this.queryBtn.Name = "queryBtn";
            this.queryBtn.Size = new System.Drawing.Size(75, 40);
            this.queryBtn.TabIndex = 10;
            this.queryBtn.Text = "查询";
            this.queryBtn.UseVisualStyleBackColor = true;
            this.queryBtn.Click += new System.EventHandler(this.queryBtn_Click);
            // 
            // computeBtn
            // 
            this.computeBtn.Location = new System.Drawing.Point(22, 119);
            this.computeBtn.Name = "computeBtn";
            this.computeBtn.Size = new System.Drawing.Size(75, 41);
            this.computeBtn.TabIndex = 11;
            this.computeBtn.Text = "伤害计算";
            this.computeBtn.UseVisualStyleBackColor = true;
            this.computeBtn.Click += new System.EventHandler(this.computeBtn_Click);
            // 
            // feedbackBtn
            // 
            this.feedbackBtn.Location = new System.Drawing.Point(22, 211);
            this.feedbackBtn.Name = "feedbackBtn";
            this.feedbackBtn.Size = new System.Drawing.Size(75, 38);
            this.feedbackBtn.TabIndex = 12;
            this.feedbackBtn.Text = "反馈";
            this.feedbackBtn.UseVisualStyleBackColor = true;
            this.feedbackBtn.Click += new System.EventHandler(this.feedbackBtn_Click);
            // 
            // remindBtn
            // 
            this.remindBtn.Location = new System.Drawing.Point(22, 300);
            this.remindBtn.Name = "remindBtn";
            this.remindBtn.Size = new System.Drawing.Size(75, 40);
            this.remindBtn.TabIndex = 13;
            this.remindBtn.Text = "副本提醒";
            this.remindBtn.UseVisualStyleBackColor = true;
            this.remindBtn.Click += new System.EventHandler(this.remindBtn_Click);
            // 
            // AnnounceBtn
            // 
            this.AnnounceBtn.Location = new System.Drawing.Point(22, 382);
            this.AnnounceBtn.Name = "AnnounceBtn";
            this.AnnounceBtn.Size = new System.Drawing.Size(75, 38);
            this.AnnounceBtn.TabIndex = 14;
            this.AnnounceBtn.Text = "公告";
            this.AnnounceBtn.UseVisualStyleBackColor = true;
            this.AnnounceBtn.Click += new System.EventHandler(this.AnnounceBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(278, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 386);
            this.panel1.TabIndex = 15;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(3, 85);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(425, 298);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(195, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "公告";
            // 
            // announcement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AnnounceBtn);
            this.Controls.Add(this.remindBtn);
            this.Controls.Add(this.feedbackBtn);
            this.Controls.Add(this.computeBtn);
            this.Controls.Add(this.queryBtn);
            this.Name = "announcement";
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.announcement_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.announcement_FormClosed);
            this.Load += new System.EventHandler(this.announcement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button queryBtn;
        private System.Windows.Forms.Button computeBtn;
        private System.Windows.Forms.Button feedbackBtn;
        private System.Windows.Forms.Button remindBtn;
        private System.Windows.Forms.Button AnnounceBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}
namespace yinyangshiWinform.Admin
{
    partial class userList
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
            this.feedbackListBtn = new System.Windows.Forms.Button();
            this.announcementBtn = new System.Windows.Forms.Button();
            this.userListBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.Label();
            this.signUpButton = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.Label();
            this.passwdTextBox = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.feedbackListBtn);
            this.panel2.Controls.Add(this.announcementBtn);
            this.panel2.Controls.Add(this.userListBtn);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(119, 426);
            this.panel2.TabIndex = 23;
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
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(172, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 388);
            this.panel1.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.phoneTextBox);
            this.groupBox1.Controls.Add(this.phone);
            this.groupBox1.Controls.Add(this.signUpButton);
            this.groupBox1.Controls.Add(this.username);
            this.groupBox1.Controls.Add(this.passwdTextBox);
            this.groupBox1.Controls.Add(this.password);
            this.groupBox1.Controls.Add(this.usernameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(102, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 247);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "编辑";
            this.groupBox1.Visible = false;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(103, 30);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.ReadOnly = true;
            this.phoneTextBox.Size = new System.Drawing.Size(180, 21);
            this.phoneTextBox.TabIndex = 14;
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.phone.Location = new System.Drawing.Point(31, 33);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(67, 14);
            this.phone.TabIndex = 13;
            this.phone.Text = "手机号：";
            // 
            // signUpButton
            // 
            this.signUpButton.BackColor = System.Drawing.Color.Lime;
            this.signUpButton.Location = new System.Drawing.Point(136, 184);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(75, 41);
            this.signUpButton.TabIndex = 12;
            this.signUpButton.Text = "确认修改";
            this.signUpButton.UseVisualStyleBackColor = false;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.username.Location = new System.Drawing.Point(31, 84);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(67, 14);
            this.username.TabIndex = 8;
            this.username.Text = "用户名：";
            // 
            // passwdTextBox
            // 
            this.passwdTextBox.Location = new System.Drawing.Point(105, 141);
            this.passwdTextBox.Name = "passwdTextBox";
            this.passwdTextBox.Size = new System.Drawing.Size(180, 21);
            this.passwdTextBox.TabIndex = 11;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.password.Location = new System.Drawing.Point(33, 144);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(52, 14);
            this.password.TabIndex = 9;
            this.password.Text = "密码：";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(105, 81);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(180, 21);
            this.usernameTextBox.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(574, 388);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(406, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "用户列表";
            // 
            // userList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "userList";
            this.Text = "userList";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.userList_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.userList_FormClosed);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button feedbackListBtn;
        private System.Windows.Forms.Button announcementBtn;
        private System.Windows.Forms.Button userListBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.TextBox passwdTextBox;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox usernameTextBox;
    }
}
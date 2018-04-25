namespace yinyangshiWinform.Admin
{
    partial class adminSignIn
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
            this.loginLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.loginButton = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.Label();
            this.adminPasswdTextBox = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.adminnameTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.loginLabel);
            this.panel2.Location = new System.Drawing.Point(293, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(216, 58);
            this.panel2.TabIndex = 7;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("楷体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.loginLabel.Location = new System.Drawing.Point(21, 13);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(180, 33);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "管理员登录";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.loginButton);
            this.panel1.Controls.Add(this.username);
            this.panel1.Controls.Add(this.adminPasswdTextBox);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.adminnameTextBox);
            this.panel1.Location = new System.Drawing.Point(246, 186);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 178);
            this.panel1.TabIndex = 6;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.loginButton.Location = new System.Drawing.Point(195, 133);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(87, 42);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "登录";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.username.Location = new System.Drawing.Point(28, 24);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(67, 14);
            this.username.TabIndex = 0;
            this.username.Text = "用户名：";
            // 
            // adminPasswdTextBox
            // 
            this.adminPasswdTextBox.Location = new System.Drawing.Point(102, 81);
            this.adminPasswdTextBox.Name = "adminPasswdTextBox";
            this.adminPasswdTextBox.Size = new System.Drawing.Size(180, 21);
            this.adminPasswdTextBox.TabIndex = 3;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.password.Location = new System.Drawing.Point(30, 84);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(52, 14);
            this.password.TabIndex = 1;
            this.password.Text = "密码：";
            // 
            // adminnameTextBox
            // 
            this.adminnameTextBox.Location = new System.Drawing.Point(102, 21);
            this.adminnameTextBox.Name = "adminnameTextBox";
            this.adminnameTextBox.Size = new System.Drawing.Size(180, 21);
            this.adminnameTextBox.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(701, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "用户登录";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // adminSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "adminSignIn";
            this.Text = "adminSignIn";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.TextBox adminPasswdTextBox;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox adminnameTextBox;
        private System.Windows.Forms.Button button1;
    }
}
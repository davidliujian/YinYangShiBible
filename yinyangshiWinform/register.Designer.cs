namespace yinyangshiWinform
{
    partial class register
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
            this.signUpLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.Label();
            this.signUpButton = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.Label();
            this.passwdTextBox = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.signUpLabel);
            this.panel2.Location = new System.Drawing.Point(309, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(234, 63);
            this.panel2.TabIndex = 7;
            // 
            // signUpLabel
            // 
            this.signUpLabel.AutoSize = true;
            this.signUpLabel.Font = new System.Drawing.Font("楷体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.signUpLabel.Location = new System.Drawing.Point(74, 12);
            this.signUpLabel.Name = "signUpLabel";
            this.signUpLabel.Size = new System.Drawing.Size(81, 33);
            this.signUpLabel.TabIndex = 0;
            this.signUpLabel.Text = "注册";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.phoneTextBox);
            this.panel1.Controls.Add(this.phone);
            this.panel1.Controls.Add(this.signUpButton);
            this.panel1.Controls.Add(this.username);
            this.panel1.Controls.Add(this.passwdTextBox);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.usernameTextBox);
            this.panel1.Location = new System.Drawing.Point(261, 171);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 189);
            this.panel1.TabIndex = 6;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(100, 7);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(180, 21);
            this.phoneTextBox.TabIndex = 7;
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.phone.Location = new System.Drawing.Point(28, 10);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(67, 14);
            this.phone.TabIndex = 6;
            this.phone.Text = "手机号：";
            // 
            // signUpButton
            // 
            this.signUpButton.BackColor = System.Drawing.Color.Lime;
            this.signUpButton.Location = new System.Drawing.Point(207, 145);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(75, 41);
            this.signUpButton.TabIndex = 5;
            this.signUpButton.Text = "注册";
            this.signUpButton.UseVisualStyleBackColor = false;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.username.Location = new System.Drawing.Point(28, 61);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(67, 14);
            this.username.TabIndex = 0;
            this.username.Text = "用户名：";
            // 
            // passwdTextBox
            // 
            this.passwdTextBox.Location = new System.Drawing.Point(102, 118);
            this.passwdTextBox.Name = "passwdTextBox";
            this.passwdTextBox.Size = new System.Drawing.Size(180, 21);
            this.passwdTextBox.TabIndex = 3;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.password.Location = new System.Drawing.Point(30, 121);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(52, 14);
            this.password.TabIndex = 1;
            this.password.Text = "密码：";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(102, 58);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(180, 21);
            this.usernameTextBox.TabIndex = 2;
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "register";
            this.Text = "register";
            this.Load += new System.EventHandler(this.register_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label signUpLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.TextBox passwdTextBox;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label phone;
    }
}
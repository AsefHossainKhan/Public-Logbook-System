namespace Public_Pricing_Logbook
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.username_TextBox = new System.Windows.Forms.TextBox();
            this.password_TextBox = new System.Windows.Forms.TextBox();
            this.login_Button = new System.Windows.Forms.Button();
            this.register_Button = new System.Windows.Forms.Button();
            this.loginasguest_Button = new System.Windows.Forms.Button();
            this.exit_Button = new System.Windows.Forms.Button();
            this.username_Label = new System.Windows.Forms.Label();
            this.password_Label = new System.Windows.Forms.Label();
            this.showpassword_CheckBox = new System.Windows.Forms.CheckBox();
            this.forgotpassword_Button = new System.Windows.Forms.Button();
            this.name_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // username_TextBox
            // 
            this.username_TextBox.Location = new System.Drawing.Point(252, 130);
            this.username_TextBox.Name = "username_TextBox";
            this.username_TextBox.Size = new System.Drawing.Size(100, 20);
            this.username_TextBox.TabIndex = 0;
            // 
            // password_TextBox
            // 
            this.password_TextBox.Location = new System.Drawing.Point(252, 156);
            this.password_TextBox.Name = "password_TextBox";
            this.password_TextBox.Size = new System.Drawing.Size(100, 20);
            this.password_TextBox.TabIndex = 1;
            this.password_TextBox.UseSystemPasswordChar = true;
            this.password_TextBox.TextChanged += new System.EventHandler(this.password_TextBox_TextChanged);
            // 
            // login_Button
            // 
            this.login_Button.BackColor = System.Drawing.Color.Transparent;
            this.login_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.login_Button.ForeColor = System.Drawing.Color.White;
            this.login_Button.Location = new System.Drawing.Point(264, 182);
            this.login_Button.Name = "login_Button";
            this.login_Button.Size = new System.Drawing.Size(75, 23);
            this.login_Button.TabIndex = 2;
            this.login_Button.Text = "Login";
            this.login_Button.UseVisualStyleBackColor = false;
            this.login_Button.Click += new System.EventHandler(this.login_Button_Click);
            // 
            // register_Button
            // 
            this.register_Button.BackColor = System.Drawing.Color.Transparent;
            this.register_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.register_Button.ForeColor = System.Drawing.Color.White;
            this.register_Button.Location = new System.Drawing.Point(264, 248);
            this.register_Button.Name = "register_Button";
            this.register_Button.Size = new System.Drawing.Size(75, 23);
            this.register_Button.TabIndex = 3;
            this.register_Button.Text = "Register";
            this.register_Button.UseVisualStyleBackColor = false;
            this.register_Button.Click += new System.EventHandler(this.register_Button_Click);
            // 
            // loginasguest_Button
            // 
            this.loginasguest_Button.BackColor = System.Drawing.Color.Transparent;
            this.loginasguest_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginasguest_Button.ForeColor = System.Drawing.Color.White;
            this.loginasguest_Button.Location = new System.Drawing.Point(252, 211);
            this.loginasguest_Button.Name = "loginasguest_Button";
            this.loginasguest_Button.Size = new System.Drawing.Size(101, 31);
            this.loginasguest_Button.TabIndex = 4;
            this.loginasguest_Button.Text = "Login As Guest";
            this.loginasguest_Button.UseVisualStyleBackColor = false;
            this.loginasguest_Button.Click += new System.EventHandler(this.loginasguest_Button_Click);
            // 
            // exit_Button
            // 
            this.exit_Button.BackColor = System.Drawing.Color.Transparent;
            this.exit_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exit_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit_Button.ForeColor = System.Drawing.Color.White;
            this.exit_Button.Location = new System.Drawing.Point(507, 28);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(75, 23);
            this.exit_Button.TabIndex = 5;
            this.exit_Button.Text = "E&XIT";
            this.exit_Button.UseVisualStyleBackColor = false;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // username_Label
            // 
            this.username_Label.BackColor = System.Drawing.Color.Transparent;
            this.username_Label.ForeColor = System.Drawing.Color.White;
            this.username_Label.Location = new System.Drawing.Point(170, 130);
            this.username_Label.Name = "username_Label";
            this.username_Label.Size = new System.Drawing.Size(76, 20);
            this.username_Label.TabIndex = 6;
            this.username_Label.Text = "USERNAME";
            this.username_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // password_Label
            // 
            this.password_Label.BackColor = System.Drawing.Color.Transparent;
            this.password_Label.ForeColor = System.Drawing.Color.White;
            this.password_Label.Location = new System.Drawing.Point(170, 156);
            this.password_Label.Name = "password_Label";
            this.password_Label.Size = new System.Drawing.Size(76, 20);
            this.password_Label.TabIndex = 7;
            this.password_Label.Text = "PASSWORD";
            this.password_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // showpassword_CheckBox
            // 
            this.showpassword_CheckBox.AutoSize = true;
            this.showpassword_CheckBox.BackColor = System.Drawing.Color.Transparent;
            this.showpassword_CheckBox.ForeColor = System.Drawing.Color.White;
            this.showpassword_CheckBox.Location = new System.Drawing.Point(369, 158);
            this.showpassword_CheckBox.Name = "showpassword_CheckBox";
            this.showpassword_CheckBox.Size = new System.Drawing.Size(102, 17);
            this.showpassword_CheckBox.TabIndex = 8;
            this.showpassword_CheckBox.Text = "Show Password";
            this.showpassword_CheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.showpassword_CheckBox.UseVisualStyleBackColor = false;
            this.showpassword_CheckBox.CheckedChanged += new System.EventHandler(this.showpassword_CheckBox_CheckedChanged);
            // 
            // forgotpassword_Button
            // 
            this.forgotpassword_Button.BackColor = System.Drawing.Color.Transparent;
            this.forgotpassword_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.forgotpassword_Button.ForeColor = System.Drawing.Color.White;
            this.forgotpassword_Button.Location = new System.Drawing.Point(226, 277);
            this.forgotpassword_Button.Name = "forgotpassword_Button";
            this.forgotpassword_Button.Size = new System.Drawing.Size(146, 26);
            this.forgotpassword_Button.TabIndex = 9;
            this.forgotpassword_Button.Text = "FORGOT PASSWORD";
            this.forgotpassword_Button.UseVisualStyleBackColor = false;
            this.forgotpassword_Button.Click += new System.EventHandler(this.forgotpassword_Button_Click);
            // 
            // name_Label
            // 
            this.name_Label.BackColor = System.Drawing.Color.Transparent;
            this.name_Label.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_Label.ForeColor = System.Drawing.Color.White;
            this.name_Label.Location = new System.Drawing.Point(173, 9);
            this.name_Label.Name = "name_Label";
            this.name_Label.Size = new System.Drawing.Size(270, 118);
            this.name_Label.TabIndex = 10;
            this.name_Label.Text = "PUBLIC PRICING LOGBOOK";
            this.name_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginPage
            // 
            this.AcceptButton = this.login_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.exit_Button;
            this.ClientSize = new System.Drawing.Size(614, 411);
            this.Controls.Add(this.name_Label);
            this.Controls.Add(this.forgotpassword_Button);
            this.Controls.Add(this.showpassword_CheckBox);
            this.Controls.Add(this.password_Label);
            this.Controls.Add(this.username_Label);
            this.Controls.Add(this.exit_Button);
            this.Controls.Add(this.loginasguest_Button);
            this.Controls.Add(this.register_Button);
            this.Controls.Add(this.login_Button);
            this.Controls.Add(this.password_TextBox);
            this.Controls.Add(this.username_TextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.Enter += new System.EventHandler(this.LoginPage_Enter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username_TextBox;
        private System.Windows.Forms.TextBox password_TextBox;
        private System.Windows.Forms.Button login_Button;
        private System.Windows.Forms.Button register_Button;
        private System.Windows.Forms.Button loginasguest_Button;
        private System.Windows.Forms.Button exit_Button;
        private System.Windows.Forms.Label username_Label;
        private System.Windows.Forms.Label password_Label;
        private System.Windows.Forms.CheckBox showpassword_CheckBox;
        private System.Windows.Forms.Button forgotpassword_Button;
        private System.Windows.Forms.Label name_Label;
    }
}


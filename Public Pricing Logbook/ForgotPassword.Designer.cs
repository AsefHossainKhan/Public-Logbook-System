namespace Public_Pricing_Logbook
{
    partial class ForgotPassword
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
            this.enterusername_Label = new System.Windows.Forms.Label();
            this.enterusername_TextBox = new System.Windows.Forms.TextBox();
            this.Enter_Button = new System.Windows.Forms.Button();
            this.back_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enterusername_Label
            // 
            this.enterusername_Label.BackColor = System.Drawing.Color.Transparent;
            this.enterusername_Label.ForeColor = System.Drawing.Color.White;
            this.enterusername_Label.Location = new System.Drawing.Point(165, 172);
            this.enterusername_Label.Name = "enterusername_Label";
            this.enterusername_Label.Size = new System.Drawing.Size(129, 20);
            this.enterusername_Label.TabIndex = 7;
            this.enterusername_Label.Text = "ENTER USERNAME";
            this.enterusername_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // enterusername_TextBox
            // 
            this.enterusername_TextBox.Location = new System.Drawing.Point(301, 171);
            this.enterusername_TextBox.Name = "enterusername_TextBox";
            this.enterusername_TextBox.Size = new System.Drawing.Size(163, 20);
            this.enterusername_TextBox.TabIndex = 8;
            // 
            // Enter_Button
            // 
            this.Enter_Button.BackColor = System.Drawing.Color.Transparent;
            this.Enter_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Enter_Button.ForeColor = System.Drawing.Color.White;
            this.Enter_Button.Location = new System.Drawing.Point(253, 232);
            this.Enter_Button.Name = "Enter_Button";
            this.Enter_Button.Size = new System.Drawing.Size(75, 23);
            this.Enter_Button.TabIndex = 9;
            this.Enter_Button.Text = "ENTER";
            this.Enter_Button.UseVisualStyleBackColor = false;
            this.Enter_Button.Click += new System.EventHandler(this.Enter_Button_Click);
            // 
            // back_Button
            // 
            this.back_Button.BackColor = System.Drawing.Color.Transparent;
            this.back_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.back_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back_Button.ForeColor = System.Drawing.Color.White;
            this.back_Button.Location = new System.Drawing.Point(12, 12);
            this.back_Button.Name = "back_Button";
            this.back_Button.Size = new System.Drawing.Size(113, 29);
            this.back_Button.TabIndex = 17;
            this.back_Button.Text = "BACK";
            this.back_Button.UseVisualStyleBackColor = false;
            this.back_Button.Click += new System.EventHandler(this.back_Button_Click);
            // 
            // ForgotPassword
            // 
            this.AcceptButton = this.Enter_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Public_Pricing_Logbook.Properties.Resources.minimalist_black_background_arrangement_coffee_beans_23_2148441212;
            this.CancelButton = this.back_Button;
            this.ClientSize = new System.Drawing.Size(621, 409);
            this.Controls.Add(this.back_Button);
            this.Controls.Add(this.Enter_Button);
            this.Controls.Add(this.enterusername_TextBox);
            this.Controls.Add(this.enterusername_Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgotPassword";
            this.Load += new System.EventHandler(this.ForgotPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterusername_Label;
        private System.Windows.Forms.TextBox enterusername_TextBox;
        private System.Windows.Forms.Button Enter_Button;
        private System.Windows.Forms.Button back_Button;
    }
}
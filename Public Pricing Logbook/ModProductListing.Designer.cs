namespace Public_Pricing_Logbook
{
    partial class ModProductListing
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.exit_Button = new System.Windows.Forms.Button();
            this.back_Button = new System.Windows.Forms.Button();
            this.addnewitem_Button = new System.Windows.Forms.Button();
            this.addnewitem_TextBox = new System.Windows.Forms.TextBox();
            this.productlisting_DataGridView = new System.Windows.Forms.DataGridView();
            this.addnewitem_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productlisting_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // exit_Button
            // 
            this.exit_Button.BackColor = System.Drawing.Color.Transparent;
            this.exit_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit_Button.ForeColor = System.Drawing.Color.White;
            this.exit_Button.Location = new System.Drawing.Point(326, 12);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(75, 23);
            this.exit_Button.TabIndex = 6;
            this.exit_Button.Text = "E&XIT";
            this.exit_Button.UseVisualStyleBackColor = false;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // back_Button
            // 
            this.back_Button.BackColor = System.Drawing.Color.Transparent;
            this.back_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back_Button.ForeColor = System.Drawing.Color.White;
            this.back_Button.Location = new System.Drawing.Point(12, 12);
            this.back_Button.Name = "back_Button";
            this.back_Button.Size = new System.Drawing.Size(114, 23);
            this.back_Button.TabIndex = 22;
            this.back_Button.Text = "BACK/SIGN OUT";
            this.back_Button.UseVisualStyleBackColor = false;
            this.back_Button.Click += new System.EventHandler(this.back_Button_Click);
            // 
            // addnewitem_Button
            // 
            this.addnewitem_Button.BackColor = System.Drawing.Color.Transparent;
            this.addnewitem_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addnewitem_Button.ForeColor = System.Drawing.Color.White;
            this.addnewitem_Button.Location = new System.Drawing.Point(250, 48);
            this.addnewitem_Button.Name = "addnewitem_Button";
            this.addnewitem_Button.Size = new System.Drawing.Size(112, 23);
            this.addnewitem_Button.TabIndex = 23;
            this.addnewitem_Button.Text = "ADD NEW ITEM";
            this.addnewitem_Button.UseVisualStyleBackColor = false;
            this.addnewitem_Button.Click += new System.EventHandler(this.addnewitem_Button_Click);
            // 
            // addnewitem_TextBox
            // 
            this.addnewitem_TextBox.Location = new System.Drawing.Point(132, 50);
            this.addnewitem_TextBox.Name = "addnewitem_TextBox";
            this.addnewitem_TextBox.Size = new System.Drawing.Size(100, 20);
            this.addnewitem_TextBox.TabIndex = 24;
            // 
            // productlisting_DataGridView
            // 
            this.productlisting_DataGridView.AllowUserToAddRows = false;
            this.productlisting_DataGridView.AllowUserToDeleteRows = false;
            this.productlisting_DataGridView.AllowUserToOrderColumns = true;
            this.productlisting_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productlisting_DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productlisting_DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.productlisting_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productlisting_DataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.productlisting_DataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.productlisting_DataGridView.Location = new System.Drawing.Point(0, 77);
            this.productlisting_DataGridView.Name = "productlisting_DataGridView";
            this.productlisting_DataGridView.ReadOnly = true;
            this.productlisting_DataGridView.RowHeadersVisible = false;
            this.productlisting_DataGridView.Size = new System.Drawing.Size(413, 324);
            this.productlisting_DataGridView.TabIndex = 25;
            this.productlisting_DataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productlisting_DataGridView_CellContentClick);
            // 
            // addnewitem_Label
            // 
            this.addnewitem_Label.BackColor = System.Drawing.Color.Transparent;
            this.addnewitem_Label.ForeColor = System.Drawing.Color.White;
            this.addnewitem_Label.Location = new System.Drawing.Point(50, 50);
            this.addnewitem_Label.Name = "addnewitem_Label";
            this.addnewitem_Label.Size = new System.Drawing.Size(76, 20);
            this.addnewitem_Label.TabIndex = 26;
            this.addnewitem_Label.Text = "ITEM NAME";
            this.addnewitem_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addnewitem_Label.Click += new System.EventHandler(this.addnewitem_Label_Click);
            // 
            // ModProductListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Public_Pricing_Logbook.Properties.Resources.coffee_background;
            this.ClientSize = new System.Drawing.Size(413, 401);
            this.Controls.Add(this.addnewitem_Label);
            this.Controls.Add(this.productlisting_DataGridView);
            this.Controls.Add(this.addnewitem_TextBox);
            this.Controls.Add(this.addnewitem_Button);
            this.Controls.Add(this.back_Button);
            this.Controls.Add(this.exit_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModProductListing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModProductListing";
            this.Load += new System.EventHandler(this.ModProductListing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productlisting_DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit_Button;
        private System.Windows.Forms.Button back_Button;
        private System.Windows.Forms.Button addnewitem_Button;
        private System.Windows.Forms.TextBox addnewitem_TextBox;
        private System.Windows.Forms.DataGridView productlisting_DataGridView;
        private System.Windows.Forms.Label addnewitem_Label;
    }
}
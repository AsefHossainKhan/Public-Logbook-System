namespace Public_Pricing_Logbook
{
    partial class GuestProductListing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuestProductListing));
            this.productlisting_DataGridView = new System.Windows.Forms.DataGridView();
            this.back_Button = new System.Windows.Forms.Button();
            this.exit_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productlisting_DataGridView)).BeginInit();
            this.SuspendLayout();
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
            this.productlisting_DataGridView.Location = new System.Drawing.Point(0, 65);
            this.productlisting_DataGridView.Name = "productlisting_DataGridView";
            this.productlisting_DataGridView.ReadOnly = true;
            this.productlisting_DataGridView.RowHeadersVisible = false;
            this.productlisting_DataGridView.Size = new System.Drawing.Size(370, 342);
            this.productlisting_DataGridView.TabIndex = 26;
            this.productlisting_DataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productlisting_DataGridView_CellContentClick);
            // 
            // back_Button
            // 
            this.back_Button.BackColor = System.Drawing.Color.Transparent;
            this.back_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back_Button.ForeColor = System.Drawing.Color.White;
            this.back_Button.Location = new System.Drawing.Point(12, 12);
            this.back_Button.Name = "back_Button";
            this.back_Button.Size = new System.Drawing.Size(114, 23);
            this.back_Button.TabIndex = 27;
            this.back_Button.Text = "BACK/SIGN OUT";
            this.back_Button.UseVisualStyleBackColor = false;
            this.back_Button.Click += new System.EventHandler(this.back_Button_Click);
            // 
            // exit_Button
            // 
            this.exit_Button.BackColor = System.Drawing.Color.Transparent;
            this.exit_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit_Button.ForeColor = System.Drawing.Color.White;
            this.exit_Button.Location = new System.Drawing.Point(283, 12);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(75, 23);
            this.exit_Button.TabIndex = 28;
            this.exit_Button.Text = "E&XIT";
            this.exit_Button.UseVisualStyleBackColor = false;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // GuestProductListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(370, 407);
            this.Controls.Add(this.exit_Button);
            this.Controls.Add(this.back_Button);
            this.Controls.Add(this.productlisting_DataGridView);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GuestProductListing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GuestProductListing";
            ((System.ComponentModel.ISupportInitialize)(this.productlisting_DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView productlisting_DataGridView;
        private System.Windows.Forms.Button back_Button;
        private System.Windows.Forms.Button exit_Button;
    }
}
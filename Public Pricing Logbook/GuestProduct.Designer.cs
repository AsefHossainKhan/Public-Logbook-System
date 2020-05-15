namespace Public_Pricing_Logbook
{
    partial class GuestProduct
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.back_Button = new System.Windows.Forms.Button();
            this.product_Label = new System.Windows.Forms.Label();
            this.product_DataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.product_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // back_Button
            // 
            this.back_Button.BackColor = System.Drawing.Color.Transparent;
            this.back_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back_Button.ForeColor = System.Drawing.Color.White;
            this.back_Button.Location = new System.Drawing.Point(12, 12);
            this.back_Button.Name = "back_Button";
            this.back_Button.Size = new System.Drawing.Size(113, 29);
            this.back_Button.TabIndex = 14;
            this.back_Button.Text = "BACK";
            this.back_Button.UseVisualStyleBackColor = false;
            this.back_Button.Click += new System.EventHandler(this.back_Button_Click);
            this.back_Button.MouseClick += new System.Windows.Forms.MouseEventHandler(this.back_Button_MouseClick);
            // 
            // product_Label
            // 
            this.product_Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.product_Label.BackColor = System.Drawing.Color.Transparent;
            this.product_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_Label.ForeColor = System.Drawing.Color.White;
            this.product_Label.Location = new System.Drawing.Point(223, 12);
            this.product_Label.Name = "product_Label";
            this.product_Label.Size = new System.Drawing.Size(157, 29);
            this.product_Label.TabIndex = 15;
            this.product_Label.Text = "PRODUCT NAME";
            this.product_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.product_Label.Click += new System.EventHandler(this.product_Label_Click);
            // 
            // product_DataGridView
            // 
            this.product_DataGridView.AllowUserToAddRows = false;
            this.product_DataGridView.AllowUserToDeleteRows = false;
            this.product_DataGridView.AllowUserToOrderColumns = true;
            this.product_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.product_DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.product_DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.product_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.product_DataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.product_DataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.product_DataGridView.Location = new System.Drawing.Point(0, 65);
            this.product_DataGridView.Name = "product_DataGridView";
            this.product_DataGridView.ReadOnly = true;
            this.product_DataGridView.RowHeadersVisible = false;
            this.product_DataGridView.Size = new System.Drawing.Size(623, 344);
            this.product_DataGridView.TabIndex = 27;
            this.product_DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.product_DataGridView_CellContentClick);
            // 
            // GuestProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Public_Pricing_Logbook.Properties.Resources.coffee_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(623, 409);
            this.Controls.Add(this.product_DataGridView);
            this.Controls.Add(this.product_Label);
            this.Controls.Add(this.back_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GuestProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GuestProduct";
            this.Load += new System.EventHandler(this.GuestProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.product_DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button back_Button;
        private System.Windows.Forms.Label product_Label;
        private System.Windows.Forms.DataGridView product_DataGridView;
    }
}
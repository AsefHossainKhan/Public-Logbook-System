namespace Public_Pricing_Logbook
{
    partial class ModProduct
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
            this.product_Label = new System.Windows.Forms.Label();
            this.price_Label = new System.Windows.Forms.Label();
            this.location_Label = new System.Windows.Forms.Label();
            this.price_TextBox = new System.Windows.Forms.TextBox();
            this.location_TextBox = new System.Windows.Forms.TextBox();
            this.product_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.back_Button = new System.Windows.Forms.Button();
            this.addentry_Button = new System.Windows.Forms.Button();
            this.deleteproduct_Button = new System.Windows.Forms.Button();
            this.product_DataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.product_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // product_Label
            // 
            this.product_Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.product_Label.BackColor = System.Drawing.Color.Transparent;
            this.product_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_Label.ForeColor = System.Drawing.Color.White;
            this.product_Label.Location = new System.Drawing.Point(235, 19);
            this.product_Label.Name = "product_Label";
            this.product_Label.Size = new System.Drawing.Size(137, 29);
            this.product_Label.TabIndex = 7;
            this.product_Label.Text = "PRODUCT NAME";
            this.product_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.product_Label.Click += new System.EventHandler(this.product_Label_Click);
            // 
            // price_Label
            // 
            this.price_Label.BackColor = System.Drawing.Color.Transparent;
            this.price_Label.ForeColor = System.Drawing.Color.White;
            this.price_Label.Location = new System.Drawing.Point(14, 57);
            this.price_Label.Name = "price_Label";
            this.price_Label.Size = new System.Drawing.Size(77, 29);
            this.price_Label.TabIndex = 8;
            this.price_Label.Text = "PRICE";
            this.price_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // location_Label
            // 
            this.location_Label.BackColor = System.Drawing.Color.Transparent;
            this.location_Label.ForeColor = System.Drawing.Color.White;
            this.location_Label.Location = new System.Drawing.Point(14, 91);
            this.location_Label.Name = "location_Label";
            this.location_Label.Size = new System.Drawing.Size(77, 29);
            this.location_Label.TabIndex = 9;
            this.location_Label.Text = "LOCATION";
            this.location_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // price_TextBox
            // 
            this.price_TextBox.Location = new System.Drawing.Point(98, 65);
            this.price_TextBox.Name = "price_TextBox";
            this.price_TextBox.Size = new System.Drawing.Size(100, 20);
            this.price_TextBox.TabIndex = 10;
            this.price_TextBox.TextChanged += new System.EventHandler(this.price_TextBox_TextChanged);
            // 
            // location_TextBox
            // 
            this.location_TextBox.Location = new System.Drawing.Point(97, 96);
            this.location_TextBox.Name = "location_TextBox";
            this.location_TextBox.Size = new System.Drawing.Size(100, 20);
            this.location_TextBox.TabIndex = 11;
            // 
            // product_DateTimePicker
            // 
            this.product_DateTimePicker.Location = new System.Drawing.Point(408, 91);
            this.product_DateTimePicker.Name = "product_DateTimePicker";
            this.product_DateTimePicker.Size = new System.Drawing.Size(194, 20);
            this.product_DateTimePicker.TabIndex = 12;
            // 
            // back_Button
            // 
            this.back_Button.BackColor = System.Drawing.Color.Transparent;
            this.back_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back_Button.ForeColor = System.Drawing.Color.White;
            this.back_Button.Location = new System.Drawing.Point(17, 19);
            this.back_Button.Name = "back_Button";
            this.back_Button.Size = new System.Drawing.Size(113, 29);
            this.back_Button.TabIndex = 13;
            this.back_Button.Text = "BACK";
            this.back_Button.UseVisualStyleBackColor = false;
            this.back_Button.Click += new System.EventHandler(this.back_Button_Click);
            // 
            // addentry_Button
            // 
            this.addentry_Button.AutoEllipsis = true;
            this.addentry_Button.BackColor = System.Drawing.Color.Transparent;
            this.addentry_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addentry_Button.ForeColor = System.Drawing.Color.White;
            this.addentry_Button.Location = new System.Drawing.Point(250, 82);
            this.addentry_Button.Name = "addentry_Button";
            this.addentry_Button.Size = new System.Drawing.Size(111, 29);
            this.addentry_Button.TabIndex = 14;
            this.addentry_Button.Text = "ADD ENTRY";
            this.addentry_Button.UseVisualStyleBackColor = false;
            this.addentry_Button.Click += new System.EventHandler(this.addentry_Button_Click);
            // 
            // deleteproduct_Button
            // 
            this.deleteproduct_Button.BackColor = System.Drawing.Color.Transparent;
            this.deleteproduct_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteproduct_Button.ForeColor = System.Drawing.Color.White;
            this.deleteproduct_Button.Location = new System.Drawing.Point(489, 19);
            this.deleteproduct_Button.Name = "deleteproduct_Button";
            this.deleteproduct_Button.Size = new System.Drawing.Size(113, 45);
            this.deleteproduct_Button.TabIndex = 15;
            this.deleteproduct_Button.Text = "DELETE THIS PRODUCT";
            this.deleteproduct_Button.UseVisualStyleBackColor = false;
            this.deleteproduct_Button.Click += new System.EventHandler(this.deleteproduct_Button_Click);
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
            this.product_DataGridView.Location = new System.Drawing.Point(0, 143);
            this.product_DataGridView.Name = "product_DataGridView";
            this.product_DataGridView.ReadOnly = true;
            this.product_DataGridView.RowHeadersVisible = false;
            this.product_DataGridView.Size = new System.Drawing.Size(620, 267);
            this.product_DataGridView.TabIndex = 26;
            this.product_DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.product_DataGridView_CellContentClick);
            // 
            // ModProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Public_Pricing_Logbook.Properties.Resources.coffee_background;
            this.ClientSize = new System.Drawing.Size(620, 410);
            this.Controls.Add(this.product_DataGridView);
            this.Controls.Add(this.deleteproduct_Button);
            this.Controls.Add(this.addentry_Button);
            this.Controls.Add(this.back_Button);
            this.Controls.Add(this.product_DateTimePicker);
            this.Controls.Add(this.location_TextBox);
            this.Controls.Add(this.price_TextBox);
            this.Controls.Add(this.location_Label);
            this.Controls.Add(this.price_Label);
            this.Controls.Add(this.product_Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModProduct";
            this.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModProduct";
            this.Load += new System.EventHandler(this.ModProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.product_DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label product_Label;
        private System.Windows.Forms.Label price_Label;
        private System.Windows.Forms.Label location_Label;
        private System.Windows.Forms.TextBox price_TextBox;
        private System.Windows.Forms.TextBox location_TextBox;
        private System.Windows.Forms.DateTimePicker product_DateTimePicker;
        private System.Windows.Forms.Button back_Button;
        private System.Windows.Forms.Button addentry_Button;
        private System.Windows.Forms.Button deleteproduct_Button;
        private System.Windows.Forms.DataGridView product_DataGridView;
    }
}
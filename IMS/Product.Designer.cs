namespace IMS
{
    partial class Product
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.proLabel = new System.Windows.Forms.Label();
            this.proTxt = new System.Windows.Forms.TextBox();
            this.proErrorLabel = new System.Windows.Forms.Label();
            this.barTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.barErrorLabel = new System.Windows.Forms.Label();
            this.priceTxt = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceErrorLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.catErrorLabel = new System.Windows.Forms.Label();
            this.expLabel = new System.Windows.Forms.Label();
            this.expireTxt = new System.Windows.Forms.DateTimePicker();
            this.expErrorLabel = new System.Windows.Forms.Label();
            this.categoryCombo = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.proidGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiryGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catidGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // delBtn
            // 
            this.delBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.delBtn.FlatAppearance.BorderSize = 2;
            // 
            // saveBtn
            // 
            this.saveBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.saveBtn.FlatAppearance.BorderSize = 2;
            // 
            // editBtn
            // 
            this.editBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.editBtn.FlatAppearance.BorderSize = 2;
            // 
            // addBtn
            // 
            this.addBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.addBtn.FlatAppearance.BorderSize = 2;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            // 
            // viewBtn
            // 
            this.viewBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.viewBtn.FlatAppearance.BorderSize = 2;
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.categoryCombo);
            this.leftPanel.Controls.Add(this.expireTxt);
            this.leftPanel.Controls.Add(this.expLabel);
            this.leftPanel.Controls.Add(this.label7);
            this.leftPanel.Controls.Add(this.catErrorLabel);
            this.leftPanel.Controls.Add(this.priceTxt);
            this.leftPanel.Controls.Add(this.priceLabel);
            this.leftPanel.Controls.Add(this.barTxt);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Controls.Add(this.barErrorLabel);
            this.leftPanel.Controls.Add(this.proTxt);
            this.leftPanel.Controls.Add(this.proLabel);
            this.leftPanel.Controls.Add(this.proErrorLabel);
            this.leftPanel.Controls.Add(this.priceErrorLabel);
            this.leftPanel.Controls.Add(this.expErrorLabel);
            this.leftPanel.Controls.SetChildIndex(this.expErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.priceErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.proErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.proLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.proTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.barErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.label3, 0);
            this.leftPanel.Controls.SetChildIndex(this.barTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.priceLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.priceTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.catErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.label7, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel1, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel4, 0);
            this.leftPanel.Controls.SetChildIndex(this.expLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.expireTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.categoryCombo, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.dataGridView1);
            this.rightPanel.Controls.SetChildIndex(this.panel2, 0);
            this.rightPanel.Controls.SetChildIndex(this.panel3, 0);
            this.rightPanel.Controls.SetChildIndex(this.dataGridView1, 0);
            // 
            // proLabel
            // 
            this.proLabel.AutoSize = true;
            this.proLabel.Location = new System.Drawing.Point(3, 107);
            this.proLabel.Name = "proLabel";
            this.proLabel.Size = new System.Drawing.Size(81, 15);
            this.proLabel.TabIndex = 2;
            this.proLabel.Text = "Product Name";
            // 
            // proTxt
            // 
            this.proTxt.Location = new System.Drawing.Point(3, 125);
            this.proTxt.Name = "proTxt";
            this.proTxt.Size = new System.Drawing.Size(191, 23);
            this.proTxt.TabIndex = 3;
            // 
            // proErrorLabel
            // 
            this.proErrorLabel.AutoSize = true;
            this.proErrorLabel.Font = new System.Drawing.Font("Segoe UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proErrorLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.proErrorLabel.Location = new System.Drawing.Point(79, 96);
            this.proErrorLabel.Name = "proErrorLabel";
            this.proErrorLabel.Size = new System.Drawing.Size(20, 28);
            this.proErrorLabel.TabIndex = 29;
            this.proErrorLabel.Text = "*";
            this.proErrorLabel.Visible = false;
            // 
            // barTxt
            // 
            this.barTxt.Location = new System.Drawing.Point(3, 177);
            this.barTxt.Name = "barTxt";
            this.barTxt.Size = new System.Drawing.Size(191, 23);
            this.barTxt.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 30;
            this.label3.Text = "Bar Code";
            // 
            // barErrorLabel
            // 
            this.barErrorLabel.AutoSize = true;
            this.barErrorLabel.Font = new System.Drawing.Font("Segoe UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barErrorLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.barErrorLabel.Location = new System.Drawing.Point(79, 148);
            this.barErrorLabel.Name = "barErrorLabel";
            this.barErrorLabel.Size = new System.Drawing.Size(20, 28);
            this.barErrorLabel.TabIndex = 32;
            this.barErrorLabel.Text = "*";
            this.barErrorLabel.Visible = false;
            // 
            // priceTxt
            // 
            this.priceTxt.Location = new System.Drawing.Point(3, 282);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.Size = new System.Drawing.Size(191, 23);
            this.priceTxt.TabIndex = 34;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(3, 264);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(31, 15);
            this.priceLabel.TabIndex = 33;
            this.priceLabel.Text = "Price";
            // 
            // priceErrorLabel
            // 
            this.priceErrorLabel.AutoSize = true;
            this.priceErrorLabel.Font = new System.Drawing.Font("Segoe UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceErrorLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.priceErrorLabel.Location = new System.Drawing.Point(37, 251);
            this.priceErrorLabel.Name = "priceErrorLabel";
            this.priceErrorLabel.Size = new System.Drawing.Size(20, 28);
            this.priceErrorLabel.TabIndex = 35;
            this.priceErrorLabel.Text = "*";
            this.priceErrorLabel.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 15);
            this.label7.TabIndex = 36;
            this.label7.Text = "Catagory";
            // 
            // catErrorLabel
            // 
            this.catErrorLabel.AutoSize = true;
            this.catErrorLabel.Font = new System.Drawing.Font("Segoe UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catErrorLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.catErrorLabel.Location = new System.Drawing.Point(63, 310);
            this.catErrorLabel.Name = "catErrorLabel";
            this.catErrorLabel.Size = new System.Drawing.Size(20, 28);
            this.catErrorLabel.TabIndex = 38;
            this.catErrorLabel.Text = "*";
            this.catErrorLabel.Visible = false;
            // 
            // expLabel
            // 
            this.expLabel.AutoSize = true;
            this.expLabel.Location = new System.Drawing.Point(3, 203);
            this.expLabel.Name = "expLabel";
            this.expLabel.Size = new System.Drawing.Size(64, 15);
            this.expLabel.TabIndex = 39;
            this.expLabel.Text = "Expiry Date";
            // 
            // expireTxt
            // 
            this.expireTxt.CustomFormat = "dd-MM-yyyy";
            this.expireTxt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.expireTxt.Location = new System.Drawing.Point(3, 225);
            this.expireTxt.Name = "expireTxt";
            this.expireTxt.Size = new System.Drawing.Size(191, 23);
            this.expireTxt.TabIndex = 40;
            // 
            // expErrorLabel
            // 
            this.expErrorLabel.AutoSize = true;
            this.expErrorLabel.Font = new System.Drawing.Font("Segoe UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expErrorLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.expErrorLabel.Location = new System.Drawing.Point(73, 194);
            this.expErrorLabel.Name = "expErrorLabel";
            this.expErrorLabel.Size = new System.Drawing.Size(20, 28);
            this.expErrorLabel.TabIndex = 41;
            this.expErrorLabel.Text = "*";
            this.expErrorLabel.Visible = false;
            // 
            // categoryCombo
            // 
            this.categoryCombo.FormattingEnabled = true;
            this.categoryCombo.Location = new System.Drawing.Point(3, 341);
            this.categoryCombo.Name = "categoryCombo";
            this.categoryCombo.Size = new System.Drawing.Size(191, 23);
            this.categoryCombo.TabIndex = 42;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.proidGV,
            this.productGV,
            this.expiryGV,
            this.barGV,
            this.priceGV,
            this.categoryGV,
            this.catidGV});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(648, 417);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // proidGV
            // 
            this.proidGV.HeaderText = "Pro ID";
            this.proidGV.Name = "proidGV";
            this.proidGV.ReadOnly = true;
            this.proidGV.Visible = false;
            // 
            // productGV
            // 
            this.productGV.HeaderText = "Product";
            this.productGV.Name = "productGV";
            this.productGV.ReadOnly = true;
            // 
            // expiryGV
            // 
            this.expiryGV.HeaderText = "Expiry";
            this.expiryGV.Name = "expiryGV";
            this.expiryGV.ReadOnly = true;
            // 
            // barGV
            // 
            this.barGV.HeaderText = "Bar Code";
            this.barGV.Name = "barGV";
            this.barGV.ReadOnly = true;
            // 
            // priceGV
            // 
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0";
            this.priceGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.priceGV.HeaderText = "Price";
            this.priceGV.Name = "priceGV";
            this.priceGV.ReadOnly = true;
            // 
            // categoryGV
            // 
            this.categoryGV.HeaderText = "Category";
            this.categoryGV.Name = "categoryGV";
            this.categoryGV.ReadOnly = true;
            // 
            // catidGV
            // 
            this.catidGV.HeaderText = "Category ID";
            this.catidGV.Name = "catidGV";
            this.catidGV.ReadOnly = true;
            this.catidGV.Visible = false;
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 501);
            this.Name = "Product";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.Product_Load);
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox proTxt;
        private System.Windows.Forms.Label proLabel;
        private System.Windows.Forms.Label proErrorLabel;
        private System.Windows.Forms.DateTimePicker expireTxt;
        private System.Windows.Forms.Label expLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label catErrorLabel;
        private System.Windows.Forms.TextBox priceTxt;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox barTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label barErrorLabel;
        private System.Windows.Forms.Label priceErrorLabel;
        private System.Windows.Forms.Label expErrorLabel;
        private System.Windows.Forms.ComboBox categoryCombo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn proidGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn productGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiryGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn barGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn catidGV;
    }
}
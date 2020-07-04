namespace IMS
{
    partial class categories
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.statusErrorLabel = new System.Windows.Forms.Label();
            this.catagoryTxt = new System.Windows.Forms.TextBox();
            this.proLabel = new System.Windows.Forms.Label();
            this.catErrorLabel = new System.Windows.Forms.Label();
            this.catCombo = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.catGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.leftPanel.Controls.Add(this.catCombo);
            this.leftPanel.Controls.Add(this.catErrorLabel);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Controls.Add(this.statusErrorLabel);
            this.leftPanel.Controls.Add(this.catagoryTxt);
            this.leftPanel.Controls.Add(this.proLabel);
            this.leftPanel.Controls.SetChildIndex(this.panel1, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel4, 0);
            this.leftPanel.Controls.SetChildIndex(this.proLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.catagoryTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.statusErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.label3, 0);
            this.leftPanel.Controls.SetChildIndex(this.catErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.catCombo, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.dataGridView1);
            this.rightPanel.Controls.SetChildIndex(this.panel2, 0);
            this.rightPanel.Controls.SetChildIndex(this.panel3, 0);
            this.rightPanel.Controls.SetChildIndex(this.dataGridView1, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 36;
            this.label3.Text = "Is Active";
            // 
            // statusErrorLabel
            // 
            this.statusErrorLabel.AutoSize = true;
            this.statusErrorLabel.Font = new System.Drawing.Font("Segoe UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusErrorLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.statusErrorLabel.Location = new System.Drawing.Point(57, 149);
            this.statusErrorLabel.Name = "statusErrorLabel";
            this.statusErrorLabel.Size = new System.Drawing.Size(20, 28);
            this.statusErrorLabel.TabIndex = 38;
            this.statusErrorLabel.Text = "*";
            this.statusErrorLabel.Visible = false;
            // 
            // catagoryTxt
            // 
            this.catagoryTxt.Location = new System.Drawing.Point(3, 123);
            this.catagoryTxt.Name = "catagoryTxt";
            this.catagoryTxt.Size = new System.Drawing.Size(191, 23);
            this.catagoryTxt.TabIndex = 34;
            // 
            // proLabel
            // 
            this.proLabel.AutoSize = true;
            this.proLabel.Location = new System.Drawing.Point(3, 105);
            this.proLabel.Name = "proLabel";
            this.proLabel.Size = new System.Drawing.Size(88, 15);
            this.proLabel.TabIndex = 33;
            this.proLabel.Text = "Catagory Name";
            // 
            // catErrorLabel
            // 
            this.catErrorLabel.AutoSize = true;
            this.catErrorLabel.Font = new System.Drawing.Font("Segoe UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catErrorLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.catErrorLabel.Location = new System.Drawing.Point(79, 94);
            this.catErrorLabel.Name = "catErrorLabel";
            this.catErrorLabel.Size = new System.Drawing.Size(20, 28);
            this.catErrorLabel.TabIndex = 35;
            this.catErrorLabel.Text = "*";
            this.catErrorLabel.Visible = false;
            // 
            // catCombo
            // 
            this.catCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.catCombo.FormattingEnabled = true;
            this.catCombo.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.catCombo.Location = new System.Drawing.Point(3, 180);
            this.catCombo.Name = "catCombo";
            this.catCombo.Size = new System.Drawing.Size(191, 23);
            this.catCombo.TabIndex = 39;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.catGV,
            this.nameGV,
            this.StatusGV});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(648, 417);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // catGV
            // 
            this.catGV.HeaderText = "cat ID";
            this.catGV.Name = "catGV";
            this.catGV.ReadOnly = true;
            this.catGV.Visible = false;
            // 
            // nameGV
            // 
            this.nameGV.HeaderText = "Name";
            this.nameGV.Name = "nameGV";
            this.nameGV.ReadOnly = true;
            // 
            // StatusGV
            // 
            this.StatusGV.HeaderText = "Status";
            this.StatusGV.Name = "StatusGV";
            this.StatusGV.ReadOnly = true;
            // 
            // categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 501);
            this.Name = "categories";
            this.Text = "categories";
            this.Load += new System.EventHandler(this.categories_Load);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label statusErrorLabel;
        private System.Windows.Forms.TextBox catagoryTxt;
        private System.Windows.Forms.Label proLabel;
        private System.Windows.Forms.Label catErrorLabel;
        private System.Windows.Forms.ComboBox catCombo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn catGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusGV;
    }
}
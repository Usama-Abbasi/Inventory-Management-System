namespace IMS
{
    partial class settings
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
            this.Server = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.serverTxt = new System.Windows.Forms.TextBox();
            this.dbTxt = new System.Windows.Forms.TextBox();
            this.userTxt = new System.Windows.Forms.TextBox();
            this.passTxt = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.saveBtn);
            this.leftPanel.Controls.Add(this.checkBox1);
            this.leftPanel.Controls.Add(this.passTxt);
            this.leftPanel.Controls.Add(this.userTxt);
            this.leftPanel.Controls.Add(this.dbTxt);
            this.leftPanel.Controls.Add(this.serverTxt);
            this.leftPanel.Controls.Add(this.label6);
            this.leftPanel.Controls.Add(this.label5);
            this.leftPanel.Controls.Add(this.label4);
            this.leftPanel.Controls.Add(this.Server);
            this.leftPanel.Size = new System.Drawing.Size(200, 496);
            this.leftPanel.Controls.SetChildIndex(this.panel1, 0);
            this.leftPanel.Controls.SetChildIndex(this.Server, 0);
            this.leftPanel.Controls.SetChildIndex(this.label4, 0);
            this.leftPanel.Controls.SetChildIndex(this.label5, 0);
            this.leftPanel.Controls.SetChildIndex(this.label6, 0);
            this.leftPanel.Controls.SetChildIndex(this.serverTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.dbTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.userTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.passTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.checkBox1, 0);
            this.leftPanel.Controls.SetChildIndex(this.saveBtn, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Size = new System.Drawing.Size(584, 496);
            // 
            // Server
            // 
            this.Server.AutoSize = true;
            this.Server.Location = new System.Drawing.Point(12, 142);
            this.Server.Name = "Server";
            this.Server.Size = new System.Drawing.Size(39, 15);
            this.Server.TabIndex = 1;
            this.Server.Text = "Server";
            this.Server.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Database";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "UserID";
            // 
            // serverTxt
            // 
            this.serverTxt.Location = new System.Drawing.Point(15, 161);
            this.serverTxt.Name = "serverTxt";
            this.serverTxt.Size = new System.Drawing.Size(161, 23);
            this.serverTxt.TabIndex = 5;
            // 
            // dbTxt
            // 
            this.dbTxt.Location = new System.Drawing.Point(15, 216);
            this.dbTxt.Name = "dbTxt";
            this.dbTxt.Size = new System.Drawing.Size(161, 23);
            this.dbTxt.TabIndex = 6;
            // 
            // userTxt
            // 
            this.userTxt.Location = new System.Drawing.Point(15, 267);
            this.userTxt.Name = "userTxt";
            this.userTxt.Size = new System.Drawing.Size(161, 23);
            this.userTxt.TabIndex = 7;
            // 
            // passTxt
            // 
            this.passTxt.Location = new System.Drawing.Point(12, 321);
            this.passTxt.Name = "passTxt";
            this.passTxt.Size = new System.Drawing.Size(164, 23);
            this.passTxt.TabIndex = 8;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 362);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(116, 19);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Integrited Security";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // saveBtn
            // 
            this.saveBtn.FlatAppearance.BorderSize = 2;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Location = new System.Drawing.Point(12, 401);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(164, 43);
            this.saveBtn.TabIndex = 10;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 496);
            this.Name = "settings";
            this.Text = "settings";
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Server;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox passTxt;
        private System.Windows.Forms.TextBox userTxt;
        private System.Windows.Forms.TextBox dbTxt;
        private System.Windows.Forms.TextBox serverTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}
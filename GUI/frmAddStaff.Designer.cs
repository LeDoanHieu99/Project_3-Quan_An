namespace GUI
{
    partial class frmAddStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddStaff));
            this.cboSex = new System.Windows.Forms.ComboBox();
            this.txtPosition = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtDate = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNameSraff = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddStaff = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboSex
            // 
            this.cboSex.FormattingEnabled = true;
            this.cboSex.Location = new System.Drawing.Point(197, 412);
            this.cboSex.Name = "cboSex";
            this.cboSex.Size = new System.Drawing.Size(102, 24);
            this.cboSex.TabIndex = 78;
            // 
            // txtPosition
            // 
            this.txtPosition.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPosition.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPosition.HintForeColor = System.Drawing.Color.Empty;
            this.txtPosition.HintText = "";
            this.txtPosition.isPassword = false;
            this.txtPosition.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtPosition.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPosition.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtPosition.LineThickness = 3;
            this.txtPosition.Location = new System.Drawing.Point(124, 355);
            this.txtPosition.Margin = new System.Windows.Forms.Padding(4);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(282, 33);
            this.txtPosition.TabIndex = 75;
            this.txtPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtDate
            // 
            this.txtDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDate.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDate.HintForeColor = System.Drawing.Color.Empty;
            this.txtDate.HintText = "";
            this.txtDate.isPassword = false;
            this.txtDate.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtDate.LineIdleColor = System.Drawing.Color.Gray;
            this.txtDate.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtDate.LineThickness = 3;
            this.txtDate.Location = new System.Drawing.Point(123, 272);
            this.txtDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(282, 33);
            this.txtDate.TabIndex = 76;
            this.txtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtNameSraff
            // 
            this.txtNameSraff.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNameSraff.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNameSraff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNameSraff.HintForeColor = System.Drawing.Color.Empty;
            this.txtNameSraff.HintText = "";
            this.txtNameSraff.isPassword = false;
            this.txtNameSraff.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtNameSraff.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNameSraff.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtNameSraff.LineThickness = 3;
            this.txtNameSraff.Location = new System.Drawing.Point(123, 189);
            this.txtNameSraff.Margin = new System.Windows.Forms.Padding(4);
            this.txtNameSraff.Name = "txtNameSraff";
            this.txtNameSraff.Size = new System.Drawing.Size(282, 33);
            this.txtNameSraff.TabIndex = 77;
            this.txtNameSraff.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(120, 412);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 23);
            this.label5.TabIndex = 71;
            this.label5.Text = "Sex:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(119, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 23);
            this.label6.TabIndex = 72;
            this.label6.Text = "Position:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 23);
            this.label1.TabIndex = 73;
            this.label1.Text = "Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(120, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 23);
            this.label3.TabIndex = 74;
            this.label3.Text = "Name:";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(128, 91);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(257, 30);
            this.bunifuCustomLabel1.TabIndex = 70;
            this.bunifuCustomLabel1.Text = "Thông Tin Nhân Viên";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(516, 25);
            this.panel1.TabIndex = 69;
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.ActiveBorderThickness = 1;
            this.btnAddStaff.ActiveCornerRadius = 20;
            this.btnAddStaff.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnAddStaff.ActiveForecolor = System.Drawing.Color.White;
            this.btnAddStaff.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnAddStaff.BackColor = System.Drawing.Color.White;
            this.btnAddStaff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddStaff.BackgroundImage")));
            this.btnAddStaff.ButtonText = "Add";
            this.btnAddStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddStaff.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStaff.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnAddStaff.IdleBorderThickness = 1;
            this.btnAddStaff.IdleCornerRadius = 20;
            this.btnAddStaff.IdleFillColor = System.Drawing.Color.White;
            this.btnAddStaff.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnAddStaff.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnAddStaff.Location = new System.Drawing.Point(169, 502);
            this.btnAddStaff.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(181, 58);
            this.btnAddStaff.TabIndex = 79;
            this.btnAddStaff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(493, 1);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(21, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // frmAddStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(516, 591);
            this.Controls.Add(this.btnAddStaff);
            this.Controls.Add(this.cboSex);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtNameSraff);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddStaff";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 btnAddStaff;
        private System.Windows.Forms.ComboBox cboSex;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPosition;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDate;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNameSraff;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
    }
}
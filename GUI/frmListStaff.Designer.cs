namespace GUI
{
    partial class frmListStaff
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListStaff));
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtStaffRole = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtStaffDate = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtStaffGender = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNameStaff = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtUserId = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearch = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtSearchStaff = new Bunifu.Framework.UI.BunifuTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dtgvStaff = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = global::GUI.Properties.Resources.trash;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(938, 268);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(189, 74);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtStaffRole
            // 
            this.txtStaffRole.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStaffRole.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtStaffRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtStaffRole.HintForeColor = System.Drawing.Color.Empty;
            this.txtStaffRole.HintText = "";
            this.txtStaffRole.isPassword = false;
            this.txtStaffRole.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtStaffRole.LineIdleColor = System.Drawing.Color.DodgerBlue;
            this.txtStaffRole.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtStaffRole.LineThickness = 3;
            this.txtStaffRole.Location = new System.Drawing.Point(573, 84);
            this.txtStaffRole.Margin = new System.Windows.Forms.Padding(4);
            this.txtStaffRole.Name = "txtStaffRole";
            this.txtStaffRole.Size = new System.Drawing.Size(225, 33);
            this.txtStaffRole.TabIndex = 2;
            this.txtStaffRole.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtStaffDate
            // 
            this.txtStaffDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStaffDate.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtStaffDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtStaffDate.HintForeColor = System.Drawing.Color.Empty;
            this.txtStaffDate.HintText = "";
            this.txtStaffDate.isPassword = false;
            this.txtStaffDate.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtStaffDate.LineIdleColor = System.Drawing.Color.DodgerBlue;
            this.txtStaffDate.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtStaffDate.LineThickness = 3;
            this.txtStaffDate.Location = new System.Drawing.Point(573, 17);
            this.txtStaffDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtStaffDate.Name = "txtStaffDate";
            this.txtStaffDate.Size = new System.Drawing.Size(225, 33);
            this.txtStaffDate.TabIndex = 2;
            this.txtStaffDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtStaffGender
            // 
            this.txtStaffGender.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStaffGender.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtStaffGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtStaffGender.HintForeColor = System.Drawing.Color.Empty;
            this.txtStaffGender.HintText = "";
            this.txtStaffGender.isPassword = false;
            this.txtStaffGender.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtStaffGender.LineIdleColor = System.Drawing.Color.DodgerBlue;
            this.txtStaffGender.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtStaffGender.LineThickness = 3;
            this.txtStaffGender.Location = new System.Drawing.Point(176, 156);
            this.txtStaffGender.Margin = new System.Windows.Forms.Padding(4);
            this.txtStaffGender.Name = "txtStaffGender";
            this.txtStaffGender.Size = new System.Drawing.Size(238, 33);
            this.txtStaffGender.TabIndex = 1;
            this.txtStaffGender.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtNameStaff
            // 
            this.txtNameStaff.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNameStaff.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNameStaff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNameStaff.HintForeColor = System.Drawing.Color.Empty;
            this.txtNameStaff.HintText = "";
            this.txtNameStaff.isPassword = false;
            this.txtNameStaff.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtNameStaff.LineIdleColor = System.Drawing.Color.DodgerBlue;
            this.txtNameStaff.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtNameStaff.LineThickness = 3;
            this.txtNameStaff.Location = new System.Drawing.Point(176, 84);
            this.txtNameStaff.Margin = new System.Windows.Forms.Padding(4);
            this.txtNameStaff.Name = "txtNameStaff";
            this.txtNameStaff.Size = new System.Drawing.Size(238, 33);
            this.txtNameStaff.TabIndex = 1;
            this.txtNameStaff.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtUserId
            // 
            this.txtUserId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserId.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtUserId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUserId.HintForeColor = System.Drawing.Color.Empty;
            this.txtUserId.HintText = "";
            this.txtUserId.isPassword = false;
            this.txtUserId.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtUserId.LineIdleColor = System.Drawing.Color.DodgerBlue;
            this.txtUserId.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtUserId.LineThickness = 3;
            this.txtUserId.Location = new System.Drawing.Point(176, 17);
            this.txtUserId.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(238, 33);
            this.txtUserId.TabIndex = 1;
            this.txtUserId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 105);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.ActiveBorderThickness = 1;
            this.btnSearch.ActiveCornerRadius = 20;
            this.btnSearch.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnSearch.ActiveForecolor = System.Drawing.Color.White;
            this.btnSearch.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.ButtonText = "Search";
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSearch.IdleBorderThickness = 1;
            this.btnSearch.IdleCornerRadius = 20;
            this.btnSearch.IdleFillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSearch.IdleForecolor = System.Drawing.Color.White;
            this.btnSearch.IdleLineColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(477, 18);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(181, 58);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchStaff
            // 
            this.txtSearchStaff.BackColor = System.Drawing.Color.White;
            this.txtSearchStaff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSearchStaff.BackgroundImage")));
            this.txtSearchStaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtSearchStaff.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.txtSearchStaff.Icon = ((System.Drawing.Image)(resources.GetObject("txtSearchStaff.Icon")));
            this.txtSearchStaff.Location = new System.Drawing.Point(36, 33);
            this.txtSearchStaff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearchStaff.Name = "txtSearchStaff";
            this.txtSearchStaff.Size = new System.Drawing.Size(416, 39);
            this.txtSearchStaff.TabIndex = 13;
            this.txtSearchStaff.text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 92);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(106, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Full Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 167);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(83, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Gender:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(468, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Birthday:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(468, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Role:";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Image = global::GUI.Properties.Resources.editing;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(938, 189);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(189, 74);
            this.btnEdit.TabIndex = 18;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(213)))), ((int)(((byte)(242)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtStaffRole);
            this.panel1.Controls.Add(this.txtStaffDate);
            this.panel1.Controls.Add(this.txtStaffGender);
            this.panel1.Controls.Add(this.txtNameStaff);
            this.panel1.Controls.Add(this.txtUserId);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(36, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(877, 232);
            this.panel1.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "User ID:";
            // 
            // dtgvStaff
            // 
            this.dtgvStaff.AllowUserToAddRows = false;
            this.dtgvStaff.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgvStaff.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgvStaff.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvStaff.Location = new System.Drawing.Point(36, 372);
            this.dtgvStaff.Name = "dtgvStaff";
            this.dtgvStaff.RowTemplate.Height = 24;
            this.dtgvStaff.Size = new System.Drawing.Size(1091, 438);
            this.dtgvStaff.TabIndex = 16;
            this.dtgvStaff.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgvStaff_CellMouseClick);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = global::GUI.Properties.Resources.add_user;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(938, 112);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(189, 74);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmListStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchStaff);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgvStaff);
            this.Name = "frmListStaff";
            this.Size = new System.Drawing.Size(1155, 825);
            this.Load += new System.EventHandler(this.frmListStaff_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStaff)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtStaffRole;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtStaffDate;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtStaffGender;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNameStaff;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUserId;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSearch;
        private Bunifu.Framework.UI.BunifuTextbox txtSearchStaff;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtgvStaff;
        private System.Windows.Forms.Button btnAdd;
    }
}

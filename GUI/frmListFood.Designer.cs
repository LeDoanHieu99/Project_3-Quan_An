namespace GUI
{
    partial class frmListFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListFood));
            this.dtgvFood = new System.Windows.Forms.DataGridView();
            this.cboSelect = new System.Windows.Forms.ComboBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPrice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtFoodName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtFoodTypeName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtFoodTypeID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtFoodId = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchFood = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txt_SearchFood = new Bunifu.Framework.UI.BunifuTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFood)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvFood
            // 
            this.dtgvFood.AllowUserToAddRows = false;
            this.dtgvFood.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgvFood.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgvFood.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvFood.Location = new System.Drawing.Point(36, 405);
            this.dtgvFood.Name = "dtgvFood";
            this.dtgvFood.ReadOnly = true;
            this.dtgvFood.RowHeadersVisible = false;
            this.dtgvFood.RowHeadersWidth = 62;
            this.dtgvFood.RowTemplate.Height = 24;
            this.dtgvFood.Size = new System.Drawing.Size(1091, 397);
            this.dtgvFood.TabIndex = 13;
            this.dtgvFood.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgvFood_CellMouseClick);
            // 
            // cboSelect
            // 
            this.cboSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelect.FormattingEnabled = true;
            this.cboSelect.Items.AddRange(new object[] {
            "Category",
            "Food"});
            this.cboSelect.Location = new System.Drawing.Point(36, 365);
            this.cboSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboSelect.Name = "cboSelect";
            this.cboSelect.Size = new System.Drawing.Size(185, 24);
            this.cboSelect.TabIndex = 12;
            this.cboSelect.SelectedIndexChanged += new System.EventHandler(this.cboSelect_SelectedIndexChanged);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Image = global::GUI.Properties.Resources.trash;
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.Location = new System.Drawing.Point(933, 271);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(194, 74);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Image = global::GUI.Properties.Resources.editing;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(933, 193);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(194, 74);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = global::GUI.Properties.Resources.add_user;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(933, 113);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(194, 74);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(213)))), ((int)(((byte)(242)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.txtFoodName);
            this.panel1.Controls.Add(this.txtFoodTypeName);
            this.panel1.Controls.Add(this.txtFoodTypeID);
            this.panel1.Controls.Add(this.txtFoodId);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(36, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(879, 242);
            this.panel1.TabIndex = 8;
            // 
            // txtPrice
            // 
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrice.HintForeColor = System.Drawing.Color.Empty;
            this.txtPrice.HintText = "";
            this.txtPrice.isPassword = false;
            this.txtPrice.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtPrice.LineIdleColor = System.Drawing.Color.DodgerBlue;
            this.txtPrice.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtPrice.LineThickness = 3;
            this.txtPrice.Location = new System.Drawing.Point(625, 84);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(225, 33);
            this.txtPrice.TabIndex = 2;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtFoodName
            // 
            this.txtFoodName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFoodName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtFoodName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFoodName.HintForeColor = System.Drawing.Color.Empty;
            this.txtFoodName.HintText = "";
            this.txtFoodName.isPassword = false;
            this.txtFoodName.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtFoodName.LineIdleColor = System.Drawing.Color.DodgerBlue;
            this.txtFoodName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtFoodName.LineThickness = 3;
            this.txtFoodName.Location = new System.Drawing.Point(625, 17);
            this.txtFoodName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(225, 33);
            this.txtFoodName.TabIndex = 2;
            this.txtFoodName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtFoodTypeName
            // 
            this.txtFoodTypeName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFoodTypeName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtFoodTypeName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFoodTypeName.HintForeColor = System.Drawing.Color.Empty;
            this.txtFoodTypeName.HintText = "";
            this.txtFoodTypeName.isPassword = false;
            this.txtFoodTypeName.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtFoodTypeName.LineIdleColor = System.Drawing.Color.DodgerBlue;
            this.txtFoodTypeName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtFoodTypeName.LineThickness = 3;
            this.txtFoodTypeName.Location = new System.Drawing.Point(225, 159);
            this.txtFoodTypeName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFoodTypeName.Name = "txtFoodTypeName";
            this.txtFoodTypeName.Size = new System.Drawing.Size(238, 33);
            this.txtFoodTypeName.TabIndex = 1;
            this.txtFoodTypeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtFoodTypeID
            // 
            this.txtFoodTypeID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFoodTypeID.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtFoodTypeID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFoodTypeID.HintForeColor = System.Drawing.Color.Empty;
            this.txtFoodTypeID.HintText = "";
            this.txtFoodTypeID.isPassword = false;
            this.txtFoodTypeID.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtFoodTypeID.LineIdleColor = System.Drawing.Color.DodgerBlue;
            this.txtFoodTypeID.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtFoodTypeID.LineThickness = 3;
            this.txtFoodTypeID.Location = new System.Drawing.Point(225, 84);
            this.txtFoodTypeID.Margin = new System.Windows.Forms.Padding(4);
            this.txtFoodTypeID.Name = "txtFoodTypeID";
            this.txtFoodTypeID.Size = new System.Drawing.Size(238, 33);
            this.txtFoodTypeID.TabIndex = 1;
            this.txtFoodTypeID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtFoodId
            // 
            this.txtFoodId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFoodId.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtFoodId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFoodId.HintForeColor = System.Drawing.Color.Empty;
            this.txtFoodId.HintText = "";
            this.txtFoodId.isPassword = false;
            this.txtFoodId.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtFoodId.LineIdleColor = System.Drawing.Color.DodgerBlue;
            this.txtFoodId.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtFoodId.LineThickness = 3;
            this.txtFoodId.Location = new System.Drawing.Point(225, 17);
            this.txtFoodId.Margin = new System.Windows.Forms.Padding(4);
            this.txtFoodId.Name = "txtFoodId";
            this.txtFoodId.Size = new System.Drawing.Size(238, 33);
            this.txtFoodId.TabIndex = 1;
            this.txtFoodId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 92);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(137, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Food Type ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 167);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(170, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Food Type Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Food ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(500, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Food Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(500, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Price:";
            // 
            // btnSearchFood
            // 
            this.btnSearchFood.ActiveBorderThickness = 1;
            this.btnSearchFood.ActiveCornerRadius = 20;
            this.btnSearchFood.ActiveFillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSearchFood.ActiveForecolor = System.Drawing.Color.White;
            this.btnSearchFood.ActiveLineColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSearchFood.BackColor = System.Drawing.Color.White;
            this.btnSearchFood.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearchFood.BackgroundImage")));
            this.btnSearchFood.ButtonText = "Search";
            this.btnSearchFood.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchFood.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchFood.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSearchFood.IdleBorderThickness = 1;
            this.btnSearchFood.IdleCornerRadius = 20;
            this.btnSearchFood.IdleFillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSearchFood.IdleForecolor = System.Drawing.Color.White;
            this.btnSearchFood.IdleLineColor = System.Drawing.Color.White;
            this.btnSearchFood.Location = new System.Drawing.Point(478, 23);
            this.btnSearchFood.Margin = new System.Windows.Forms.Padding(5);
            this.btnSearchFood.Name = "btnSearchFood";
            this.btnSearchFood.Size = new System.Drawing.Size(122, 54);
            this.btnSearchFood.TabIndex = 14;
            this.btnSearchFood.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearchFood.Click += new System.EventHandler(this.bunifuThinButton21_search_Click);
            // 
            // txt_SearchFood
            // 
            this.txt_SearchFood.BackColor = System.Drawing.Color.White;
            this.txt_SearchFood.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_SearchFood.BackgroundImage")));
            this.txt_SearchFood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txt_SearchFood.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.txt_SearchFood.Icon = ((System.Drawing.Image)(resources.GetObject("txt_SearchFood.Icon")));
            this.txt_SearchFood.Location = new System.Drawing.Point(36, 30);
            this.txt_SearchFood.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_SearchFood.Name = "txt_SearchFood";
            this.txt_SearchFood.Size = new System.Drawing.Size(416, 39);
            this.txt_SearchFood.TabIndex = 15;
            this.txt_SearchFood.text = "";
            // 
            // frmListFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txt_SearchFood);
            this.Controls.Add(this.btnSearchFood);
            this.Controls.Add(this.dtgvFood);
            this.Controls.Add(this.cboSelect);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panel1);
            this.Name = "frmListFood";
            this.Size = new System.Drawing.Size(1155, 825);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFood)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvFood;
        private System.Windows.Forms.ComboBox cboSelect;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPrice;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtFoodName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtFoodTypeName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtFoodTypeID;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtFoodId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSearchFood;
        private Bunifu.Framework.UI.BunifuTextbox txt_SearchFood;
    }
}

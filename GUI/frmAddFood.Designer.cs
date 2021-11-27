namespace GUI
{
    partial class frmAddFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddFood));
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.txtFoodPrice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtFoodName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddFood = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboCategory
            // 
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(72, 305);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(379, 24);
            this.cboCategory.TabIndex = 24;
            // 
            // txtFoodPrice
            // 
            this.txtFoodPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFoodPrice.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtFoodPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFoodPrice.HintForeColor = System.Drawing.Color.Empty;
            this.txtFoodPrice.HintText = "";
            this.txtFoodPrice.isPassword = false;
            this.txtFoodPrice.LineFocusedColor = System.Drawing.Color.DeepSkyBlue;
            this.txtFoodPrice.LineIdleColor = System.Drawing.Color.DeepSkyBlue;
            this.txtFoodPrice.LineMouseHoverColor = System.Drawing.Color.DeepSkyBlue;
            this.txtFoodPrice.LineThickness = 3;
            this.txtFoodPrice.Location = new System.Drawing.Point(72, 393);
            this.txtFoodPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtFoodPrice.Name = "txtFoodPrice";
            this.txtFoodPrice.Size = new System.Drawing.Size(379, 33);
            this.txtFoodPrice.TabIndex = 22;
            this.txtFoodPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtFoodName
            // 
            this.txtFoodName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFoodName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtFoodName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFoodName.HintForeColor = System.Drawing.Color.Empty;
            this.txtFoodName.HintText = "";
            this.txtFoodName.isPassword = false;
            this.txtFoodName.LineFocusedColor = System.Drawing.Color.DeepSkyBlue;
            this.txtFoodName.LineIdleColor = System.Drawing.Color.DeepSkyBlue;
            this.txtFoodName.LineMouseHoverColor = System.Drawing.Color.DeepSkyBlue;
            this.txtFoodName.LineThickness = 3;
            this.txtFoodName.Location = new System.Drawing.Point(72, 196);
            this.txtFoodName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(379, 33);
            this.txtFoodName.TabIndex = 23;
            this.txtFoodName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 23);
            this.label3.TabIndex = 19;
            this.label3.Text = "Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "Categories:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 23);
            this.label1.TabIndex = 21;
            this.label1.Text = "Name:";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(142, 72);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(233, 30);
            this.bunifuCustomLabel1.TabIndex = 18;
            this.bunifuCustomLabel1.Text = "Food-Informantion";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(516, 25);
            this.panel1.TabIndex = 17;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(494, 1);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(21, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // btnAddFood
            // 
            this.btnAddFood.ActiveBorderThickness = 1;
            this.btnAddFood.ActiveCornerRadius = 20;
            this.btnAddFood.ActiveFillColor = System.Drawing.Color.SkyBlue;
            this.btnAddFood.ActiveForecolor = System.Drawing.Color.White;
            this.btnAddFood.ActiveLineColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAddFood.BackColor = System.Drawing.Color.White;
            this.btnAddFood.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddFood.BackgroundImage")));
            this.btnAddFood.ButtonText = "Add";
            this.btnAddFood.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddFood.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFood.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnAddFood.IdleBorderThickness = 1;
            this.btnAddFood.IdleCornerRadius = 20;
            this.btnAddFood.IdleFillColor = System.Drawing.Color.White;
            this.btnAddFood.IdleForecolor = System.Drawing.Color.DeepSkyBlue;
            this.btnAddFood.IdleLineColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAddFood.Location = new System.Drawing.Point(168, 479);
            this.btnAddFood.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(181, 62);
            this.btnAddFood.TabIndex = 27;
            this.btnAddFood.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmAddFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(516, 591);
            this.Controls.Add(this.btnAddFood);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.txtFoodPrice);
            this.Controls.Add(this.txtFoodName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddFood";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCategory;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtFoodPrice;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtFoodName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAddFood;
    }
}
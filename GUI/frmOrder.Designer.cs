﻿namespace GUI
{
    partial class frmOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrder));
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.cboFood = new System.Windows.Forms.ComboBox();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.txtOrderPrice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNameSraff = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddOrder = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(244, 430);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(72, 22);
            this.numericUpDown1.TabIndex = 93;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cboFood
            // 
            this.cboFood.FormattingEnabled = true;
            this.cboFood.Location = new System.Drawing.Point(120, 295);
            this.cboFood.Name = "cboFood";
            this.cboFood.Size = new System.Drawing.Size(282, 24);
            this.cboFood.TabIndex = 91;
            // 
            // cboCategory
            // 
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(121, 215);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(282, 24);
            this.cboCategory.TabIndex = 92;
            // 
            // txtOrderPrice
            // 
            this.txtOrderPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOrderPrice.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtOrderPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtOrderPrice.HintForeColor = System.Drawing.Color.Empty;
            this.txtOrderPrice.HintText = "";
            this.txtOrderPrice.isPassword = false;
            this.txtOrderPrice.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtOrderPrice.LineIdleColor = System.Drawing.Color.Gray;
            this.txtOrderPrice.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtOrderPrice.LineThickness = 3;
            this.txtOrderPrice.Location = new System.Drawing.Point(122, 362);
            this.txtOrderPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtOrderPrice.Name = "txtOrderPrice";
            this.txtOrderPrice.Size = new System.Drawing.Size(282, 33);
            this.txtOrderPrice.TabIndex = 88;
            this.txtOrderPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.txtNameSraff.Location = new System.Drawing.Point(122, 130);
            this.txtNameSraff.Margin = new System.Windows.Forms.Padding(4);
            this.txtNameSraff.Name = "txtNameSraff";
            this.txtNameSraff.Size = new System.Drawing.Size(282, 33);
            this.txtNameSraff.TabIndex = 89;
            this.txtNameSraff.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(116, 426);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 23);
            this.label5.TabIndex = 83;
            this.label5.Text = "Quantity:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(117, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 23);
            this.label6.TabIndex = 84;
            this.label6.Text = "Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 23);
            this.label2.TabIndex = 85;
            this.label2.Text = "Food:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 23);
            this.label1.TabIndex = 86;
            this.label1.Text = "Categories:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(118, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 23);
            this.label3.TabIndex = 87;
            this.label3.Text = "Table:";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(209, 58);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(87, 30);
            this.bunifuCustomLabel1.TabIndex = 82;
            this.bunifuCustomLabel1.Text = "Order ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(516, 25);
            this.panel1.TabIndex = 81;
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.ActiveBorderThickness = 1;
            this.btnAddOrder.ActiveCornerRadius = 20;
            this.btnAddOrder.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnAddOrder.ActiveForecolor = System.Drawing.Color.White;
            this.btnAddOrder.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnAddOrder.BackColor = System.Drawing.Color.White;
            this.btnAddOrder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddOrder.BackgroundImage")));
            this.btnAddOrder.ButtonText = "Add";
            this.btnAddOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddOrder.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOrder.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnAddOrder.IdleBorderThickness = 1;
            this.btnAddOrder.IdleCornerRadius = 20;
            this.btnAddOrder.IdleFillColor = System.Drawing.Color.White;
            this.btnAddOrder.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnAddOrder.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnAddOrder.Location = new System.Drawing.Point(166, 511);
            this.btnAddOrder.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(181, 58);
            this.btnAddOrder.TabIndex = 90;
            this.btnAddOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(516, 591);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.cboFood);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.txtOrderPrice);
            this.Controls.Add(this.txtNameSraff);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOrder";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox cboFood;
        private System.Windows.Forms.ComboBox cboCategory;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAddOrder;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtOrderPrice;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNameSraff;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
    }
}
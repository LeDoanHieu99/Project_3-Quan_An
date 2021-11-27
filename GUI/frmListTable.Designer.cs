﻿namespace GUI
{
    partial class frmListTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListTable));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtTotal = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cbbMergeTable = new System.Windows.Forms.ComboBox();
            this.btnMergeTable = new System.Windows.Forms.Button();
            this.cbbSwichTable = new System.Windows.Forms.ComboBox();
            this.btnSwichTable = new System.Windows.Forms.Button();
            this.dtgvFoodbyId = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnNewTable = new System.Windows.Forms.Button();
            this.btnPayMonney = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFoodbyId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.cbbMergeTable);
            this.panel1.Controls.Add(this.btnMergeTable);
            this.panel1.Controls.Add(this.cbbSwichTable);
            this.panel1.Controls.Add(this.btnSwichTable);
            this.panel1.Location = new System.Drawing.Point(501, 570);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 98);
            this.panel1.TabIndex = 43;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.txtTongTien);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(355, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(244, 80);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Total";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(16, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(58, 23);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(4);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(150, 26);
            this.txtTongTien.TabIndex = 3;
            // 
            // txtTotal
            // 
            this.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotal.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTotal.HintForeColor = System.Drawing.Color.Empty;
            this.txtTotal.HintText = "";
            this.txtTotal.isPassword = false;
            this.txtTotal.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtTotal.LineIdleColor = System.Drawing.Color.Gray;
            this.txtTotal.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.txtTotal.LineThickness = 3;
            this.txtTotal.Location = new System.Drawing.Point(84, 33);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(124, 33);
            this.txtTotal.TabIndex = 37;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cbbMergeTable
            // 
            this.cbbMergeTable.FormattingEnabled = true;
            this.cbbMergeTable.Location = new System.Drawing.Point(29, 59);
            this.cbbMergeTable.Margin = new System.Windows.Forms.Padding(4);
            this.cbbMergeTable.Name = "cbbMergeTable";
            this.cbbMergeTable.Size = new System.Drawing.Size(153, 24);
            this.cbbMergeTable.TabIndex = 33;
            // 
            // btnMergeTable
            // 
            this.btnMergeTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(213)))), ((int)(((byte)(242)))));
            this.btnMergeTable.FlatAppearance.BorderSize = 0;
            this.btnMergeTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMergeTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMergeTable.Image = ((System.Drawing.Image)(resources.GetObject("btnMergeTable.Image")));
            this.btnMergeTable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMergeTable.Location = new System.Drawing.Point(190, 50);
            this.btnMergeTable.Margin = new System.Windows.Forms.Padding(4);
            this.btnMergeTable.Name = "btnMergeTable";
            this.btnMergeTable.Size = new System.Drawing.Size(131, 36);
            this.btnMergeTable.TabIndex = 32;
            this.btnMergeTable.Text = "  Merge";
            this.btnMergeTable.UseVisualStyleBackColor = false;
            // 
            // cbbSwichTable
            // 
            this.cbbSwichTable.FormattingEnabled = true;
            this.cbbSwichTable.Location = new System.Drawing.Point(29, 16);
            this.cbbSwichTable.Margin = new System.Windows.Forms.Padding(4);
            this.cbbSwichTable.Name = "cbbSwichTable";
            this.cbbSwichTable.Size = new System.Drawing.Size(153, 24);
            this.cbbSwichTable.TabIndex = 31;
            // 
            // btnSwichTable
            // 
            this.btnSwichTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSwichTable.FlatAppearance.BorderSize = 0;
            this.btnSwichTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSwichTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwichTable.Image = ((System.Drawing.Image)(resources.GetObject("btnSwichTable.Image")));
            this.btnSwichTable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSwichTable.Location = new System.Drawing.Point(190, 6);
            this.btnSwichTable.Margin = new System.Windows.Forms.Padding(4);
            this.btnSwichTable.Name = "btnSwichTable";
            this.btnSwichTable.Size = new System.Drawing.Size(131, 36);
            this.btnSwichTable.TabIndex = 30;
            this.btnSwichTable.Text = "     Transfer";
            this.btnSwichTable.UseVisualStyleBackColor = false;
            // 
            // dtgvFoodbyId
            // 
            this.dtgvFoodbyId.AllowUserToAddRows = false;
            this.dtgvFoodbyId.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvFoodbyId.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvFoodbyId.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvFoodbyId.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvFoodbyId.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvFoodbyId.Location = new System.Drawing.Point(502, 8);
            this.dtgvFoodbyId.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvFoodbyId.Name = "dtgvFoodbyId";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvFoodbyId.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvFoodbyId.RowHeadersVisible = false;
            this.dtgvFoodbyId.RowHeadersWidth = 62;
            this.dtgvFoodbyId.Size = new System.Drawing.Size(588, 554);
            this.dtgvFoodbyId.TabIndex = 39;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(213)))), ((int)(((byte)(242)))));
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(21, 9);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(457, 553);
            this.flowLayoutPanel1.TabIndex = 38;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 321);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // btnNewTable
            // 
            this.btnNewTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnNewTable.FlatAppearance.BorderSize = 0;
            this.btnNewTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewTable.ForeColor = System.Drawing.Color.Black;
            this.btnNewTable.Image = ((System.Drawing.Image)(resources.GetObject("btnNewTable.Image")));
            this.btnNewTable.Location = new System.Drawing.Point(21, 570);
            this.btnNewTable.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewTable.Name = "btnNewTable";
            this.btnNewTable.Size = new System.Drawing.Size(145, 95);
            this.btnNewTable.TabIndex = 42;
            this.btnNewTable.Text = "New Table";
            this.btnNewTable.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNewTable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNewTable.UseVisualStyleBackColor = false;
            // 
            // btnPayMonney
            // 
            this.btnPayMonney.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnPayMonney.FlatAppearance.BorderSize = 0;
            this.btnPayMonney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayMonney.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayMonney.Image = ((System.Drawing.Image)(resources.GetObject("btnPayMonney.Image")));
            this.btnPayMonney.Location = new System.Drawing.Point(326, 570);
            this.btnPayMonney.Margin = new System.Windows.Forms.Padding(4);
            this.btnPayMonney.Name = "btnPayMonney";
            this.btnPayMonney.Size = new System.Drawing.Size(152, 95);
            this.btnPayMonney.TabIndex = 41;
            this.btnPayMonney.Text = "Payment";
            this.btnPayMonney.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPayMonney.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPayMonney.UseVisualStyleBackColor = false;
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnOrder.Image")));
            this.btnOrder.Location = new System.Drawing.Point(169, 570);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(154, 95);
            this.btnOrder.TabIndex = 40;
            this.btnOrder.Text = "Order";
            this.btnOrder.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnOrder.UseVisualStyleBackColor = false;
            // 
            // frmListTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgvFoodbyId);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnNewTable);
            this.Controls.Add(this.btnPayMonney);
            this.Controls.Add(this.btnOrder);
            this.Name = "frmListTable";
            this.Size = new System.Drawing.Size(1096, 676);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFoodbyId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtTongTien;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTotal;
        private System.Windows.Forms.ComboBox cbbMergeTable;
        private System.Windows.Forms.Button btnMergeTable;
        private System.Windows.Forms.ComboBox cbbSwichTable;
        private System.Windows.Forms.Button btnSwichTable;
        private System.Windows.Forms.DataGridView dtgvFoodbyId;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnNewTable;
        private System.Windows.Forms.Button btnPayMonney;
        private System.Windows.Forms.Button btnOrder;
    }
}
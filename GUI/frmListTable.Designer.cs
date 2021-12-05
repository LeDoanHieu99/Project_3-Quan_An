namespace GUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtTotal = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cbbMergeTable = new System.Windows.Forms.ComboBox();
            this.btnMergeTable = new System.Windows.Forms.Button();
            this.cbbSwichTable = new System.Windows.Forms.ComboBox();
            this.btnSwichTable = new System.Windows.Forms.Button();
            this.dtgvFoodbyId = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNewTable = new System.Windows.Forms.Button();
            this.btnPayMonney = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFoodbyId)).BeginInit();
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
            this.panel1.Location = new System.Drawing.Point(534, 669);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 130);
            this.panel1.TabIndex = 43;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(355, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(226, 110);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Total";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(16, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 56);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
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
            this.txtTotal.Location = new System.Drawing.Point(77, 50);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(138, 33);
            this.txtTotal.TabIndex = 37;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cbbMergeTable
            // 
            this.cbbMergeTable.FormattingEnabled = true;
            this.cbbMergeTable.Location = new System.Drawing.Point(22, 83);
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
            this.btnMergeTable.Location = new System.Drawing.Point(194, 71);
            this.btnMergeTable.Margin = new System.Windows.Forms.Padding(4);
            this.btnMergeTable.Name = "btnMergeTable";
            this.btnMergeTable.Size = new System.Drawing.Size(138, 40);
            this.btnMergeTable.TabIndex = 32;
            this.btnMergeTable.Text = "  Merge";
            this.btnMergeTable.UseVisualStyleBackColor = false;
            this.btnMergeTable.Click += new System.EventHandler(this.btnMergeTable_Click);
            // 
            // cbbSwichTable
            // 
            this.cbbSwichTable.FormattingEnabled = true;
            this.cbbSwichTable.Location = new System.Drawing.Point(22, 30);
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
            this.btnSwichTable.Location = new System.Drawing.Point(194, 18);
            this.btnSwichTable.Margin = new System.Windows.Forms.Padding(4);
            this.btnSwichTable.Name = "btnSwichTable";
            this.btnSwichTable.Size = new System.Drawing.Size(138, 40);
            this.btnSwichTable.TabIndex = 30;
            this.btnSwichTable.Text = "     Transfer";
            this.btnSwichTable.UseVisualStyleBackColor = false;
            this.btnSwichTable.Click += new System.EventHandler(this.btnSwichTable_Click);
            // 
            // dtgvFoodbyId
            // 
            this.dtgvFoodbyId.AllowUserToAddRows = false;
            this.dtgvFoodbyId.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvFoodbyId.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvFoodbyId.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvFoodbyId.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvFoodbyId.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtgvFoodbyId.Location = new System.Drawing.Point(534, 25);
            this.dtgvFoodbyId.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvFoodbyId.Name = "dtgvFoodbyId";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvFoodbyId.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgvFoodbyId.RowHeadersVisible = false;
            this.dtgvFoodbyId.RowHeadersWidth = 62;
            this.dtgvFoodbyId.Size = new System.Drawing.Size(599, 622);
            this.dtgvFoodbyId.TabIndex = 39;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(213)))), ((int)(((byte)(242)))));
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(17, 26);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(500, 621);
            this.flowLayoutPanel1.TabIndex = 38;
            // 
            // btnNewTable
            // 
            this.btnNewTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnNewTable.FlatAppearance.BorderSize = 0;
            this.btnNewTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewTable.ForeColor = System.Drawing.Color.Black;
            this.btnNewTable.Image = ((System.Drawing.Image)(resources.GetObject("btnNewTable.Image")));
            this.btnNewTable.Location = new System.Drawing.Point(17, 669);
            this.btnNewTable.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewTable.Name = "btnNewTable";
            this.btnNewTable.Size = new System.Drawing.Size(163, 130);
            this.btnNewTable.TabIndex = 42;
            this.btnNewTable.Text = "New Table";
            this.btnNewTable.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNewTable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNewTable.UseVisualStyleBackColor = false;
            this.btnNewTable.Click += new System.EventHandler(this.btnNewTable_Click);
            // 
            // btnPayMonney
            // 
            this.btnPayMonney.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnPayMonney.FlatAppearance.BorderSize = 0;
            this.btnPayMonney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayMonney.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayMonney.Image = ((System.Drawing.Image)(resources.GetObject("btnPayMonney.Image")));
            this.btnPayMonney.Location = new System.Drawing.Point(354, 669);
            this.btnPayMonney.Margin = new System.Windows.Forms.Padding(4);
            this.btnPayMonney.Name = "btnPayMonney";
            this.btnPayMonney.Size = new System.Drawing.Size(163, 130);
            this.btnPayMonney.TabIndex = 41;
            this.btnPayMonney.Text = "Payment";
            this.btnPayMonney.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPayMonney.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPayMonney.UseVisualStyleBackColor = false;
            this.btnPayMonney.Click += new System.EventHandler(this.btnPayMonney_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnOrder.Image")));
            this.btnOrder.Location = new System.Drawing.Point(188, 669);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(163, 130);
            this.btnOrder.TabIndex = 40;
            this.btnOrder.Text = "Order";
            this.btnOrder.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // frmListTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgvFoodbyId);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnNewTable);
            this.Controls.Add(this.btnPayMonney);
            this.Controls.Add(this.btnOrder);
            this.Name = "frmListTable";
            this.Size = new System.Drawing.Size(1155, 825);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFoodbyId)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTotal;
        private System.Windows.Forms.ComboBox cbbMergeTable;
        private System.Windows.Forms.Button btnMergeTable;
        private System.Windows.Forms.ComboBox cbbSwichTable;
        private System.Windows.Forms.Button btnSwichTable;
        private System.Windows.Forms.DataGridView dtgvFoodbyId;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnNewTable;
        private System.Windows.Forms.Button btnPayMonney;
        private System.Windows.Forms.Button btnOrder;
    }
}

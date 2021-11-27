namespace GUI
{
    partial class frmListBill
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtTotal = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtStatus = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBillId = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtTableId = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvBillDetail = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.Panel();
            this.dtgvBill = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.datetimeGetDay = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBillDetail)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTotal
            // 
            this.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTotal.HintForeColor = System.Drawing.Color.Empty;
            this.txtTotal.HintText = "";
            this.txtTotal.isPassword = false;
            this.txtTotal.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtTotal.LineIdleColor = System.Drawing.Color.Gray;
            this.txtTotal.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtTotal.LineThickness = 3;
            this.txtTotal.Location = new System.Drawing.Point(726, 624);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(340, 31);
            this.txtTotal.TabIndex = 20;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtStatus
            // 
            this.txtStatus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtStatus.HintForeColor = System.Drawing.Color.Empty;
            this.txtStatus.HintText = "";
            this.txtStatus.isPassword = false;
            this.txtStatus.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtStatus.LineIdleColor = System.Drawing.Color.Gray;
            this.txtStatus.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtStatus.LineThickness = 3;
            this.txtStatus.Location = new System.Drawing.Point(726, 576);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(4);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(340, 31);
            this.txtStatus.TabIndex = 21;
            this.txtStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(644, 631);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 24);
            this.label7.TabIndex = 18;
            this.label7.Text = "Total:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(644, 583);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 24);
            this.label6.TabIndex = 19;
            this.label6.Text = "Status:";
            // 
            // txtBillId
            // 
            this.txtBillId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBillId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBillId.HintForeColor = System.Drawing.Color.Empty;
            this.txtBillId.HintText = "";
            this.txtBillId.isPassword = false;
            this.txtBillId.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtBillId.LineIdleColor = System.Drawing.Color.Gray;
            this.txtBillId.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtBillId.LineThickness = 3;
            this.txtBillId.Location = new System.Drawing.Point(138, 624);
            this.txtBillId.Margin = new System.Windows.Forms.Padding(4);
            this.txtBillId.Name = "txtBillId";
            this.txtBillId.Size = new System.Drawing.Size(340, 31);
            this.txtBillId.TabIndex = 16;
            this.txtBillId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtTableId
            // 
            this.txtTableId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTableId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTableId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTableId.HintForeColor = System.Drawing.Color.Empty;
            this.txtTableId.HintText = "";
            this.txtTableId.isPassword = false;
            this.txtTableId.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtTableId.LineIdleColor = System.Drawing.Color.Gray;
            this.txtTableId.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtTableId.LineThickness = 3;
            this.txtTableId.Location = new System.Drawing.Point(138, 576);
            this.txtTableId.Margin = new System.Windows.Forms.Padding(4);
            this.txtTableId.Name = "txtTableId";
            this.txtTableId.Size = new System.Drawing.Size(340, 31);
            this.txtTableId.TabIndex = 17;
            this.txtTableId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 2;
            this.bunifuSeparator2.Location = new System.Drawing.Point(576, 558);
            this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(61, 116);
            this.bunifuSeparator2.TabIndex = 14;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 631);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Bill ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 583);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Table ID:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvBillDetail);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(612, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 542);
            this.panel1.TabIndex = 10;
            // 
            // dtgvBillDetail
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgvBillDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvBillDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvBillDetail.BackgroundColor = System.Drawing.Color.Silver;
            this.dtgvBillDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvBillDetail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvBillDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvBillDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBillDetail.DoubleBuffered = true;
            this.dtgvBillDetail.EnableHeadersVisualStyles = false;
            this.dtgvBillDetail.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dtgvBillDetail.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dtgvBillDetail.Location = new System.Drawing.Point(5, 37);
            this.dtgvBillDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvBillDetail.Name = "dtgvBillDetail";
            this.dtgvBillDetail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvBillDetail.RowHeadersVisible = false;
            this.dtgvBillDetail.RowHeadersWidth = 62;
            this.dtgvBillDetail.RowTemplate.Height = 24;
            this.dtgvBillDetail.Size = new System.Drawing.Size(471, 500);
            this.dtgvBillDetail.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(195, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Bill Details";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgvBill);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.datetimeGetDay);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(604, 542);
            this.groupBox1.TabIndex = 9;
            // 
            // dtgvBill
            // 
            this.dtgvBill.AllowUserToAddRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgvBill.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvBill.BackgroundColor = System.Drawing.Color.Silver;
            this.dtgvBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvBill.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dtgvBill.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBill.DoubleBuffered = true;
            this.dtgvBill.EnableHeadersVisualStyles = false;
            this.dtgvBill.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dtgvBill.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dtgvBill.Location = new System.Drawing.Point(4, 75);
            this.dtgvBill.Name = "dtgvBill";
            this.dtgvBill.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvBill.RowHeadersVisible = false;
            this.dtgvBill.RowTemplate.Height = 24;
            this.dtgvBill.Size = new System.Drawing.Size(594, 482);
            this.dtgvBill.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(244, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bill History";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 1;
            // 
            // datetimeGetDay
            // 
            this.datetimeGetDay.BackColor = System.Drawing.Color.Silver;
            this.datetimeGetDay.BorderRadius = 0;
            this.datetimeGetDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimeGetDay.ForeColor = System.Drawing.Color.White;
            this.datetimeGetDay.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.datetimeGetDay.FormatCustom = null;
            this.datetimeGetDay.Location = new System.Drawing.Point(6, 46);
            this.datetimeGetDay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datetimeGetDay.Name = "datetimeGetDay";
            this.datetimeGetDay.Size = new System.Drawing.Size(288, 24);
            this.datetimeGetDay.TabIndex = 0;
            this.datetimeGetDay.Value = new System.DateTime(2021, 11, 25, 22, 37, 32, 423);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.White;
            this.bunifuImageButton1.Image = global::GUI.Properties.Resources.loupe;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(501, 583);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(54, 24);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 15;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // frmListBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBillId);
            this.Controls.Add(this.txtTableId);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmListBill";
            this.Size = new System.Drawing.Size(1095, 676);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBillDetail)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTotal;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtBillId;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTableId;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dtgvBillDetail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel groupBox1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dtgvBill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDatepicker datetimeGetDay;
    }
}

﻿namespace GUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.datetimeGetDay = new Bunifu.Framework.UI.BunifuDatepicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnImgSearch = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnImgCountFood = new Bunifu.Framework.UI.BunifuImageButton();
            this.dtgvBill1 = new System.Windows.Forms.DataGridView();
            this.dtgvBillDetail = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnImgSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImgCountFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBillDetail)).BeginInit();
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
            this.txtTotal.Location = new System.Drawing.Point(740, 735);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(340, 31);
            this.txtTotal.TabIndex = 20;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.txtStatus.Location = new System.Drawing.Point(740, 675);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(4);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(340, 31);
            this.txtStatus.TabIndex = 21;
            this.txtStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(658, 742);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 24);
            this.label7.TabIndex = 18;
            this.label7.Text = "Total:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(658, 682);
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
            this.txtBillId.Location = new System.Drawing.Point(148, 735);
            this.txtBillId.Margin = new System.Windows.Forms.Padding(4);
            this.txtBillId.Name = "txtBillId";
            this.txtBillId.Size = new System.Drawing.Size(340, 31);
            this.txtBillId.TabIndex = 16;
            this.txtBillId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTableId
            // 
            this.txtTableId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTableId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTableId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTableId.HintForeColor = System.Drawing.Color.Empty;
            this.txtTableId.HintText = "";
            this.txtTableId.isPassword = false;
            this.txtTableId.LineFocusedColor = System.Drawing.Color.DeepSkyBlue;
            this.txtTableId.LineIdleColor = System.Drawing.Color.DeepSkyBlue;
            this.txtTableId.LineMouseHoverColor = System.Drawing.Color.DeepSkyBlue;
            this.txtTableId.LineThickness = 3;
            this.txtTableId.Location = new System.Drawing.Point(148, 675);
            this.txtTableId.Margin = new System.Windows.Forms.Padding(4);
            this.txtTableId.Name = "txtTableId";
            this.txtTableId.Size = new System.Drawing.Size(340, 31);
            this.txtTableId.TabIndex = 17;
            this.txtTableId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 2;
            this.bunifuSeparator2.Location = new System.Drawing.Point(582, 657);
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
            this.label5.Location = new System.Drawing.Point(43, 742);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Bill ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 682);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Table ID:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvBillDetail);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(614, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 633);
            this.panel1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(194, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Bill Details";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgvBill1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.datetimeGetDay);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(595, 634);
            this.groupBox1.TabIndex = 9;
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
            this.datetimeGetDay.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.datetimeGetDay.BorderRadius = 0;
            this.datetimeGetDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.datetimeGetDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimeGetDay.ForeColor = System.Drawing.Color.Black;
            this.datetimeGetDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetimeGetDay.FormatCustom = null;
            this.datetimeGetDay.Location = new System.Drawing.Point(6, 44);
            this.datetimeGetDay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datetimeGetDay.Name = "datetimeGetDay";
            this.datetimeGetDay.Size = new System.Drawing.Size(251, 24);
            this.datetimeGetDay.TabIndex = 0;
            this.datetimeGetDay.Value = new System.DateTime(2021, 11, 25, 22, 37, 32, 423);
            this.datetimeGetDay.onValueChanged += new System.EventHandler(this.datetimeGetDay_onValueChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel3.Location = new System.Drawing.Point(148, 704);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(350, 2);
            this.panel3.TabIndex = 88;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Location = new System.Drawing.Point(148, 764);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 2);
            this.panel2.TabIndex = 89;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel4.Location = new System.Drawing.Point(740, 704);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(340, 2);
            this.panel4.TabIndex = 90;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel5.Location = new System.Drawing.Point(740, 764);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(340, 2);
            this.panel5.TabIndex = 91;
            // 
            // btnImgSearch
            // 
            this.btnImgSearch.BackColor = System.Drawing.Color.White;
            this.btnImgSearch.Image = global::GUI.Properties.Resources.loupe;
            this.btnImgSearch.ImageActive = null;
            this.btnImgSearch.Location = new System.Drawing.Point(511, 682);
            this.btnImgSearch.Name = "btnImgSearch";
            this.btnImgSearch.Size = new System.Drawing.Size(54, 24);
            this.btnImgSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnImgSearch.TabIndex = 93;
            this.btnImgSearch.TabStop = false;
            this.btnImgSearch.Zoom = 10;
            this.btnImgSearch.Click += new System.EventHandler(this.btnImgSearch_Click);
            // 
            // btnImgCountFood
            // 
            this.btnImgCountFood.BackColor = System.Drawing.Color.White;
            this.btnImgCountFood.Image = global::GUI.Properties.Resources.png_clipart_computer_icons_salad_food_food_icon_food_heart_thumbnail;
            this.btnImgCountFood.ImageActive = null;
            this.btnImgCountFood.Location = new System.Drawing.Point(511, 742);
            this.btnImgCountFood.Name = "btnImgCountFood";
            this.btnImgCountFood.Size = new System.Drawing.Size(54, 24);
            this.btnImgCountFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnImgCountFood.TabIndex = 94;
            this.btnImgCountFood.TabStop = false;
            this.btnImgCountFood.Zoom = 10;
            this.btnImgCountFood.Click += new System.EventHandler(this.btnImgCountFood_Click);
            // 
            // dtgvBill1
            // 
            this.dtgvBill1.AllowUserToAddRows = false;
            this.dtgvBill1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvBill1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvBill1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvBill1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvBill1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtgvBill1.Location = new System.Drawing.Point(6, 75);
            this.dtgvBill1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvBill1.Name = "dtgvBill1";
            this.dtgvBill1.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvBill1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgvBill1.RowHeadersVisible = false;
            this.dtgvBill1.RowHeadersWidth = 46;
            this.dtgvBill1.RowTemplate.Height = 28;
            this.dtgvBill1.Size = new System.Drawing.Size(583, 554);
            this.dtgvBill1.TabIndex = 12;
            this.dtgvBill1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvBill1_CellContentClick);
            // 
            // dtgvBillDetail
            // 
            this.dtgvBillDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvBillDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvBillDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvBillDetail.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvBillDetail.Location = new System.Drawing.Point(3, 75);
            this.dtgvBillDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvBillDetail.Name = "dtgvBillDetail";
            this.dtgvBillDetail.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvBillDetail.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvBillDetail.RowHeadersVisible = false;
            this.dtgvBillDetail.RowHeadersWidth = 62;
            this.dtgvBillDetail.RowTemplate.Height = 28;
            this.dtgvBillDetail.Size = new System.Drawing.Size(528, 554);
            this.dtgvBillDetail.TabIndex = 13;
            // 
            // frmListBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnImgCountFood);
            this.Controls.Add(this.btnImgSearch);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBillId);
            this.Controls.Add(this.txtTableId);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmListBill";
            this.Size = new System.Drawing.Size(1155, 825);
            this.Load += new System.EventHandler(this.frmListBill_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnImgSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImgCountFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBillDetail)).EndInit();
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
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDatepicker datetimeGetDay;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private Bunifu.Framework.UI.BunifuImageButton btnImgSearch;
        private Bunifu.Framework.UI.BunifuImageButton btnImgCountFood;
        private System.Windows.Forms.DataGridView dtgvBill1;
        private System.Windows.Forms.DataGridView dtgvBillDetail;
    }
}

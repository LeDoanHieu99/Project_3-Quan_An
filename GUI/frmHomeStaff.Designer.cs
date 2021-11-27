namespace GUI
{
    partial class frmHomeStaff
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
            this.TabPanel = new System.Windows.Forms.Panel();
            this.BtnBill = new System.Windows.Forms.Button();
            this.btnFood = new System.Windows.Forms.Button();
            this.btnTable = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panMainData = new System.Windows.Forms.Panel();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.TabPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TabPanel
            // 
            this.TabPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(199)))), ((int)(((byte)(242)))));
            this.TabPanel.Controls.Add(this.BtnBill);
            this.TabPanel.Controls.Add(this.btnFood);
            this.TabPanel.Controls.Add(this.btnTable);
            this.TabPanel.Controls.Add(this.btnHome);
            this.TabPanel.Controls.Add(this.pictureBox1);
            this.TabPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.TabPanel.Location = new System.Drawing.Point(0, 0);
            this.TabPanel.Name = "TabPanel";
            this.TabPanel.Size = new System.Drawing.Size(311, 907);
            this.TabPanel.TabIndex = 10;
            // 
            // BtnBill
            // 
            this.BtnBill.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBill.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBill.ForeColor = System.Drawing.Color.White;
            this.BtnBill.Image = global::GUI.Properties.Resources.bill;
            this.BtnBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBill.Location = new System.Drawing.Point(2, 779);
            this.BtnBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnBill.Name = "BtnBill";
            this.BtnBill.Size = new System.Drawing.Size(309, 100);
            this.BtnBill.TabIndex = 6;
            this.BtnBill.Text = "Bill";
            this.BtnBill.UseVisualStyleBackColor = true;
            // 
            // btnFood
            // 
            this.btnFood.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFood.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFood.ForeColor = System.Drawing.Color.White;
            this.btnFood.Image = global::GUI.Properties.Resources.fast_food__3_;
            this.btnFood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFood.Location = new System.Drawing.Point(2, 653);
            this.btnFood.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFood.Name = "btnFood";
            this.btnFood.Size = new System.Drawing.Size(309, 100);
            this.btnFood.TabIndex = 6;
            this.btnFood.Text = "Food";
            this.btnFood.UseVisualStyleBackColor = true;
            // 
            // btnTable
            // 
            this.btnTable.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTable.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTable.ForeColor = System.Drawing.Color.White;
            this.btnTable.Image = global::GUI.Properties.Resources.dinner_table;
            this.btnTable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTable.Location = new System.Drawing.Point(2, 523);
            this.btnTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTable.Name = "btnTable";
            this.btnTable.Size = new System.Drawing.Size(309, 100);
            this.btnTable.TabIndex = 6;
            this.btnTable.Text = "Table";
            this.btnTable.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::GUI.Properties.Resources.home;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(2, 394);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(309, 100);
            this.btnHome.TabIndex = 6;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::GUI.Properties.Resources.images__1__removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(311, 367);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panMainData
            // 
            this.panMainData.BackColor = System.Drawing.SystemColors.Control;
            this.panMainData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panMainData.Location = new System.Drawing.Point(311, 28);
            this.panMainData.Margin = new System.Windows.Forms.Padding(4);
            this.panMainData.Name = "panMainData";
            this.panMainData.Size = new System.Drawing.Size(1203, 879);
            this.panMainData.TabIndex = 11;
            // 
            // btnHide
            // 
            this.btnHide.FlatAppearance.BorderSize = 0;
            this.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHide.Image = global::GUI.Properties.Resources.minus;
            this.btnHide.Location = new System.Drawing.Point(1445, 2);
            this.btnHide.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(30, 22);
            this.btnHide.TabIndex = 13;
            this.btnHide.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::GUI.Properties.Resources.cancel2;
            this.btnClose.Location = new System.Drawing.Point(1480, 2);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 22);
            this.btnClose.TabIndex = 12;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // frmHomeStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(232)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1515, 907);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panMainData);
            this.Controls.Add(this.TabPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHomeStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHomeStaff";
            this.TabPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TabPanel;
        private System.Windows.Forms.Button BtnBill;
        private System.Windows.Forms.Button btnFood;
        private System.Windows.Forms.Button btnTable;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panMainData;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnClose;
    }
}
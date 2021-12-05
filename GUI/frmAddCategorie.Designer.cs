namespace GUI
{
    partial class frmAddCategorie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddCategorie));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAddCategorie = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtTypeName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnAddCategorie);
            this.panel1.Controls.Add(this.txtTypeName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 145);
            this.panel1.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.ActiveBorderThickness = 1;
            this.btnCancel.ActiveCornerRadius = 20;
            this.btnCancel.ActiveFillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCancel.ActiveForecolor = System.Drawing.Color.White;
            this.btnCancel.ActiveLineColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCancel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.ButtonText = "Cancel";
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCancel.IdleBorderThickness = 1;
            this.btnCancel.IdleCornerRadius = 20;
            this.btnCancel.IdleFillColor = System.Drawing.Color.White;
            this.btnCancel.IdleForecolor = System.Drawing.Color.Green;
            this.btnCancel.IdleLineColor = System.Drawing.Color.Green;
            this.btnCancel.Location = new System.Drawing.Point(165, 78);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 53);
            this.btnCancel.TabIndex = 36;
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddCategorie
            // 
            this.btnAddCategorie.ActiveBorderThickness = 1;
            this.btnAddCategorie.ActiveCornerRadius = 20;
            this.btnAddCategorie.ActiveFillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAddCategorie.ActiveForecolor = System.Drawing.Color.White;
            this.btnAddCategorie.ActiveLineColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAddCategorie.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddCategorie.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddCategorie.BackgroundImage")));
            this.btnAddCategorie.ButtonText = "Add";
            this.btnAddCategorie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCategorie.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCategorie.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAddCategorie.IdleBorderThickness = 1;
            this.btnAddCategorie.IdleCornerRadius = 20;
            this.btnAddCategorie.IdleFillColor = System.Drawing.Color.White;
            this.btnAddCategorie.IdleForecolor = System.Drawing.Color.DeepSkyBlue;
            this.btnAddCategorie.IdleLineColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAddCategorie.Location = new System.Drawing.Point(42, 78);
            this.btnAddCategorie.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddCategorie.Name = "btnAddCategorie";
            this.btnAddCategorie.Size = new System.Drawing.Size(94, 53);
            this.btnAddCategorie.TabIndex = 35;
            this.btnAddCategorie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddCategorie.Click += new System.EventHandler(this.btnAddCategorie_Click);
            // 
            // txtTypeName
            // 
            this.txtTypeName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTypeName.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtTypeName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTypeName.HintForeColor = System.Drawing.Color.Empty;
            this.txtTypeName.HintText = "TypeName";
            this.txtTypeName.isPassword = false;
            this.txtTypeName.LineFocusedColor = System.Drawing.Color.DeepSkyBlue;
            this.txtTypeName.LineIdleColor = System.Drawing.Color.DeepSkyBlue;
            this.txtTypeName.LineMouseHoverColor = System.Drawing.Color.DeepSkyBlue;
            this.txtTypeName.LineThickness = 3;
            this.txtTypeName.Location = new System.Drawing.Point(32, 12);
            this.txtTypeName.Margin = new System.Windows.Forms.Padding(4);
            this.txtTypeName.Name = "txtTypeName";
            this.txtTypeName.Size = new System.Drawing.Size(240, 46);
            this.txtTypeName.TabIndex = 34;
            this.txtTypeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // frmAddCategorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(306, 145);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddCategorie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddCategorie";
            this.Load += new System.EventHandler(this.frmAddCategorie_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCancel;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAddCategorie;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTypeName;
    }
}
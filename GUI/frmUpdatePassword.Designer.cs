namespace GUI
{
    partial class frmUpdatePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdatePassword));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnNewPassword = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtId = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNewPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnNewPassword);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.txtNewPassword);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 145);
            this.panel1.TabIndex = 1;
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
            this.btnCancel.IdleForecolor = System.Drawing.Color.DeepSkyBlue;
            this.btnCancel.IdleLineColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCancel.Location = new System.Drawing.Point(165, 78);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 53);
            this.btnCancel.TabIndex = 36;
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnNewPassword
            // 
            this.btnNewPassword.ActiveBorderThickness = 1;
            this.btnNewPassword.ActiveCornerRadius = 20;
            this.btnNewPassword.ActiveFillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnNewPassword.ActiveForecolor = System.Drawing.Color.White;
            this.btnNewPassword.ActiveLineColor = System.Drawing.Color.DeepSkyBlue;
            this.btnNewPassword.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNewPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNewPassword.BackgroundImage")));
            this.btnNewPassword.ButtonText = "Reset";
            this.btnNewPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewPassword.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPassword.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnNewPassword.IdleBorderThickness = 1;
            this.btnNewPassword.IdleCornerRadius = 20;
            this.btnNewPassword.IdleFillColor = System.Drawing.Color.White;
            this.btnNewPassword.IdleForecolor = System.Drawing.Color.DeepSkyBlue;
            this.btnNewPassword.IdleLineColor = System.Drawing.Color.DeepSkyBlue;
            this.btnNewPassword.Location = new System.Drawing.Point(42, 78);
            this.btnNewPassword.Margin = new System.Windows.Forms.Padding(5);
            this.btnNewPassword.Name = "btnNewPassword";
            this.btnNewPassword.Size = new System.Drawing.Size(94, 53);
            this.btnNewPassword.TabIndex = 35;
            this.btnNewPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNewPassword.Click += new System.EventHandler(this.btnNewPassword_Click);
            // 
            // txtId
            // 
            this.txtId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtId.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtId.HintForeColor = System.Drawing.Color.Empty;
            this.txtId.HintText = "ID";
            this.txtId.isPassword = false;
            this.txtId.LineFocusedColor = System.Drawing.Color.DeepSkyBlue;
            this.txtId.LineIdleColor = System.Drawing.Color.DeepSkyBlue;
            this.txtId.LineMouseHoverColor = System.Drawing.Color.DeepSkyBlue;
            this.txtId.LineThickness = 3;
            this.txtId.Location = new System.Drawing.Point(20, 13);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(52, 46);
            this.txtId.TabIndex = 34;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPassword.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtNewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNewPassword.HintForeColor = System.Drawing.Color.Empty;
            this.txtNewPassword.HintText = "New PassWord";
            this.txtNewPassword.isPassword = false;
            this.txtNewPassword.LineFocusedColor = System.Drawing.Color.DeepSkyBlue;
            this.txtNewPassword.LineIdleColor = System.Drawing.Color.DeepSkyBlue;
            this.txtNewPassword.LineMouseHoverColor = System.Drawing.Color.DeepSkyBlue;
            this.txtNewPassword.LineThickness = 3;
            this.txtNewPassword.Location = new System.Drawing.Point(86, 12);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(197, 46);
            this.txtNewPassword.TabIndex = 34;
            this.txtNewPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // frmUpdatePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(306, 145);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUpdatePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUpdatePassword";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCancel;
        private Bunifu.Framework.UI.BunifuThinButton2 btnNewPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNewPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtId;
    }
}
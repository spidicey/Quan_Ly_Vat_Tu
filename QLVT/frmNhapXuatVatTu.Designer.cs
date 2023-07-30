namespace QLVT
{
    partial class frmNhapXuatVatTu
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
            this.components = new System.ComponentModel.Container();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.nudDONGIA = new System.Windows.Forms.NumericUpDown();
            this.nudSOLUONG = new System.Windows.Forms.NumericUpDown();
            this.cmbMAVT = new System.Windows.Forms.ComboBox();
            this.txtSOPHIEU = new System.Windows.Forms.TextBox();
            this.lblDONGIA = new System.Windows.Forms.Label();
            this.lblSOLUONG = new System.Windows.Forms.Label();
            this.lblMAVT = new System.Windows.Forms.Label();
            this.lblSOPHIEU = new System.Windows.Forms.Label();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.toolTipSOLUONG = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudDONGIA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSOLUONG)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHuyBo.Location = new System.Drawing.Point(365, 390);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(150, 52);
            this.btnHuyBo.TabIndex = 2;
            this.btnHuyBo.Text = "Hủy bỏ";
            this.btnHuyBo.UseVisualStyleBackColor = true;
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(136, 390);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(150, 52);
            this.btnXacNhan.TabIndex = 1;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // nudDONGIA
            // 
            this.nudDONGIA.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDONGIA.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudDONGIA.Location = new System.Drawing.Point(261, 289);
            this.nudDONGIA.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudDONGIA.Name = "nudDONGIA";
            this.nudDONGIA.Size = new System.Drawing.Size(244, 29);
            this.nudDONGIA.TabIndex = 0;
            this.nudDONGIA.TabStop = false;
            this.nudDONGIA.ThousandsSeparator = true;
            // 
            // nudSOLUONG
            // 
            this.nudSOLUONG.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSOLUONG.Location = new System.Drawing.Point(261, 228);
            this.nudSOLUONG.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudSOLUONG.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSOLUONG.Name = "nudSOLUONG";
            this.nudSOLUONG.Size = new System.Drawing.Size(244, 29);
            this.nudSOLUONG.TabIndex = 0;
            this.nudSOLUONG.TabStop = false;
            this.nudSOLUONG.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmbMAVT
            // 
            this.cmbMAVT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMAVT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbMAVT.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMAVT.FormattingEnabled = true;
            this.cmbMAVT.Location = new System.Drawing.Point(261, 167);
            this.cmbMAVT.Name = "cmbMAVT";
            this.cmbMAVT.Size = new System.Drawing.Size(244, 29);
            this.cmbMAVT.TabIndex = 0;
            this.cmbMAVT.TabStop = false;
            this.cmbMAVT.SelectedIndexChanged += new System.EventHandler(this.cmbMAVT_SelectedIndexChanged);
            // 
            // txtSOPHIEU
            // 
            this.txtSOPHIEU.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSOPHIEU.Location = new System.Drawing.Point(261, 106);
            this.txtSOPHIEU.Name = "txtSOPHIEU";
            this.txtSOPHIEU.ReadOnly = true;
            this.txtSOPHIEU.Size = new System.Drawing.Size(244, 29);
            this.txtSOPHIEU.TabIndex = 0;
            this.txtSOPHIEU.TabStop = false;
            // 
            // lblDONGIA
            // 
            this.lblDONGIA.AutoSize = true;
            this.lblDONGIA.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDONGIA.Location = new System.Drawing.Point(146, 293);
            this.lblDONGIA.Name = "lblDONGIA";
            this.lblDONGIA.Size = new System.Drawing.Size(80, 21);
            this.lblDONGIA.TabIndex = 0;
            this.lblDONGIA.Text = "Đơn giá:";
            // 
            // lblSOLUONG
            // 
            this.lblSOLUONG.AutoSize = true;
            this.lblSOLUONG.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSOLUONG.Location = new System.Drawing.Point(146, 232);
            this.lblSOLUONG.Name = "lblSOLUONG";
            this.lblSOLUONG.Size = new System.Drawing.Size(89, 21);
            this.lblSOLUONG.TabIndex = 0;
            this.lblSOLUONG.Text = "Số lượng:";
            // 
            // lblMAVT
            // 
            this.lblMAVT.AutoSize = true;
            this.lblMAVT.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMAVT.Location = new System.Drawing.Point(146, 171);
            this.lblMAVT.Name = "lblMAVT";
            this.lblMAVT.Size = new System.Drawing.Size(66, 21);
            this.lblMAVT.TabIndex = 0;
            this.lblMAVT.Text = "Vật tư:";
            // 
            // lblSOPHIEU
            // 
            this.lblSOPHIEU.AutoSize = true;
            this.lblSOPHIEU.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSOPHIEU.Location = new System.Drawing.Point(146, 110);
            this.lblSOPHIEU.Name = "lblSOPHIEU";
            this.lblSOPHIEU.Size = new System.Drawing.Size(87, 21);
            this.lblSOPHIEU.TabIndex = 0;
            this.lblSOPHIEU.Text = "Số phiếu:";
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTieuDe.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.Location = new System.Drawing.Point(0, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(650, 60);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "THÔNG TIN VẬT TƯ";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmNhapXuatVatTu
            // 
            this.AcceptButton = this.btnXacNhan;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.btnHuyBo;
            this.ClientSize = new System.Drawing.Size(650, 460);
            this.ControlBox = false;
            this.Controls.Add(this.nudDONGIA);
            this.Controls.Add(this.btnHuyBo);
            this.Controls.Add(this.nudSOLUONG);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.cmbMAVT);
            this.Controls.Add(this.txtSOPHIEU);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.lblDONGIA);
            this.Controls.Add(this.lblSOPHIEU);
            this.Controls.Add(this.lblSOLUONG);
            this.Controls.Add(this.lblMAVT);
            this.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNhapXuatVatTu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin vật tư";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.nudDONGIA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSOLUONG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.ComboBox cmbMAVT;
        private System.Windows.Forms.TextBox txtSOPHIEU;
        private System.Windows.Forms.Label lblDONGIA;
        private System.Windows.Forms.Label lblSOLUONG;
        private System.Windows.Forms.Label lblMAVT;
        private System.Windows.Forms.Label lblSOPHIEU;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.NumericUpDown nudSOLUONG;
        private System.Windows.Forms.NumericUpDown nudDONGIA;
        private System.Windows.Forms.ToolTip toolTipSOLUONG;
    }
}
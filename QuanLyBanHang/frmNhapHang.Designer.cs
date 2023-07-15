namespace QuanLyBanHang
{
    partial class frmNhapHang
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
            this.lblMaHH = new System.Windows.Forms.Label();
            this.lblTenHH = new System.Windows.Forms.Label();
            this.lblDVT = new System.Windows.Forms.Label();
            this.lblSLHH = new System.Windows.Forms.Label();
            this.txtMaHH = new System.Windows.Forms.TextBox();
            this.txtTenHH = new System.Windows.Forms.TextBox();
            this.txtDVT = new System.Windows.Forms.TextBox();
            this.txtSoLuongHH = new System.Windows.Forms.TextBox();
            this.btnThemHH = new System.Windows.Forms.Button();
            this.btnThoat3 = new System.Windows.Forms.Button();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMaHH
            // 
            this.lblMaHH.AutoSize = true;
            this.lblMaHH.Location = new System.Drawing.Point(112, 142);
            this.lblMaHH.Name = "lblMaHH";
            this.lblMaHH.Size = new System.Drawing.Size(31, 19);
            this.lblMaHH.TabIndex = 0;
            this.lblMaHH.Text = "Mã";
            // 
            // lblTenHH
            // 
            this.lblTenHH.AutoSize = true;
            this.lblTenHH.Location = new System.Drawing.Point(112, 204);
            this.lblTenHH.Name = "lblTenHH";
            this.lblTenHH.Size = new System.Drawing.Size(34, 19);
            this.lblTenHH.TabIndex = 1;
            this.lblTenHH.Text = "Tên";
            // 
            // lblDVT
            // 
            this.lblDVT.AutoSize = true;
            this.lblDVT.Location = new System.Drawing.Point(112, 266);
            this.lblDVT.Name = "lblDVT";
            this.lblDVT.Size = new System.Drawing.Size(84, 19);
            this.lblDVT.TabIndex = 2;
            this.lblDVT.Text = "Đơn vị tính";
            // 
            // lblSLHH
            // 
            this.lblSLHH.AutoSize = true;
            this.lblSLHH.Location = new System.Drawing.Point(112, 328);
            this.lblSLHH.Name = "lblSLHH";
            this.lblSLHH.Size = new System.Drawing.Size(70, 19);
            this.lblSLHH.TabIndex = 3;
            this.lblSLHH.Text = "Số lượng";
            // 
            // txtMaHH
            // 
            this.txtMaHH.Location = new System.Drawing.Point(257, 130);
            this.txtMaHH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaHH.Multiline = true;
            this.txtMaHH.Name = "txtMaHH";
            this.txtMaHH.Size = new System.Drawing.Size(110, 31);
            this.txtMaHH.TabIndex = 4;
            // 
            // txtTenHH
            // 
            this.txtTenHH.Location = new System.Drawing.Point(257, 169);
            this.txtTenHH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenHH.Multiline = true;
            this.txtTenHH.Name = "txtTenHH";
            this.txtTenHH.Size = new System.Drawing.Size(330, 54);
            this.txtTenHH.TabIndex = 5;
            // 
            // txtDVT
            // 
            this.txtDVT.Location = new System.Drawing.Point(257, 231);
            this.txtDVT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDVT.Multiline = true;
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.Size = new System.Drawing.Size(330, 54);
            this.txtDVT.TabIndex = 6;
            // 
            // txtSoLuongHH
            // 
            this.txtSoLuongHH.Location = new System.Drawing.Point(257, 293);
            this.txtSoLuongHH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoLuongHH.Multiline = true;
            this.txtSoLuongHH.Name = "txtSoLuongHH";
            this.txtSoLuongHH.Size = new System.Drawing.Size(330, 54);
            this.txtSoLuongHH.TabIndex = 7;
            // 
            // btnThemHH
            // 
            this.btnThemHH.Location = new System.Drawing.Point(140, 446);
            this.btnThemHH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThemHH.Name = "btnThemHH";
            this.btnThemHH.Size = new System.Drawing.Size(136, 36);
            this.btnThemHH.TabIndex = 8;
            this.btnThemHH.Text = "Thêm";
            this.btnThemHH.UseVisualStyleBackColor = true;
            this.btnThemHH.Click += new System.EventHandler(this.btnThemHH_Click);
            // 
            // btnThoat3
            // 
            this.btnThoat3.Location = new System.Drawing.Point(451, 446);
            this.btnThoat3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThoat3.Name = "btnThoat3";
            this.btnThoat3.Size = new System.Drawing.Size(136, 36);
            this.btnThoat3.TabIndex = 9;
            this.btnThoat3.Text = "Thoát";
            this.btnThoat3.UseVisualStyleBackColor = true;
            this.btnThoat3.Click += new System.EventHandler(this.btnThoat3_Click);
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.Location = new System.Drawing.Point(109, 55);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(474, 37);
            this.lblTieuDe.TabIndex = 10;
            this.lblTieuDe.Text = "NHẬP THÔNG TIN HÀNG HÓA";
            // 
            // frmNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 512);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.btnThoat3);
            this.Controls.Add(this.btnThemHH);
            this.Controls.Add(this.txtSoLuongHH);
            this.Controls.Add(this.txtDVT);
            this.Controls.Add(this.txtTenHH);
            this.Controls.Add(this.txtMaHH);
            this.Controls.Add(this.lblSLHH);
            this.Controls.Add(this.lblDVT);
            this.Controls.Add(this.lblTenHH);
            this.Controls.Add(this.lblMaHH);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmNhapHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập thông tin hàng hóa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaHH;
        private System.Windows.Forms.Label lblTenHH;
        private System.Windows.Forms.Label lblDVT;
        private System.Windows.Forms.Label lblSLHH;
        private System.Windows.Forms.TextBox txtMaHH;
        private System.Windows.Forms.TextBox txtTenHH;
        private System.Windows.Forms.TextBox txtDVT;
        private System.Windows.Forms.TextBox txtSoLuongHH;
        private System.Windows.Forms.Button btnThemHH;
        private System.Windows.Forms.Button btnThoat3;
        private System.Windows.Forms.Label lblTieuDe;
    }
}
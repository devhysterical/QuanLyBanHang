namespace QuanLyBanHang
{
    partial class frmLuaChonChucNang
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
            this.btnQLNV = new System.Windows.Forms.Button();
            this.btnQLMH = new System.Windows.Forms.Button();
            this.btnQLKH = new System.Windows.Forms.Button();
            this.btnNhapHD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDSHH = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQLNV
            // 
            this.btnQLNV.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLNV.Location = new System.Drawing.Point(187, 87);
            this.btnQLNV.Name = "btnQLNV";
            this.btnQLNV.Size = new System.Drawing.Size(180, 62);
            this.btnQLNV.TabIndex = 0;
            this.btnQLNV.Text = "Quản lý nhân viên";
            this.btnQLNV.UseVisualStyleBackColor = true;
            this.btnQLNV.Click += new System.EventHandler(this.btnQLNV_Click);
            // 
            // btnQLMH
            // 
            this.btnQLMH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLMH.Location = new System.Drawing.Point(187, 155);
            this.btnQLMH.Name = "btnQLMH";
            this.btnQLMH.Size = new System.Drawing.Size(180, 62);
            this.btnQLMH.TabIndex = 1;
            this.btnQLMH.Text = "Quản lý các mặt hàng";
            this.btnQLMH.UseVisualStyleBackColor = true;
            this.btnQLMH.Click += new System.EventHandler(this.btnQLMH_Click);
            // 
            // btnQLKH
            // 
            this.btnQLKH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLKH.Location = new System.Drawing.Point(187, 223);
            this.btnQLKH.Name = "btnQLKH";
            this.btnQLKH.Size = new System.Drawing.Size(180, 62);
            this.btnQLKH.TabIndex = 2;
            this.btnQLKH.Text = "Quản lý khách hàng";
            this.btnQLKH.UseVisualStyleBackColor = true;
            this.btnQLKH.Click += new System.EventHandler(this.btnQLKH_Click);
            // 
            // btnNhapHD
            // 
            this.btnNhapHD.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapHD.Location = new System.Drawing.Point(187, 359);
            this.btnNhapHD.Name = "btnNhapHD";
            this.btnNhapHD.Size = new System.Drawing.Size(180, 62);
            this.btnNhapHD.TabIndex = 3;
            this.btnNhapHD.Text = "Nhập hóa đơn mua hàng";
            this.btnNhapHD.UseVisualStyleBackColor = true;
            this.btnNhapHD.Click += new System.EventHandler(this.btnNhapHD_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "LỰA CHỌN CHỨC NĂNG";
            // 
            // btnDSHH
            // 
            this.btnDSHH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDSHH.Location = new System.Drawing.Point(187, 291);
            this.btnDSHH.Name = "btnDSHH";
            this.btnDSHH.Size = new System.Drawing.Size(180, 62);
            this.btnDSHH.TabIndex = 5;
            this.btnDSHH.Text = "Danh sách hàng hóa";
            this.btnDSHH.UseVisualStyleBackColor = true;
            this.btnDSHH.Click += new System.EventHandler(this.btnDSHH_Click);
            // 
            // frmLuaChonChucNang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 472);
            this.Controls.Add(this.btnDSHH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNhapHD);
            this.Controls.Add(this.btnQLKH);
            this.Controls.Add(this.btnQLMH);
            this.Controls.Add(this.btnQLNV);
            this.Name = "frmLuaChonChucNang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lựa chọn chức năng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQLNV;
        private System.Windows.Forms.Button btnQLMH;
        private System.Windows.Forms.Button btnQLKH;
        private System.Windows.Forms.Button btnNhapHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDSHH;
    }
}
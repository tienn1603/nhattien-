namespace MAIN.main
{
    partial class frmLePhi
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
            this.grbHopDong = new System.Windows.Forms.GroupBox();
            this.txtDichVu = new System.Windows.Forms.TextBox();
            this.txtTienPhong = new System.Windows.Forms.TextBox();
            this.dtpNgayTao = new System.Windows.Forms.DateTimePicker();
            this.lblIDlePhi = new System.Windows.Forms.Label();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.txtIDLePhi = new System.Windows.Forms.TextBox();
            this.lblNgayKetThuc = new System.Windows.Forms.Label();
            this.lblNgayBatDau = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.lblPhong = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTimLePhi = new System.Windows.Forms.TextBox();
            this.dgvLePhi = new System.Windows.Forms.DataGridView();
            this.btnTimLePhi = new System.Windows.Forms.Button();
            this.lblTenPhong = new System.Windows.Forms.Label();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.grbHopDong.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLePhi)).BeginInit();
            this.SuspendLayout();
            // 
            // grbHopDong
            // 
            this.grbHopDong.Controls.Add(this.lblTenPhong);
            this.grbHopDong.Controls.Add(this.txtTenPhong);
            this.grbHopDong.Controls.Add(this.txtDichVu);
            this.grbHopDong.Controls.Add(this.txtTienPhong);
            this.grbHopDong.Controls.Add(this.dtpNgayTao);
            this.grbHopDong.Controls.Add(this.lblIDlePhi);
            this.grbHopDong.Controls.Add(this.lblThanhTien);
            this.grbHopDong.Controls.Add(this.txtIDLePhi);
            this.grbHopDong.Controls.Add(this.lblNgayKetThuc);
            this.grbHopDong.Controls.Add(this.lblNgayBatDau);
            this.grbHopDong.Controls.Add(this.txtThanhTien);
            this.grbHopDong.Controls.Add(this.lblPhong);
            this.grbHopDong.Location = new System.Drawing.Point(21, 22);
            this.grbHopDong.Name = "grbHopDong";
            this.grbHopDong.Size = new System.Drawing.Size(1004, 184);
            this.grbHopDong.TabIndex = 49;
            this.grbHopDong.TabStop = false;
            // 
            // txtDichVu
            // 
            this.txtDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDichVu.Location = new System.Drawing.Point(750, 68);
            this.txtDichVu.Name = "txtDichVu";
            this.txtDichVu.ReadOnly = true;
            this.txtDichVu.Size = new System.Drawing.Size(200, 38);
            this.txtDichVu.TabIndex = 63;
            // 
            // txtTienPhong
            // 
            this.txtTienPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienPhong.Location = new System.Drawing.Point(750, 15);
            this.txtTienPhong.Name = "txtTienPhong";
            this.txtTienPhong.ReadOnly = true;
            this.txtTienPhong.Size = new System.Drawing.Size(200, 38);
            this.txtTienPhong.TabIndex = 62;
            // 
            // dtpNgayTao
            // 
            this.dtpNgayTao.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayTao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayTao.Location = new System.Drawing.Point(176, 129);
            this.dtpNgayTao.Name = "dtpNgayTao";
            this.dtpNgayTao.Size = new System.Drawing.Size(264, 38);
            this.dtpNgayTao.TabIndex = 61;
            // 
            // lblIDlePhi
            // 
            this.lblIDlePhi.AutoSize = true;
            this.lblIDlePhi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDlePhi.Location = new System.Drawing.Point(17, 18);
            this.lblIDlePhi.Name = "lblIDlePhi";
            this.lblIDlePhi.Size = new System.Drawing.Size(144, 32);
            this.lblIDlePhi.TabIndex = 54;
            this.lblIDlePhi.Text = "Mã lệ phí: ";
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.AutoSize = true;
            this.lblThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanhTien.Location = new System.Drawing.Point(554, 118);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(164, 32);
            this.lblThanhTien.TabIndex = 49;
            this.lblThanhTien.Text = "Thành tiền: ";
            // 
            // txtIDLePhi
            // 
            this.txtIDLePhi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDLePhi.Location = new System.Drawing.Point(176, 21);
            this.txtIDLePhi.Name = "txtIDLePhi";
            this.txtIDLePhi.ReadOnly = true;
            this.txtIDLePhi.Size = new System.Drawing.Size(264, 38);
            this.txtIDLePhi.TabIndex = 58;
            // 
            // lblNgayKetThuc
            // 
            this.lblNgayKetThuc.AutoSize = true;
            this.lblNgayKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayKetThuc.Location = new System.Drawing.Point(554, 68);
            this.lblNgayKetThuc.Name = "lblNgayKetThuc";
            this.lblNgayKetThuc.Size = new System.Drawing.Size(167, 32);
            this.lblNgayKetThuc.TabIndex = 50;
            this.lblNgayKetThuc.Text = "Tiền dịch vụ";
            // 
            // lblNgayBatDau
            // 
            this.lblNgayBatDau.AutoSize = true;
            this.lblNgayBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayBatDau.Location = new System.Drawing.Point(554, 18);
            this.lblNgayBatDau.Name = "lblNgayBatDau";
            this.lblNgayBatDau.Size = new System.Drawing.Size(165, 32);
            this.lblNgayBatDau.TabIndex = 51;
            this.lblNgayBatDau.Text = "Tiền phòng:";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhTien.Location = new System.Drawing.Point(750, 118);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(200, 38);
            this.txtThanhTien.TabIndex = 55;
            // 
            // lblPhong
            // 
            this.lblPhong.AutoSize = true;
            this.lblPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhong.Location = new System.Drawing.Point(17, 129);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(127, 32);
            this.lblPhong.TabIndex = 53;
            this.lblPhong.Text = "Ngày tạo";
            this.lblPhong.Click += new System.EventHandler(this.lblPhong_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtTimLePhi);
            this.groupBox1.Controls.Add(this.dgvLePhi);
            this.groupBox1.Controls.Add(this.btnTimLePhi);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1004, 448);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(490, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 25);
            this.label6.TabIndex = 45;
            // 
            // txtTimLePhi
            // 
            this.txtTimLePhi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimLePhi.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtTimLePhi.Location = new System.Drawing.Point(12, 29);
            this.txtTimLePhi.Name = "txtTimLePhi";
            this.txtTimLePhi.Size = new System.Drawing.Size(338, 38);
            this.txtTimLePhi.TabIndex = 44;
            this.txtTimLePhi.Text = "Nhập từ khóa để tìm kiếm";
            // 
            // dgvLePhi
            // 
            this.dgvLePhi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLePhi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLePhi.Location = new System.Drawing.Point(12, 78);
            this.dgvLePhi.Name = "dgvLePhi";
            this.dgvLePhi.RowHeadersWidth = 51;
            this.dgvLePhi.RowTemplate.Height = 29;
            this.dgvLePhi.Size = new System.Drawing.Size(938, 325);
            this.dgvLePhi.TabIndex = 42;
            this.dgvLePhi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLePhi_CellClick);
            // 
            // btnTimLePhi
            // 
            this.btnTimLePhi.BackColor = System.Drawing.Color.DarkGreen;
            this.btnTimLePhi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimLePhi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTimLePhi.Location = new System.Drawing.Point(356, 34);
            this.btnTimLePhi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimLePhi.Name = "btnTimLePhi";
            this.btnTimLePhi.Size = new System.Drawing.Size(84, 32);
            this.btnTimLePhi.TabIndex = 31;
            this.btnTimLePhi.Text = "Tìm";
            this.btnTimLePhi.UseVisualStyleBackColor = false;
            this.btnTimLePhi.Click += new System.EventHandler(this.btnTimLePhi_Click);
            // 
            // lblTenPhong
            // 
            this.lblTenPhong.AutoSize = true;
            this.lblTenPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenPhong.Location = new System.Drawing.Point(6, 74);
            this.lblTenPhong.Name = "lblTenPhong";
            this.lblTenPhong.Size = new System.Drawing.Size(158, 32);
            this.lblTenPhong.TabIndex = 64;
            this.lblTenPhong.Text = "Tên phòng:";
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenPhong.Location = new System.Drawing.Point(176, 68);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.ReadOnly = true;
            this.txtTenPhong.Size = new System.Drawing.Size(264, 38);
            this.txtTenPhong.TabIndex = 65;
            // 
            // frmLePhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 730);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbHopDong);
            this.Name = "frmLePhi";
            this.Text = "Quản lý lệ phí";
            this.grbHopDong.ResumeLayout(false);
            this.grbHopDong.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLePhi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbHopDong;
        private System.Windows.Forms.Label lblIDlePhi;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.TextBox txtIDLePhi;
        private System.Windows.Forms.Label lblNgayKetThuc;
        private System.Windows.Forms.Label lblNgayBatDau;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTimLePhi;
        private System.Windows.Forms.DataGridView dgvLePhi;
        private System.Windows.Forms.Button btnTimLePhi;
        private System.Windows.Forms.DateTimePicker dtpNgayTao;
        private System.Windows.Forms.TextBox txtTienPhong;
        private System.Windows.Forms.TextBox txtDichVu;
        private System.Windows.Forms.Label lblTenPhong;
        private System.Windows.Forms.TextBox txtTenPhong;
    }
}
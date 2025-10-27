namespace MAIN.main
{
    partial class frmNuoc
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTenPhong = new System.Windows.Forms.Label();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.lblThang = new System.Windows.Forms.Label();
            this.lblTienNuoc = new System.Windows.Forms.Label();
            this.lblChiSoMoi = new System.Windows.Forms.Label();
            this.lblChiSoCu = new System.Windows.Forms.Label();
            this.lblMaNuoc = new System.Windows.Forms.Label();
            this.txtTienNuoc = new System.Windows.Forms.TextBox();
            this.txtChiSoMoi = new System.Windows.Forms.TextBox();
            this.txtChiSoCu = new System.Windows.Forms.TextBox();
            this.txtMaNuoc = new System.Windows.Forms.TextBox();
            this.dtpThang = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTimNuoc = new System.Windows.Forms.TextBox();
            this.dgvNuoc = new System.Windows.Forms.DataGridView();
            this.btnTimNuoc = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTenPhong);
            this.groupBox1.Controls.Add(this.txtTenPhong);
            this.groupBox1.Controls.Add(this.lblThang);
            this.groupBox1.Controls.Add(this.lblTienNuoc);
            this.groupBox1.Controls.Add(this.lblChiSoMoi);
            this.groupBox1.Controls.Add(this.lblChiSoCu);
            this.groupBox1.Controls.Add(this.lblMaNuoc);
            this.groupBox1.Controls.Add(this.txtTienNuoc);
            this.groupBox1.Controls.Add(this.txtChiSoMoi);
            this.groupBox1.Controls.Add(this.txtChiSoCu);
            this.groupBox1.Controls.Add(this.txtMaNuoc);
            this.groupBox1.Controls.Add(this.dtpThang);
            this.groupBox1.Location = new System.Drawing.Point(34, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(914, 263);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblTenPhong
            // 
            this.lblTenPhong.AutoSize = true;
            this.lblTenPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenPhong.Location = new System.Drawing.Point(-6, 109);
            this.lblTenPhong.Name = "lblTenPhong";
            this.lblTenPhong.Size = new System.Drawing.Size(158, 32);
            this.lblTenPhong.TabIndex = 29;
            this.lblTenPhong.Text = "Tên phòng:";
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenPhong.Location = new System.Drawing.Point(158, 103);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.ReadOnly = true;
            this.txtTenPhong.Size = new System.Drawing.Size(251, 38);
            this.txtTenPhong.TabIndex = 30;
            // 
            // lblThang
            // 
            this.lblThang.AutoSize = true;
            this.lblThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThang.Location = new System.Drawing.Point(9, 177);
            this.lblThang.Name = "lblThang";
            this.lblThang.Size = new System.Drawing.Size(127, 32);
            this.lblThang.TabIndex = 19;
            this.lblThang.Text = "Ngày tạo";
            // 
            // lblTienNuoc
            // 
            this.lblTienNuoc.AutoSize = true;
            this.lblTienNuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienNuoc.Location = new System.Drawing.Point(467, 186);
            this.lblTienNuoc.Name = "lblTienNuoc";
            this.lblTienNuoc.Size = new System.Drawing.Size(147, 32);
            this.lblTienNuoc.TabIndex = 20;
            this.lblTienNuoc.Text = "Tiền nước:";
            // 
            // lblChiSoMoi
            // 
            this.lblChiSoMoi.AutoSize = true;
            this.lblChiSoMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiSoMoi.Location = new System.Drawing.Point(451, 109);
            this.lblChiSoMoi.Name = "lblChiSoMoi";
            this.lblChiSoMoi.Size = new System.Drawing.Size(219, 32);
            this.lblChiSoMoi.TabIndex = 21;
            this.lblChiSoMoi.Text = "Chỉ số cuối (m³):";
            // 
            // lblChiSoCu
            // 
            this.lblChiSoCu.AutoSize = true;
            this.lblChiSoCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiSoCu.Location = new System.Drawing.Point(456, 28);
            this.lblChiSoCu.Name = "lblChiSoCu";
            this.lblChiSoCu.Size = new System.Drawing.Size(214, 32);
            this.lblChiSoCu.TabIndex = 22;
            this.lblChiSoCu.Text = "Chỉ số đầu (m³):";
            // 
            // lblMaNuoc
            // 
            this.lblMaNuoc.AutoSize = true;
            this.lblMaNuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNuoc.Location = new System.Drawing.Point(6, 34);
            this.lblMaNuoc.Name = "lblMaNuoc";
            this.lblMaNuoc.Size = new System.Drawing.Size(130, 32);
            this.lblMaNuoc.TabIndex = 23;
            this.lblMaNuoc.Text = "Mã nước:";
            // 
            // txtTienNuoc
            // 
            this.txtTienNuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienNuoc.Location = new System.Drawing.Point(643, 180);
            this.txtTienNuoc.Name = "txtTienNuoc";
            this.txtTienNuoc.ReadOnly = true;
            this.txtTienNuoc.Size = new System.Drawing.Size(251, 38);
            this.txtTienNuoc.TabIndex = 24;
            // 
            // txtChiSoMoi
            // 
            this.txtChiSoMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChiSoMoi.Location = new System.Drawing.Point(669, 109);
            this.txtChiSoMoi.Name = "txtChiSoMoi";
            this.txtChiSoMoi.ReadOnly = true;
            this.txtChiSoMoi.Size = new System.Drawing.Size(221, 38);
            this.txtChiSoMoi.TabIndex = 25;
            // 
            // txtChiSoCu
            // 
            this.txtChiSoCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChiSoCu.Location = new System.Drawing.Point(669, 25);
            this.txtChiSoCu.Name = "txtChiSoCu";
            this.txtChiSoCu.ReadOnly = true;
            this.txtChiSoCu.Size = new System.Drawing.Size(221, 38);
            this.txtChiSoCu.TabIndex = 26;
            // 
            // txtMaNuoc
            // 
            this.txtMaNuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNuoc.Location = new System.Drawing.Point(159, 28);
            this.txtMaNuoc.Name = "txtMaNuoc";
            this.txtMaNuoc.Size = new System.Drawing.Size(251, 38);
            this.txtMaNuoc.TabIndex = 27;
            // 
            // dtpThang
            // 
            this.dtpThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpThang.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpThang.Location = new System.Drawing.Point(159, 177);
            this.dtpThang.Name = "dtpThang";
            this.dtpThang.Size = new System.Drawing.Size(251, 38);
            this.dtpThang.TabIndex = 28;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtTimNuoc);
            this.groupBox2.Controls.Add(this.dgvNuoc);
            this.groupBox2.Controls.Add(this.btnTimNuoc);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 307);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(946, 269);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(490, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 25);
            this.label6.TabIndex = 45;
            // 
            // txtTimNuoc
            // 
            this.txtTimNuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimNuoc.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtTimNuoc.Location = new System.Drawing.Point(12, 29);
            this.txtTimNuoc.Name = "txtTimNuoc";
            this.txtTimNuoc.Size = new System.Drawing.Size(338, 38);
            this.txtTimNuoc.TabIndex = 44;
            this.txtTimNuoc.Text = "Nhập từ khóa để tìm kiếm";
            // 
            // dgvNuoc
            // 
            this.dgvNuoc.AllowUserToAddRows = false;
            this.dgvNuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNuoc.Location = new System.Drawing.Point(22, 73);
            this.dgvNuoc.Name = "dgvNuoc";
            this.dgvNuoc.RowHeadersWidth = 51;
            this.dgvNuoc.RowTemplate.Height = 29;
            this.dgvNuoc.Size = new System.Drawing.Size(894, 379);
            this.dgvNuoc.TabIndex = 42;
            this.dgvNuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNuoc_CellClick);
            // 
            // btnTimNuoc
            // 
            this.btnTimNuoc.BackColor = System.Drawing.Color.DarkGreen;
            this.btnTimNuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimNuoc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTimNuoc.Location = new System.Drawing.Point(356, 34);
            this.btnTimNuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimNuoc.Name = "btnTimNuoc";
            this.btnTimNuoc.Size = new System.Drawing.Size(84, 32);
            this.btnTimNuoc.TabIndex = 31;
            this.btnTimNuoc.Text = "Tìm";
            this.btnTimNuoc.UseVisualStyleBackColor = false;
            this.btnTimNuoc.Click += new System.EventHandler(this.btnTimNuoc_Click);
            // 
            // frmNuoc
            // 
            this.ClientSize = new System.Drawing.Size(991, 600);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmNuoc";
            this.Text = "Quản lý tiền nước";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNuoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblThang;
        private System.Windows.Forms.Label lblTienNuoc;
        private System.Windows.Forms.Label lblChiSoMoi;
        private System.Windows.Forms.Label lblChiSoCu;
        private System.Windows.Forms.Label lblMaNuoc;
        private System.Windows.Forms.TextBox txtTienNuoc;
        private System.Windows.Forms.TextBox txtChiSoMoi;
        private System.Windows.Forms.TextBox txtChiSoCu;
        private System.Windows.Forms.TextBox txtMaNuoc;
        private System.Windows.Forms.DateTimePicker dtpThang;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTimNuoc;
        private System.Windows.Forms.DataGridView dgvNuoc;
        private System.Windows.Forms.Button btnTimNuoc;
        private System.Windows.Forms.Label lblTenPhong;
        private System.Windows.Forms.TextBox txtTenPhong;
    }
}
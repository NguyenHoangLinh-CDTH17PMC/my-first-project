namespace QuanLiThuVien
{
    partial class frmNhanVien
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
            this.txtTen = new System.Windows.Forms.TextBox();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.bntThem = new System.Windows.Forms.Button();
            this.lblMaSo = new System.Windows.Forms.Label();
            this.txtMS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtChucvu = new System.Windows.Forms.TextBox();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.lvwNhanvien = new System.Windows.Forms.ListView();
            this.colTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMaNV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPhai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNgaysinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colChucVu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCMND = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblDanhsachNhanvien = new System.Windows.Forms.Label();
            this.grbNhanvien = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bntXoaNv = new System.Windows.Forms.Button();
            this.bntCapNhat = new System.Windows.Forms.Button();
            this.bntThoat = new System.Windows.Forms.Button();
            this.dgvDSNhanVien = new System.Windows.Forms.DataGridView();
            this.grbNhanvien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(92, 24);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(116, 20);
            this.txtTen.TabIndex = 3;
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Location = new System.Drawing.Point(7, 28);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(46, 14);
            this.lblTenNV.TabIndex = 0;
            this.lblTenNV.Text = "Tên NV";
            this.lblTenNV.Click += new System.EventHandler(this.label1_Click);
            // 
            // bntThem
            // 
            this.bntThem.Location = new System.Drawing.Point(689, 13);
            this.bntThem.Name = "bntThem";
            this.bntThem.Size = new System.Drawing.Size(110, 46);
            this.bntThem.TabIndex = 2;
            this.bntThem.Text = "Thêm NV";
            this.bntThem.UseVisualStyleBackColor = true;
            this.bntThem.Click += new System.EventHandler(this.bntThem_Click);
            // 
            // lblMaSo
            // 
            this.lblMaSo.AutoSize = true;
            this.lblMaSo.Location = new System.Drawing.Point(231, 24);
            this.lblMaSo.Name = "lblMaSo";
            this.lblMaSo.Size = new System.Drawing.Size(40, 14);
            this.lblMaSo.TabIndex = 4;
            this.lblMaSo.Text = "Mã số";
            // 
            // txtMS
            // 
            this.txtMS.Location = new System.Drawing.Point(299, 20);
            this.txtMS.Name = "txtMS";
            this.txtMS.Size = new System.Drawing.Size(116, 20);
            this.txtMS.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "CMND";
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(299, 60);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(116, 20);
            this.txtCMND.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 14);
            this.label2.TabIndex = 8;
            this.label2.Text = "Chức vụ";
            // 
            // txtChucvu
            // 
            this.txtChucvu.Location = new System.Drawing.Point(92, 60);
            this.txtChucvu.Name = "txtChucvu";
            this.txtChucvu.Size = new System.Drawing.Size(116, 20);
            this.txtChucvu.TabIndex = 4;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(112, 144);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(60, 14);
            this.lblNgaySinh.TabIndex = 10;
            this.lblNgaySinh.Text = "Ngày sinh";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(182, 137);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(233, 20);
            this.dtpNgaySinh.TabIndex = 9;
            this.dtpNgaySinh.ValueChanged += new System.EventHandler(this.dtpNgaySinh_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 14);
            this.label3.TabIndex = 13;
            this.label3.Text = "Phái";
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Location = new System.Drawing.Point(370, 88);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(40, 18);
            this.rdbNu.TabIndex = 8;
            this.rdbNu.TabStop = true;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = true;
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Location = new System.Drawing.Point(299, 88);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(49, 18);
            this.rdbNam.TabIndex = 7;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = true;
            // 
            // lvwNhanvien
            // 
            this.lvwNhanvien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTen,
            this.colMaNV,
            this.colPhai,
            this.colNgaysinh,
            this.colChucVu,
            this.colCMND});
            this.lvwNhanvien.Location = new System.Drawing.Point(14, 341);
            this.lvwNhanvien.Name = "lvwNhanvien";
            this.lvwNhanvien.Size = new System.Drawing.Size(936, 197);
            this.lvwNhanvien.TabIndex = 16;
            this.lvwNhanvien.UseCompatibleStateImageBehavior = false;
            this.lvwNhanvien.View = System.Windows.Forms.View.Details;
            // 
            // colTen
            // 
            this.colTen.Text = "Tên";
            this.colTen.Width = 146;
            // 
            // colMaNV
            // 
            this.colMaNV.Text = "Mã NV";
            this.colMaNV.Width = 112;
            // 
            // colPhai
            // 
            this.colPhai.Text = "Phái";
            this.colPhai.Width = 105;
            // 
            // colNgaysinh
            // 
            this.colNgaysinh.Text = "Ngày Sinh";
            this.colNgaysinh.Width = 130;
            // 
            // colChucVu
            // 
            this.colChucVu.Text = "Chức vụ";
            this.colChucVu.Width = 163;
            // 
            // colCMND
            // 
            this.colCMND.Text = "CMND";
            this.colCMND.Width = 346;
            // 
            // lblDanhsachNhanvien
            // 
            this.lblDanhsachNhanvien.AutoSize = true;
            this.lblDanhsachNhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhsachNhanvien.ForeColor = System.Drawing.Color.Maroon;
            this.lblDanhsachNhanvien.Location = new System.Drawing.Point(20, 300);
            this.lblDanhsachNhanvien.Name = "lblDanhsachNhanvien";
            this.lblDanhsachNhanvien.Size = new System.Drawing.Size(207, 24);
            this.lblDanhsachNhanvien.TabIndex = 17;
            this.lblDanhsachNhanvien.Text = "Danh sách nhân viên";
            // 
            // grbNhanvien
            // 
            this.grbNhanvien.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.grbNhanvien.Controls.Add(this.comboBox1);
            this.grbNhanvien.Controls.Add(this.txtMS);
            this.grbNhanvien.Controls.Add(this.txtCMND);
            this.grbNhanvien.Controls.Add(this.lblMaSo);
            this.grbNhanvien.Controls.Add(this.lblNgaySinh);
            this.grbNhanvien.Controls.Add(this.dtpNgaySinh);
            this.grbNhanvien.Controls.Add(this.label3);
            this.grbNhanvien.Controls.Add(this.rdbNu);
            this.grbNhanvien.Controls.Add(this.label2);
            this.grbNhanvien.Controls.Add(this.rdbNam);
            this.grbNhanvien.Controls.Add(this.txtChucvu);
            this.grbNhanvien.Controls.Add(this.label1);
            this.grbNhanvien.Controls.Add(this.txtTen);
            this.grbNhanvien.Controls.Add(this.lblTenNV);
            this.grbNhanvien.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grbNhanvien.Location = new System.Drawing.Point(24, 13);
            this.grbNhanvien.Name = "grbNhanvien";
            this.grbNhanvien.Size = new System.Drawing.Size(461, 241);
            this.grbNhanvien.TabIndex = 0;
            this.grbNhanvien.TabStop = false;
            this.grbNhanvien.Text = "Thông tin nhân viên";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(92, 99);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 22);
            this.comboBox1.TabIndex = 14;
            // 
            // bntXoaNv
            // 
            this.bntXoaNv.Location = new System.Drawing.Point(689, 127);
            this.bntXoaNv.Name = "bntXoaNv";
            this.bntXoaNv.Size = new System.Drawing.Size(110, 47);
            this.bntXoaNv.TabIndex = 19;
            this.bntXoaNv.Text = "Xóa";
            this.bntXoaNv.UseVisualStyleBackColor = true;
            this.bntXoaNv.Click += new System.EventHandler(this.bntXoaNv_Click);
            // 
            // bntCapNhat
            // 
            this.bntCapNhat.Location = new System.Drawing.Point(689, 66);
            this.bntCapNhat.Name = "bntCapNhat";
            this.bntCapNhat.Size = new System.Drawing.Size(110, 55);
            this.bntCapNhat.TabIndex = 20;
            this.bntCapNhat.Text = "CẬP NHẬT";
            this.bntCapNhat.UseVisualStyleBackColor = true;
            // 
            // bntThoat
            // 
            this.bntThoat.Location = new System.Drawing.Point(689, 181);
            this.bntThoat.Name = "bntThoat";
            this.bntThoat.Size = new System.Drawing.Size(110, 45);
            this.bntThoat.TabIndex = 21;
            this.bntThoat.Text = "Thoát";
            this.bntThoat.UseVisualStyleBackColor = true;
            // 
            // dgvDSNhanVien
            // 
            this.dgvDSNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSNhanVien.Location = new System.Drawing.Point(14, 341);
            this.dgvDSNhanVien.Name = "dgvDSNhanVien";
            this.dgvDSNhanVien.Size = new System.Drawing.Size(936, 182);
            this.dgvDSNhanVien.TabIndex = 22;
            // 
            // frmNhanVien
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 551);
            this.Controls.Add(this.dgvDSNhanVien);
            this.Controls.Add(this.bntThoat);
            this.Controls.Add(this.bntCapNhat);
            this.Controls.Add(this.bntXoaNv);
            this.Controls.Add(this.grbNhanvien);
            this.Controls.Add(this.lblDanhsachNhanvien);
            this.Controls.Add(this.lvwNhanvien);
            this.Controls.Add(this.bntThem);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "frmNhanVien";
            this.Text = "Quản lí Nhân Viên";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            this.grbNhanvien.ResumeLayout(false);
            this.grbNhanvien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.Button bntThem;
        private System.Windows.Forms.Label lblMaSo;
        private System.Windows.Forms.TextBox txtMS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtChucvu;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.ListView lvwNhanvien;
        private System.Windows.Forms.ColumnHeader colTen;
        private System.Windows.Forms.ColumnHeader colMaNV;
        private System.Windows.Forms.ColumnHeader colPhai;
        private System.Windows.Forms.ColumnHeader colNgaysinh;
        private System.Windows.Forms.ColumnHeader colChucVu;
        private System.Windows.Forms.ColumnHeader colCMND;
        private System.Windows.Forms.Label lblDanhsachNhanvien;
        private System.Windows.Forms.GroupBox grbNhanvien;
        private System.Windows.Forms.Button bntXoaNv;
        private System.Windows.Forms.Button bntCapNhat;
        private System.Windows.Forms.Button bntThoat;
        private System.Windows.Forms.DataGridView dgvDSNhanVien;
        private System.Windows.Forms.ComboBox comboBox1;

        private void bntThem_Click(object sender, System.EventArgs e)
        {

        }
    }
}


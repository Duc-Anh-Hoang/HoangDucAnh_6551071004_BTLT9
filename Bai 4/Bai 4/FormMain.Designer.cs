namespace Bai_4;

partial class FormMain
{
    private System.ComponentModel.IContainer components = null;

    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabBanHang;
    private System.Windows.Forms.TabPage tabThucDon;
    private System.Windows.Forms.TabPage tabHoaDon;

    // Tab Ban Hang
    private System.Windows.Forms.GroupBox grpChonMon;
    private System.Windows.Forms.Label lblDanhMucBanHang;
    private System.Windows.Forms.ComboBox cboBanHangDanhMuc;
    private System.Windows.Forms.ListBox lstMonUong;
    private System.Windows.Forms.Label lblSoLy;
    private System.Windows.Forms.NumericUpDown nudSoLy;
    private System.Windows.Forms.Button btnThemVaoDon;

    private System.Windows.Forms.GroupBox grpDonHienTai;
    private System.Windows.Forms.DataGridView dgvGioHang;
    private System.Windows.Forms.Button btnXoaDong;
    private System.Windows.Forms.Label lblTongTien;

    private System.Windows.Forms.GroupBox grpThanhToan;
    private System.Windows.Forms.Button btnThanhToanChuyenKhoan;
    private System.Windows.Forms.Button btnTienMat;
    private System.Windows.Forms.PictureBox picVietQR;
    private System.Windows.Forms.Label lblQRThongTin;
    private System.Windows.Forms.Button btnDaNhanTien;

    // Tab Thuc Don
    private System.Windows.Forms.GroupBox grpThongTinMon;
    private System.Windows.Forms.Label lblTenMon;
    private System.Windows.Forms.TextBox txtTenMon;
    private System.Windows.Forms.Label lblDanhMucThucDon;
    private System.Windows.Forms.ComboBox cboDanhMucThucDon;
    private System.Windows.Forms.Label lblGiaBan;
    private System.Windows.Forms.NumericUpDown nudGiaBan;
    private System.Windows.Forms.CheckBox chkDangBan;
    private System.Windows.Forms.Button btnThemMon;
    private System.Windows.Forms.Button btnSuaMon;
    private System.Windows.Forms.Button btnXoaMon;
    private System.Windows.Forms.Button btnLamMoiMon;

    private System.Windows.Forms.GroupBox grpTimThucDon;
    private System.Windows.Forms.TextBox txtTimTenMon;
    private System.Windows.Forms.ComboBox cboLocDanhMuc;
    private System.Windows.Forms.Button btnTimMon;

    private System.Windows.Forms.DataGridView dgvThucDon;

    // Tab Hoa Don
    private System.Windows.Forms.Panel pnlLocHoaDon;
    private System.Windows.Forms.Label lblChonNgayHD;
    private System.Windows.Forms.DateTimePicker dtpLocNgayHD;
    private System.Windows.Forms.Button btnLocHD;
    private System.Windows.Forms.Label lblDoanhThuNgay;

    private System.Windows.Forms.SplitContainer splitContainerHD;
    private System.Windows.Forms.DataGridView dgvHoaDon;
    private System.Windows.Forms.DataGridView dgvChiTietHD;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        this.tabControl1 = new System.Windows.Forms.TabControl();
        this.tabBanHang = new System.Windows.Forms.TabPage();
        this.grpChonMon = new System.Windows.Forms.GroupBox();
        this.lblDanhMucBanHang = new System.Windows.Forms.Label();
        this.cboBanHangDanhMuc = new System.Windows.Forms.ComboBox();
        this.lstMonUong = new System.Windows.Forms.ListBox();
        this.lblSoLy = new System.Windows.Forms.Label();
        this.nudSoLy = new System.Windows.Forms.NumericUpDown();
        this.btnThemVaoDon = new System.Windows.Forms.Button();

        this.grpDonHienTai = new System.Windows.Forms.GroupBox();
        this.dgvGioHang = new System.Windows.Forms.DataGridView();
        this.btnXoaDong = new System.Windows.Forms.Button();
        this.lblTongTien = new System.Windows.Forms.Label();

        this.grpThanhToan = new System.Windows.Forms.GroupBox();
        this.btnThanhToanChuyenKhoan = new System.Windows.Forms.Button();
        this.btnTienMat = new System.Windows.Forms.Button();
        this.picVietQR = new System.Windows.Forms.PictureBox();
        this.lblQRThongTin = new System.Windows.Forms.Label();
        this.btnDaNhanTien = new System.Windows.Forms.Button();

        this.tabThucDon = new System.Windows.Forms.TabPage();
        this.grpThongTinMon = new System.Windows.Forms.GroupBox();
        this.lblTenMon = new System.Windows.Forms.Label();
        this.txtTenMon = new System.Windows.Forms.TextBox();
        this.lblDanhMucThucDon = new System.Windows.Forms.Label();
        this.cboDanhMucThucDon = new System.Windows.Forms.ComboBox();
        this.lblGiaBan = new System.Windows.Forms.Label();
        this.nudGiaBan = new System.Windows.Forms.NumericUpDown();
        this.chkDangBan = new System.Windows.Forms.CheckBox();
        this.btnThemMon = new System.Windows.Forms.Button();
        this.btnSuaMon = new System.Windows.Forms.Button();
        this.btnXoaMon = new System.Windows.Forms.Button();
        this.btnLamMoiMon = new System.Windows.Forms.Button();

        this.grpTimThucDon = new System.Windows.Forms.GroupBox();
        this.txtTimTenMon = new System.Windows.Forms.TextBox();
        this.cboLocDanhMuc = new System.Windows.Forms.ComboBox();
        this.btnTimMon = new System.Windows.Forms.Button();
        this.dgvThucDon = new System.Windows.Forms.DataGridView();

        this.tabHoaDon = new System.Windows.Forms.TabPage();
        this.pnlLocHoaDon = new System.Windows.Forms.Panel();
        this.lblChonNgayHD = new System.Windows.Forms.Label();
        this.dtpLocNgayHD = new System.Windows.Forms.DateTimePicker();
        this.btnLocHD = new System.Windows.Forms.Button();
        this.lblDoanhThuNgay = new System.Windows.Forms.Label();
        this.splitContainerHD = new System.Windows.Forms.SplitContainer();
        this.dgvHoaDon = new System.Windows.Forms.DataGridView();
        this.dgvChiTietHD = new System.Windows.Forms.DataGridView();

        this.tabControl1.SuspendLayout();
        this.tabBanHang.SuspendLayout();
        this.grpChonMon.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.nudSoLy)).BeginInit();
        this.grpDonHienTai.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).BeginInit();
        this.grpThanhToan.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.picVietQR)).BeginInit();
        this.tabThucDon.SuspendLayout();
        this.grpThongTinMon.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.nudGiaBan)).BeginInit();
        this.grpTimThucDon.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvThucDon)).BeginInit();
        this.tabHoaDon.SuspendLayout();
        this.pnlLocHoaDon.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.splitContainerHD)).BeginInit();
        this.splitContainerHD.Panel1.SuspendLayout();
        this.splitContainerHD.Panel2.SuspendLayout();
        this.splitContainerHD.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHD)).BeginInit();
        this.SuspendLayout();

        // 
        // tabControl1
        // 
        this.tabControl1.Controls.Add(this.tabBanHang);
        this.tabControl1.Controls.Add(this.tabThucDon);
        this.tabControl1.Controls.Add(this.tabHoaDon);
        this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.tabControl1.Location = new System.Drawing.Point(0, 0);
        this.tabControl1.Name = "tabControl1";
        this.tabControl1.SelectedIndex = 0;
        this.tabControl1.Size = new System.Drawing.Size(984, 611);
        this.tabControl1.TabIndex = 0;

        // 
        // tabBanHang
        // 
        this.tabBanHang.Controls.Add(this.grpThanhToan);
        this.tabBanHang.Controls.Add(this.grpDonHienTai);
        this.tabBanHang.Controls.Add(this.grpChonMon);
        this.tabBanHang.Location = new System.Drawing.Point(4, 24);
        this.tabBanHang.Name = "tabBanHang";
        this.tabBanHang.Padding = new System.Windows.Forms.Padding(3);
        this.tabBanHang.Size = new System.Drawing.Size(976, 583);
        this.tabBanHang.TabIndex = 0;
        this.tabBanHang.Text = "Bán hàng - Quán trà sữa";
        this.tabBanHang.UseVisualStyleBackColor = true;

        // 
        // grpChonMon
        // 
        this.grpChonMon.Controls.Add(this.btnThemVaoDon);
        this.grpChonMon.Controls.Add(this.nudSoLy);
        this.grpChonMon.Controls.Add(this.lblSoLy);
        this.grpChonMon.Controls.Add(this.lstMonUong);
        this.grpChonMon.Controls.Add(this.cboBanHangDanhMuc);
        this.grpChonMon.Controls.Add(this.lblDanhMucBanHang);
        this.grpChonMon.Location = new System.Drawing.Point(8, 10);
        this.grpChonMon.Name = "grpChonMon";
        this.grpChonMon.Size = new System.Drawing.Size(260, 565);
        this.grpChonMon.TabIndex = 0;
        this.grpChonMon.TabStop = false;
        this.grpChonMon.Text = "Chọn món";

        // lblDanhMucBanHang
        this.lblDanhMucBanHang.AutoSize = true;
        this.lblDanhMucBanHang.Location = new System.Drawing.Point(10, 25);
        this.lblDanhMucBanHang.Name = "lblDanhMucBanHang";
        this.lblDanhMucBanHang.Size = new System.Drawing.Size(65, 15);
        this.lblDanhMucBanHang.Text = "Danh mục:";

        // cboBanHangDanhMuc
        this.cboBanHangDanhMuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cboBanHangDanhMuc.FormattingEnabled = true;
        this.cboBanHangDanhMuc.Location = new System.Drawing.Point(10, 45);
        this.cboBanHangDanhMuc.Name = "cboBanHangDanhMuc";
        this.cboBanHangDanhMuc.Size = new System.Drawing.Size(240, 23);
        this.cboBanHangDanhMuc.TabIndex = 1;
        this.cboBanHangDanhMuc.SelectedIndexChanged += new System.EventHandler(this.cboBanHangDanhMuc_SelectedIndexChanged);

        // lstMonUong
        this.lstMonUong.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.lstMonUong.FormattingEnabled = true;
        this.lstMonUong.ItemHeight = 17;
        this.lstMonUong.Location = new System.Drawing.Point(10, 80);
        this.lstMonUong.Name = "lstMonUong";
        this.lstMonUong.Size = new System.Drawing.Size(240, 395);
        this.lstMonUong.TabIndex = 2;

        // lblSoLy
        this.lblSoLy.AutoSize = true;
        this.lblSoLy.Location = new System.Drawing.Point(10, 490);
        this.lblSoLy.Name = "lblSoLy";
        this.lblSoLy.Size = new System.Drawing.Size(35, 15);
        this.lblSoLy.Text = "Số ly:";

        // nudSoLy
        this.nudSoLy.Location = new System.Drawing.Point(55, 487);
        this.nudSoLy.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        this.nudSoLy.Name = "nudSoLy";
        this.nudSoLy.Size = new System.Drawing.Size(195, 23);
        this.nudSoLy.TabIndex = 4;
        this.nudSoLy.Value = new decimal(new int[] { 1, 0, 0, 0 });

        // btnThemVaoDon
        this.btnThemVaoDon.Location = new System.Drawing.Point(10, 520);
        this.btnThemVaoDon.Name = "btnThemVaoDon";
        this.btnThemVaoDon.Size = new System.Drawing.Size(240, 35);
        this.btnThemVaoDon.TabIndex = 5;
        this.btnThemVaoDon.Text = "Thêm vào đơn";
        this.btnThemVaoDon.UseVisualStyleBackColor = true;
        this.btnThemVaoDon.Click += new System.EventHandler(this.btnThemVaoDon_Click);

        // 
        // grpDonHienTai
        // 
        this.grpDonHienTai.Controls.Add(this.lblTongTien);
        this.grpDonHienTai.Controls.Add(this.btnXoaDong);
        this.grpDonHienTai.Controls.Add(this.dgvGioHang);
        this.grpDonHienTai.Location = new System.Drawing.Point(275, 10);
        this.grpDonHienTai.Name = "grpDonHienTai";
        this.grpDonHienTai.Size = new System.Drawing.Size(430, 565);
        this.grpDonHienTai.TabIndex = 1;
        this.grpDonHienTai.TabStop = false;
        this.grpDonHienTai.Text = "Đơn hiện tại";

        // dgvGioHang
        this.dgvGioHang.AllowUserToAddRows = false;
        this.dgvGioHang.AllowUserToDeleteRows = false;
        this.dgvGioHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        this.dgvGioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvGioHang.Location = new System.Drawing.Point(10, 22);
        this.dgvGioHang.MultiSelect = false;
        this.dgvGioHang.Name = "dgvGioHang";
        this.dgvGioHang.ReadOnly = true;
        this.dgvGioHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dgvGioHang.Size = new System.Drawing.Size(410, 453);
        this.dgvGioHang.TabIndex = 0;

        // btnXoaDong
        this.btnXoaDong.Location = new System.Drawing.Point(10, 485);
        this.btnXoaDong.Name = "btnXoaDong";
        this.btnXoaDong.Size = new System.Drawing.Size(120, 30);
        this.btnXoaDong.TabIndex = 1;
        this.btnXoaDong.Text = "Xóa dòng";
        this.btnXoaDong.UseVisualStyleBackColor = true;
        this.btnXoaDong.Click += new System.EventHandler(this.btnXoaDong_Click);

        // lblTongTien
        this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblTongTien.ForeColor = System.Drawing.Color.DarkBlue;
        this.lblTongTien.Location = new System.Drawing.Point(10, 520);
        this.lblTongTien.Name = "lblTongTien";
        this.lblTongTien.Size = new System.Drawing.Size(410, 35);
        this.lblTongTien.TabIndex = 2;
        this.lblTongTien.Text = "Tổng tiền: 0 đ";
        this.lblTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

        // 
        // grpThanhToan
        // 
        this.grpThanhToan.Controls.Add(this.btnDaNhanTien);
        this.grpThanhToan.Controls.Add(this.lblQRThongTin);
        this.grpThanhToan.Controls.Add(this.picVietQR);
        this.grpThanhToan.Controls.Add(this.btnTienMat);
        this.grpThanhToan.Controls.Add(this.btnThanhToanChuyenKhoan);
        this.grpThanhToan.Location = new System.Drawing.Point(715, 10);
        this.grpThanhToan.Name = "grpThanhToan";
        this.grpThanhToan.Size = new System.Drawing.Size(250, 565);
        this.grpThanhToan.TabIndex = 2;
        this.grpThanhToan.TabStop = false;
        this.grpThanhToan.Text = "Thanh toán";

        // btnThanhToanChuyenKhoan
        this.btnThanhToanChuyenKhoan.BackColor = System.Drawing.Color.LightSkyBlue;
        this.btnThanhToanChuyenKhoan.Location = new System.Drawing.Point(10, 22);
        this.btnThanhToanChuyenKhoan.Name = "btnThanhToanChuyenKhoan";
        this.btnThanhToanChuyenKhoan.Size = new System.Drawing.Size(230, 32);
        this.btnThanhToanChuyenKhoan.TabIndex = 0;
        this.btnThanhToanChuyenKhoan.Text = "Thanh toán chuyển khoản";
        this.btnThanhToanChuyenKhoan.UseVisualStyleBackColor = false;
        this.btnThanhToanChuyenKhoan.Click += new System.EventHandler(this.btnThanhToanChuyenKhoan_Click);

        // btnTienMat
        this.btnTienMat.Location = new System.Drawing.Point(10, 60);
        this.btnTienMat.Name = "btnTienMat";
        this.btnTienMat.Size = new System.Drawing.Size(230, 30);
        this.btnTienMat.TabIndex = 1;
        this.btnTienMat.Text = "Tiền mặt (Lưu không cần QR)";
        this.btnTienMat.UseVisualStyleBackColor = true;
        this.btnTienMat.Click += new System.EventHandler(this.btnTienMat_Click);

        // picVietQR
        this.picVietQR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.picVietQR.Location = new System.Drawing.Point(10, 98);
        this.picVietQR.Name = "picVietQR";
        this.picVietQR.Size = new System.Drawing.Size(230, 230);
        this.picVietQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        this.picVietQR.TabIndex = 2;
        this.picVietQR.TabStop = false;

        // lblQRThongTin
        this.lblQRThongTin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.lblQRThongTin.Location = new System.Drawing.Point(10, 335);
        this.lblQRThongTin.Name = "lblQRThongTin";
        this.lblQRThongTin.Size = new System.Drawing.Size(230, 160);
        this.lblQRThongTin.TabIndex = 3;
        this.lblQRThongTin.Text = "Số tiền: 0 đ\r\nNội dung: --\r\nChủ TK: --\r\nSTK: --";

        // btnDaNhanTien
        this.btnDaNhanTien.BackColor = System.Drawing.Color.ForestGreen;
        this.btnDaNhanTien.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnDaNhanTien.ForeColor = System.Drawing.Color.White;
        this.btnDaNhanTien.Location = new System.Drawing.Point(10, 510);
        this.btnDaNhanTien.Name = "btnDaNhanTien";
        this.btnDaNhanTien.Size = new System.Drawing.Size(230, 45);
        this.btnDaNhanTien.TabIndex = 4;
        this.btnDaNhanTien.Text = "Đã nhận tiền";
        this.btnDaNhanTien.UseVisualStyleBackColor = false;
        this.btnDaNhanTien.Click += new System.EventHandler(this.btnDaNhanTien_Click);

        // 
        // tabThucDon
        // 
        this.tabThucDon.Controls.Add(this.dgvThucDon);
        this.tabThucDon.Controls.Add(this.grpTimThucDon);
        this.tabThucDon.Controls.Add(this.grpThongTinMon);
        this.tabThucDon.Location = new System.Drawing.Point(4, 24);
        this.tabThucDon.Name = "tabThucDon";
        this.tabThucDon.Padding = new System.Windows.Forms.Padding(3);
        this.tabThucDon.Size = new System.Drawing.Size(976, 583);
        this.tabThucDon.TabIndex = 1;
        this.tabThucDon.Text = "Quản lý thực đơn";
        this.tabThucDon.UseVisualStyleBackColor = true;

        // grpThongTinMon
        this.grpThongTinMon.Controls.Add(this.btnLamMoiMon);
        this.grpThongTinMon.Controls.Add(this.btnXoaMon);
        this.grpThongTinMon.Controls.Add(this.btnSuaMon);
        this.grpThongTinMon.Controls.Add(this.btnThemMon);
        this.grpThongTinMon.Controls.Add(this.chkDangBan);
        this.grpThongTinMon.Controls.Add(this.lblGiaBan);
        this.grpThongTinMon.Controls.Add(this.nudGiaBan);
        this.grpThongTinMon.Controls.Add(this.lblDanhMucThucDon);
        this.grpThongTinMon.Controls.Add(this.cboDanhMucThucDon);
        this.grpThongTinMon.Controls.Add(this.lblTenMon);
        this.grpThongTinMon.Controls.Add(this.txtTenMon);
        this.grpThongTinMon.Location = new System.Drawing.Point(10, 10);
        this.grpThongTinMon.Name = "grpThongTinMon";
        this.grpThongTinMon.Size = new System.Drawing.Size(950, 115);
        this.grpThongTinMon.TabIndex = 0;
        this.grpThongTinMon.TabStop = false;
        this.grpThongTinMon.Text = "Thông tin món";

        // lblTenMon
        this.lblTenMon.AutoSize = true;
        this.lblTenMon.Location = new System.Drawing.Point(15, 25);
        this.lblTenMon.Name = "lblTenMon";
        this.lblTenMon.Size = new System.Drawing.Size(56, 15);
        this.lblTenMon.Text = "Tên món:";

        // txtTenMon
        this.txtTenMon.Location = new System.Drawing.Point(85, 22);
        this.txtTenMon.Name = "txtTenMon";
        this.txtTenMon.Size = new System.Drawing.Size(200, 23);
        this.txtTenMon.TabIndex = 0;

        // lblDanhMucThucDon
        this.lblDanhMucThucDon.AutoSize = true;
        this.lblDanhMucThucDon.Location = new System.Drawing.Point(305, 25);
        this.lblDanhMucThucDon.Name = "lblDanhMucThucDon";
        this.lblDanhMucThucDon.Size = new System.Drawing.Size(65, 15);
        this.lblDanhMucThucDon.Text = "Danh mục:";

        // cboDanhMucThucDon
        this.cboDanhMucThucDon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cboDanhMucThucDon.FormattingEnabled = true;
        this.cboDanhMucThucDon.Location = new System.Drawing.Point(375, 22);
        this.cboDanhMucThucDon.Name = "cboDanhMucThucDon";
        this.cboDanhMucThucDon.Size = new System.Drawing.Size(180, 23);
        this.cboDanhMucThucDon.TabIndex = 1;

        // lblGiaBan
        this.lblGiaBan.AutoSize = true;
        this.lblGiaBan.Location = new System.Drawing.Point(575, 25);
        this.lblGiaBan.Name = "lblGiaBan";
        this.lblGiaBan.Size = new System.Drawing.Size(50, 15);
        this.lblGiaBan.Text = "Giá bán:";

        // nudGiaBan
        this.nudGiaBan.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
        this.nudGiaBan.Location = new System.Drawing.Point(630, 22);
        this.nudGiaBan.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
        this.nudGiaBan.Name = "nudGiaBan";
        this.nudGiaBan.Size = new System.Drawing.Size(150, 23);
        this.nudGiaBan.ThousandsSeparator = true;
        this.nudGiaBan.TabIndex = 2;

        // chkDangBan
        this.chkDangBan.AutoSize = true;
        this.chkDangBan.Checked = true;
        this.chkDangBan.CheckState = System.Windows.Forms.CheckState.Checked;
        this.chkDangBan.Location = new System.Drawing.Point(800, 24);
        this.chkDangBan.Name = "chkDangBan";
        this.chkDangBan.Size = new System.Drawing.Size(77, 19);
        this.chkDangBan.TabIndex = 3;
        this.chkDangBan.Text = "Đang bán";
        this.chkDangBan.UseVisualStyleBackColor = true;

        // btnThemMon
        this.btnThemMon.Location = new System.Drawing.Point(85, 65);
        this.btnThemMon.Name = "btnThemMon";
        this.btnThemMon.Size = new System.Drawing.Size(85, 30);
        this.btnThemMon.TabIndex = 4;
        this.btnThemMon.Text = "Thêm";
        this.btnThemMon.UseVisualStyleBackColor = true;
        this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);

        // btnSuaMon
        this.btnSuaMon.Location = new System.Drawing.Point(185, 65);
        this.btnSuaMon.Name = "btnSuaMon";
        this.btnSuaMon.Size = new System.Drawing.Size(85, 30);
        this.btnSuaMon.TabIndex = 5;
        this.btnSuaMon.Text = "Sửa";
        this.btnSuaMon.UseVisualStyleBackColor = true;
        this.btnSuaMon.Click += new System.EventHandler(this.btnSuaMon_Click);

        // btnXoaMon
        this.btnXoaMon.Location = new System.Drawing.Point(285, 65);
        this.btnXoaMon.Name = "btnXoaMon";
        this.btnXoaMon.Size = new System.Drawing.Size(85, 30);
        this.btnXoaMon.TabIndex = 6;
        this.btnXoaMon.Text = "Xóa";
        this.btnXoaMon.UseVisualStyleBackColor = true;
        this.btnXoaMon.Click += new System.EventHandler(this.btnXoaMon_Click);

        // btnLamMoiMon
        this.btnLamMoiMon.Location = new System.Drawing.Point(385, 65);
        this.btnLamMoiMon.Name = "btnLamMoiMon";
        this.btnLamMoiMon.Size = new System.Drawing.Size(85, 30);
        this.btnLamMoiMon.TabIndex = 7;
        this.btnLamMoiMon.Text = "Làm mới";
        this.btnLamMoiMon.UseVisualStyleBackColor = true;
        this.btnLamMoiMon.Click += new System.EventHandler(this.btnLamMoiMon_Click);

        // grpTimThucDon
        this.grpTimThucDon.Controls.Add(this.btnTimMon);
        this.grpTimThucDon.Controls.Add(this.cboLocDanhMuc);
        this.grpTimThucDon.Controls.Add(this.txtTimTenMon);
        this.grpTimThucDon.Location = new System.Drawing.Point(10, 135);
        this.grpTimThucDon.Name = "grpTimThucDon";
        this.grpTimThucDon.Size = new System.Drawing.Size(950, 55);
        this.grpTimThucDon.TabIndex = 1;
        this.grpTimThucDon.TabStop = false;
        this.grpTimThucDon.Text = "Tìm kiếm & Lọc";

        // txtTimTenMon
        this.txtTimTenMon.Location = new System.Drawing.Point(15, 20);
        this.txtTimTenMon.Name = "txtTimTenMon";
        this.txtTimTenMon.PlaceholderText = "Tìm theo tên món...";
        this.txtTimTenMon.Size = new System.Drawing.Size(250, 23);
        this.txtTimTenMon.TabIndex = 0;

        // cboLocDanhMuc
        this.cboLocDanhMuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cboLocDanhMuc.FormattingEnabled = true;
        this.cboLocDanhMuc.Location = new System.Drawing.Point(280, 20);
        this.cboLocDanhMuc.Name = "cboLocDanhMuc";
        this.cboLocDanhMuc.Size = new System.Drawing.Size(200, 23);
        this.cboLocDanhMuc.TabIndex = 1;

        // btnTimMon
        this.btnTimMon.Location = new System.Drawing.Point(495, 19);
        this.btnTimMon.Name = "btnTimMon";
        this.btnTimMon.Size = new System.Drawing.Size(80, 26);
        this.btnTimMon.TabIndex = 2;
        this.btnTimMon.Text = "Tìm kiếm";
        this.btnTimMon.UseVisualStyleBackColor = true;
        this.btnTimMon.Click += new System.EventHandler(this.btnTimMon_Click);

        // dgvThucDon
        this.dgvThucDon.AllowUserToAddRows = false;
        this.dgvThucDon.AllowUserToDeleteRows = false;
        this.dgvThucDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        this.dgvThucDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvThucDon.Location = new System.Drawing.Point(10, 200);
        this.dgvThucDon.MultiSelect = false;
        this.dgvThucDon.Name = "dgvThucDon";
        this.dgvThucDon.ReadOnly = true;
        this.dgvThucDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dgvThucDon.Size = new System.Drawing.Size(950, 365);
        this.dgvThucDon.TabIndex = 2;
        this.dgvThucDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThucDon_CellClick);

        // 
        // tabHoaDon
        // 
        this.tabHoaDon.Controls.Add(this.splitContainerHD);
        this.tabHoaDon.Controls.Add(this.pnlLocHoaDon);
        this.tabHoaDon.Location = new System.Drawing.Point(4, 24);
        this.tabHoaDon.Name = "tabHoaDon";
        this.tabHoaDon.Padding = new System.Windows.Forms.Padding(3);
        this.tabHoaDon.Size = new System.Drawing.Size(976, 583);
        this.tabHoaDon.TabIndex = 2;
        this.tabHoaDon.Text = "Lịch sử hóa đơn";
        this.tabHoaDon.UseVisualStyleBackColor = true;

        // pnlLocHoaDon
        this.pnlLocHoaDon.Controls.Add(this.lblDoanhThuNgay);
        this.pnlLocHoaDon.Controls.Add(this.btnLocHD);
        this.pnlLocHoaDon.Controls.Add(this.dtpLocNgayHD);
        this.pnlLocHoaDon.Controls.Add(this.lblChonNgayHD);
        this.pnlLocHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
        this.pnlLocHoaDon.Location = new System.Drawing.Point(3, 3);
        this.pnlLocHoaDon.Name = "pnlLocHoaDon";
        this.pnlLocHoaDon.Size = new System.Drawing.Size(970, 50);
        this.pnlLocHoaDon.TabIndex = 0;

        // lblChonNgayHD
        this.lblChonNgayHD.AutoSize = true;
        this.lblChonNgayHD.Location = new System.Drawing.Point(15, 18);
        this.lblChonNgayHD.Name = "lblChonNgayHD";
        this.lblChonNgayHD.Size = new System.Drawing.Size(68, 15);
        this.lblChonNgayHD.Text = "Chọn ngày:";

        // dtpLocNgayHD
        this.dtpLocNgayHD.CustomFormat = "dd/MM/yyyy";
        this.dtpLocNgayHD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        this.dtpLocNgayHD.Location = new System.Drawing.Point(90, 15);
        this.dtpLocNgayHD.Name = "dtpLocNgayHD";
        this.dtpLocNgayHD.Size = new System.Drawing.Size(120, 23);
        this.dtpLocNgayHD.TabIndex = 0;

        // btnLocHD
        this.btnLocHD.Location = new System.Drawing.Point(220, 13);
        this.btnLocHD.Name = "btnLocHD";
        this.btnLocHD.Size = new System.Drawing.Size(90, 26);
        this.btnLocHD.TabIndex = 1;
        this.btnLocHD.Text = "Lọc hóa đơn";
        this.btnLocHD.UseVisualStyleBackColor = true;
        this.btnLocHD.Click += new System.EventHandler(this.btnLocHD_Click);

        // lblDoanhThuNgay
        this.lblDoanhThuNgay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblDoanhThuNgay.ForeColor = System.Drawing.Color.Red;
        this.lblDoanhThuNgay.Location = new System.Drawing.Point(450, 10);
        this.lblDoanhThuNgay.Name = "lblDoanhThuNgay";
        this.lblDoanhThuNgay.Size = new System.Drawing.Size(500, 30);
        this.lblDoanhThuNgay.TabIndex = 2;
        this.lblDoanhThuNgay.Text = "Doanh thu ngày: 0 đ";
        this.lblDoanhThuNgay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

        // splitContainerHD
        this.splitContainerHD.Dock = System.Windows.Forms.DockStyle.Fill;
        this.splitContainerHD.Location = new System.Drawing.Point(3, 53);
        this.splitContainerHD.Name = "splitContainerHD";
        this.splitContainerHD.Orientation = System.Windows.Forms.Orientation.Horizontal;

        // splitContainerHD.Panel1
        this.splitContainerHD.Panel1.Controls.Add(this.dgvHoaDon);
        // splitContainerHD.Panel2
        this.splitContainerHD.Panel2.Controls.Add(this.dgvChiTietHD);
        this.splitContainerHD.Size = new System.Drawing.Size(970, 527);
        this.splitContainerHD.SplitterDistance = 270;
        this.splitContainerHD.TabIndex = 1;

        // dgvHoaDon
        this.dgvHoaDon.AllowUserToAddRows = false;
        this.dgvHoaDon.AllowUserToDeleteRows = false;
        this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
        this.dgvHoaDon.Location = new System.Drawing.Point(0, 0);
        this.dgvHoaDon.MultiSelect = false;
        this.dgvHoaDon.Name = "dgvHoaDon";
        this.dgvHoaDon.ReadOnly = true;
        this.dgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dgvHoaDon.Size = new System.Drawing.Size(970, 270);
        this.dgvHoaDon.TabIndex = 0;
        this.dgvHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellClick);

        // dgvChiTietHD
        this.dgvChiTietHD.AllowUserToAddRows = false;
        this.dgvChiTietHD.AllowUserToDeleteRows = false;
        this.dgvChiTietHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        this.dgvChiTietHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvChiTietHD.Dock = System.Windows.Forms.DockStyle.Fill;
        this.dgvChiTietHD.Location = new System.Drawing.Point(0, 0);
        this.dgvChiTietHD.MultiSelect = false;
        this.dgvChiTietHD.Name = "dgvChiTietHD";
        this.dgvChiTietHD.ReadOnly = true;
        this.dgvChiTietHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dgvChiTietHD.Size = new System.Drawing.Size(970, 253);
        this.dgvChiTietHD.TabIndex = 0;

        // 
        // FormMain
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(984, 611);
        this.Controls.Add(this.tabControl1);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.MaximizeBox = false;
        this.Name = "FormMain";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Hệ thống Quản lý Bán hàng Quán trà sữa";
        this.Load += new System.EventHandler(this.FormMain_Load);
        this.tabControl1.ResumeLayout(false);
        this.tabBanHang.ResumeLayout(false);
        this.grpChonMon.ResumeLayout(false);
        this.grpChonMon.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.nudSoLy)).EndInit();
        this.grpDonHienTai.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).EndInit();
        this.grpThanhToan.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.picVietQR)).EndInit();
        this.tabThucDon.ResumeLayout(false);
        this.grpThongTinMon.ResumeLayout(false);
        this.grpThongTinMon.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.nudGiaBan)).EndInit();
        this.grpTimThucDon.ResumeLayout(false);
        this.grpTimThucDon.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvThucDon)).EndInit();
        this.tabHoaDon.ResumeLayout(false);
        this.pnlLocHoaDon.ResumeLayout(false);
        this.pnlLocHoaDon.PerformLayout();
        this.splitContainerHD.Panel1.ResumeLayout(false);
        this.splitContainerHD.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.splitContainerHD)).EndInit();
        this.splitContainerHD.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHD)).EndInit();
        this.ResumeLayout(false);
    }
}

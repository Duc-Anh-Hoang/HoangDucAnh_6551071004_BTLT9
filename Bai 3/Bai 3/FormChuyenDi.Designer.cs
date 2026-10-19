namespace Bai_3;

partial class FormChuyenDi
{
    private System.ComponentModel.IContainer components = null;

    private System.Windows.Forms.Label lblNgonNgu;
    private System.Windows.Forms.ComboBox cboNgonNgu;

    private System.Windows.Forms.GroupBox grpThongTin;
    private System.Windows.Forms.Label lblTenChuyen;
    private System.Windows.Forms.TextBox txtTenChuyen;
    private System.Windows.Forms.Label lblDiaDiem;
    private System.Windows.Forms.TextBox txtDiaDiem;
    private System.Windows.Forms.Label lblNgayDi;
    private System.Windows.Forms.DateTimePicker dtpNgayDi;
    private System.Windows.Forms.Label lblSoNguoi;
    private System.Windows.Forms.NumericUpDown nudSoNguoi;
    private System.Windows.Forms.Label lblNganSach;
    private System.Windows.Forms.NumericUpDown nudNganSach;
    private System.Windows.Forms.Label lblPhuongTien;
    private System.Windows.Forms.ComboBox cboPhuongTien;
    private System.Windows.Forms.CheckBox chkDaHoanThanh;

    private System.Windows.Forms.Button btnThem;
    private System.Windows.Forms.Button btnSua;
    private System.Windows.Forms.Button btnXoa;
    private System.Windows.Forms.Button btnLamMoi;

    private System.Windows.Forms.GroupBox grpThoiTiet;
    private System.Windows.Forms.Button btnXemThoiTiet;
    private System.Windows.Forms.ProgressBar pbLoading;
    private System.Windows.Forms.Panel pnlThoiTietBox;
    private System.Windows.Forms.Label lblThoiTietTieuDe;
    private System.Windows.Forms.Label lblIconThoiTiet;
    private System.Windows.Forms.Label lblMoTaThoiTiet;
    private System.Windows.Forms.Label lblNhietDo;
    private System.Windows.Forms.Label lblKhaNangMua;
    private System.Windows.Forms.Label lblCanhBao;

    private System.Windows.Forms.GroupBox grpTimKiem;
    private System.Windows.Forms.TextBox txtTimDiaDiem;
    private System.Windows.Forms.CheckBox chkChuaHoanThanh;
    private System.Windows.Forms.Label lblTuNgay;
    private System.Windows.Forms.DateTimePicker dtpTuNgay;
    private System.Windows.Forms.Label lblDenNgay;
    private System.Windows.Forms.DateTimePicker dtpDenNgay;
    private System.Windows.Forms.Button btnTim;

    private System.Windows.Forms.DataGridView dgvChuyenDi;

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
        this.lblNgonNgu = new System.Windows.Forms.Label();
        this.cboNgonNgu = new System.Windows.Forms.ComboBox();

        this.grpThongTin = new System.Windows.Forms.GroupBox();
        this.lblTenChuyen = new System.Windows.Forms.Label();
        this.txtTenChuyen = new System.Windows.Forms.TextBox();
        this.lblDiaDiem = new System.Windows.Forms.Label();
        this.txtDiaDiem = new System.Windows.Forms.TextBox();
        this.lblNgayDi = new System.Windows.Forms.Label();
        this.dtpNgayDi = new System.Windows.Forms.DateTimePicker();
        this.lblSoNguoi = new System.Windows.Forms.Label();
        this.nudSoNguoi = new System.Windows.Forms.NumericUpDown();
        this.lblNganSach = new System.Windows.Forms.Label();
        this.nudNganSach = new System.Windows.Forms.NumericUpDown();
        this.lblPhuongTien = new System.Windows.Forms.Label();
        this.cboPhuongTien = new System.Windows.Forms.ComboBox();
        this.chkDaHoanThanh = new System.Windows.Forms.CheckBox();

        this.btnThem = new System.Windows.Forms.Button();
        this.btnSua = new System.Windows.Forms.Button();
        this.btnXoa = new System.Windows.Forms.Button();
        this.btnLamMoi = new System.Windows.Forms.Button();

        this.grpThoiTiet = new System.Windows.Forms.GroupBox();
        this.btnXemThoiTiet = new System.Windows.Forms.Button();
        this.pbLoading = new System.Windows.Forms.ProgressBar();
        this.pnlThoiTietBox = new System.Windows.Forms.Panel();
        this.lblThoiTietTieuDe = new System.Windows.Forms.Label();
        this.lblIconThoiTiet = new System.Windows.Forms.Label();
        this.lblMoTaThoiTiet = new System.Windows.Forms.Label();
        this.lblNhietDo = new System.Windows.Forms.Label();
        this.lblKhaNangMua = new System.Windows.Forms.Label();
        this.lblCanhBao = new System.Windows.Forms.Label();

        this.grpTimKiem = new System.Windows.Forms.GroupBox();
        this.txtTimDiaDiem = new System.Windows.Forms.TextBox();
        this.chkChuaHoanThanh = new System.Windows.Forms.CheckBox();
        this.lblTuNgay = new System.Windows.Forms.Label();
        this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
        this.lblDenNgay = new System.Windows.Forms.Label();
        this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
        this.btnTim = new System.Windows.Forms.Button();

        this.dgvChuyenDi = new System.Windows.Forms.DataGridView();

        this.grpThongTin.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.nudSoNguoi)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.nudNganSach)).BeginInit();
        this.grpThoiTiet.SuspendLayout();
        this.pnlThoiTietBox.SuspendLayout();
        this.grpTimKiem.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvChuyenDi)).BeginInit();
        this.SuspendLayout();

        // 
        // lblNgonNgu
        // 
        this.lblNgonNgu.AutoSize = true;
        this.lblNgonNgu.Location = new System.Drawing.Point(700, 15);
        this.lblNgonNgu.Name = "lblNgonNgu";
        this.lblNgonNgu.Size = new System.Drawing.Size(65, 15);
        this.lblNgonNgu.Text = "Ngôn ngữ:";

        // 
        // cboNgonNgu
        // 
        this.cboNgonNgu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cboNgonNgu.FormattingEnabled = true;
        this.cboNgonNgu.Items.AddRange(new object[] { "Tiếng Việt", "English" });
        this.cboNgonNgu.Location = new System.Drawing.Point(775, 12);
        this.cboNgonNgu.Name = "cboNgonNgu";
        this.cboNgonNgu.Size = new System.Drawing.Size(110, 23);
        this.cboNgonNgu.TabIndex = 0;
        this.cboNgonNgu.SelectedIndexChanged += new System.EventHandler(this.cboNgonNgu_SelectedIndexChanged);

        // 
        // grpThongTin
        // 
        this.grpThongTin.Controls.Add(this.lblTenChuyen);
        this.grpThongTin.Controls.Add(this.txtTenChuyen);
        this.grpThongTin.Controls.Add(this.lblDiaDiem);
        this.grpThongTin.Controls.Add(this.txtDiaDiem);
        this.grpThongTin.Controls.Add(this.lblNgayDi);
        this.grpThongTin.Controls.Add(this.dtpNgayDi);
        this.grpThongTin.Controls.Add(this.lblSoNguoi);
        this.grpThongTin.Controls.Add(this.nudSoNguoi);
        this.grpThongTin.Controls.Add(this.lblNganSach);
        this.grpThongTin.Controls.Add(this.nudNganSach);
        this.grpThongTin.Controls.Add(this.lblPhuongTien);
        this.grpThongTin.Controls.Add(this.cboPhuongTien);
        this.grpThongTin.Controls.Add(this.chkDaHoanThanh);
        this.grpThongTin.Location = new System.Drawing.Point(12, 40);
        this.grpThongTin.Name = "grpThongTin";
        this.grpThongTin.Size = new System.Drawing.Size(430, 230);
        this.grpThongTin.TabIndex = 1;
        this.grpThongTin.TabStop = false;
        this.grpThongTin.Text = "Thông tin chuyến đi";

        // lblTenChuyen
        this.lblTenChuyen.AutoSize = true;
        this.lblTenChuyen.Location = new System.Drawing.Point(15, 25);
        this.lblTenChuyen.Name = "lblTenChuyen";
        this.lblTenChuyen.Size = new System.Drawing.Size(70, 15);
        this.lblTenChuyen.Text = "Tên chuyến:";

        // txtTenChuyen
        this.txtTenChuyen.Location = new System.Drawing.Point(100, 22);
        this.txtTenChuyen.Name = "txtTenChuyen";
        this.txtTenChuyen.Size = new System.Drawing.Size(315, 23);
        this.txtTenChuyen.TabIndex = 0;

        // lblDiaDiem
        this.lblDiaDiem.AutoSize = true;
        this.lblDiaDiem.Location = new System.Drawing.Point(15, 55);
        this.lblDiaDiem.Name = "lblDiaDiem";
        this.lblDiaDiem.Size = new System.Drawing.Size(57, 15);
        this.lblDiaDiem.Text = "Địa điểm:";

        // txtDiaDiem
        this.txtDiaDiem.Location = new System.Drawing.Point(100, 52);
        this.txtDiaDiem.Name = "txtDiaDiem";
        this.txtDiaDiem.Size = new System.Drawing.Size(315, 23);
        this.txtDiaDiem.TabIndex = 1;

        // lblNgayDi
        this.lblNgayDi.AutoSize = true;
        this.lblNgayDi.Location = new System.Drawing.Point(15, 85);
        this.lblNgayDi.Name = "lblNgayDi";
        this.lblNgayDi.Size = new System.Drawing.Size(51, 15);
        this.lblNgayDi.Text = "Ngày đi:";

        // dtpNgayDi
        this.dtpNgayDi.CustomFormat = "dd/MM/yyyy";
        this.dtpNgayDi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        this.dtpNgayDi.Location = new System.Drawing.Point(100, 82);
        this.dtpNgayDi.Name = "dtpNgayDi";
        this.dtpNgayDi.Size = new System.Drawing.Size(150, 23);
        this.dtpNgayDi.TabIndex = 2;

        // lblSoNguoi
        this.lblSoNguoi.AutoSize = true;
        this.lblSoNguoi.Location = new System.Drawing.Point(15, 115);
        this.lblSoNguoi.Name = "lblSoNguoi";
        this.lblSoNguoi.Size = new System.Drawing.Size(57, 15);
        this.lblSoNguoi.Text = "Số người:";

        // nudSoNguoi
        this.nudSoNguoi.Location = new System.Drawing.Point(100, 112);
        this.nudSoNguoi.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        this.nudSoNguoi.Name = "nudSoNguoi";
        this.nudSoNguoi.Size = new System.Drawing.Size(150, 23);
        this.nudSoNguoi.TabIndex = 3;
        this.nudSoNguoi.Value = new decimal(new int[] { 1, 0, 0, 0 });

        // lblNganSach
        this.lblNganSach.AutoSize = true;
        this.lblNganSach.Location = new System.Drawing.Point(15, 145);
        this.lblNganSach.Name = "lblNganSach";
        this.lblNganSach.Size = new System.Drawing.Size(66, 15);
        this.lblNganSach.Text = "Ngân sách:";

        // nudNganSach
        this.nudNganSach.Increment = new decimal(new int[] { 50000, 0, 0, 0 });
        this.nudNganSach.Location = new System.Drawing.Point(100, 142);
        this.nudNganSach.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
        this.nudNganSach.Name = "nudNganSach";
        this.nudNganSach.Size = new System.Drawing.Size(150, 23);
        this.nudNganSach.ThousandsSeparator = true;
        this.nudNganSach.TabIndex = 4;

        // lblPhuongTien
        this.lblPhuongTien.AutoSize = true;
        this.lblPhuongTien.Location = new System.Drawing.Point(15, 175);
        this.lblPhuongTien.Name = "lblPhuongTien";
        this.lblPhuongTien.Size = new System.Drawing.Size(75, 15);
        this.lblPhuongTien.Text = "Phương tiện:";

        // cboPhuongTien
        this.cboPhuongTien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cboPhuongTien.FormattingEnabled = true;
        this.cboPhuongTien.Items.AddRange(new object[] { "Xe máy", "Ô tô", "Xe khách", "Tàu hỏa" });
        this.cboPhuongTien.Location = new System.Drawing.Point(100, 172);
        this.cboPhuongTien.Name = "cboPhuongTien";
        this.cboPhuongTien.Size = new System.Drawing.Size(150, 23);
        this.cboPhuongTien.TabIndex = 5;

        // chkDaHoanThanh
        this.chkDaHoanThanh.AutoSize = true;
        this.chkDaHoanThanh.Location = new System.Drawing.Point(100, 203);
        this.chkDaHoanThanh.Name = "chkDaHoanThanh";
        this.chkDaHoanThanh.Size = new System.Drawing.Size(104, 19);
        this.chkDaHoanThanh.TabIndex = 6;
        this.chkDaHoanThanh.Text = "Đã hoàn thành";
        this.chkDaHoanThanh.UseVisualStyleBackColor = true;

        // 
        // btnThem
        // 
        this.btnThem.Location = new System.Drawing.Point(12, 280);
        this.btnThem.Name = "btnThem";
        this.btnThem.Size = new System.Drawing.Size(95, 30);
        this.btnThem.TabIndex = 2;
        this.btnThem.Text = "Thêm";
        this.btnThem.UseVisualStyleBackColor = true;
        this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

        // 
        // btnSua
        // 
        this.btnSua.Location = new System.Drawing.Point(120, 280);
        this.btnSua.Name = "btnSua";
        this.btnSua.Size = new System.Drawing.Size(95, 30);
        this.btnSua.TabIndex = 3;
        this.btnSua.Text = "Sửa";
        this.btnSua.UseVisualStyleBackColor = true;
        this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

        // 
        // btnXoa
        // 
        this.btnXoa.Location = new System.Drawing.Point(230, 280);
        this.btnXoa.Name = "btnXoa";
        this.btnXoa.Size = new System.Drawing.Size(95, 30);
        this.btnXoa.TabIndex = 4;
        this.btnXoa.Text = "Xóa";
        this.btnXoa.UseVisualStyleBackColor = true;
        this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

        // 
        // btnLamMoi
        // 
        this.btnLamMoi.Location = new System.Drawing.Point(340, 280);
        this.btnLamMoi.Name = "btnLamMoi";
        this.btnLamMoi.Size = new System.Drawing.Size(95, 30);
        this.btnLamMoi.TabIndex = 5;
        this.btnLamMoi.Text = "Làm mới";
        this.btnLamMoi.UseVisualStyleBackColor = true;
        this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);

        // 
        // grpThoiTiet
        // 
        this.grpThoiTiet.Controls.Add(this.btnXemThoiTiet);
        this.grpThoiTiet.Controls.Add(this.pbLoading);
        this.grpThoiTiet.Controls.Add(this.pnlThoiTietBox);
        this.grpThoiTiet.Location = new System.Drawing.Point(455, 40);
        this.grpThoiTiet.Name = "grpThoiTiet";
        this.grpThoiTiet.Size = new System.Drawing.Size(430, 230);
        this.grpThoiTiet.TabIndex = 6;
        this.grpThoiTiet.TabStop = false;
        this.grpThoiTiet.Text = "Dự báo thời tiết";

        // btnXemThoiTiet
        this.btnXemThoiTiet.Location = new System.Drawing.Point(15, 20);
        this.btnXemThoiTiet.Name = "btnXemThoiTiet";
        this.btnXemThoiTiet.Size = new System.Drawing.Size(120, 26);
        this.btnXemThoiTiet.TabIndex = 0;
        this.btnXemThoiTiet.Text = "Xem thời tiết";
        this.btnXemThoiTiet.UseVisualStyleBackColor = true;
        this.btnXemThoiTiet.Click += new System.EventHandler(this.btnXemThoiTiet_Click);

        // pbLoading
        this.pbLoading.Location = new System.Drawing.Point(150, 23);
        this.pbLoading.MarqueeAnimationSpeed = 30;
        this.pbLoading.Name = "pbLoading";
        this.pbLoading.Size = new System.Drawing.Size(265, 20);
        this.pbLoading.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
        this.pbLoading.TabIndex = 1;
        this.pbLoading.Visible = false;

        // pnlThoiTietBox
        this.pnlThoiTietBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.pnlThoiTietBox.Controls.Add(this.lblThoiTietTieuDe);
        this.pnlThoiTietBox.Controls.Add(this.lblIconThoiTiet);
        this.pnlThoiTietBox.Controls.Add(this.lblMoTaThoiTiet);
        this.pnlThoiTietBox.Controls.Add(this.lblNhietDo);
        this.pnlThoiTietBox.Controls.Add(this.lblKhaNangMua);
        this.pnlThoiTietBox.Controls.Add(this.lblCanhBao);
        this.pnlThoiTietBox.Location = new System.Drawing.Point(15, 52);
        this.pnlThoiTietBox.Name = "pnlThoiTietBox";
        this.pnlThoiTietBox.Size = new System.Drawing.Size(400, 165);
        this.pnlThoiTietBox.TabIndex = 2;

        // lblThoiTietTieuDe
        this.lblThoiTietTieuDe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
        this.lblThoiTietTieuDe.Location = new System.Drawing.Point(5, 5);
        this.lblThoiTietTieuDe.Name = "lblThoiTietTieuDe";
        this.lblThoiTietTieuDe.Size = new System.Drawing.Size(388, 20);
        this.lblThoiTietTieuDe.Text = "Chọn một chuyến đi để xem dự báo";

        // lblIconThoiTiet
        this.lblIconThoiTiet.Font = new System.Drawing.Font("Segoe UI Emoji", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.lblIconThoiTiet.Location = new System.Drawing.Point(10, 25);
        this.lblIconThoiTiet.Name = "lblIconThoiTiet";
        this.lblIconThoiTiet.Size = new System.Drawing.Size(80, 80);
        this.lblIconThoiTiet.TabIndex = 1;
        this.lblIconThoiTiet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

        // lblMoTaThoiTiet
        this.lblMoTaThoiTiet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblMoTaThoiTiet.Location = new System.Drawing.Point(100, 30);
        this.lblMoTaThoiTiet.Name = "lblMoTaThoiTiet";
        this.lblMoTaThoiTiet.Size = new System.Drawing.Size(290, 25);
        this.lblMoTaThoiTiet.Text = "---";

        // lblNhietDo
        this.lblNhietDo.Location = new System.Drawing.Point(100, 58);
        this.lblNhietDo.Name = "lblNhietDo";
        this.lblNhietDo.Size = new System.Drawing.Size(290, 20);
        this.lblNhietDo.Text = "Nhiệt độ: --";

        // lblKhaNangMua
        this.lblKhaNangMua.Location = new System.Drawing.Point(100, 80);
        this.lblKhaNangMua.Name = "lblKhaNangMua";
        this.lblKhaNangMua.Size = new System.Drawing.Size(290, 20);
        this.lblKhaNangMua.Text = "Khả năng mưa: --";

        // lblCanhBao
        this.lblCanhBao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblCanhBao.Location = new System.Drawing.Point(5, 120);
        this.lblCanhBao.Name = "lblCanhBao";
        this.lblCanhBao.Size = new System.Drawing.Size(388, 38);
        this.lblCanhBao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

        // 
        // grpTimKiem
        // 
        this.grpTimKiem.Controls.Add(this.txtTimDiaDiem);
        this.grpTimKiem.Controls.Add(this.chkChuaHoanThanh);
        this.grpTimKiem.Controls.Add(this.lblTuNgay);
        this.grpTimKiem.Controls.Add(this.dtpTuNgay);
        this.grpTimKiem.Controls.Add(this.lblDenNgay);
        this.grpTimKiem.Controls.Add(this.dtpDenNgay);
        this.grpTimKiem.Controls.Add(this.btnTim);
        this.grpTimKiem.Location = new System.Drawing.Point(12, 320);
        this.grpTimKiem.Name = "grpTimKiem";
        this.grpTimKiem.Size = new System.Drawing.Size(873, 55);
        this.grpTimKiem.TabIndex = 7;
        this.grpTimKiem.TabStop = false;
        this.grpTimKiem.Text = "Tìm kiếm & Lọc";

        // txtTimDiaDiem
        this.txtTimDiaDiem.Location = new System.Drawing.Point(10, 22);
        this.txtTimDiaDiem.Name = "txtTimDiaDiem";
        this.txtTimDiaDiem.PlaceholderText = "Tìm tên chuyến hoặc địa điểm...";
        this.txtTimDiaDiem.Size = new System.Drawing.Size(180, 23);
        this.txtTimDiaDiem.TabIndex = 0;

        // chkChuaHoanThanh
        this.chkChuaHoanThanh.AutoSize = true;
        this.chkChuaHoanThanh.Location = new System.Drawing.Point(200, 24);
        this.chkChuaHoanThanh.Name = "chkChuaHoanThanh";
        this.chkChuaHoanThanh.Size = new System.Drawing.Size(182, 19);
        this.chkChuaHoanThanh.TabIndex = 1;
        this.chkChuaHoanThanh.Text = "Chỉ hiện chuyến chưa xong";
        this.chkChuaHoanThanh.UseVisualStyleBackColor = true;

        // lblTuNgay
        this.lblTuNgay.AutoSize = true;
        this.lblTuNgay.Location = new System.Drawing.Point(395, 25);
        this.lblTuNgay.Name = "lblTuNgay";
        this.lblTuNgay.Size = new System.Drawing.Size(23, 15);
        this.lblTuNgay.Text = "Từ:";

        // dtpTuNgay
        this.dtpTuNgay.CustomFormat = "dd/MM/yyyy";
        this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        this.dtpTuNgay.Location = new System.Drawing.Point(425, 22);
        this.dtpTuNgay.Name = "dtpTuNgay";
        this.dtpTuNgay.Size = new System.Drawing.Size(110, 23);
        this.dtpTuNgay.TabIndex = 2;

        // lblDenNgay
        this.lblDenNgay.AutoSize = true;
        this.lblDenNgay.Location = new System.Drawing.Point(545, 25);
        this.lblDenNgay.Name = "lblDenNgay";
        this.lblDenNgay.Size = new System.Drawing.Size(31, 15);
        this.lblDenNgay.Text = "Đến:";

        // dtpDenNgay
        this.dtpDenNgay.CustomFormat = "dd/MM/yyyy";
        this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        this.dtpDenNgay.Location = new System.Drawing.Point(580, 22);
        this.dtpDenNgay.Name = "dtpDenNgay";
        this.dtpDenNgay.Size = new System.Drawing.Size(110, 23);
        this.dtpDenNgay.TabIndex = 3;

        // btnTim
        this.btnTim.Location = new System.Drawing.Point(710, 20);
        this.btnTim.Name = "btnTim";
        this.btnTim.Size = new System.Drawing.Size(80, 26);
        this.btnTim.TabIndex = 4;
        this.btnTim.Text = "Tìm kiếm";
        this.btnTim.UseVisualStyleBackColor = true;
        this.btnTim.Click += new System.EventHandler(this.btnTim_Click);

        // 
        // dgvChuyenDi
        // 
        this.dgvChuyenDi.AllowUserToAddRows = false;
        this.dgvChuyenDi.AllowUserToDeleteRows = false;
        this.dgvChuyenDi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        this.dgvChuyenDi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvChuyenDi.Location = new System.Drawing.Point(12, 385);
        this.dgvChuyenDi.MultiSelect = false;
        this.dgvChuyenDi.Name = "dgvChuyenDi";
        this.dgvChuyenDi.ReadOnly = true;
        this.dgvChuyenDi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dgvChuyenDi.Size = new System.Drawing.Size(873, 220);
        this.dgvChuyenDi.TabIndex = 8;
        this.dgvChuyenDi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChuyenDi_CellClick);

        // 
        // FormChuyenDi
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(897, 617);
        this.Controls.Add(this.dgvChuyenDi);
        this.Controls.Add(this.grpTimKiem);
        this.Controls.Add(this.grpThoiTiet);
        this.Controls.Add(this.btnLamMoi);
        this.Controls.Add(this.btnXoa);
        this.Controls.Add(this.btnSua);
        this.Controls.Add(this.btnThem);
        this.Controls.Add(this.grpThongTin);
        this.Controls.Add(this.cboNgonNgu);
        this.Controls.Add(this.lblNgonNgu);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.MaximizeBox = false;
        this.Name = "FormChuyenDi";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Kế hoạch dã ngoại cuối tuần";
        this.Load += new System.EventHandler(this.FormChuyenDi_Load);
        this.grpThongTin.ResumeLayout(false);
        this.grpThongTin.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.nudSoNguoi)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.nudNganSach)).EndInit();
        this.grpThoiTiet.ResumeLayout(false);
        this.pnlThoiTietBox.ResumeLayout(false);
        this.grpTimKiem.ResumeLayout(false);
        this.grpTimKiem.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvChuyenDi)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}

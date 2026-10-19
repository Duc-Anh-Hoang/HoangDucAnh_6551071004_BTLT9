namespace Bai_2;

partial class FormKhachThue
{
    private System.ComponentModel.IContainer components = null;

    private System.Windows.Forms.GroupBox grpThongTin;
    private System.Windows.Forms.Label lblHoTen;
    private System.Windows.Forms.TextBox txtHoTen;
    private System.Windows.Forms.Label lblGioiTinh;
    private System.Windows.Forms.RadioButton radNam;
    private System.Windows.Forms.RadioButton radNu;
    private System.Windows.Forms.Panel pnlGioiTinh;
    private System.Windows.Forms.Label lblNgaySinh;
    private System.Windows.Forms.DateTimePicker dtpNgaySinh;
    private System.Windows.Forms.Label lblSoDienThoai;
    private System.Windows.Forms.TextBox txtSoDienThoai;
    private System.Windows.Forms.Label lblPhong;
    private System.Windows.Forms.ComboBox cboPhong;
    private System.Windows.Forms.Label lblTinhThanh;
    private System.Windows.Forms.ComboBox cboTinhThanh;
    private System.Windows.Forms.Label lblPhuongXa;
    private System.Windows.Forms.ComboBox cboPhuongXa;
    private System.Windows.Forms.CheckBox chkDaDangKyTamTru;

    private System.Windows.Forms.Button btnThem;
    private System.Windows.Forms.Button btnSua;
    private System.Windows.Forms.Button btnXoa;
    private System.Windows.Forms.Button btnLamMoi;
    private System.Windows.Forms.Button btnGayLoiThu;

    private System.Windows.Forms.GroupBox grpTimKiem;
    private System.Windows.Forms.TextBox txtTimKiem;
    private System.Windows.Forms.ComboBox cboLocPhong;
    private System.Windows.Forms.ComboBox cboLocTinh;
    private System.Windows.Forms.Button btnTim;
    private System.Windows.Forms.Button btnBoLoc;

    private System.Windows.Forms.DataGridView dgvKhachThue;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripStatusLabel lblStatus;

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
        this.grpThongTin = new System.Windows.Forms.GroupBox();
        this.lblHoTen = new System.Windows.Forms.Label();
        this.txtHoTen = new System.Windows.Forms.TextBox();
        this.lblGioiTinh = new System.Windows.Forms.Label();
        this.pnlGioiTinh = new System.Windows.Forms.Panel();
        this.radNam = new System.Windows.Forms.RadioButton();
        this.radNu = new System.Windows.Forms.RadioButton();
        this.lblNgaySinh = new System.Windows.Forms.Label();
        this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
        this.lblSoDienThoai = new System.Windows.Forms.Label();
        this.txtSoDienThoai = new System.Windows.Forms.TextBox();
        this.lblPhong = new System.Windows.Forms.Label();
        this.cboPhong = new System.Windows.Forms.ComboBox();
        this.lblTinhThanh = new System.Windows.Forms.Label();
        this.cboTinhThanh = new System.Windows.Forms.ComboBox();
        this.lblPhuongXa = new System.Windows.Forms.Label();
        this.cboPhuongXa = new System.Windows.Forms.ComboBox();
        this.chkDaDangKyTamTru = new System.Windows.Forms.CheckBox();

        this.btnThem = new System.Windows.Forms.Button();
        this.btnSua = new System.Windows.Forms.Button();
        this.btnXoa = new System.Windows.Forms.Button();
        this.btnLamMoi = new System.Windows.Forms.Button();
        this.btnGayLoiThu = new System.Windows.Forms.Button();

        this.grpTimKiem = new System.Windows.Forms.GroupBox();
        this.txtTimKiem = new System.Windows.Forms.TextBox();
        this.cboLocPhong = new System.Windows.Forms.ComboBox();
        this.cboLocTinh = new System.Windows.Forms.ComboBox();
        this.btnTim = new System.Windows.Forms.Button();
        this.btnBoLoc = new System.Windows.Forms.Button();

        this.dgvKhachThue = new System.Windows.Forms.DataGridView();
        this.statusStrip1 = new System.Windows.Forms.StatusStrip();
        this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();

        this.grpThongTin.SuspendLayout();
        this.pnlGioiTinh.SuspendLayout();
        this.grpTimKiem.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvKhachThue)).BeginInit();
        this.statusStrip1.SuspendLayout();
        this.SuspendLayout();

        // 
        // grpThongTin
        // 
        this.grpThongTin.Controls.Add(this.lblHoTen);
        this.grpThongTin.Controls.Add(this.txtHoTen);
        this.grpThongTin.Controls.Add(this.lblGioiTinh);
        this.grpThongTin.Controls.Add(this.pnlGioiTinh);
        this.grpThongTin.Controls.Add(this.lblNgaySinh);
        this.grpThongTin.Controls.Add(this.dtpNgaySinh);
        this.grpThongTin.Controls.Add(this.lblSoDienThoai);
        this.grpThongTin.Controls.Add(this.txtSoDienThoai);
        this.grpThongTin.Controls.Add(this.lblPhong);
        this.grpThongTin.Controls.Add(this.cboPhong);
        this.grpThongTin.Controls.Add(this.lblTinhThanh);
        this.grpThongTin.Controls.Add(this.cboTinhThanh);
        this.grpThongTin.Controls.Add(this.lblPhuongXa);
        this.grpThongTin.Controls.Add(this.cboPhuongXa);
        this.grpThongTin.Controls.Add(this.chkDaDangKyTamTru);
        this.grpThongTin.Location = new System.Drawing.Point(12, 12);
        this.grpThongTin.Name = "grpThongTin";
        this.grpThongTin.Size = new System.Drawing.Size(370, 310);
        this.grpThongTin.TabIndex = 0;
        this.grpThongTin.TabStop = false;
        this.grpThongTin.Text = "Thông tin khách thuê";

        // lblHoTen
        this.lblHoTen.AutoSize = true;
        this.lblHoTen.Location = new System.Drawing.Point(15, 25);
        this.lblHoTen.Name = "lblHoTen";
        this.lblHoTen.Size = new System.Drawing.Size(46, 15);
        this.lblHoTen.Text = "Họ tên:";

        // txtHoTen
        this.txtHoTen.Location = new System.Drawing.Point(110, 22);
        this.txtHoTen.Name = "txtHoTen";
        this.txtHoTen.Size = new System.Drawing.Size(240, 23);
        this.txtHoTen.TabIndex = 0;

        // lblGioiTinh
        this.lblGioiTinh.AutoSize = true;
        this.lblGioiTinh.Location = new System.Drawing.Point(15, 55);
        this.lblGioiTinh.Name = "lblGioiTinh";
        this.lblGioiTinh.Size = new System.Drawing.Size(55, 15);
        this.lblGioiTinh.Text = "Giới tính:";

        // pnlGioiTinh
        this.pnlGioiTinh.Controls.Add(this.radNam);
        this.pnlGioiTinh.Controls.Add(this.radNu);
        this.pnlGioiTinh.Location = new System.Drawing.Point(110, 50);
        this.pnlGioiTinh.Name = "pnlGioiTinh";
        this.pnlGioiTinh.Size = new System.Drawing.Size(240, 25);
        this.pnlGioiTinh.TabIndex = 1;

        // radNam
        this.radNam.AutoSize = true;
        this.radNam.Checked = true;
        this.radNam.Location = new System.Drawing.Point(5, 3);
        this.radNam.Name = "radNam";
        this.radNam.Size = new System.Drawing.Size(51, 19);
        this.radNam.TabIndex = 0;
        this.radNam.TabStop = true;
        this.radNam.Text = "Nam";
        this.radNam.UseVisualStyleBackColor = true;

        // radNu
        this.radNu.AutoSize = true;
        this.radNu.Location = new System.Drawing.Point(85, 3);
        this.radNu.Name = "radNu";
        this.radNu.Size = new System.Drawing.Size(41, 19);
        this.radNu.TabIndex = 1;
        this.radNu.Text = "Nữ";
        this.radNu.UseVisualStyleBackColor = true;

        // lblNgaySinh
        this.lblNgaySinh.AutoSize = true;
        this.lblNgaySinh.Location = new System.Drawing.Point(15, 85);
        this.lblNgaySinh.Name = "lblNgaySinh";
        this.lblNgaySinh.Size = new System.Drawing.Size(63, 15);
        this.lblNgaySinh.Text = "Ngày sinh:";

        // dtpNgaySinh
        this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
        this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        this.dtpNgaySinh.Location = new System.Drawing.Point(110, 81);
        this.dtpNgaySinh.Name = "dtpNgaySinh";
        this.dtpNgaySinh.Size = new System.Drawing.Size(240, 23);
        this.dtpNgaySinh.TabIndex = 2;

        // lblSoDienThoai
        this.lblSoDienThoai.AutoSize = true;
        this.lblSoDienThoai.Location = new System.Drawing.Point(15, 115);
        this.lblSoDienThoai.Name = "lblSoDienThoai";
        this.lblSoDienThoai.Size = new System.Drawing.Size(79, 15);
        this.lblSoDienThoai.Text = "Số điện thoại:";

        // txtSoDienThoai
        this.txtSoDienThoai.Location = new System.Drawing.Point(110, 112);
        this.txtSoDienThoai.Name = "txtSoDienThoai";
        this.txtSoDienThoai.Size = new System.Drawing.Size(240, 23);
        this.txtSoDienThoai.TabIndex = 3;

        // lblPhong
        this.lblPhong.AutoSize = true;
        this.lblPhong.Location = new System.Drawing.Point(15, 145);
        this.lblPhong.Name = "lblPhong";
        this.lblPhong.Size = new System.Drawing.Size(45, 15);
        this.lblPhong.Text = "Phòng:";

        // cboPhong
        this.cboPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cboPhong.FormattingEnabled = true;
        this.cboPhong.Location = new System.Drawing.Point(110, 142);
        this.cboPhong.Name = "cboPhong";
        this.cboPhong.Size = new System.Drawing.Size(240, 23);
        this.cboPhong.TabIndex = 4;

        // lblTinhThanh
        this.lblTinhThanh.AutoSize = true;
        this.lblTinhThanh.Location = new System.Drawing.Point(15, 175);
        this.lblTinhThanh.Name = "lblTinhThanh";
        this.lblTinhThanh.Size = new System.Drawing.Size(69, 15);
        this.lblTinhThanh.Text = "Tỉnh/Thành:";

        // cboTinhThanh
        this.cboTinhThanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cboTinhThanh.FormattingEnabled = true;
        this.cboTinhThanh.Location = new System.Drawing.Point(110, 172);
        this.cboTinhThanh.Name = "cboTinhThanh";
        this.cboTinhThanh.Size = new System.Drawing.Size(240, 23);
        this.cboTinhThanh.TabIndex = 5;
        this.cboTinhThanh.SelectedIndexChanged += new System.EventHandler(this.cboTinhThanh_SelectedIndexChanged);

        // lblPhuongXa
        this.lblPhuongXa.AutoSize = true;
        this.lblPhuongXa.Location = new System.Drawing.Point(15, 205);
        this.lblPhuongXa.Name = "lblPhuongXa";
        this.lblPhuongXa.Size = new System.Drawing.Size(69, 15);
        this.lblPhuongXa.Text = "Phường/Xã:";

        // cboPhuongXa
        this.cboPhuongXa.FormattingEnabled = true;
        this.cboPhuongXa.Location = new System.Drawing.Point(110, 202);
        this.cboPhuongXa.Name = "cboPhuongXa";
        this.cboPhuongXa.Size = new System.Drawing.Size(240, 23);
        this.cboPhuongXa.TabIndex = 6;

        // chkDaDangKyTamTru
        this.chkDaDangKyTamTru.AutoSize = true;
        this.chkDaDangKyTamTru.Location = new System.Drawing.Point(110, 235);
        this.chkDaDangKyTamTru.Name = "chkDaDangKyTamTru";
        this.chkDaDangKyTamTru.Size = new System.Drawing.Size(127, 19);
        this.chkDaDangKyTamTru.TabIndex = 7;
        this.chkDaDangKyTamTru.Text = "Đã đăng ký tạm trú";
        this.chkDaDangKyTamTru.UseVisualStyleBackColor = true;

        // 
        // btnThem
        // 
        this.btnThem.Location = new System.Drawing.Point(15, 270);
        this.btnThem.Name = "btnThem";
        this.btnThem.Size = new System.Drawing.Size(75, 28);
        this.btnThem.TabIndex = 8;
        this.btnThem.Text = "Thêm";
        this.btnThem.UseVisualStyleBackColor = true;
        this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

        // 
        // btnSua
        // 
        this.btnSua.Location = new System.Drawing.Point(95, 270);
        this.btnSua.Name = "btnSua";
        this.btnSua.Size = new System.Drawing.Size(75, 28);
        this.btnSua.TabIndex = 9;
        this.btnSua.Text = "Sửa";
        this.btnSua.UseVisualStyleBackColor = true;
        this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

        // 
        // btnXoa
        // 
        this.btnXoa.Location = new System.Drawing.Point(175, 270);
        this.btnXoa.Name = "btnXoa";
        this.btnXoa.Size = new System.Drawing.Size(75, 28);
        this.btnXoa.TabIndex = 10;
        this.btnXoa.Text = "Xóa";
        this.btnXoa.UseVisualStyleBackColor = true;
        this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

        // 
        // btnLamMoi
        // 
        this.btnLamMoi.Location = new System.Drawing.Point(255, 270);
        this.btnLamMoi.Name = "btnLamMoi";
        this.btnLamMoi.Size = new System.Drawing.Size(75, 28);
        this.btnLamMoi.TabIndex = 11;
        this.btnLamMoi.Text = "Làm mới";
        this.btnLamMoi.UseVisualStyleBackColor = true;
        this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);

        // 
        // btnGayLoiThu
        // 
        this.btnGayLoiThu.BackColor = System.Drawing.Color.LightCoral;
        this.btnGayLoiThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnGayLoiThu.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.btnGayLoiThu.Location = new System.Drawing.Point(335, 275);
        this.btnGayLoiThu.Name = "btnGayLoiThu";
        this.btnGayLoiThu.Size = new System.Drawing.Size(25, 20);
        this.btnGayLoiThu.TabIndex = 12;
        this.btnGayLoiThu.Text = "!";
        this.btnGayLoiThu.UseVisualStyleBackColor = false;
        this.btnGayLoiThu.Click += new System.EventHandler(this.btnGayLoiThu_Click);

        // 
        // grpTimKiem
        // 
        this.grpTimKiem.Controls.Add(this.txtTimKiem);
        this.grpTimKiem.Controls.Add(this.cboLocPhong);
        this.grpTimKiem.Controls.Add(this.cboLocTinh);
        this.grpTimKiem.Controls.Add(this.btnTim);
        this.grpTimKiem.Controls.Add(this.btnBoLoc);
        this.grpTimKiem.Location = new System.Drawing.Point(395, 12);
        this.grpTimKiem.Name = "grpTimKiem";
        this.grpTimKiem.Size = new System.Drawing.Size(540, 60);
        this.grpTimKiem.TabIndex = 1;
        this.grpTimKiem.TabStop = false;
        this.grpTimKiem.Text = "Tìm kiếm & Lọc";

        // txtTimKiem
        this.txtTimKiem.Location = new System.Drawing.Point(10, 22);
        this.txtTimKiem.Name = "txtTimKiem";
        this.txtTimKiem.PlaceholderText = "Tìm theo tên hoặc SĐT...";
        this.txtTimKiem.Size = new System.Drawing.Size(150, 23);
        this.txtTimKiem.TabIndex = 0;

        // cboLocPhong
        this.cboLocPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cboLocPhong.FormattingEnabled = true;
        this.cboLocPhong.Location = new System.Drawing.Point(165, 22);
        this.cboLocPhong.Name = "cboLocPhong";
        this.cboLocPhong.Size = new System.Drawing.Size(110, 23);
        this.cboLocPhong.TabIndex = 1;

        // cboLocTinh
        this.cboLocTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cboLocTinh.FormattingEnabled = true;
        this.cboLocTinh.Location = new System.Drawing.Point(280, 22);
        this.cboLocTinh.Name = "cboLocTinh";
        this.cboLocTinh.Size = new System.Drawing.Size(120, 23);
        this.cboLocTinh.TabIndex = 2;

        // btnTim
        this.btnTim.Location = new System.Drawing.Point(405, 20);
        this.btnTim.Name = "btnTim";
        this.btnTim.Size = new System.Drawing.Size(60, 26);
        this.btnTim.TabIndex = 3;
        this.btnTim.Text = "Tìm";
        this.btnTim.UseVisualStyleBackColor = true;
        this.btnTim.Click += new System.EventHandler(this.btnTim_Click);

        // btnBoLoc
        this.btnBoLoc.Location = new System.Drawing.Point(470, 20);
        this.btnBoLoc.Name = "btnBoLoc";
        this.btnBoLoc.Size = new System.Drawing.Size(60, 26);
        this.btnBoLoc.TabIndex = 4;
        this.btnBoLoc.Text = "Bỏ lọc";
        this.btnBoLoc.UseVisualStyleBackColor = true;
        this.btnBoLoc.Click += new System.EventHandler(this.btnBoLoc_Click);

        // 
        // dgvKhachThue
        // 
        this.dgvKhachThue.AllowUserToAddRows = false;
        this.dgvKhachThue.AllowUserToDeleteRows = false;
        this.dgvKhachThue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        this.dgvKhachThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvKhachThue.Location = new System.Drawing.Point(395, 80);
        this.dgvKhachThue.MultiSelect = false;
        this.dgvKhachThue.Name = "dgvKhachThue";
        this.dgvKhachThue.ReadOnly = true;
        this.dgvKhachThue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dgvKhachThue.Size = new System.Drawing.Size(540, 242);
        this.dgvKhachThue.TabIndex = 2;
        this.dgvKhachThue.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachThue_CellClick);

        // 
        // statusStrip1
        // 
        this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
        this.statusStrip1.Location = new System.Drawing.Point(0, 335);
        this.statusStrip1.Name = "statusStrip1";
        this.statusStrip1.Size = new System.Drawing.Size(950, 22);
        this.statusStrip1.TabIndex = 3;

        // lblStatus
        this.lblStatus.Name = "lblStatus";
        this.lblStatus.Size = new System.Drawing.Size(42, 17);
        this.lblStatus.Text = "Sẵn sàng";

        // 
        // FormKhachThue
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(950, 357);
        this.Controls.Add(this.statusStrip1);
        this.Controls.Add(this.dgvKhachThue);
        this.Controls.Add(this.grpTimKiem);
        this.Controls.Add(this.grpThongTin);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.MaximizeBox = false;
        this.Name = "FormKhachThue";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Quản lý nhà trọ - Khách thuê";
        this.Load += new System.EventHandler(this.FormKhachThue_Load);
        this.grpThongTin.ResumeLayout(false);
        this.grpThongTin.PerformLayout();
        this.pnlGioiTinh.ResumeLayout(false);
        this.pnlGioiTinh.PerformLayout();
        this.grpTimKiem.ResumeLayout(false);
        this.grpTimKiem.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvKhachThue)).EndInit();
        this.statusStrip1.ResumeLayout(false);
        this.statusStrip1.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}

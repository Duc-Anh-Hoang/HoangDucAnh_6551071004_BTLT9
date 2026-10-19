namespace Bai_1;

partial class FormChiTieu
{
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.GroupBox grpThongTin;
    private System.Windows.Forms.Label lblNgayChi;
    private System.Windows.Forms.DateTimePicker dtpNgayChi;
    private System.Windows.Forms.Label lblNoiDung;
    private System.Windows.Forms.TextBox txtNoiDung;
    private System.Windows.Forms.Label lblLoaiChi;
    private System.Windows.Forms.ComboBox cboLoaiChi;
    private System.Windows.Forms.Label lblSoTien;
    private System.Windows.Forms.NumericUpDown nudSoTien;
    private System.Windows.Forms.Label lblGhiChu;
    private System.Windows.Forms.TextBox txtGhiChu;

    private System.Windows.Forms.GroupBox grpTimKiem;
    private System.Windows.Forms.Label lblTimNoiDung;
    private System.Windows.Forms.TextBox txtTimNoiDung;
    private System.Windows.Forms.Label lblTimLoaiChi;
    private System.Windows.Forms.ComboBox cboTimLoaiChi;
    private System.Windows.Forms.Label lblTuNgay;
    private System.Windows.Forms.DateTimePicker dtpTuNgay;
    private System.Windows.Forms.Label lblDenNgay;
    private System.Windows.Forms.DateTimePicker dtpDenNgay;
    private System.Windows.Forms.Button btnTim;

    private System.Windows.Forms.Button btnThem;
    private System.Windows.Forms.Button btnSua;
    private System.Windows.Forms.Button btnXoa;
    private System.Windows.Forms.Button btnLamMoi;

    private System.Windows.Forms.DataGridView dgvChiTieu;
    private System.Windows.Forms.Label lblTongChi;

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
        this.lblNgayChi = new System.Windows.Forms.Label();
        this.dtpNgayChi = new System.Windows.Forms.DateTimePicker();
        this.lblNoiDung = new System.Windows.Forms.Label();
        this.txtNoiDung = new System.Windows.Forms.TextBox();
        this.lblLoaiChi = new System.Windows.Forms.Label();
        this.cboLoaiChi = new System.Windows.Forms.ComboBox();
        this.lblSoTien = new System.Windows.Forms.Label();
        this.nudSoTien = new System.Windows.Forms.NumericUpDown();
        this.lblGhiChu = new System.Windows.Forms.Label();
        this.txtGhiChu = new System.Windows.Forms.TextBox();

        this.grpTimKiem = new System.Windows.Forms.GroupBox();
        this.lblTimNoiDung = new System.Windows.Forms.Label();
        this.txtTimNoiDung = new System.Windows.Forms.TextBox();
        this.lblTimLoaiChi = new System.Windows.Forms.Label();
        this.cboTimLoaiChi = new System.Windows.Forms.ComboBox();
        this.lblTuNgay = new System.Windows.Forms.Label();
        this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
        this.lblDenNgay = new System.Windows.Forms.Label();
        this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
        this.btnTim = new System.Windows.Forms.Button();

        this.btnThem = new System.Windows.Forms.Button();
        this.btnSua = new System.Windows.Forms.Button();
        this.btnXoa = new System.Windows.Forms.Button();
        this.btnLamMoi = new System.Windows.Forms.Button();

        this.dgvChiTieu = new System.Windows.Forms.DataGridView();
        this.lblTongChi = new System.Windows.Forms.Label();

        this.grpThongTin.SuspendLayout();
        this.grpTimKiem.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.nudSoTien)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.dgvChiTieu)).BeginInit();
        this.SuspendLayout();

        // 
        // grpThongTin
        // 
        this.grpThongTin.Controls.Add(this.lblNgayChi);
        this.grpThongTin.Controls.Add(this.dtpNgayChi);
        this.grpThongTin.Controls.Add(this.lblLoaiChi);
        this.grpThongTin.Controls.Add(this.cboLoaiChi);
        this.grpThongTin.Controls.Add(this.lblNoiDung);
        this.grpThongTin.Controls.Add(this.txtNoiDung);
        this.grpThongTin.Controls.Add(this.lblSoTien);
        this.grpThongTin.Controls.Add(this.nudSoTien);
        this.grpThongTin.Controls.Add(this.lblGhiChu);
        this.grpThongTin.Controls.Add(this.txtGhiChu);
        this.grpThongTin.Location = new System.Drawing.Point(12, 12);
        this.grpThongTin.Name = "grpThongTin";
        this.grpThongTin.Size = new System.Drawing.Size(430, 160);
        this.grpThongTin.TabIndex = 0;
        this.grpThongTin.TabStop = false;
        this.grpThongTin.Text = "Thông tin khoản chi";

        // lblNgayChi
        this.lblNgayChi.AutoSize = true;
        this.lblNgayChi.Location = new System.Drawing.Point(10, 25);
        this.lblNgayChi.Name = "lblNgayChi";
        this.lblNgayChi.Size = new System.Drawing.Size(56, 15);
        this.lblNgayChi.Text = "Ngày chi:";

        // dtpNgayChi
        this.dtpNgayChi.CustomFormat = "dd/MM/yyyy";
        this.dtpNgayChi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        this.dtpNgayChi.Location = new System.Drawing.Point(75, 22);
        this.dtpNgayChi.Name = "dtpNgayChi";
        this.dtpNgayChi.Size = new System.Drawing.Size(125, 23);
        this.dtpNgayChi.TabIndex = 0;

        // lblLoaiChi
        this.lblLoaiChi.AutoSize = true;
        this.lblLoaiChi.Location = new System.Drawing.Point(215, 25);
        this.lblLoaiChi.Name = "lblLoaiChi";
        this.lblLoaiChi.Size = new System.Drawing.Size(51, 15);
        this.lblLoaiChi.Text = "Loại chi:";

        // cboLoaiChi
        this.cboLoaiChi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cboLoaiChi.FormattingEnabled = true;
        this.cboLoaiChi.Location = new System.Drawing.Point(275, 22);
        this.cboLoaiChi.Name = "cboLoaiChi";
        this.cboLoaiChi.Size = new System.Drawing.Size(140, 23);
        this.cboLoaiChi.TabIndex = 1;

        // lblNoiDung
        this.lblNoiDung.AutoSize = true;
        this.lblNoiDung.Location = new System.Drawing.Point(10, 56);
        this.lblNoiDung.Name = "lblNoiDung";
        this.lblNoiDung.Size = new System.Drawing.Size(60, 15);
        this.lblNoiDung.Text = "Nội dung:";

        // txtNoiDung
        this.txtNoiDung.Location = new System.Drawing.Point(75, 53);
        this.txtNoiDung.Name = "txtNoiDung";
        this.txtNoiDung.Size = new System.Drawing.Size(125, 23);
        this.txtNoiDung.TabIndex = 2;

        // lblSoTien
        this.lblSoTien.AutoSize = true;
        this.lblSoTien.Location = new System.Drawing.Point(215, 56);
        this.lblSoTien.Name = "lblSoTien";
        this.lblSoTien.Size = new System.Drawing.Size(46, 15);
        this.lblSoTien.Text = "Số tiền:";

        // nudSoTien
        this.nudSoTien.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
        this.nudSoTien.Location = new System.Drawing.Point(275, 53);
        this.nudSoTien.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
        this.nudSoTien.Name = "nudSoTien";
        this.nudSoTien.Size = new System.Drawing.Size(140, 23);
        this.nudSoTien.ThousandsSeparator = true;
        this.nudSoTien.TabIndex = 3;

        // lblGhiChu
        this.lblGhiChu.AutoSize = true;
        this.lblGhiChu.Location = new System.Drawing.Point(10, 87);
        this.lblGhiChu.Name = "lblGhiChu";
        this.lblGhiChu.Size = new System.Drawing.Size(51, 15);
        this.lblGhiChu.Text = "Ghi chú:";

        // txtGhiChu
        this.txtGhiChu.Location = new System.Drawing.Point(75, 84);
        this.txtGhiChu.Multiline = true;
        this.txtGhiChu.Name = "txtGhiChu";
        this.txtGhiChu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        this.txtGhiChu.Size = new System.Drawing.Size(340, 65);
        this.txtGhiChu.TabIndex = 4;

        // 
        // grpTimKiem
        // 
        this.grpTimKiem.Controls.Add(this.lblTimNoiDung);
        this.grpTimKiem.Controls.Add(this.txtTimNoiDung);
        this.grpTimKiem.Controls.Add(this.lblTimLoaiChi);
        this.grpTimKiem.Controls.Add(this.cboTimLoaiChi);
        this.grpTimKiem.Controls.Add(this.lblTuNgay);
        this.grpTimKiem.Controls.Add(this.dtpTuNgay);
        this.grpTimKiem.Controls.Add(this.lblDenNgay);
        this.grpTimKiem.Controls.Add(this.dtpDenNgay);
        this.grpTimKiem.Controls.Add(this.btnTim);
        this.grpTimKiem.Location = new System.Drawing.Point(450, 12);
        this.grpTimKiem.Name = "grpTimKiem";
        this.grpTimKiem.Size = new System.Drawing.Size(370, 160);
        this.grpTimKiem.TabIndex = 1;
        this.grpTimKiem.TabStop = false;
        this.grpTimKiem.Text = "Tìm kiếm";

        // lblTimNoiDung
        this.lblTimNoiDung.AutoSize = true;
        this.lblTimNoiDung.Location = new System.Drawing.Point(10, 25);
        this.lblTimNoiDung.Name = "lblTimNoiDung";
        this.lblTimNoiDung.Size = new System.Drawing.Size(60, 15);
        this.lblTimNoiDung.Text = "Nội dung:";

        // txtTimNoiDung
        this.txtTimNoiDung.Location = new System.Drawing.Point(75, 22);
        this.txtTimNoiDung.Name = "txtTimNoiDung";
        this.txtTimNoiDung.PlaceholderText = "Nhập nội dung...";
        this.txtTimNoiDung.Size = new System.Drawing.Size(280, 23);
        this.txtTimNoiDung.TabIndex = 0;

        // lblTimLoaiChi
        this.lblTimLoaiChi.AutoSize = true;
        this.lblTimLoaiChi.Location = new System.Drawing.Point(10, 56);
        this.lblTimLoaiChi.Name = "lblTimLoaiChi";
        this.lblTimLoaiChi.Size = new System.Drawing.Size(51, 15);
        this.lblTimLoaiChi.Text = "Loại chi:";

        // cboTimLoaiChi
        this.cboTimLoaiChi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cboTimLoaiChi.FormattingEnabled = true;
        this.cboTimLoaiChi.Location = new System.Drawing.Point(75, 53);
        this.cboTimLoaiChi.Name = "cboTimLoaiChi";
        this.cboTimLoaiChi.Size = new System.Drawing.Size(280, 23);
        this.cboTimLoaiChi.TabIndex = 1;

        // lblTuNgay
        this.lblTuNgay.AutoSize = true;
        this.lblTuNgay.Location = new System.Drawing.Point(10, 87);
        this.lblTuNgay.Name = "lblTuNgay";
        this.lblTuNgay.Size = new System.Drawing.Size(52, 15);
        this.lblTuNgay.Text = "Từ ngày:";

        // dtpTuNgay
        this.dtpTuNgay.CustomFormat = "dd/MM/yyyy";
        this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        this.dtpTuNgay.Location = new System.Drawing.Point(75, 84);
        this.dtpTuNgay.Name = "dtpTuNgay";
        this.dtpTuNgay.Size = new System.Drawing.Size(120, 23);
        this.dtpTuNgay.TabIndex = 2;

        // lblDenNgay
        this.lblDenNgay.AutoSize = true;
        this.lblDenNgay.Location = new System.Drawing.Point(10, 118);
        this.lblDenNgay.Name = "lblDenNgay";
        this.lblDenNgay.Size = new System.Drawing.Size(60, 15);
        this.lblDenNgay.Text = "Đến ngày:";

        // dtpDenNgay
        this.dtpDenNgay.CustomFormat = "dd/MM/yyyy";
        this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        this.dtpDenNgay.Location = new System.Drawing.Point(75, 115);
        this.dtpDenNgay.Name = "dtpDenNgay";
        this.dtpDenNgay.Size = new System.Drawing.Size(120, 23);
        this.dtpDenNgay.TabIndex = 3;

        // btnTim
        this.btnTim.Location = new System.Drawing.Point(230, 95);
        this.btnTim.Name = "btnTim";
        this.btnTim.Size = new System.Drawing.Size(125, 40);
        this.btnTim.TabIndex = 4;
        this.btnTim.Text = "Tìm kiếm";
        this.btnTim.UseVisualStyleBackColor = true;
        this.btnTim.Click += new System.EventHandler(this.btnTim_Click);

        // 
        // btnThem
        // 
        this.btnThem.Location = new System.Drawing.Point(50, 180);
        this.btnThem.Name = "btnThem";
        this.btnThem.Size = new System.Drawing.Size(90, 32);
        this.btnThem.TabIndex = 2;
        this.btnThem.Text = "Thêm";
        this.btnThem.UseVisualStyleBackColor = true;
        this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

        // 
        // btnSua
        // 
        this.btnSua.Location = new System.Drawing.Point(160, 180);
        this.btnSua.Name = "btnSua";
        this.btnSua.Size = new System.Drawing.Size(90, 32);
        this.btnSua.TabIndex = 3;
        this.btnSua.Text = "Sửa";
        this.btnSua.UseVisualStyleBackColor = true;
        this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

        // 
        // btnXoa
        // 
        this.btnXoa.Location = new System.Drawing.Point(270, 180);
        this.btnXoa.Name = "btnXoa";
        this.btnXoa.Size = new System.Drawing.Size(90, 32);
        this.btnXoa.TabIndex = 4;
        this.btnXoa.Text = "Xóa";
        this.btnXoa.UseVisualStyleBackColor = true;
        this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

        // 
        // btnLamMoi
        // 
        this.btnLamMoi.Location = new System.Drawing.Point(380, 180);
        this.btnLamMoi.Name = "btnLamMoi";
        this.btnLamMoi.Size = new System.Drawing.Size(90, 32);
        this.btnLamMoi.TabIndex = 5;
        this.btnLamMoi.Text = "Làm mới";
        this.btnLamMoi.UseVisualStyleBackColor = true;
        this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);

        // 
        // dgvChiTieu
        // 
        this.dgvChiTieu.AllowUserToAddRows = false;
        this.dgvChiTieu.AllowUserToDeleteRows = false;
        this.dgvChiTieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        this.dgvChiTieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvChiTieu.Location = new System.Drawing.Point(12, 222);
        this.dgvChiTieu.MultiSelect = false;
        this.dgvChiTieu.Name = "dgvChiTieu";
        this.dgvChiTieu.ReadOnly = true;
        this.dgvChiTieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dgvChiTieu.Size = new System.Drawing.Size(808, 250);
        this.dgvChiTieu.TabIndex = 6;
        this.dgvChiTieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTieu_CellClick);

        // 
        // lblTongChi
        // 
        this.lblTongChi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblTongChi.ForeColor = System.Drawing.Color.Red;
        this.lblTongChi.Location = new System.Drawing.Point(400, 480);
        this.lblTongChi.Name = "lblTongChi";
        this.lblTongChi.Size = new System.Drawing.Size(420, 30);
        this.lblTongChi.TabIndex = 7;
        this.lblTongChi.Text = "Tổng chi: 0 đ";
        this.lblTongChi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

        // 
        // FormChiTieu
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(834, 521);
        this.Controls.Add(this.lblTongChi);
        this.Controls.Add(this.dgvChiTieu);
        this.Controls.Add(this.btnLamMoi);
        this.Controls.Add(this.btnXoa);
        this.Controls.Add(this.btnSua);
        this.Controls.Add(this.btnThem);
        this.Controls.Add(this.grpTimKiem);
        this.Controls.Add(this.grpThongTin);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.MaximizeBox = false;
        this.Name = "FormChiTieu";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Sổ chi tiêu cá nhân";
        this.Load += new System.EventHandler(this.FormChiTieu_Load);
        this.grpThongTin.ResumeLayout(false);
        this.grpThongTin.PerformLayout();
        this.grpTimKiem.ResumeLayout(false);
        this.grpTimKiem.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.nudSoTien)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.dgvChiTieu)).EndInit();
        this.ResumeLayout(false);
    }
}

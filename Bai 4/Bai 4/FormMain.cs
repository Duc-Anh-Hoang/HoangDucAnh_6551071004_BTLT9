using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bai_4.Models;
using Microsoft.EntityFrameworkCore;
using Serilog;

namespace Bai_4;

public partial class FormMain : Form
{
    private static readonly HttpClient _httpClient = new HttpClient
    {
        Timeout = TimeSpan.FromSeconds(10)
    };

    private readonly List<GioHangItem> _gioHang = new();
    private int? _selectedMaMon = null;
    private int? _currentPendingOrderCode = null;

    public FormMain()
    {
        InitializeComponent();
    }

    private void FormMain_Load(object sender, EventArgs e)
    {
        SetupDataGridViews();
        LoadDanhMuc();
        LoadThucDon();
        LoadMonUongTheoDanhMuc();
        dtpLocNgayHD.Value = DateTime.Today;
        LoadHoaDonTheoNgay(DateTime.Today);
    }

    private void SetupDataGridViews()
    {
        // 1. Giỏ hàng
        dgvGioHang.AutoGenerateColumns = false;
        dgvGioHang.Columns.Clear();
        dgvGioHang.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "TenMon", HeaderText = "Tên món", Width = 140 });
        dgvGioHang.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "SoLuong", HeaderText = "SL", Width = 45, DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter } });
        dgvGioHang.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "DonGia", HeaderText = "Đơn giá", Width = 90, DefaultCellStyle = new DataGridViewCellStyle { Format = "N0", Alignment = DataGridViewContentAlignment.MiddleRight } });
        dgvGioHang.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ThanhTien", HeaderText = "Thành tiền", Width = 100, DefaultCellStyle = new DataGridViewCellStyle { Format = "N0", Alignment = DataGridViewContentAlignment.MiddleRight } });

        // 2. Thực đơn
        dgvThucDon.AutoGenerateColumns = false;
        dgvThucDon.Columns.Clear();
        dgvThucDon.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "MaMon", HeaderText = "Mã", Width = 60, DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter } });
        dgvThucDon.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "TenMon", HeaderText = "Tên món", Width = 220 });
        dgvThucDon.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "TenDm", HeaderText = "Danh mục", Width = 150 });
        dgvThucDon.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "GiaBan", HeaderText = "Giá bán", Width = 120, DefaultCellStyle = new DataGridViewCellStyle { Format = "N0", Alignment = DataGridViewContentAlignment.MiddleRight } });
        dgvThucDon.Columns.Add(new DataGridViewCheckBoxColumn { DataPropertyName = "DangBan", HeaderText = "Đang bán", Width = 90 });

        // 3. Hóa đơn
        dgvHoaDon.AutoGenerateColumns = false;
        dgvHoaDon.Columns.Clear();
        dgvHoaDon.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "MaHd", HeaderText = "Mã HD", Width = 80, DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter } });
        dgvHoaDon.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "NgayLap", HeaderText = "Giờ lập", Width = 160, DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy HH:mm:ss", Alignment = DataGridViewContentAlignment.MiddleCenter } });
        dgvHoaDon.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "HinhThucTt", HeaderText = "Hình thức TT", Width = 140, DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter } });
        dgvHoaDon.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "TongTien", HeaderText = "Tổng tiền", Width = 140, DefaultCellStyle = new DataGridViewCellStyle { Format = "N0", Alignment = DataGridViewContentAlignment.MiddleRight } });

        // 4. Chi tiết hóa đơn
        dgvChiTietHD.AutoGenerateColumns = false;
        dgvChiTietHD.Columns.Clear();
        dgvChiTietHD.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "TenMon", HeaderText = "Tên món", Width = 250 });
        dgvChiTietHD.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "SoLy", HeaderText = "Số ly", Width = 80, DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter } });
        dgvChiTietHD.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "DonGia", HeaderText = "Đơn giá", Width = 130, DefaultCellStyle = new DataGridViewCellStyle { Format = "N0", Alignment = DataGridViewContentAlignment.MiddleRight } });
        dgvChiTietHD.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ThanhTien", HeaderText = "Thành tiền", Width = 150, DefaultCellStyle = new DataGridViewCellStyle { Format = "N0", Alignment = DataGridViewContentAlignment.MiddleRight } });
    }

    private void LoadDanhMuc()
    {
        try
        {
            using var db = new QlTraSuaContext();
            var danhMucs = db.DanhMucMons.OrderBy(d => d.MaDm).ToList();

            // Cho cboBanHangDanhMuc
            cboBanHangDanhMuc.DisplayMember = "TenDm";
            cboBanHangDanhMuc.ValueMember = "MaDm";
            cboBanHangDanhMuc.DataSource = danhMucs;

            // Cho cboDanhMucThucDon
            cboDanhMucThucDon.DisplayMember = "TenDm";
            cboDanhMucThucDon.ValueMember = "MaDm";
            cboDanhMucThucDon.DataSource = danhMucs.ToList();

            // Cho cboLocDanhMuc
            var locList = new List<dynamic> { new { MaDm = 0, TenDm = "Tất cả danh mục" } };
            locList.AddRange(danhMucs.Select(d => new { d.MaDm, d.TenDm }));
            cboLocDanhMuc.DisplayMember = "TenDm";
            cboLocDanhMuc.ValueMember = "MaDm";
            cboLocDanhMuc.DataSource = locList;
            cboLocDanhMuc.SelectedIndex = 0;
        }
        catch (Exception ex)
        {
            Log.Error(ex, "Lỗi khi nạp danh mục");
        }
    }

    #region TAB 1: BÁN HÀNG
    private void cboBanHangDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
    {
        LoadMonUongTheoDanhMuc();
    }

    private void LoadMonUongTheoDanhMuc()
    {
        if (cboBanHangDanhMuc.SelectedValue == null || !int.TryParse(cboBanHangDanhMuc.SelectedValue.ToString(), out int maDm))
            return;

        try
        {
            using var db = new QlTraSuaContext();
            var mons = db.MonUongs
                .Where(m => m.MaDm == maDm && m.DangBan)
                .OrderBy(m => m.TenMon)
                .ToList();

            lstMonUong.DisplayMember = "DisplayText";
            lstMonUong.ValueMember = "MaMon";
            lstMonUong.DataSource = mons.Select(m => new
            {
                m.MaMon,
                m.TenMon,
                m.GiaBan,
                DisplayText = $"{m.TenMon} - {m.GiaBan:N0} đ"
            }).ToList();
        }
        catch (Exception ex)
        {
            Log.Error(ex, "Lỗi khi nạp món uống theo danh mục");
        }
    }

    private void btnThemVaoDon_Click(object sender, EventArgs e)
    {
        if (lstMonUong.SelectedItem == null)
        {
            MessageBox.Show("Vui lòng chọn món cần thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        dynamic selected = lstMonUong.SelectedItem;
        int maMon = (int)selected.MaMon;
        string tenMon = (string)selected.TenMon;
        decimal giaBan = (decimal)selected.GiaBan;
        int soLy = (int)nudSoLy.Value;

        var existing = _gioHang.FirstOrDefault(g => g.MaMon == maMon);
        if (existing != null)
        {
            existing.SoLuong += soLy;
        }
        else
        {
            _gioHang.Add(new GioHangItem
            {
                MaMon = maMon,
                TenMon = tenMon,
                SoLuong = soLy,
                DonGia = giaBan
            });
        }

        CapNhatGioHang();
    }

    private void btnXoaDong_Click(object sender, EventArgs e)
    {
        if (dgvGioHang.SelectedRows.Count == 0)
        {
            MessageBox.Show("Vui lòng chọn món trong giỏ để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        if (dgvGioHang.SelectedRows[0].DataBoundItem is GioHangItem item)
        {
            _gioHang.Remove(item);
            CapNhatGioHang();
        }
    }

    private void CapNhatGioHang()
    {
        dgvGioHang.DataSource = null;
        dgvGioHang.DataSource = _gioHang.ToList();

        decimal tongTien = _gioHang.Sum(g => g.ThanhTien);
        lblTongTien.Text = $"Tổng tiền: {tongTien:N0} đ";

        // Xóa thông tin QR cũ nếu giỏ hàng thay đổi
        if (_currentPendingOrderCode.HasValue)
        {
            picVietQR.Image = null;
            lblQRThongTin.Text = $"Tổng tiền đã đổi: {tongTien:N0} đ. Vui lòng bấm tạo lại mã QR hoặc thanh toán tiền mặt.";
            _currentPendingOrderCode = null;
        }
    }

    private async void btnThanhToanChuyenKhoan_Click(object sender, EventArgs e)
    {
        if (_gioHang.Count == 0)
        {
            MessageBox.Show("Giỏ hàng đang trống! Vui lòng chọn món trước.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        decimal tongTien = _gioHang.Sum(g => g.ThanhTien);
        if (tongTien <= 0) return;

        // Sinh mã hóa đơn tạm
        int tempCode = new Random().Next(1000, 9999);
        _currentPendingOrderCode = tempCode;
        string noiDung = $"TRASUA HD{tempCode}";

        var payment = AppConfigManager.Payment;
        string bankId = payment.BankId;
        string accNo = payment.AccountNo;
        string accName = payment.AccountName;
        string template = payment.Template;
        string shopName = payment.ShopName;

        // Masking STK cho log bảo mật
        string maskedAccNo = accNo.Length > 4 ? $"***{accNo[^4..]}" : "***";
        Log.Information("Tạo mã QR VietQR: MaHD_Tam={TempCode}, SoTien={TongTien}, STK={MaskedAcc}",
            tempCode, tongTien, maskedAccNo);

        string qrUrl = $"https://img.vietqr.io/image/{bankId}-{accNo}-{template}.png?amount={tongTien}&addInfo={Uri.EscapeDataString(noiDung)}&accountName={Uri.EscapeDataString(accName)}";

        // Cập nhật thông tin dạng chữ trước để nếu mất mạng vẫn có thông tin
        lblQRThongTin.Text = $"{shopName}\r\n" +
                             $"Ngân hàng: {bankId.ToUpper()}\r\n" +
                             $"STK: {accNo}\r\n" +
                             $"Chủ TK: {accName}\r\n" +
                             $"Số tiền: {tongTien:N0} đ\r\n" +
                             $"Nội dung CK: {noiDung}";

        picVietQR.Image = null;

        try
        {
            byte[] imageBytes = await _httpClient.GetByteArrayAsync(qrUrl);
            using var ms = new MemoryStream(imageBytes);
            picVietQR.Image = Image.FromStream(ms);
        }
        catch (Exception ex)
        {
            Log.Error(ex, "Lỗi khi tải ảnh mã VietQR từ URL: {Url}", qrUrl);
            MessageBox.Show("Không thể tải mã QR do lỗi mạng. Bạn có thể cho khách quét chuyển khoản thủ công bằng thông tin hiển thị bên dưới, hoặc bấm 'Tiền mặt'!",
                "Cảnh báo kết nối", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void btnDaNhanTien_Click(object sender, EventArgs e)
    {
        if (_gioHang.Count == 0)
        {
            MessageBox.Show("Giỏ hàng đang trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        LuuHoaDon("Chuyển khoản");
    }

    private void btnTienMat_Click(object sender, EventArgs e)
    {
        if (_gioHang.Count == 0)
        {
            MessageBox.Show("Giỏ hàng đang trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        LuuHoaDon("Tiền mặt");
    }

    private void LuuHoaDon(string hinhThucTt)
    {
        try
        {
            using var db = new QlTraSuaContext();
            decimal tongTien = _gioHang.Sum(g => g.ThanhTien);

            var hoaDon = new HoaDon
            {
                NgayLap = DateTime.Now,
                TongTien = tongTien,
                HinhThucTt = hinhThucTt,
                DaThanhToan = true
            };

            foreach (var item in _gioHang)
            {
                hoaDon.ChiTietHoaDons.Add(new ChiTietHoaDon
                {
                    MaMon = item.MaMon,
                    SoLy = item.SoLuong,
                    DonGia = item.DonGia
                });
            }

            db.HoaDons.Add(hoaDon);
            db.SaveChanges(); // Lưu cả HoaDon và ChiTietHoaDon trong 1 lần SaveChanges

            Log.Information("Đã lưu hóa đơn thành công: MaHD={MaHd}, HinhThuc={HinhThuc}, TongTien={TongTien}",
                hoaDon.MaHd, hinhThucTt, tongTien);

            MessageBox.Show($"Thanh toán thành công hóa đơn #{hoaDon.MaHd} ({hinhThucTt}) với số tiền {tongTien:N0} đ!",
                "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Dọn dẹp giỏ hàng
            _gioHang.Clear();
            _currentPendingOrderCode = null;
            picVietQR.Image = null;
            lblQRThongTin.Text = "Số tiền: 0 đ\r\nNội dung: --\r\nChủ TK: --\r\nSTK: --";
            CapNhatGioHang();

            // Làm mới tab Lịch sử hóa đơn
            LoadHoaDonTheoNgay(dtpLocNgayHD.Value.Date);
        }
        catch (Exception ex)
        {
            Log.Error(ex, "Lỗi khi lưu hóa đơn");
            MessageBox.Show("Đã xảy ra lỗi khi lưu hóa đơn vào CSDL!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    #endregion

    #region TAB 2: THỰC ĐƠN (CRUD & TÌM KIẾM)
    private void LoadThucDon()
    {
        try
        {
            using var db = new QlTraSuaContext();
            var query = db.MonUongs.Include(m => m.MaDmNavigation).AsQueryable();

            string keyword = txtTimTenMon.Text.Trim();
            if (!string.IsNullOrEmpty(keyword))
            {
                query = query.Where(m => m.TenMon.Contains(keyword));
            }

            if (cboLocDanhMuc.SelectedValue != null && int.TryParse(cboLocDanhMuc.SelectedValue.ToString(), out int maDm) && maDm > 0)
            {
                query = query.Where(m => m.MaDm == maDm);
            }

            var list = query.OrderBy(m => m.MaDm).ThenBy(m => m.TenMon).Select(m => new
            {
                m.MaMon,
                m.TenMon,
                m.MaDm,
                TenDm = m.MaDmNavigation.TenDm,
                m.GiaBan,
                m.DangBan
            }).ToList();

            dgvThucDon.DataSource = list;
        }
        catch (Exception ex)
        {
            Log.Error(ex, "Lỗi khi nạp danh sách thực đơn");
        }
    }

    private void dgvThucDon_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.RowIndex >= dgvThucDon.Rows.Count) return;

        dynamic? item = dgvThucDon.Rows[e.RowIndex].DataBoundItem;
        if (item == null) return;

        _selectedMaMon = item.MaMon;
        txtTenMon.Text = item.TenMon;
        cboDanhMucThucDon.SelectedValue = (int)item.MaDm;
        nudGiaBan.Value = (decimal)item.GiaBan;
        chkDangBan.Checked = (bool)item.DangBan;
    }

    private void btnThemMon_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtTenMon.Text))
        {
            MessageBox.Show("Tên món không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtTenMon.Focus();
            return;
        }

        if (cboDanhMucThucDon.SelectedValue == null)
        {
            MessageBox.Show("Vui lòng chọn danh mục!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        try
        {
            using var db = new QlTraSuaContext();
            var mon = new MonUong
            {
                TenMon = txtTenMon.Text.Trim(),
                MaDm = Convert.ToInt32(cboDanhMucThucDon.SelectedValue),
                GiaBan = nudGiaBan.Value,
                DangBan = chkDangBan.Checked
            };

            db.MonUongs.Add(mon);
            db.SaveChanges();

            Log.Information("Thêm món mới: MaMon={MaMon}, TenMon={TenMon}, GiaBan={GiaBan}", mon.MaMon, mon.TenMon, mon.GiaBan);
            MessageBox.Show("Thêm món mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearThucDonInput();
            LoadThucDon();
            LoadMonUongTheoDanhMuc();
        }
        catch (Exception ex)
        {
            Log.Error(ex, "Lỗi khi thêm món");
            MessageBox.Show("Lỗi khi thêm món vào CSDL!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnSuaMon_Click(object sender, EventArgs e)
    {
        if (_selectedMaMon == null)
        {
            MessageBox.Show("Vui lòng chọn món để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        if (string.IsNullOrWhiteSpace(txtTenMon.Text))
        {
            MessageBox.Show("Tên món không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        try
        {
            using var db = new QlTraSuaContext();
            var mon = db.MonUongs.Find(_selectedMaMon.Value);
            if (mon != null)
            {
                mon.TenMon = txtTenMon.Text.Trim();
                mon.MaDm = Convert.ToInt32(cboDanhMucThucDon.SelectedValue);
                mon.GiaBan = nudGiaBan.Value;
                mon.DangBan = chkDangBan.Checked;

                db.SaveChanges();
                Log.Information("Cập nhật món: MaMon={MaMon}, TenMon={TenMon}", mon.MaMon, mon.TenMon);
                MessageBox.Show("Cập nhật món thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            ClearThucDonInput();
            LoadThucDon();
            LoadMonUongTheoDanhMuc();
        }
        catch (Exception ex)
        {
            Log.Error(ex, "Lỗi khi sửa món");
            MessageBox.Show("Lỗi khi cập nhật món!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnXoaMon_Click(object sender, EventArgs e)
    {
        if (_selectedMaMon == null)
        {
            MessageBox.Show("Vui lòng chọn món cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        var confirm = MessageBox.Show($"Bạn có chắc chắn muốn xóa món mã {_selectedMaMon}?", "Xác nhận xóa",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (confirm != DialogResult.Yes) return;

        try
        {
            using var db = new QlTraSuaContext();
            var mon = db.MonUongs.Find(_selectedMaMon.Value);
            if (mon != null)
            {
                // Kiểm tra xem món đã có trong hóa đơn chưa
                bool inHoaDon = db.ChiTietHoaDons.Any(c => c.MaMon == mon.MaMon);
                if (inHoaDon)
                {
                    // Nếu đã có trong hóa đơn, chỉ cần ngừng bán
                    mon.DangBan = false;
                    db.SaveChanges();
                    MessageBox.Show("Món này đã phát sinh trong các hóa đơn cũ nên đã được chuyển trạng thái sang 'Ngừng bán' thay vì xóa hoàn toàn.",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    db.MonUongs.Remove(mon);
                    db.SaveChanges();
                    MessageBox.Show("Xóa món thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            ClearThucDonInput();
            LoadThucDon();
            LoadMonUongTheoDanhMuc();
        }
        catch (Exception ex)
        {
            Log.Error(ex, "Lỗi khi xóa món");
            MessageBox.Show("Lỗi khi xóa món!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnLamMoiMon_Click(object sender, EventArgs e)
    {
        ClearThucDonInput();
        txtTimTenMon.Text = string.Empty;
        cboLocDanhMuc.SelectedIndex = 0;
        LoadThucDon();
    }

    private void btnTimMon_Click(object sender, EventArgs e)
    {
        LoadThucDon();
    }

    private void ClearThucDonInput()
    {
        _selectedMaMon = null;
        txtTenMon.Text = string.Empty;
        if (cboDanhMucThucDon.Items.Count > 0) cboDanhMucThucDon.SelectedIndex = 0;
        nudGiaBan.Value = 30000;
        chkDangBan.Checked = true;
        dgvThucDon.ClearSelection();
    }
    #endregion

    #region TAB 3: LỊCH SỬ HÓA ĐƠN
    private void btnLocHD_Click(object sender, EventArgs e)
    {
        LoadHoaDonTheoNgay(dtpLocNgayHD.Value.Date);
    }

    private void LoadHoaDonTheoNgay(DateTime ngay)
    {
        try
        {
            using var db = new QlTraSuaContext();
            var start = ngay.Date;
            var end = start.AddDays(1);

            var hoaDons = db.HoaDons
                .Where(h => h.NgayLap >= start && h.NgayLap < end)
                .OrderByDescending(h => h.NgayLap)
                .ToList();

            dgvHoaDon.DataSource = hoaDons;

            decimal doanhThu = hoaDons.Sum(h => h.TongTien);
            lblDoanhThuNgay.Text = $"Doanh thu ngày {ngay:dd/MM/yyyy}: {doanhThu:N0} đ";

            dgvChiTietHD.DataSource = null;
        }
        catch (Exception ex)
        {
            Log.Error(ex, "Lỗi khi nạp lịch sử hóa đơn");
        }
    }

    private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.RowIndex >= dgvHoaDon.Rows.Count) return;

        if (dgvHoaDon.Rows[e.RowIndex].DataBoundItem is HoaDon hd)
        {
            try
            {
                using var db = new QlTraSuaContext();
                var details = db.ChiTietHoaDons
                    .Include(c => c.MaMonNavigation)
                    .Where(c => c.MaHd == hd.MaHd)
                    .Select(c => new
                    {
                        TenMon = c.MaMonNavigation.TenMon,
                        c.SoLy,
                        c.DonGia,
                        ThanhTien = c.SoLy * c.DonGia
                    })
                    .ToList();

                dgvChiTietHD.DataSource = details;
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Lỗi khi nạp chi tiết hóa đơn MaHD={MaHd}", hd.MaHd);
            }
        }
    }
    #endregion
}

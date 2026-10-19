using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bai_2.Models;
using Microsoft.EntityFrameworkCore;
using Serilog;

namespace Bai_2;

public partial class FormKhachThue : Form
{
    private static readonly HttpClient _httpClient = new HttpClient
    {
        Timeout = TimeSpan.FromSeconds(10)
    };

    private int? _selectedMaKhach = null;
    private List<ProvinceDto> _provinces = new();
    private bool _isLoadingWards = false;

    public FormKhachThue()
    {
        InitializeComponent();
    }

    private async void FormKhachThue_Load(object sender, EventArgs e)
    {
        SetupDataGridView();
        LoadRooms();
        LoadData();
        await LoadProvincesAsync();
    }

    private void SetupDataGridView()
    {
        dgvKhachThue.AutoGenerateColumns = false;
        dgvKhachThue.Columns.Clear();

        dgvKhachThue.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "HoTen",
            HeaderText = "Họ tên",
            Width = 140
        });

        dgvKhachThue.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "SoDienThoai",
            HeaderText = "SĐT",
            Width = 100
        });

        dgvKhachThue.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "TenPhong",
            HeaderText = "Phòng",
            Width = 70,
            DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
        });

        dgvKhachThue.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "GiaThue",
            HeaderText = "Giá thuê",
            Width = 110,
            DefaultCellStyle = new DataGridViewCellStyle { Format = "N0", Alignment = DataGridViewContentAlignment.MiddleRight }
        });

        dgvKhachThue.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "QueQuan",
            HeaderText = "Quê quán",
            Width = 160
        });

        dgvKhachThue.Columns.Add(new DataGridViewCheckBoxColumn
        {
            DataPropertyName = "DaDangKyTamTru",
            HeaderText = "Tạm trú",
            Width = 70
        });
    }

    private void LoadRooms()
    {
        try
        {
            using var db = new QlNhaTroContext();
            var rooms = db.PhongTros.OrderBy(p => p.TenPhong).ToList();

            cboPhong.DisplayMember = "DisplayText";
            cboPhong.ValueMember = "MaPhong";
            cboPhong.DataSource = rooms.Select(p => new
            {
                p.MaPhong,
                p.TenPhong,
                DisplayText = $"{p.TenPhong} - {p.GiaThue:N0} đ ({p.TinhTrang})"
            }).ToList();

            // Cấu hình ComboBox lọc phòng
            var filterRooms = new List<dynamic>
            {
                new { MaPhong = 0, DisplayText = "Tất cả" }
            };
            filterRooms.AddRange(rooms.Select(p => new { p.MaPhong, DisplayText = p.TenPhong }));

            cboLocPhong.DisplayMember = "DisplayText";
            cboLocPhong.ValueMember = "MaPhong";
            cboLocPhong.DataSource = filterRooms;
            cboLocPhong.SelectedIndex = 0;
        }
        catch (Exception ex)
        {
            Log.Error(ex, "Lỗi khi nạp danh sách phòng trọ");
        }
    }

    private async Task LoadProvincesAsync()
    {
        cboTinhThanh.Enabled = false;
        lblStatus.Text = "Đang tải danh sách tỉnh/thành...";

        try
        {
            var provinces = await _httpClient.GetFromJsonAsync<List<ProvinceDto>>("https://provinces.open-api.vn/api/v2/");
            if (provinces != null && provinces.Count > 0)
            {
                _provinces = provinces;

                cboTinhThanh.DisplayMember = "Name";
                cboTinhThanh.ValueMember = "Code";
                cboTinhThanh.DataSource = _provinces;

                // Load cho cboLocTinh
                var locTinhList = new List<string> { "Tất cả" };
                locTinhList.AddRange(_provinces.Select(p => p.Name));
                cboLocTinh.DataSource = locTinhList;
                cboLocTinh.SelectedIndex = 0;

                lblStatus.Text = $"Đã tải {_provinces.Count} tỉnh/thành từ provinces.open-api.vn";
                Log.Information("Tải thành công {Count} tỉnh/thành từ API.", _provinces.Count);
            }
            else
            {
                lblStatus.Text = "Không nhận được dữ liệu tỉnh/thành.";
            }
        }
        catch (Exception ex) when (ex is HttpRequestException or TaskCanceledException or JsonException)
        {
            Log.Warning(ex, "Không thể kết nối đến API tỉnh/thành.");
            lblStatus.Text = "Không tải được danh sách địa chỉ, vui lòng kiểm tra mạng";
            MessageBox.Show("Không tải được danh sách địa chỉ, vui lòng kiểm tra mạng. Bạn có thể tự gõ tên xã/phường để lưu.",
                "Cảnh báo kết nối", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            cboPhuongXa.DropDownStyle = ComboBoxStyle.DropDown;
        }
        finally
        {
            cboTinhThanh.Enabled = true;
        }
    }

    private async void cboTinhThanh_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (cboTinhThanh.SelectedValue == null || !int.TryParse(cboTinhThanh.SelectedValue.ToString(), out int code))
        {
            return;
        }

        if (_isLoadingWards) return;
        _isLoadingWards = true;

        cboPhuongXa.DataSource = null;
        cboPhuongXa.Items.Clear();
        cboPhuongXa.Text = "Đang tải...";
        cboPhuongXa.Enabled = false;

        try
        {
            string url = $"https://provinces.open-api.vn/api/v2/p/{code}?depth=2";
            var provinceDetail = await _httpClient.GetFromJsonAsync<ProvinceDto>(url);

            if (provinceDetail?.Wards != null && provinceDetail.Wards.Count > 0)
            {
                cboPhuongXa.DisplayMember = "Name";
                cboPhuongXa.ValueMember = "Code";
                cboPhuongXa.DataSource = provinceDetail.Wards;
            }
            else
            {
                cboPhuongXa.Text = string.Empty;
            }
        }
        catch (Exception ex) when (ex is HttpRequestException or TaskCanceledException or JsonException)
        {
            Log.Warning(ex, "Không thể nạp danh sách phường/xã cho tỉnh code={Code}", code);
            cboPhuongXa.Text = string.Empty;
        }
        finally
        {
            cboPhuongXa.Enabled = true;
            _isLoadingWards = false;
        }
    }

    private void LoadData()
    {
        try
        {
            using var db = new QlNhaTroContext();
            var query = db.KhachThues.Include(k => k.MaPhongNavigation).AsQueryable();

            string keyword = txtTimKiem.Text.Trim();
            if (!string.IsNullOrEmpty(keyword))
            {
                query = query.Where(k => k.HoTen.Contains(keyword) || k.SoDienThoai.Contains(keyword));
            }

            if (cboLocPhong.SelectedValue != null && int.TryParse(cboLocPhong.SelectedValue.ToString(), out int filterPhong) && filterPhong > 0)
            {
                query = query.Where(k => k.MaPhong == filterPhong);
            }

            string filterTinh = cboLocTinh.SelectedItem?.ToString() ?? "Tất cả";
            if (filterTinh != "Tất cả" && !string.IsNullOrEmpty(filterTinh))
            {
                query = query.Where(k => k.TenTinh == filterTinh);
            }

            var list = query.OrderBy(k => k.MaPhong).ThenBy(k => k.HoTen).Select(k => new
            {
                k.MaKhach,
                k.HoTen,
                k.GioiTinh,
                k.NgaySinh,
                k.SoDienThoai,
                k.MaPhong,
                TenPhong = k.MaPhongNavigation.TenPhong,
                GiaThue = k.MaPhongNavigation.GiaThue,
                k.MaTinh,
                k.TenTinh,
                k.MaPhuongXa,
                k.TenPhuongXa,
                QueQuan = $"{k.TenPhuongXa} – {k.TenTinh}",
                k.DaDangKyTamTru
            }).ToList();

            dgvKhachThue.DataSource = list;
        }
        catch (Exception ex)
        {
            Log.Error(ex, "Lỗi khi truy cập CSDL trong LoadData FormKhachThue");
            MessageBox.Show("Đã xảy ra lỗi khi tải danh sách khách thuê!", "Lỗi kết nối CSDL", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void dgvKhachThue_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.RowIndex >= dgvKhachThue.Rows.Count) return;

        dynamic? item = dgvKhachThue.Rows[e.RowIndex].DataBoundItem;
        if (item == null) return;

        _selectedMaKhach = item.MaKhach;
        txtHoTen.Text = item.HoTen;
        if (item.GioiTinh == "Nữ") radNu.Checked = true;
        else radNam.Checked = true;

        dtpNgaySinh.Value = ((DateOnly)item.NgaySinh).ToDateTime(TimeOnly.MinValue);
        txtSoDienThoai.Text = item.SoDienThoai;
        cboPhong.SelectedValue = (int)item.MaPhong;

        if (cboTinhThanh.Items.Count > 0)
        {
            cboTinhThanh.SelectedValue = (int)item.MaTinh;
        }
        cboPhuongXa.Text = item.TenPhuongXa;
        chkDaDangKyTamTru.Checked = (bool)item.DaDangKyTamTru;
    }

    private bool ValidateInputs()
    {
        if (string.IsNullOrWhiteSpace(txtHoTen.Text))
        {
            MessageBox.Show("Vui lòng nhập họ tên khách thuê!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtHoTen.Focus();
            return false;
        }

        if (string.IsNullOrWhiteSpace(txtSoDienThoai.Text))
        {
            MessageBox.Show("Vui lòng nhập số điện thoại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtSoDienThoai.Focus();
            return false;
        }

        if (cboPhong.SelectedValue == null)
        {
            MessageBox.Show("Vui lòng chọn phòng trọ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            cboPhong.Focus();
            return false;
        }

        return true;
    }

    private void btnThem_Click(object sender, EventArgs e)
    {
        if (!ValidateInputs()) return;

        try
        {
            using var db = new QlNhaTroContext();

            int maPhong = Convert.ToInt32(cboPhong.SelectedValue);
            int maTinh = cboTinhThanh.SelectedValue != null && int.TryParse(cboTinhThanh.SelectedValue.ToString(), out int mt) ? mt : 0;
            string tenTinh = cboTinhThanh.Text;
            int maPhuongXa = cboPhuongXa.SelectedValue != null && int.TryParse(cboPhuongXa.SelectedValue.ToString(), out int mpx) ? mpx : 0;
            string tenPhuongXa = cboPhuongXa.Text;

            var khach = new KhachThue
            {
                HoTen = txtHoTen.Text.Trim(),
                GioiTinh = radNu.Checked ? "Nữ" : "Nam",
                NgaySinh = DateOnly.FromDateTime(dtpNgaySinh.Value.Date),
                SoDienThoai = txtSoDienThoai.Text.Trim(),
                MaPhong = maPhong,
                MaTinh = maTinh,
                TenTinh = tenTinh,
                MaPhuongXa = maPhuongXa,
                TenPhuongXa = tenPhuongXa,
                DaDangKyTamTru = chkDaDangKyTamTru.Checked
            };

            db.KhachThues.Add(khach);

            // Cập nhật trạng thái phòng thành "Đang thuê"
            var phong = db.PhongTros.Find(maPhong);
            if (phong != null)
            {
                phong.TinhTrang = "Đang thuê";
            }

            db.SaveChanges();

            Log.Information("Thêm khách thuê thành công: MaKhach={MaKhach}, HoTen={HoTen}, MaPhong={MaPhong}",
                khach.MaKhach, khach.HoTen, maPhong);

            MessageBox.Show("Thêm khách thuê thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearInput();
            LoadRooms();
            LoadData();
        }
        catch (Exception ex)
        {
            Log.Error(ex, "Lỗi khi thêm khách thuê");
            MessageBox.Show("Đã xảy ra lỗi khi thêm khách thuê vào CSDL!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnSua_Click(object sender, EventArgs e)
    {
        if (_selectedMaKhach == null)
        {
            MessageBox.Show("Vui lòng chọn khách thuê cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        if (!ValidateInputs()) return;

        try
        {
            using var db = new QlNhaTroContext();
            var khach = db.KhachThues.Find(_selectedMaKhach.Value);
            if (khach == null)
            {
                MessageBox.Show("Khách thuê không tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LoadData();
                return;
            }

            int oldMaPhong = khach.MaPhong;
            int newMaPhong = Convert.ToInt32(cboPhong.SelectedValue);

            khach.HoTen = txtHoTen.Text.Trim();
            khach.GioiTinh = radNu.Checked ? "Nữ" : "Nam";
            khach.NgaySinh = DateOnly.FromDateTime(dtpNgaySinh.Value.Date);
            khach.SoDienThoai = txtSoDienThoai.Text.Trim();
            khach.MaPhong = newMaPhong;
            if (cboTinhThanh.SelectedValue != null && int.TryParse(cboTinhThanh.SelectedValue.ToString(), out int mt))
                khach.MaTinh = mt;
            khach.TenTinh = cboTinhThanh.Text;
            if (cboPhuongXa.SelectedValue != null && int.TryParse(cboPhuongXa.SelectedValue.ToString(), out int mpx))
                khach.MaPhuongXa = mpx;
            khach.TenPhuongXa = cboPhuongXa.Text;
            khach.DaDangKyTamTru = chkDaDangKyTamTru.Checked;

            // Nếu chuyển phòng:
            if (oldMaPhong != newMaPhong)
            {
                // Phòng mới chuyển Đang thuê
                var newPhong = db.PhongTros.Find(newMaPhong);
                if (newPhong != null) newPhong.TinhTrang = "Đang thuê";

                // Kiểm tra phòng cũ còn ai không
                bool hasOtherInOld = db.KhachThues.Any(k => k.MaPhong == oldMaPhong && k.MaKhach != khach.MaKhach);
                if (!hasOtherInOld)
                {
                    var oldPhong = db.PhongTros.Find(oldMaPhong);
                    if (oldPhong != null) oldPhong.TinhTrang = "Trống";
                }
            }

            db.SaveChanges();

            Log.Information("Cập nhật khách thuê thành công: MaKhach={MaKhach}, HoTen={HoTen}", khach.MaKhach, khach.HoTen);
            MessageBox.Show("Cập nhật khách thuê thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearInput();
            LoadRooms();
            LoadData();
        }
        catch (Exception ex)
        {
            Log.Error(ex, "Lỗi khi sửa khách thuê MaKhach={MaKhach}", _selectedMaKhach);
            MessageBox.Show("Đã xảy ra lỗi khi cập nhật thông tin khách thuê!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnXoa_Click(object sender, EventArgs e)
    {
        if (_selectedMaKhach == null)
        {
            MessageBox.Show("Vui lòng chọn khách thuê cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        var confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa khách thuê này?", "Xác nhận xóa",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (confirm != DialogResult.Yes) return;

        try
        {
            using var db = new QlNhaTroContext();
            var khach = db.KhachThues.Find(_selectedMaKhach.Value);
            if (khach != null)
            {
                int maPhong = khach.MaPhong;
                int maKhach = khach.MaKhach;
                db.KhachThues.Remove(khach);

                // Nếu là người cuối cùng của phòng -> phòng trở lại "Trống"
                bool hasOther = db.KhachThues.Any(k => k.MaPhong == maPhong && k.MaKhach != maKhach);
                if (!hasOther)
                {
                    var phong = db.PhongTros.Find(maPhong);
                    if (phong != null) phong.TinhTrang = "Trống";
                }

                db.SaveChanges();

                Log.Information("Đã xóa khách thuê MaKhach={MaKhach}", maKhach);
                MessageBox.Show("Xóa khách thuê thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            ClearInput();
            LoadRooms();
            LoadData();
        }
        catch (Exception ex)
        {
            Log.Error(ex, "Lỗi khi xóa khách thuê MaKhach={MaKhach}", _selectedMaKhach);
            MessageBox.Show("Đã xảy ra lỗi khi xóa khách thuê!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnLamMoi_Click(object sender, EventArgs e)
    {
        ClearInput();
        LoadRooms();
        LoadData();
    }

    private void btnTim_Click(object sender, EventArgs e)
    {
        LoadData();
    }

    private void btnBoLoc_Click(object sender, EventArgs e)
    {
        txtTimKiem.Text = string.Empty;
        cboLocPhong.SelectedIndex = 0;
        if (cboLocTinh.Items.Count > 0) cboLocTinh.SelectedIndex = 0;
        LoadData();
    }

    private void btnGayLoiThu_Click(object sender, EventArgs e)
    {
        // Gây ra lỗi chưa xử lý để kiểm tra cơ chế bắt lỗi toàn cục
        throw new InvalidOperationException("Đây là lỗi thử nghiệm được kích hoạt từ nút 'Gây lỗi thử'.");
    }

    private void ClearInput()
    {
        _selectedMaKhach = null;
        txtHoTen.Text = string.Empty;
        radNam.Checked = true;
        dtpNgaySinh.Value = new DateTime(2000, 1, 1);
        txtSoDienThoai.Text = string.Empty;
        chkDaDangKyTamTru.Checked = false;
        cboPhuongXa.DataSource = null;
        cboPhuongXa.Items.Clear();
        cboPhuongXa.Text = string.Empty;
        dgvKhachThue.ClearSelection();
    }
}

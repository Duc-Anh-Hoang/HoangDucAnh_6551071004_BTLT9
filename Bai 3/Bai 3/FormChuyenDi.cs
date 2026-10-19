using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bai_3.Models;
using Serilog;

namespace Bai_3;

public partial class FormChuyenDi : Form
{
    private static readonly HttpClient _httpClient = new HttpClient
    {
        Timeout = TimeSpan.FromSeconds(8)
    };

    private int? _selectedMaChuyen = null;
    private UserSettings _userSettings = new();
    private bool _isEnglish = false;

    public FormChuyenDi()
    {
        InitializeComponent();
    }

    private void FormChuyenDi_Load(object sender, EventArgs e)
    {
        _userSettings = UserSettings.Load();
        _isEnglish = _userSettings.Language.StartsWith("en", StringComparison.OrdinalIgnoreCase);
        cboNgonNgu.SelectedIndex = _isEnglish ? 1 : 0;

        cboPhuongTien.SelectedIndex = 0;
        var today = DateTime.Today;
        dtpNgayDi.Value = today.AddDays(3);
        dtpTuNgay.Value = today;
        dtpDenNgay.Value = today.AddDays(30);

        ApplyLanguage();
        SetupDataGridView();
        LoadData();
    }

    private void SetupDataGridView()
    {
        dgvChuyenDi.AutoGenerateColumns = false;
        dgvChuyenDi.Columns.Clear();

        dgvChuyenDi.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "MaChuyen",
            HeaderText = _isEnglish ? "ID" : "Mã",
            Width = 50,
            DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
        });

        dgvChuyenDi.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "TenChuyen",
            HeaderText = _isEnglish ? "Trip Name" : "Tên chuyến",
            Width = 160
        });

        dgvChuyenDi.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "DiaDiem",
            HeaderText = _isEnglish ? "Destination" : "Địa điểm",
            Width = 120
        });

        dgvChuyenDi.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "NgayDi",
            HeaderText = _isEnglish ? "Departure Date" : "Ngày đi",
            Width = 100,
            DefaultCellStyle = new DataGridViewCellStyle
            {
                Format = _isEnglish ? "MM/dd/yyyy" : "dd/MM/yyyy",
                Alignment = DataGridViewContentAlignment.MiddleCenter
            }
        });

        dgvChuyenDi.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "SoNguoi",
            HeaderText = _isEnglish ? "People" : "Số người",
            Width = 70,
            DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
        });

        dgvChuyenDi.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "NganSach",
            HeaderText = _isEnglish ? "Budget" : "Ngân sách",
            Width = 110,
            DefaultCellStyle = new DataGridViewCellStyle
            {
                Format = "N0",
                Alignment = DataGridViewContentAlignment.MiddleRight
            }
        });

        dgvChuyenDi.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "PhuongTien",
            HeaderText = _isEnglish ? "Vehicle" : "Phương tiện",
            Width = 100
        });

        dgvChuyenDi.Columns.Add(new DataGridViewCheckBoxColumn
        {
            DataPropertyName = "DaHoanThanh",
            HeaderText = _isEnglish ? "Completed" : "Hoàn thành",
            Width = 80
        });
    }

    private void cboNgonNgu_SelectedIndexChanged(object sender, EventArgs e)
    {
        _isEnglish = cboNgonNgu.SelectedIndex == 1;
        _userSettings.Language = _isEnglish ? "en-US" : "vi-VN";
        _userSettings.Save();

        ApplyLanguage();
        SetupDataGridView();
        LoadData();
    }

    private void ApplyLanguage()
    {
        if (_isEnglish)
        {
            this.Text = "Weekend Picnic Planner";
            lblNgonNgu.Text = "Language:";
            grpThongTin.Text = "Trip Information";
            lblTenChuyen.Text = "Trip Name:";
            lblDiaDiem.Text = "Destination:";
            lblNgayDi.Text = "Date:";
            lblSoNguoi.Text = "People:";
            lblNganSach.Text = "Budget:";
            lblPhuongTien.Text = "Transport:";
            chkDaHoanThanh.Text = "Completed";

            btnThem.Text = "Add";
            btnSua.Text = "Update";
            btnXoa.Text = "Delete";
            btnLamMoi.Text = "Reset";

            grpThoiTiet.Text = "Weather Forecast";
            btnXemThoiTiet.Text = "Get Weather";
            lblThoiTietTieuDe.Text = "Select a trip to view weather forecast";

            grpTimKiem.Text = "Search & Filter";
            txtTimDiaDiem.PlaceholderText = "Search trip or destination...";
            chkChuaHoanThanh.Text = "Unfinished only";
            lblTuNgay.Text = "From:";
            lblDenNgay.Text = "To:";
            btnTim.Text = "Filter";
            dtpNgayDi.CustomFormat = "MM/dd/yyyy";
            dtpTuNgay.CustomFormat = "MM/dd/yyyy";
            dtpDenNgay.CustomFormat = "MM/dd/yyyy";
        }
        else
        {
            this.Text = "Kế hoạch dã ngoại cuối tuần";
            lblNgonNgu.Text = "Ngôn ngữ:";
            grpThongTin.Text = "Thông tin chuyến đi";
            lblTenChuyen.Text = "Tên chuyến:";
            lblDiaDiem.Text = "Địa điểm:";
            lblNgayDi.Text = "Ngày đi:";
            lblSoNguoi.Text = "Số người:";
            lblNganSach.Text = "Ngân sách:";
            lblPhuongTien.Text = "Phương tiện:";
            chkDaHoanThanh.Text = "Đã hoàn thành";

            btnThem.Text = "Thêm";
            btnSua.Text = "Sửa";
            btnXoa.Text = "Xóa";
            btnLamMoi.Text = "Làm mới";

            grpThoiTiet.Text = "Dự báo thời tiết";
            btnXemThoiTiet.Text = "Xem thời tiết";
            lblThoiTietTieuDe.Text = "Chọn một chuyến đi để xem dự báo";

            grpTimKiem.Text = "Tìm kiếm & Lọc";
            txtTimDiaDiem.PlaceholderText = "Tìm tên chuyến hoặc địa điểm...";
            chkChuaHoanThanh.Text = "Chỉ hiện chuyến chưa xong";
            lblTuNgay.Text = "Từ:";
            lblDenNgay.Text = "Đến:";
            btnTim.Text = "Tìm kiếm";
            dtpNgayDi.CustomFormat = "dd/MM/yyyy";
            dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            dtpDenNgay.CustomFormat = "dd/MM/yyyy";
        }
    }

    private void LoadData()
    {
        try
        {
            using var db = new QlDaNgoaiContext();
            var query = db.ChuyenDis.AsQueryable();

            string keyword = txtTimDiaDiem.Text.Trim();
            if (!string.IsNullOrEmpty(keyword))
            {
                query = query.Where(c => c.TenChuyen.Contains(keyword) || c.DiaDiem.Contains(keyword));
            }

            if (chkChuaHoanThanh.Checked)
            {
                query = query.Where(c => !c.DaHoanThanh);
            }

            var tuNgay = DateOnly.FromDateTime(dtpTuNgay.Value.Date);
            var denNgay = DateOnly.FromDateTime(dtpDenNgay.Value.Date);
            query = query.Where(c => c.NgayDi >= tuNgay && c.NgayDi <= denNgay);

            var list = query.OrderBy(c => c.NgayDi).ToList();
            dgvChuyenDi.DataSource = list;
        }
        catch (Exception ex)
        {
            Log.Error(ex, "Lỗi khi nạp danh sách chuyến đi");
            MessageBox.Show(_isEnglish ? "Error loading trips from database!" : "Đã xảy ra lỗi khi tải danh sách chuyến đi!",
                _isEnglish ? "Database Error" : "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void dgvChuyenDi_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.RowIndex >= dgvChuyenDi.Rows.Count) return;

        if (dgvChuyenDi.Rows[e.RowIndex].DataBoundItem is ChuyenDi item)
        {
            _selectedMaChuyen = item.MaChuyen;
            txtTenChuyen.Text = item.TenChuyen;
            txtDiaDiem.Text = item.DiaDiem;
            dtpNgayDi.Value = item.NgayDi.ToDateTime(TimeOnly.MinValue);
            nudSoNguoi.Value = item.SoNguoi;
            nudNganSach.Value = item.NganSach;
            cboPhuongTien.SelectedItem = item.PhuongTien;
            chkDaHoanThanh.Checked = item.DaHoanThanh;

            // Tự động xem dự báo thời tiết khi chọn dòng
            _ = FetchWeatherAsync(item.DiaDiem, item.NgayDi);
        }
    }

    private bool ValidateInputs(bool isAddingNew)
    {
        if (string.IsNullOrWhiteSpace(txtTenChuyen.Text))
        {
            MessageBox.Show(_isEnglish ? "Trip name cannot be empty!" : "Tên chuyến không được để trống!",
                _isEnglish ? "Warning" : "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtTenChuyen.Focus();
            return false;
        }

        if (string.IsNullOrWhiteSpace(txtDiaDiem.Text))
        {
            MessageBox.Show(_isEnglish ? "Destination cannot be empty!" : "Địa điểm không được để trống!",
                _isEnglish ? "Warning" : "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtDiaDiem.Focus();
            return false;
        }

        if (isAddingNew && dtpNgayDi.Value.Date < DateTime.Today)
        {
            MessageBox.Show(_isEnglish ? "Departure date cannot be in the past!" : "Ngày đi không được nhỏ hơn hôm nay!",
                _isEnglish ? "Warning" : "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            dtpNgayDi.Focus();
            return false;
        }

        if (nudSoNguoi.Value < 1)
        {
            MessageBox.Show(_isEnglish ? "Number of people must be at least 1!" : "Số người phải từ 1 trở lên!",
                _isEnglish ? "Warning" : "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            nudSoNguoi.Focus();
            return false;
        }

        if (nudNganSach.Value < 0)
        {
            MessageBox.Show(_isEnglish ? "Budget cannot be negative!" : "Ngân sách phải từ 0 trở lên!",
                _isEnglish ? "Warning" : "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            nudNganSach.Focus();
            return false;
        }

        return true;
    }

    private void btnThem_Click(object sender, EventArgs e)
    {
        if (!ValidateInputs(true)) return;

        try
        {
            using var db = new QlDaNgoaiContext();
            var item = new ChuyenDi
            {
                TenChuyen = txtTenChuyen.Text.Trim(),
                DiaDiem = txtDiaDiem.Text.Trim(),
                NgayDi = DateOnly.FromDateTime(dtpNgayDi.Value.Date),
                SoNguoi = (int)nudSoNguoi.Value,
                NganSach = nudNganSach.Value,
                PhuongTien = cboPhuongTien.SelectedItem?.ToString() ?? "Ô tô",
                DaHoanThanh = chkDaHoanThanh.Checked,
                GhiChu = string.Empty
            };

            db.ChuyenDis.Add(item);
            db.SaveChanges();

            Log.Information("Thêm chuyến đi thành công: MaChuyen={MaChuyen}, TenChuyen={TenChuyen}", item.MaChuyen, item.TenChuyen);
            MessageBox.Show(_isEnglish ? "Trip added successfully!" : "Thêm chuyến đi thành công!",
                _isEnglish ? "Success" : "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearInput();
            LoadData();
        }
        catch (Exception ex)
        {
            Log.Error(ex, "Lỗi khi thêm chuyến đi");
            MessageBox.Show(_isEnglish ? "Error adding trip!" : "Đã xảy ra lỗi khi lưu vào CSDL!",
                _isEnglish ? "Error" : "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnSua_Click(object sender, EventArgs e)
    {
        if (_selectedMaChuyen == null)
        {
            MessageBox.Show(_isEnglish ? "Please select a trip to edit!" : "Vui lòng chọn một chuyến đi để sửa!",
                _isEnglish ? "Notice" : "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        if (!ValidateInputs(false)) return;

        try
        {
            using var db = new QlDaNgoaiContext();
            var item = db.ChuyenDis.Find(_selectedMaChuyen.Value);
            if (item == null)
            {
                MessageBox.Show(_isEnglish ? "Trip not found!" : "Chuyến đi không tồn tại!",
                    _isEnglish ? "Notice" : "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LoadData();
                return;
            }

            item.TenChuyen = txtTenChuyen.Text.Trim();
            item.DiaDiem = txtDiaDiem.Text.Trim();
            item.NgayDi = DateOnly.FromDateTime(dtpNgayDi.Value.Date);
            item.SoNguoi = (int)nudSoNguoi.Value;
            item.NganSach = nudNganSach.Value;
            item.PhuongTien = cboPhuongTien.SelectedItem?.ToString() ?? "Ô tô";
            item.DaHoanThanh = chkDaHoanThanh.Checked;

            db.SaveChanges();

            Log.Information("Cập nhật chuyến đi thành công: MaChuyen={MaChuyen}", item.MaChuyen);
            MessageBox.Show(_isEnglish ? "Trip updated successfully!" : "Cập nhật chuyến đi thành công!",
                _isEnglish ? "Success" : "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearInput();
            LoadData();
        }
        catch (Exception ex)
        {
            Log.Error(ex, "Lỗi khi sửa chuyến đi MaChuyen={MaChuyen}", _selectedMaChuyen);
            MessageBox.Show(_isEnglish ? "Error updating trip!" : "Đã xảy ra lỗi khi cập nhật CSDL!",
                _isEnglish ? "Error" : "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnXoa_Click(object sender, EventArgs e)
    {
        if (_selectedMaChuyen == null)
        {
            MessageBox.Show(_isEnglish ? "Please select a trip to delete!" : "Vui lòng chọn chuyến đi để xóa!",
                _isEnglish ? "Notice" : "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        var confirm = MessageBox.Show(
            _isEnglish ? $"Are you sure you want to delete trip #{_selectedMaChuyen}?" : $"Bạn có chắc chắn muốn xóa chuyến đi mã {_selectedMaChuyen}?",
            _isEnglish ? "Confirm delete" : "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (confirm != DialogResult.Yes) return;

        try
        {
            using var db = new QlDaNgoaiContext();
            var item = db.ChuyenDis.Find(_selectedMaChuyen.Value);
            if (item != null)
            {
                int ma = item.MaChuyen;
                db.ChuyenDis.Remove(item);
                db.SaveChanges();
                Log.Information("Đã xóa chuyến đi MaChuyen={MaChuyen}", ma);
                MessageBox.Show(_isEnglish ? "Trip deleted successfully!" : "Xóa chuyến đi thành công!",
                    _isEnglish ? "Success" : "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            ClearInput();
            LoadData();
        }
        catch (Exception ex)
        {
            Log.Error(ex, "Lỗi khi xóa chuyến đi MaChuyen={MaChuyen}", _selectedMaChuyen);
            MessageBox.Show(_isEnglish ? "Error deleting trip!" : "Đã xảy ra lỗi khi xóa chuyến đi!",
                _isEnglish ? "Error" : "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnLamMoi_Click(object sender, EventArgs e)
    {
        ClearInput();
        txtTimDiaDiem.Text = string.Empty;
        chkChuaHoanThanh.Checked = false;
        var today = DateTime.Today;
        dtpTuNgay.Value = today;
        dtpDenNgay.Value = today.AddDays(30);
        LoadData();
    }

    private void btnTim_Click(object sender, EventArgs e)
    {
        LoadData();
    }

    private async void btnXemThoiTiet_Click(object sender, EventArgs e)
    {
        string diaDiem = txtDiaDiem.Text.Trim();
        if (string.IsNullOrEmpty(diaDiem))
        {
            MessageBox.Show(_isEnglish ? "Please enter a destination first!" : "Vui lòng nhập địa điểm trước!",
                _isEnglish ? "Warning" : "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var ngayDi = DateOnly.FromDateTime(dtpNgayDi.Value.Date);
        await FetchWeatherAsync(diaDiem, ngayDi);
    }

    private async Task FetchWeatherAsync(string diaDiem, DateOnly ngayDi)
    {
        btnXemThoiTiet.Enabled = false;
        pbLoading.Visible = true;
        pnlThoiTietBox.BackColor = SystemColors.Control;
        lblCanhBao.Text = string.Empty;

        try
        {
            string dateStr = _isEnglish ? ngayDi.ToString("MM/dd/yyyy") : ngayDi.ToString("dd/MM/yyyy");
            lblThoiTietTieuDe.Text = _isEnglish
                ? $"Forecast for {dateStr} - {diaDiem}"
                : $"Dự báo thời tiết ngày {dateStr} - {diaDiem}";

            // Bước 1: Geocoding
            string geoUrl = $"https://geocoding-api.open-meteo.com/v1/search?name={Uri.EscapeDataString(diaDiem)}&count=1&language=vi";
            var geoRes = await _httpClient.GetFromJsonAsync<GeocodingResponse>(geoUrl);

            GeocodingResult? location = geoRes?.Results?.FirstOrDefault();

            // Nếu không tìm thấy, thử bỏ dấu tiếng Việt (ví dụ Đà Lạt -> Da Lat)
            if (location == null)
            {
                string unaccented = RemoveDiacritics(diaDiem);
                if (!string.Equals(unaccented, diaDiem, StringComparison.OrdinalIgnoreCase))
                {
                    string fallbackGeoUrl = $"https://geocoding-api.open-meteo.com/v1/search?name={Uri.EscapeDataString(unaccented)}&count=1&language=vi";
                    var fallbackGeoRes = await _httpClient.GetFromJsonAsync<GeocodingResponse>(fallbackGeoUrl);
                    location = fallbackGeoRes?.Results?.FirstOrDefault();
                }
            }

            if (location == null)
            {
                lblIconThoiTiet.Text = "❓";
                lblMoTaThoiTiet.Text = _isEnglish ? "Location not found" : "Không tìm thấy địa danh";
                lblNhietDo.Text = _isEnglish ? "Suggestion: try unaccented name (e.g. 'Da Lat')" : "Gợi ý: thử gõ tên không dấu như 'Da Lat'";
                lblKhaNangMua.Text = string.Empty;
                return;
            }

            // Bước 2: Forecast
            string forecastUrl = $"https://api.open-meteo.com/v1/forecast?latitude={location.Latitude}&longitude={location.Longitude}&daily=weather_code,temperature_2m_max,temperature_2m_min,precipitation_probability_max&timezone=auto&forecast_days=16";
            var forecastRes = await _httpClient.GetFromJsonAsync<ForecastResponse>(forecastUrl);

            if (forecastRes?.Daily?.Time == null || forecastRes.Daily.Time.Count == 0)
            {
                lblMoTaThoiTiet.Text = _isEnglish ? "No forecast data" : "Chưa có dữ liệu dự báo";
                return;
            }

            string targetDateStr = ngayDi.ToString("yyyy-MM-dd");
            int dateIndex = forecastRes.Daily.Time.IndexOf(targetDateStr);

            if (dateIndex < 0)
            {
                lblIconThoiTiet.Text = "📅";
                lblMoTaThoiTiet.Text = _isEnglish ? "No forecast data yet" : "Chưa có dữ liệu dự báo";
                lblNhietDo.Text = _isEnglish ? "Forecast only available for next 16 days" : "Ngày đi quá 16 ngày nên chưa có dự báo.";
                lblKhaNangMua.Text = string.Empty;
                return;
            }

            int weatherCode = forecastRes.Daily.WeatherCode != null && forecastRes.Daily.WeatherCode.Count > dateIndex
                ? forecastRes.Daily.WeatherCode[dateIndex] : 0;
            double tMax = forecastRes.Daily.Temperature2mMax != null && forecastRes.Daily.Temperature2mMax.Count > dateIndex
                ? forecastRes.Daily.Temperature2mMax[dateIndex] : 0;
            double tMin = forecastRes.Daily.Temperature2mMin != null && forecastRes.Daily.Temperature2mMin.Count > dateIndex
                ? forecastRes.Daily.Temperature2mMin[dateIndex] : 0;
            int precipProb = forecastRes.Daily.PrecipitationProbabilityMax != null && forecastRes.Daily.PrecipitationProbabilityMax.Count > dateIndex
                ? forecastRes.Daily.PrecipitationProbabilityMax[dateIndex] : 0;

            var (icon, desc) = GetWeatherDescription(weatherCode);

            lblIconThoiTiet.Text = icon;
            lblMoTaThoiTiet.Text = desc;
            lblNhietDo.Text = _isEnglish
                ? $"Temperature: {tMin:0.#}°C - {tMax:0.#}°C"
                : $"Nhiệt độ: {tMin:0.#}°C - {tMax:0.#}°C";
            lblKhaNangMua.Text = _isEnglish
                ? $"Precipitation chance: {precipProb}%"
                : $"Xác suất mưa: {precipProb}%";

            if (precipProb >= 60)
            {
                pnlThoiTietBox.BackColor = Color.FromArgb(255, 230, 200);
                lblCanhBao.ForeColor = Color.DarkRed;
                lblCanhBao.Text = _isEnglish
                    ? "⚠️ Should bring a raincoat or consider rescheduling"
                    : "⚠️ Nên mang áo mưa hoặc cân nhắc dời lịch";
            }
            else
            {
                pnlThoiTietBox.BackColor = Color.FromArgb(240, 255, 240);
                lblCanhBao.ForeColor = Color.DarkGreen;
                lblCanhBao.Text = _isEnglish ? "Weather is suitable for picnic!" : "Thời tiết thuận lợi cho dã ngoại!";
            }
        }
        catch (Exception ex) when (ex is HttpRequestException or TaskCanceledException)
        {
            Log.Warning(ex, "Lỗi kết nối khi lấy dữ liệu thời tiết cho {DiaDiem}", diaDiem);
            lblIconThoiTiet.Text = "⚠️";
            lblMoTaThoiTiet.Text = _isEnglish ? "Connection error" : "Lỗi kết nối mạng";
            lblNhietDo.Text = _isEnglish ? "Could not reach weather service" : "Không thể kết nối đến máy chủ thời tiết";
            lblKhaNangMua.Text = string.Empty;
        }
        catch (Exception ex)
        {
            Log.Error(ex, "Lỗi xử lý API thời tiết");
        }
        finally
        {
            btnXemThoiTiet.Enabled = true;
            pbLoading.Visible = false;
        }
    }

    private (string Icon, string Description) GetWeatherDescription(int code)
    {
        return code switch
        {
            0 => ("☀️", _isEnglish ? "Clear sky" : "Trời quang"),
            1 or 2 or 3 => ("⛅", _isEnglish ? "Partly cloudy" : "Có mây"),
            45 or 48 => ("🌫️", _isEnglish ? "Fog" : "Sương mù"),
            (>= 51 and <= 67) or (>= 80 and <= 82) => ("🌧️", _isEnglish ? "Rain" : "Mưa"),
            >= 95 and <= 99 => ("⛈️", _isEnglish ? "Thunderstorm" : "Dông"),
            _ => ("🌤️", _isEnglish ? "Fair" : "Thời tiết bình thường")
        };
    }

    private static string RemoveDiacritics(string text)
    {
        var normalizedString = text.Normalize(NormalizationForm.FormD);
        var stringBuilder = new StringBuilder(normalizedString.Length);

        foreach (var c in normalizedString)
        {
            var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
            if (unicodeCategory != UnicodeCategory.NonSpacingMark)
            {
                stringBuilder.Append(c);
            }
        }

        return stringBuilder.ToString().Normalize(NormalizationForm.FormC)
            .Replace("đ", "d").Replace("Đ", "D");
    }

    private void ClearInput()
    {
        _selectedMaChuyen = null;
        txtTenChuyen.Text = string.Empty;
        txtDiaDiem.Text = string.Empty;
        dtpNgayDi.Value = DateTime.Today.AddDays(3);
        nudSoNguoi.Value = 1;
        nudNganSach.Value = 0;
        cboPhuongTien.SelectedIndex = 0;
        chkDaHoanThanh.Checked = false;
        pnlThoiTietBox.BackColor = SystemColors.Control;
        lblIconThoiTiet.Text = string.Empty;
        lblMoTaThoiTiet.Text = "---";
        lblNhietDo.Text = _isEnglish ? "Temperature: --" : "Nhiệt độ: --";
        lblKhaNangMua.Text = _isEnglish ? "Precipitation chance: --" : "Khả năng mưa: --";
        lblCanhBao.Text = string.Empty;
        dgvChuyenDi.ClearSelection();
    }
}

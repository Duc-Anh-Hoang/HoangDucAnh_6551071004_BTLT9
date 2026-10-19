using System;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Bai_1.Models;
using Serilog;

namespace Bai_1;

public partial class FormChiTieu : Form
{
    private int? _selectedMaCt = null;
    private readonly string[] _loaiChiList = ["Ăn uống", "Đi lại", "Học tập", "Giải trí", "Khác"];

    public FormChiTieu()
    {
        InitializeComponent();
    }

    private void FormChiTieu_Load(object sender, EventArgs e)
    {
        try
        {
            cboLoaiChi.Items.AddRange(_loaiChiList);
            if (cboLoaiChi.Items.Count > 0) cboLoaiChi.SelectedIndex = 0;

            cboTimLoaiChi.Items.Add("Tất cả");
            cboTimLoaiChi.Items.AddRange(_loaiChiList);
            cboTimLoaiChi.SelectedIndex = 0;

            var today = DateTime.Today;
            dtpNgayChi.Value = today;
            dtpTuNgay.Value = new DateTime(today.Year, today.Month, 1);
            dtpDenNgay.Value = today;

            SetupDataGridView();
            LoadData();
        }
        catch (Exception ex)
        {
            Log.Error(ex, "Lỗi khi khởi tạo FormChiTieu");
            MessageBox.Show("Có lỗi xảy ra khi tải dữ liệu ban đầu. Vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void SetupDataGridView()
    {
        dgvChiTieu.AutoGenerateColumns = false;
        dgvChiTieu.Columns.Clear();

        dgvChiTieu.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "MaCt",
            HeaderText = "Mã",
            Width = 60,
            DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
        });

        dgvChiTieu.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "NgayChi",
            HeaderText = "Ngày chi",
            Width = 100,
            DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy", Alignment = DataGridViewContentAlignment.MiddleCenter }
        });

        dgvChiTieu.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "NoiDung",
            HeaderText = "Nội dung",
            Width = 200
        });

        dgvChiTieu.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "LoaiChi",
            HeaderText = "Loại chi",
            Width = 110
        });

        dgvChiTieu.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "SoTien",
            HeaderText = "Số tiền",
            Width = 120,
            DefaultCellStyle = new DataGridViewCellStyle { Format = "N0", Alignment = DataGridViewContentAlignment.MiddleRight }
        });

        dgvChiTieu.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "GhiChu",
            HeaderText = "Ghi chú",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        });
    }

    private void LoadData()
    {
        try
        {
            using var db = new QlChiTieuContext();
            var query = db.ChiTieus.AsQueryable();

            // Tìm theo nội dung
            string keyword = txtTimNoiDung.Text.Trim();
            if (!string.IsNullOrEmpty(keyword))
            {
                query = query.Where(c => c.NoiDung.Contains(keyword));
            }

            // Lọc theo loại chi
            string loaiChi = cboTimLoaiChi.SelectedItem?.ToString() ?? "Tất cả";
            if (loaiChi != "Tất cả")
            {
                query = query.Where(c => c.LoaiChi == loaiChi);
            }

            // Lọc từ ngày - đến ngày
            var tuNgay = DateOnly.FromDateTime(dtpTuNgay.Value.Date);
            var denNgay = DateOnly.FromDateTime(dtpDenNgay.Value.Date);
            query = query.Where(c => c.NgayChi >= tuNgay && c.NgayChi <= denNgay);

            var list = query.OrderByDescending(c => c.NgayChi).ThenByDescending(c => c.MaCt).ToList();
            dgvChiTieu.DataSource = list;

            CapNhatTongTien(list);
        }
        catch (Exception ex)
        {
            Log.Error(ex, "Lỗi khi truy cập CSDL trong hàm LoadData");
            MessageBox.Show("Không thể tải danh sách chi tiêu từ cơ sở dữ liệu. Vui lòng kiểm tra kết nối!", "Lỗi kết nối CSDL", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void CapNhatTongTien(System.Collections.Generic.IEnumerable<ChiTieu> list)
    {
        decimal tong = list.Sum(c => c.SoTien);
        lblTongChi.Text = $"Tổng chi: {tong:N0} đ";
    }

    private void dgvChiTieu_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.RowIndex >= dgvChiTieu.Rows.Count) return;

        if (dgvChiTieu.Rows[e.RowIndex].DataBoundItem is ChiTieu item)
        {
            _selectedMaCt = item.MaCt;
            dtpNgayChi.Value = item.NgayChi.ToDateTime(TimeOnly.MinValue);
            txtNoiDung.Text = item.NoiDung;
            cboLoaiChi.SelectedItem = item.LoaiChi;
            nudSoTien.Value = item.SoTien;
            txtGhiChu.Text = item.GhiChu ?? string.Empty;
        }
    }

    private bool ValidateInputs()
    {
        if (string.IsNullOrWhiteSpace(txtNoiDung.Text))
        {
            MessageBox.Show("Nội dung không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtNoiDung.Focus();
            return false;
        }

        if (nudSoTien.Value <= 0)
        {
            MessageBox.Show("Số tiền chi phải lớn hơn 0!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            nudSoTien.Focus();
            return false;
        }

        if (dtpNgayChi.Value.Date > DateTime.Today)
        {
            MessageBox.Show("Ngày chi không được lớn hơn hôm nay!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            dtpNgayChi.Focus();
            return false;
        }

        if (cboLoaiChi.SelectedIndex < 0)
        {
            MessageBox.Show("Vui lòng chọn loại chi!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            cboLoaiChi.Focus();
            return false;
        }

        return true;
    }

    private void btnThem_Click(object sender, EventArgs e)
    {
        if (!ValidateInputs()) return;

        try
        {
            using var db = new QlChiTieuContext();
            var item = new ChiTieu
            {
                NgayChi = DateOnly.FromDateTime(dtpNgayChi.Value.Date),
                NoiDung = txtNoiDung.Text.Trim(),
                LoaiChi = cboLoaiChi.SelectedItem!.ToString()!,
                SoTien = nudSoTien.Value,
                GhiChu = string.IsNullOrWhiteSpace(txtGhiChu.Text) ? null : txtGhiChu.Text.Trim()
            };

            db.ChiTieus.Add(item);
            db.SaveChanges();

            Log.Information("Đã thêm khoản chi thành công: MaCT={MaCt}, NoiDung={NoiDung}, SoTien={SoTien}",
                item.MaCt, item.NoiDung, item.SoTien);

            MessageBox.Show("Thêm khoản chi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearInput();
            LoadData();
        }
        catch (Exception ex)
        {
            Log.Error(ex, "Lỗi CSDL khi thêm khoản chi: NoiDung={NoiDung}", txtNoiDung.Text);
            MessageBox.Show("Đã xảy ra lỗi khi thêm dữ liệu vào cơ sở dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnSua_Click(object sender, EventArgs e)
    {
        if (_selectedMaCt == null)
        {
            MessageBox.Show("Vui lòng chọn một dòng để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        if (!ValidateInputs()) return;

        try
        {
            using var db = new QlChiTieuContext();
            var item = db.ChiTieus.Find(_selectedMaCt.Value);
            if (item == null)
            {
                MessageBox.Show("Khoản chi không tồn tại hoặc đã bị xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LoadData();
                return;
            }

            item.NgayChi = DateOnly.FromDateTime(dtpNgayChi.Value.Date);
            item.NoiDung = txtNoiDung.Text.Trim();
            item.LoaiChi = cboLoaiChi.SelectedItem!.ToString()!;
            item.SoTien = nudSoTien.Value;
            item.GhiChu = string.IsNullOrWhiteSpace(txtGhiChu.Text) ? null : txtGhiChu.Text.Trim();

            db.SaveChanges();

            Log.Information("Đã cập nhật khoản chi thành công: MaCT={MaCt}, NoiDung={NoiDung}, SoTien={SoTien}",
                item.MaCt, item.NoiDung, item.SoTien);

            MessageBox.Show("Cập nhật khoản chi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearInput();
            LoadData();
        }
        catch (Exception ex)
        {
            Log.Error(ex, "Lỗi CSDL khi sửa khoản chi MaCT={MaCt}", _selectedMaCt);
            MessageBox.Show("Đã xảy ra lỗi khi cập nhật cơ sở dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnXoa_Click(object sender, EventArgs e)
    {
        if (_selectedMaCt == null)
        {
            MessageBox.Show("Vui lòng chọn một khoản chi để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        var confirm = MessageBox.Show($"Bạn có chắc chắn muốn xóa khoản chi mã {_selectedMaCt}?",
            "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (confirm != DialogResult.Yes) return;

        try
        {
            using var db = new QlChiTieuContext();
            var item = db.ChiTieus.Find(_selectedMaCt.Value);
            if (item != null)
            {
                int maCt = item.MaCt;
                db.ChiTieus.Remove(item);
                db.SaveChanges();

                Log.Information("Đã xóa khoản chi thành công: MaCT={MaCt}", maCt);
                MessageBox.Show("Xóa khoản chi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            ClearInput();
            LoadData();
        }
        catch (Exception ex)
        {
            Log.Error(ex, "Lỗi CSDL khi xóa khoản chi MaCT={MaCt}", _selectedMaCt);
            MessageBox.Show("Đã xảy ra lỗi khi xóa khoản chi khỏi cơ sở dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnLamMoi_Click(object sender, EventArgs e)
    {
        ClearInput();
        txtTimNoiDung.Text = string.Empty;
        cboTimLoaiChi.SelectedIndex = 0;
        var today = DateTime.Today;
        dtpTuNgay.Value = new DateTime(today.Year, today.Month, 1);
        dtpDenNgay.Value = today;
        LoadData();
    }

    private void btnTim_Click(object sender, EventArgs e)
    {
        LoadData();
    }

    private void ClearInput()
    {
        _selectedMaCt = null;
        dtpNgayChi.Value = DateTime.Today;
        txtNoiDung.Text = string.Empty;
        if (cboLoaiChi.Items.Count > 0) cboLoaiChi.SelectedIndex = 0;
        nudSoTien.Value = 0;
        txtGhiChu.Text = string.Empty;
        dgvChiTieu.ClearSelection();
    }
}

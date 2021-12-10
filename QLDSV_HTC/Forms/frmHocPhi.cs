using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV_HTC.Forms
{
    public partial class frmHocPhi : DevExpress.XtraEditors.XtraForm
    {
        private int viTriHocPhi;
        private int viTriCTDHP;

        bool optionThem;
        private string oldNK;
        private int oldHK;
        private DateTime oldNgayDong;
        private int oldSoTienDong;

        public frmHocPhi()
        {
            InitializeComponent();
        }

        private void ChuyenTrangThaiDangCapNhat_HocPhi(bool flag)
        {
            btnThemHP.Enabled = btnTaiHP.Enabled = btnThoat.Enabled = txtViTriHocPhi.Enabled = !flag;
            btnXoaHP.Enabled = btnSuaHP.Enabled = !flag && (bdsHocPhi.Count > 0);
            btnGhiHP.Enabled = btnHuyHP.Enabled = flag;
            gbHocPhi.Enabled = flag;

            gbSinhVien.Enabled = gcHocPhi.Enabled = nvgtCTHocPhi.Enabled = gcCTHocPhi.Enabled = !flag;
        }

        private void ChuyenTrangThaiDangCapNhat_CTDHP(bool flag)
        {
            btnTaiCTDHP.Enabled = btnThoat.Enabled = txtViTriCTDHP.Enabled = !flag;
            btnThemCTDHP.Enabled = !flag && (bdsHocPhi.Count > 0);
            btnXoaCTDHP.Enabled = btnSuaCTDHP.Enabled = !flag && (bdsCTDHP.Count > 0);
            btnGhiCTDHP.Enabled = btnHuyCTDHP.Enabled = flag;
            gbCTDHP.Enabled = flag;

            gbSinhVien.Enabled = gcCTHocPhi.Enabled = nvgtHocPhi.Enabled = gcHocPhi.Enabled = !flag;
        }

        private void TaiDuLieuHocPhi()
        {
            try
            {
                hOCPHITableAdapter.Connection.ConnectionString = Program.connstr;
                this.hOCPHITableAdapter.Fill(this.DS_HOCPHI.HOCPHI);
                cT_DONGHOCPHITableAdapter.Connection.ConnectionString = Program.connstr;
                this.cT_DONGHOCPHITableAdapter.Fill(this.DS_HOCPHI.CT_DONGHOCPHI);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi tải dữ liệu học phí: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ChuyenTrangThaiDangCapNhat_HocPhi(false);
            ChuyenTrangThaiDangCapNhat_CTDHP(false);
        }

        private void frmHocPhi_Load(object sender, EventArgs e)
        {
            DS_HOCPHI.EnforceConstraints = false;
            sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.DS_HOCPHI.SINHVIEN);
            if (bdsSinhVien.Count > 0)
            {
                lkupSinhVien.EditValue = ((DataRowView)bdsSinhVien.Current)["MASV"];
            }
            cmbNienKhoa.DataSource = Utils.LayDSNienKhoa();
            TaiDuLieuHocPhi();
            ChuyenTrangThaiDangCapNhat_HocPhi(false);
            ChuyenTrangThaiDangCapNhat_CTDHP(false);
        }

        private void lkupSinhVien_EditValueChanged(object sender, EventArgs e)
        {
            DataRowView selectedSV = lkupSinhVien.GetSelectedDataRow() as DataRowView;
            txtTenSV.Text = selectedSV.Row["HO"] + " " + selectedSV.Row["TEN"];
            txtMaLop.Text = selectedSV.Row["MALOP"].ToString();
            this.bdsSinhVien.Position = this.bdsSinhVien.Find("MASV", selectedSV.Row["MASV"].ToString());
            btnXoaHP.Enabled = btnSuaHP.Enabled = (bdsHocPhi.Count > 0);
            btnThemCTDHP.Enabled = (bdsHocPhi.Count > 0);
            btnXoaCTDHP.Enabled = btnSuaCTDHP.Enabled = (bdsCTDHP.Count > 0);
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void btnThemHP_Click(object sender, EventArgs e)
        {
            optionThem = true;
            viTriHocPhi = bdsHocPhi.Position;
            bdsHocPhi.AddNew();
            ChuyenTrangThaiDangCapNhat_HocPhi(true);
        }

        private void btnXoaHP_Click(object sender, EventArgs e)
        {
            if (bdsCTDHP.Count > 0)
            {
                XtraMessageBox.Show("Không thể xóa thông tin học phí này vì đã có " +
                    "thông tin chi tiết đóng học phí cho học phí này!",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (XtraMessageBox.Show("Bạn có chắc muốn xóa thông tin học phí này không?", "Xác nhận",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK) return;

            int position = bdsHocPhi.Position;
            try
            {
                bdsHocPhi.RemoveCurrent();
                hOCPHITableAdapter.Connection.ConnectionString = Program.connstr;
                this.hOCPHITableAdapter.Update(this.DS_HOCPHI.HOCPHI);
                XtraMessageBox.Show("Đã xóa thông tin học phí!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi xóa thông tin học phí! Bạn hãy xóa lại!\n" + ex.Message, 
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.hOCPHITableAdapter.Fill(this.DS_HOCPHI.HOCPHI);
                bdsHocPhi.Position = position;
                return;
            }
            btnXoaHP.Enabled = btnSuaHP.Enabled = (bdsHocPhi.Count > 0);
            btnThemCTDHP.Enabled = (bdsHocPhi.Count > 0);
            btnXoaCTDHP.Enabled = btnSuaCTDHP.Enabled = (bdsCTDHP.Count > 0);
        }

        private void btnSuaHP_Click(object sender, EventArgs e)
        {
            optionThem = false;
            oldNK = cmbNienKhoa.Text.Trim();
            oldHK = (int)spinHocKy.Value;
            viTriHocPhi = bdsHocPhi.Position;
            ChuyenTrangThaiDangCapNhat_HocPhi(true);
        }

        private void btnGhiHP_Click(object sender, EventArgs e)
        {
            if (cmbNienKhoa.Text.Trim() == "")
            {
                XtraMessageBox.Show("Niên khóa không được để trống!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbNienKhoa.Focus();
                return;
            }
            if (!Regex.IsMatch(cmbNienKhoa.Text.Trim(), @"^\d{4}-\d{4}$"))
            {
                XtraMessageBox.Show("Định dạng niên khóa không hợp lệ!\n" +
                    "Niên khóa phải có dạng ####-####.\nVí dụ: 2021-2022", 
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbNienKhoa.Focus();
                return;
            }
            if (spinHocKy.Text.Trim() == "")
            {
                XtraMessageBox.Show("Học kỳ không được để trống!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                spinHocKy.Focus();
                return;
            }
            if (spinHocKy.Value < 1 || spinHocKy.Value > 4)
            {
                XtraMessageBox.Show("Học kỳ phải có giá trị trong đoạn từ 1 đến 4!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                spinHocKy.Focus();
                return;
            }
            if (spinHocPhi.Text.Trim() == "")
            {
                XtraMessageBox.Show("Học phí không được để trống!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                spinHocKy.Focus();
                return;
            }
            if (spinHocPhi.Value <= 0)
            {
                XtraMessageBox.Show("Học phí phải lớn hơn 0!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                spinHocKy.Focus();
                return;
            }
            if (!optionThem)
            {
                int soTienDaDong = int.Parse(gvHocPhi.GetRowCellValue(gvHocPhi.GetSelectedRows()[0], "SOTIENDADONG").ToString());
                if (spinHocPhi.Value < soTienDaDong)
                {
                    XtraMessageBox.Show($"Học phí sửa lại là {spinHocPhi.Value.ToString("n0")} nhỏ hơn số tiền đã đóng là {soTienDaDong.ToString("n0")}!",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    spinHocPhi.Focus();
                    return;
                }
            }

            string maSV = (bdsSinhVien.Current as DataRowView)["MASV"].ToString();
            string nk = cmbNienKhoa.Text.Trim();
            int hk = (int)spinHocKy.Value;
            if (optionThem || (nk != oldNK || hk != oldHK))
            {
                string strLenh = $"EXECUTE SP_CHECK_HOCPHI '{maSV}', '{nk}', {hk}";
                int result = Program.Check(strLenh);
                if (result == -1)
                {
                    XtraMessageBox.Show("Lỗi kết nối với database. Mời bạn xem lại!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (result == 1)
                {
                    XtraMessageBox.Show("Đã có thông tin học phí của sinh viên này trong niên khóa - học kỳ này!", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (XtraMessageBox.Show("Bạn có chắc muốn ghi thông tin học phí vào cơ sở dữ liệu không?", 
                "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK) 
                return;

            try
            {
                bdsHocPhi.EndEdit();
                bdsHocPhi.ResetCurrentItem();
                hOCPHITableAdapter.Connection.ConnectionString = Program.connstr;
                this.hOCPHITableAdapter.Update(this.DS_HOCPHI.HOCPHI);
                XtraMessageBox.Show("Đã ghi thông tin học phí vào cơ sở dữ liệu!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                ChuyenTrangThaiDangCapNhat_HocPhi(false);
                ChuyenTrangThaiDangCapNhat_CTDHP(false);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi ghi thông tin học phí!\n" + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnHuyHP_Click(object sender, EventArgs e)
        {
            bdsHocPhi.CancelEdit();
            bdsHocPhi.Position = viTriHocPhi;
            ChuyenTrangThaiDangCapNhat_HocPhi(false);
        }

        private void btnTaiHP_Click(object sender, EventArgs e)
        {
            TaiDuLieuHocPhi();
        }

        private void btnThemCTDHP_Click(object sender, EventArgs e)
        {
            optionThem = true;
            viTriCTDHP = bdsCTDHP.Position;
            bdsCTDHP.AddNew();
            ChuyenTrangThaiDangCapNhat_CTDHP(true);
        }

        private void btnXoaCTDHP_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có chắc muốn xóa chi tiết đóng học phí này không?", "Xác nhận",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK) return;

            int position = bdsCTDHP.Position;
            try
            {
                bdsCTDHP.RemoveCurrent();
                cT_DONGHOCPHITableAdapter.Connection.ConnectionString = Program.connstr;
                this.cT_DONGHOCPHITableAdapter.Update(this.DS_HOCPHI.CT_DONGHOCPHI);
                hOCPHITableAdapter.Connection.ConnectionString = Program.connstr;
                this.hOCPHITableAdapter.Fill(this.DS_HOCPHI.HOCPHI);
                XtraMessageBox.Show("Đã xóa chi tiết đóng học phí!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi xóa chi tiết đóng học phí! Bạn hãy xóa lại!\n" + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.cT_DONGHOCPHITableAdapter.Fill(this.DS_HOCPHI.CT_DONGHOCPHI);
                bdsCTDHP.Position = position;
                return;
            }

            if (bdsCTDHP.Count == 0) btnXoaCTDHP.Enabled = btnSuaCTDHP.Enabled = false;
        }

        private void btnSuaCTDHP_Click(object sender, EventArgs e)
        {
            optionThem = false;
            oldNK = (bdsCTDHP.Current as DataRowView)["NIENKHOA"].ToString();
            oldHK = int.Parse((bdsCTDHP.Current as DataRowView)["HOCKY"].ToString());
            oldNgayDong = dateNgayDong.DateTime.Date;
            oldSoTienDong = int.Parse((bdsCTDHP.Current as DataRowView)["SOTIENDONG"].ToString());
            viTriCTDHP = bdsCTDHP.Position;
            ChuyenTrangThaiDangCapNhat_CTDHP(true);
        }

        private void btnGhiCTDHP_Click(object sender, EventArgs e)
        {
            if (dateNgayDong.Text.Trim() == "")
            {
                XtraMessageBox.Show("Ngày đóng không được để trống!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateNgayDong.Focus();
                return;
            }
            if (spinSoTienDong.Text.Trim() == "")
            {
                XtraMessageBox.Show("Số tiền đóng không được để trống!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                spinSoTienDong.Focus();
                return;
            }
            if (spinSoTienDong.Value <= 0)
            {
                XtraMessageBox.Show("Số tiền đóng phải lớn hơn 0!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                spinSoTienDong.Focus();
                return;
            }
            int soTienCanDong = int.Parse(gvHocPhi.GetRowCellValue(gvHocPhi.GetSelectedRows()[0], "SOTIENCANDONG").ToString());
            if (!optionThem) soTienCanDong += oldSoTienDong;
            if (spinSoTienDong.Value > soTienCanDong)
            {
                XtraMessageBox.Show($"Số tiền đóng là {spinSoTienDong.Value.ToString("n0")} vượt quá số tiền còn lại phải đóng là {soTienCanDong.ToString("n0")}!", 
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                spinSoTienDong.Focus();
                return;
            }

            string maSV = (bdsSinhVien.Current as DataRowView)["MASV"].ToString();
            string nk = (bdsCTDHP.Current as DataRowView)["NIENKHOA"].ToString();
            int hk = int.Parse((bdsCTDHP.Current as DataRowView)["HOCKY"].ToString());
            DateTime ngayDong = dateNgayDong.DateTime.Date;
            if (optionThem || (nk != oldNK || hk != oldHK || ngayDong != oldNgayDong))
            {
                string strLenh = $"EXECUTE SP_CHECK_CT_DONGHOCPHI '{maSV}', '{nk}', {hk}, '{ngayDong}'";
                int result = Program.Check(strLenh);
                if (result == -1)
                {
                    XtraMessageBox.Show("Lỗi kết nối với database. Mời bạn xem lại!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (result == 1)
                {
                    XtraMessageBox.Show("Đã có chi tiết đóng học phí của sinh viên này trong niên khóa - học kỳ này và ngày này!\n" +
                        "Vui lòng chọn ngày đóng khác hoặc sửa số tiền đóng!", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (XtraMessageBox.Show("Bạn có chắc muốn ghi thông tin đóng học phí vào cơ sở dữ liệu không?",
                "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK)
                return;

            try
            {
                bdsCTDHP.EndEdit();
                bdsCTDHP.ResetCurrentItem();
                cT_DONGHOCPHITableAdapter.Connection.ConnectionString = Program.connstr;
                this.cT_DONGHOCPHITableAdapter.Update(this.DS_HOCPHI.CT_DONGHOCPHI);
                hOCPHITableAdapter.Connection.ConnectionString = Program.connstr;
                this.hOCPHITableAdapter.Fill(this.DS_HOCPHI.HOCPHI);
                XtraMessageBox.Show("Đã ghi thông tin đóng học phí vào cơ sở dữ liệu!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                ChuyenTrangThaiDangCapNhat_CTDHP(false);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi ghi thông tin đóng học phí!\n" + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnHuyCTDHP_Click(object sender, EventArgs e)
        {
            bdsCTDHP.CancelEdit();
            bdsCTDHP.Position = viTriCTDHP;
            ChuyenTrangThaiDangCapNhat_CTDHP(false);
        }

        private void btnTaiCTDHP_Click(object sender, EventArgs e)
        {
            try
            {
                cT_DONGHOCPHITableAdapter.Connection.ConnectionString = Program.connstr;
                this.cT_DONGHOCPHITableAdapter.Fill(this.DS_HOCPHI.CT_DONGHOCPHI);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi tải dữ liệu học phí: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ChuyenTrangThaiDangCapNhat_CTDHP(false);
        }

        private void gvHocPhi_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            btnXoaCTDHP.Enabled = btnSuaCTDHP.Enabled = (bdsCTDHP.Count > 0);
        }
    }
}
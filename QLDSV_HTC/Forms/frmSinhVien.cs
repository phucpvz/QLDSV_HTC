using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using QLDSV_HTC.Actions;
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
    public partial class frmSinhVien : DevExpress.XtraEditors.XtraForm
    {
        int vitri = 0;
        private readonly string matKhauMacDinh = "123";
        bool optionThem;
        private string oldMaSV = "";
        private CommandManager cmd;
        private object[] oldData;

        public frmSinhVien()
        {
            InitializeComponent();
            cmd = new CommandManager(btnUndo, btnRedo);
        }

        private void ChuyenTrangThaiDangCapNhat(bool flag)
        {
            btnThem.Enabled = btnReload.Enabled = btnThoat.Enabled = nvgtSinhVien.Enabled 
                = btnResetPassword.Enabled = nvgtLop.Enabled = gcLop.Enabled = !flag;
            btnXoa.Enabled = btnSua.Enabled = !flag && (bdsSinhVien.Count > 0);
            btnUndo.Enabled = !flag && cmd.GetUndoStackSize() > 0;
            btnRedo.Enabled = !flag && cmd.GetRedoStackSize() > 0;
            btnGhi.Enabled = btnHuy.Enabled = flag;
            gcSinhVien.Enabled = !flag;
            groupSinhVien.Enabled = flag;
            if (Program.mGroup == "PGV")
                cmbKhoa.Enabled = !flag;
        }

        private void TaiDuLieu()
        {
            try
            {
                lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(this.DS.LOP);
                sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
                dANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                this.dANGKYTableAdapter.Fill(this.DS.DANGKY);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            btnThem.Enabled = (bdsLop.Count > 0);
            btnXoa.Enabled = btnSua.Enabled = btnResetPassword.Enabled = (bdsSinhVien.Count > 0);
            cmd.Clear();
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            TaiDuLieu();
            Program.bds_dspm.Filter = "TENKHOA LIKE 'Khoa%'";
            Program.LoadDataToComboBox(cmbKhoa, Program.bds_dspm);
            if (Program.mGroup == "PGV")
                cmbKhoa.Enabled = true;
            else
                cmbKhoa.Enabled = false;
            btnThem.Enabled = (bdsLop.Count > 0);
            btnXoa.Enabled = btnSua.Enabled = btnResetPassword.Enabled = (bdsSinhVien.Count > 0);
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            optionThem = true;
            vitri = bdsSinhVien.Position;
            bdsSinhVien.AddNew();
            txtMaLop.Text = ((DataRowView)bdsLop[bdsLop.Position])["MALOP"].ToString();
            ckePhai.Checked = true;
            ckeDaNghiHoc.Checked = false;
            ChuyenTrangThaiDangCapNhat(true);
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string maSV = "";
            if (bdsDangKy.Count > 0)
            {
                XtraMessageBox.Show("Không thể xóa sinh viên này vì sinh viên này đã đăng ký lớp tín chỉ!",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (XtraMessageBox.Show("Bạn có chắc muốn xóa sinh viên này không?", "Xác nhận",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK) return;

            try
            {
                maSV = ((DataRowView)bdsSinhVien[bdsSinhVien.Position])["MASV"].ToString();
                cmd.Add(new DeleteAction(bdsSinhVien));
                bdsSinhVien.RemoveCurrent();
                sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Update(this.DS.SINHVIEN);
                XtraMessageBox.Show("Đã xóa thông tin sinh viên!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi xóa sinh viên! Bạn hãy xóa lại!\n" + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.sINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
                int pos = bdsSinhVien.Find("MASV", maSV);
                if (pos > -1)
                    bdsSinhVien.Position = pos;
                return;
            }
            if (bdsSinhVien.Count == 0)
                btnXoa.Enabled = btnSua.Enabled = btnResetPassword.Enabled = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            optionThem = false;
            oldMaSV = Utils.ChuanHoaMa(txtMaSV.Text);
            oldData = (bdsSinhVien.Current as DataRowView).Row.ItemArray;
            vitri = bdsSinhVien.Position;
            ChuyenTrangThaiDangCapNhat(true);
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có chắc muốn hoàn tác không?", "Xác nhận",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK) return;
            try
            {
                cmd.Undo();
                sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Update(this.DS.SINHVIEN);
                XtraMessageBox.Show("Đã hoàn tác thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Đã xảy ra lỗi khi hoàn tác!\n" + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnRedo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có chắc muốn làm lại không?", "Xác nhận",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK) return;
            try
            {
                cmd.Redo();
                sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Update(this.DS.SINHVIEN);
                XtraMessageBox.Show("Đã làm lại thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Đã xảy ra lỗi khi làm lại!\n" + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string maSV = Utils.ChuanHoaMa(txtMaSV.Text);
            if (maSV == "")
            {
                XtraMessageBox.Show("Mã sinh viên không được để trống", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaSV.Focus();
                return;
            }
            if (!Regex.IsMatch(maSV, @"^[A-Z0-9]+$"))
            {
                XtraMessageBox.Show("Mã sinh viên chỉ được chứa chữ cái in hoa A-Z và số 0-9!",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaSV.Focus();
                return;
            }
            string ho = Utils.ChuanHoaHoTen(txtHo.Text);
            if (ho == "")
            {
                XtraMessageBox.Show("Họ của sinh viên không được để trống", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHo.Focus();
                return;
            }
            if (!Regex.IsMatch(ho, Utils.CAC_TU_CO_DAU))
            {
                XtraMessageBox.Show("Họ của sinh viên chỉ được bao gồm các chữ cái a-z, A-Z\n" +
                    "(có dấu hoặc không dấu) và khoảng trắng giữa các từ!",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHo.Focus();
                return;
            }
            string ten = Utils.ChuanHoaHoTen(txtTen.Text);
            if (ten == "")
            {
                XtraMessageBox.Show("Tên của sinh viên không được để trống", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTen.Focus();
                return;
            }
            if (!Regex.IsMatch(ten, Utils.TU_CO_DAU))
            {
                XtraMessageBox.Show("Tên của sinh viên chỉ được bao gồm các chữ cái a-z, A-Z\n" +
                    "(có dấu hoặc không dấu) và chỉ gồm 1 từ duy nhất!",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTen.Focus();
                return;
            }

            if (optionThem || maSV != oldMaSV)
            {
                string strLenh = $"EXECUTE SP_CHECKID '{maSV}', 'MASV'";
                int result = Program.Check(strLenh);
                if (result == -1)
                {
                    XtraMessageBox.Show("Lỗi kết nối với database. Mời bạn xem lại!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (result == 1)
                {
                    XtraMessageBox.Show("Mã sinh viên đã tồn tại! Vui lòng nhập mã sinh viên khác!", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (result == 2)
                {
                    XtraMessageBox.Show("Mã sinh viên đã tồn tại ở khoa khác! Vui lòng nhập mã sinh viên khác!", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            try
            {
                bdsSinhVien.EndEdit();
                bdsSinhVien.ResetCurrentItem();
                DataRowView current = (DataRowView)bdsSinhVien.Current;
                current["MASV"] = maSV;
                current["HO"] = ho;
                current["TEN"] = ten;
                sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Update(this.DS.SINHVIEN);
                if (optionThem) cmd.Add(new InsertAction(bdsSinhVien));
                else
                {
                    object[] newData = (bdsSinhVien.Current as DataRowView).Row.ItemArray;
                    cmd.Add(new UpdateAction(bdsSinhVien, oldData, newData));
                }
                XtraMessageBox.Show("Đã ghi thông tin sinh viên vào cơ sở dữ liệu!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi ghi sinh viên!\n" + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ChuyenTrangThaiDangCapNhat(false);
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsSinhVien.CancelEdit();
            if (btnThem.Enabled == false) bdsSinhVien.Position = vitri;
            ChuyenTrangThaiDangCapNhat(false);
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TaiDuLieu();
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKhoa.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.serverName = cmbKhoa.SelectedValue.ToString();

            if (cmbKhoa.SelectedIndex != Program.mKhoa)
            {
                Program.mLogin = Program.remoteLogin;
                Program.password = Program.remotePassword;
            }
            else
            {
                Program.mLogin = Program.mLoginDN;
                Program.password = Program.passwordDN;
            }
            if (Program.KetNoi() == 0)
            {
                //XtraMessageBox.Show("Lỗi kết nối về chi nhánh mới!", "Lỗi",
                //        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                TaiDuLieu();
            }
        }

        private void btnResetPassword_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có chắc muốn đặt lại mật khẩu cho sinh viên này không?",
                "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK) return;
            try
            {
                string maSV = ((DataRowView)bdsSinhVien[bdsSinhVien.Position])["MASV"].ToString();
                string strLenh = $"EXECUTE SP_DATMATKHAU '{maSV}', '{matKhauMacDinh}'";
                int result = Program.ExecSqlNonQuery(strLenh);
                if (result == 0)
                {
                    XtraMessageBox.Show("Đã đặt lại mật khẩu cho sinh viên!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi đặt mật khẩu sinh viên! Bạn hãy thử lại!\n" + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void gvLop_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            btnXoa.Enabled = btnSua.Enabled = btnResetPassword.Enabled = bdsSinhVien.Count > 0;
            cmd.Clear();
        }
    }
}
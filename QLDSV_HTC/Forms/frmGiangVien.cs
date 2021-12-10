using DevExpress.XtraEditors;
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
    public partial class frmGiangVien : DevExpress.XtraEditors.XtraForm
    {
        int vitri = 0;
        bool optionThem;
        private string oldMaGV = "";
        private CommandManager cmd;
        private object[] oldData;

        public frmGiangVien()
        {
            InitializeComponent();
            cmd = new CommandManager(btnUndo, btnRedo);
        }

        private void ChuyenTrangThaiDangCapNhat(bool flag)
        {
            btnThem.Enabled = btnReload.Enabled = btnThoat.Enabled = nvgtGiangVien.Enabled = !flag;
            btnXoa.Enabled = btnSua.Enabled = !flag && (bdsGiangVien.Count > 0);
            btnUndo.Enabled = !flag && cmd.GetUndoStackSize() > 0;
            btnRedo.Enabled = !flag && cmd.GetRedoStackSize() > 0;
            btnGhi.Enabled = btnHuy.Enabled = flag;
            groupGiangVien.Enabled = flag;
            gridGiangVien.Enabled = !flag;

            if (Program.mGroup == "PGV") cmbKhoa.Enabled = !flag;
        }

        private void TaiDuLieu()
        {
            try
            {
                gIANGVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gIANGVIENTableAdapter.Fill(this.DS.GIANGVIEN);
                lOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTINCHITableAdapter.Fill(this.DS.LOPTINCHI);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi tải giảng viên: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            btnXoa.Enabled = btnSua.Enabled = bdsGiangVien.Count > 0;
            cmd.Clear();
        }
        
        private void frmGiangVien_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            TaiDuLieu();
            Program.bds_dspm.Filter = "TENKHOA LIKE 'Khoa%'";
            Program.LoadDataToComboBox(cmbKhoa, Program.bds_dspm);
            if (Program.mGroup == "PGV")
                cmbKhoa.Enabled = true;
            else
                cmbKhoa.Enabled = false;
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

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            optionThem = true;
            vitri = bdsGiangVien.Position;
            bdsGiangVien.AddNew();
            txtMaKhoa.Text = (cmbKhoa.SelectedIndex == 0) ? "CNTT" : "VT";
            ChuyenTrangThaiDangCapNhat(true);
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string maGV = "";
            if (bdsLopTinChi.Count > 0)
            {
                XtraMessageBox.Show("Không thể xóa giảng viên này vì đã có lớp tín chỉ do giảng viên này dạy!",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (XtraMessageBox.Show("Bạn có chắc muốn xóa giảng viên này không?", "Xác nhận",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK) return;

            try
            {
                maGV = ((DataRowView)bdsGiangVien[bdsGiangVien.Position])["MAGV"].ToString();
                cmd.Add(new DeleteAction(bdsGiangVien));
                bdsGiangVien.RemoveCurrent();
                gIANGVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gIANGVIENTableAdapter.Update(this.DS.GIANGVIEN);
                XtraMessageBox.Show("Đã xóa thông tin giảng viên!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi xóa giảng viên! Bạn hãy xóa lại!\n" + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.gIANGVIENTableAdapter.Fill(this.DS.GIANGVIEN);
                int pos = bdsGiangVien.Find("MAGV", maGV);
                if (pos > -1) 
                    bdsGiangVien.Position = pos;
            }
            btnXoa.Enabled = btnSua.Enabled = bdsGiangVien.Count > 0;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            optionThem = false;
            oldMaGV = Utils.ChuanHoaMa(txtMaGV.Text);
            oldData = (bdsGiangVien.Current as DataRowView).Row.ItemArray;
            vitri = bdsGiangVien.Position;
            ChuyenTrangThaiDangCapNhat(true);
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có chắc muốn hoàn tác không?", "Xác nhận",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK) return;
            try
            {
                cmd.Undo();
                gIANGVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gIANGVIENTableAdapter.Update(this.DS.GIANGVIEN);
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
                gIANGVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gIANGVIENTableAdapter.Update(this.DS.GIANGVIEN);
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
            string maGV = Utils.ChuanHoaMa(txtMaGV.Text);
            if (maGV == "")
            {
                XtraMessageBox.Show("Mã giảng viên không được để trống!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaGV.Focus();
                return;
            }
            if (!Regex.IsMatch(maGV, @"^[A-Z0-9]+$"))
            {
                XtraMessageBox.Show("Mã giảng viên chỉ được chứa chữ cái in hoa A-Z và số 0-9!",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaGV.Focus();
                return;
            }
            string ho = Utils.ChuanHoaHoTen(txtHo.Text);
            if (ho == "")
            {
                XtraMessageBox.Show("Họ của giảng viên không được để trống!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHo.Focus();
                return;
            }
            if (!Regex.IsMatch(ho, Utils.CAC_TU_CO_DAU))
            {
                XtraMessageBox.Show("Họ của giảng viên chỉ được bao gồm các chữ cái a-z, A-Z\n" +
                    "(có dấu hoặc không dấu) và khoảng trắng giữa các từ!",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHo.Focus();
                return;
            }
            string ten = Utils.ChuanHoaHoTen(txtTen.Text);
            if (ten == "")
            {
                XtraMessageBox.Show("Tên của giảng viên không được để trống!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTen.Focus();
                return;
            }
            if (!Regex.IsMatch(ten, Utils.TU_CO_DAU))
            {
                XtraMessageBox.Show("Tên của giảng viên chỉ được bao gồm các chữ cái a-z, A-Z\n" +
                    "(có dấu hoặc không dấu) và chỉ gồm 1 từ duy nhất!",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTen.Focus();
                return;
            }

            if (optionThem || maGV != oldMaGV)
            {
                string strLenh = $"EXECUTE SP_CHECKID '{maGV}', 'MAGV'";
                int result = Program.Check(strLenh);
                if (result == -1)
                {
                    XtraMessageBox.Show("Lỗi kết nối với database. Mời bạn xem lại!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (result == 1)
                {
                    XtraMessageBox.Show("Mã giảng viên đã tồn tại! Vui lòng nhập mã giảng viên khác!", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            try
            {
                bdsGiangVien.EndEdit();
                bdsGiangVien.ResetCurrentItem();
                DataRowView current = (DataRowView)bdsGiangVien.Current;
                current["MAGV"] = maGV;
                current["HO"] = ho;
                current["TEN"] = ten;
                gIANGVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gIANGVIENTableAdapter.Update(this.DS.GIANGVIEN);
                if (optionThem) cmd.Add(new InsertAction(bdsGiangVien));
                else
                {
                    object[] newData = (bdsGiangVien.Current as DataRowView).Row.ItemArray;
                    cmd.Add(new UpdateAction(bdsGiangVien, oldData, newData));
                }
                XtraMessageBox.Show("Đã ghi thông tin giảng viên vào cơ sở dữ liệu!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi ghi giảng viên!\n" + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ChuyenTrangThaiDangCapNhat(false);
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsGiangVien.CancelEdit();
            if (btnThem.Enabled == false) bdsGiangVien.Position = vitri;
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
    }
}
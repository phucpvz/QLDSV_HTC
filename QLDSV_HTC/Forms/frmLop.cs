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
    public partial class frmLop : DevExpress.XtraEditors.XtraForm
    {
        int vitri = 0;
        bool optionThem;
        private string oldMaLop = "";
        private string oldTenLop = "";
        private CommandManager cmd;
        private object[] oldData;

        public frmLop()
        {
            InitializeComponent();
            cmd = new CommandManager(btnUndo, btnRedo);
        }

        private void ChuyenTrangThaiDangCapNhat(bool flag)
        {
            btnThem.Enabled = btnReload.Enabled = btnThoat.Enabled = nvgtLop.Enabled = !flag;
            btnXoa.Enabled = btnSua.Enabled = !flag && (bdsLop.Count > 0);
            btnUndo.Enabled = !flag && cmd.GetUndoStackSize() > 0;
            btnRedo.Enabled = !flag && cmd.GetRedoStackSize() > 0;
            btnGhi.Enabled = btnHuy.Enabled = flag;
            groupLop.Enabled = flag;
            gridLop.Enabled = !flag;

            if (Program.mGroup == "PGV") cmbKhoa.Enabled = !flag;
        }

        private void TaiDuLieu()
        {
            try
            {
                lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(this.DS.LOP);
                sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi tải lớp: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            btnXoa.Enabled = btnSua.Enabled = bdsLop.Count > 0;
            cmd.Clear();
        }

        private void frmLop_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            TaiDuLieu();
            Program.bds_dspm.Filter = "TENKHOA LIKE 'Khoa%'";
            Program.LoadDataToComboBox(cmbKhoa, Program.bds_dspm);

            if (Program.mGroup == "PGV")
                cmbKhoa.Enabled = true;
            else
                cmbKhoa.Enabled = false;
            if (bdsLop.Count == 0) btnXoa.Enabled = btnSua.Enabled = false;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            optionThem = true;
            vitri = bdsLop.Position;
            groupLop.Enabled = true;
            bdsLop.AddNew();
            txtMaKhoa.Text = (cmbKhoa.SelectedIndex == 0) ? "CNTT" : "VT";
            ChuyenTrangThaiDangCapNhat(true);
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string malop = "";
            if (bdsSinhVien.Count > 0)
            {
                XtraMessageBox.Show("Không thể xóa lớp này vì đã có sinh viên trong lớp này!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (XtraMessageBox.Show("Bạn có chắc muốn xóa lớp này không?", "Xác nhận",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK) return;

            try
            {
                malop = ((DataRowView)bdsLop[bdsLop.Position])["MALOP"].ToString();
                cmd.Add(new DeleteAction(bdsLop));
                bdsLop.RemoveCurrent();
                lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Update(this.DS.LOP);
                XtraMessageBox.Show("Đã xóa thông tin lớp!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi xóa lớp! Bạn hãy xóa lại!\n" + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.lOPTableAdapter.Fill(this.DS.LOP);
                int pos = bdsLop.Find("MALOP", malop);
                if (pos > -1) bdsLop.Position = pos;
            }
            if (bdsLop.Count == 0) btnXoa.Enabled = btnSua.Enabled = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            optionThem = false;
            oldMaLop = Utils.ChuanHoaMa(txtMaLop.Text);
            oldTenLop = Utils.ChuanHoaTen(txtTenLop.Text);
            oldData = (bdsLop.Current as DataRowView).Row.ItemArray;
            vitri = bdsLop.Position;
            ChuyenTrangThaiDangCapNhat(true);
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có chắc muốn hoàn tác không?", "Xác nhận",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK) return;
            try
            {
                cmd.Undo();
                lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Update(this.DS.LOP);
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
                lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Update(this.DS.LOP);
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
            string maLop = Utils.ChuanHoaMa(txtMaLop.Text);
            if (maLop == "")
            {
                XtraMessageBox.Show("Mã lớp không được để trống", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaLop.Focus();
                return;
            }
            if (!Regex.IsMatch(maLop, @"^[A-Z0-9]+$"))
            {
                XtraMessageBox.Show("Mã lớp chỉ được chứa chữ cái in hoa A-Z và số 0-9!",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaLop.Focus();
                return;
            }
            string tenLop = Utils.ChuanHoaTen(txtTenLop.Text);
            if (tenLop == "")
            {
                XtraMessageBox.Show("Tên lớp không được để trống", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenLop.Focus();
                return;
            }
            if (!Regex.IsMatch(tenLop, Utils.TEN_LOP))
            {
                XtraMessageBox.Show("Tên lớp chỉ được chứa chữ cái có hoặc không dấu, số và khoảng cách!",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenLop.Focus();
                return;
            }
            if (txtKhoaHoc.Text.Trim() == "")
            {
                XtraMessageBox.Show("Khóa học không được để trống", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtKhoaHoc.Focus();
                return;
            }
            if (!Regex.IsMatch(txtKhoaHoc.Text.Trim(), @"^\d{4}-\d{4}$"))
            {
                XtraMessageBox.Show("Định dạng khóa học không hợp lệ!\n" +
                    "Khóa học phải có dạng ####-####.\nVí dụ: 2018-2023",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtKhoaHoc.Focus();
                return;
            }
            string khoaHoc = txtKhoaHoc.Text.Trim();
            int namTruoc = int.Parse(khoaHoc.Substring(0, 4));
            int namSau = int.Parse(khoaHoc.Substring(5, 4));
            if (namTruoc >= namSau)
            {
                XtraMessageBox.Show("Khóa học không hợp lệ!\nNăm trước phải nhỏ hơn năm sau!",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtKhoaHoc.Focus();
                return;
            }

            if (optionThem || maLop != oldMaLop)
            {
                string strLenh = $"EXECUTE SP_CHECKID '{maLop}', 'MALOP'";
                int result = Program.Check(strLenh);
                if (result == -1)
                {
                    XtraMessageBox.Show("Lỗi kết nối với database. Mời bạn xem lại!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (result == 1)
                {
                    XtraMessageBox.Show("Mã lớp đã tồn tại! Vui lòng nhập mã lớp khác!", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (result == 2)
                {
                    XtraMessageBox.Show("Mã lớp đã tồn tại ở khoa khác! Vui lòng nhập mã lớp khác!", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (optionThem || !string.Equals(tenLop, oldTenLop, StringComparison.OrdinalIgnoreCase))
            {
                string strLenh = $"EXECUTE SP_CHECKNAME N'{tenLop}', 'TENLOP'";
                int result = Program.Check(strLenh);
                if (result == -1)
                {
                    XtraMessageBox.Show("Lỗi kết nối với database. Mời bạn xem lại!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (result == 1)
                {
                    XtraMessageBox.Show("Tên lớp đã tồn tại! Vui lòng nhập tên lớp khác!", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (result == 2)
                {
                    XtraMessageBox.Show("Tên lớp đã tồn tại ở khoa khác! Vui lòng nhập tên lớp khác!", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            try
            {
                bdsLop.EndEdit();
                bdsLop.ResetCurrentItem();
                DataRowView current = (DataRowView)bdsLop.Current;
                current["MALOP"] = maLop;
                current["TENLOP"] = tenLop;
                lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Update(this.DS.LOP);
                if (optionThem) cmd.Add(new InsertAction(bdsLop));
                else
                {
                    object[] newData = (bdsLop.Current as DataRowView).Row.ItemArray;
                    cmd.Add(new UpdateAction(bdsLop, oldData, newData));
                }
                XtraMessageBox.Show("Đã ghi thông tin lớp vào cơ sở dữ liệu!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi ghi lớp!\n" + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ChuyenTrangThaiDangCapNhat(false);
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsLop.CancelEdit();
            if (btnThem.Enabled == false) bdsLop.Position = vitri;
            ChuyenTrangThaiDangCapNhat(false);
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TaiDuLieu();
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

        
    }
}
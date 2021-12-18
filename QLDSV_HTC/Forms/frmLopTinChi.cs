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
    public partial class frmLopTinChi : DevExpress.XtraEditors.XtraForm
    {
        private int vitri = 0;
        bool optionThem;
        private string oldMaMH;
        private int oldNhom;
        private CommandManager cmd;
        private object[] oldData;

        public frmLopTinChi()
        {
            InitializeComponent();
            cmd = new CommandManager(btnUndo, btnRedo);
        }

        private void ChuyenTrangThaiDangCapNhat(bool flag)
        {
            btnThem.Enabled = btnReload.Enabled = btnThoat.Enabled = nvgtLTC.Enabled = !flag;
            btnXoa.Enabled = btnSua.Enabled = !flag && (bdsLTC.Count > 0);
            btnUndo.Enabled = !flag && cmd.GetUndoStackSize() > 0;
            btnRedo.Enabled = !flag && cmd.GetRedoStackSize() > 0;
            btnGhi.Enabled = btnHuy.Enabled = flag;
            gcLTC.Enabled = !flag;
            groupLTC.Enabled = flag;
            if (Program.mGroup == "PGV")
                cmbKhoa.Enabled = !flag;
            cmbNK.Enabled = cmbHK.Enabled = !flag;
        }

        private void TaiLTC()
        {
            string nk = cmbNK.Text.Trim();
            if (nk == "") return;
            if (!Regex.IsMatch(nk, @"^\d{4}-\d{4}$"))
            {
                XtraMessageBox.Show("Định dạng niên khóa không hợp lệ!\n" +
                    "Khóa học phải có dạng ####-####.\nVí dụ: 2021-2022",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbNK.Focus();
                return;
            }
            int hk;
            int.TryParse(cmbHK.Text, out hk);
            if (hk == 0) return;
            try
            {
                sP_LOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_LOPTINCHITableAdapter.Fill(this.dS.SP_LOPTINCHI, nk, hk);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Đã xảy ra lỗi khi tải lớp tín chỉ!\n" + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btnXoa.Enabled = btnSua.Enabled = bdsLTC.Count > 0;
        }

        private void frmLopTinChi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.HOTENGIANGVIEN' table. You can move, or remove it, as needed.
            this.hOTENGIANGVIENTableAdapter.Fill(this.dS.HOTENGIANGVIEN);
            dS.EnforceConstraints = false;
            //TaiLTC();
            gIANGVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIANGVIENTableAdapter.Fill(this.dS.GIANGVIEN);
            mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            Program.bds_dspm.Filter = "TENKHOA LIKE 'Khoa%'";
            Program.LoadDataToComboBox(cmbKhoa, Program.bds_dspm);
            cmbNK.DataSource = Utils.LayDSNienKhoa();
            cmbHK.DataSource = Utils.LayDSHocKy();
            if (Program.mGroup == "PGV")
                cmbKhoa.Enabled = true;
            else
                cmbKhoa.Enabled = false;
            if (bdsLTC.Count == 0) btnXoa.Enabled = btnSua.Enabled = false;
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
                TaiLTC();
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            optionThem = true;
            vitri = bdsLTC.Position;
            bdsLTC.AddNew();
            spinNhom.Value = spinSoSVToiThieu.Value = 1;
            ckeHuyLop.Checked = false;
            txtMaKhoa.Text = cmbKhoa.Text == "Khoa Công nghệ thông tin" ? "CNTT" : "VT";
            ChuyenTrangThaiDangCapNhat(true);
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int soSVDaDangKy = int.Parse((bdsLTC.Current as DataRowView)["SOSVDADANGKY"].ToString());
            if (soSVDaDangKy > 0)
            {
                XtraMessageBox.Show("Không thể xóa lớp tín chỉ này vì đã có sinh viên đăng ký!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (XtraMessageBox.Show("Bạn có chắc muốn xóa lớp tín chỉ này không?", "Xác nhận",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK) return;

            string maltc = "";
            try
            {
                maltc = ((DataRowView)bdsLTC[bdsLTC.Position])["MALTC"].ToString();
                cmd.Add(new DeleteAction(bdsLTC, true));
                bdsLTC.RemoveCurrent();
                sP_LOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_LOPTINCHITableAdapter.Update(this.dS.SP_LOPTINCHI);
                XtraMessageBox.Show("Đã xóa thông tin lớp tín chỉ!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Không xóa được lớp tín chỉ!\n" + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmd.RemoveLastUndoNode();
                TaiLTC();
                int pos = bdsLTC.Find("MALTC", maltc);
                if (pos > -1) bdsLTC.Position = pos;
            }

            if (bdsLTC.Count == 0) btnXoa.Enabled = btnSua.Enabled = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            optionThem = false;
            oldMaMH = ((DataRowView)bdsLTC.Current)["MAMH"].ToString();
            oldNhom = int.Parse(((DataRowView)bdsLTC.Current)["NHOM"].ToString());
            oldData = (bdsLTC.Current as DataRowView).Row.ItemArray;
            vitri = bdsLTC.Position;
            lkupMH.EditValue = ((DataRowView)bdsLTC.Current)["MAMH"];
            lkupGV.EditValue = ((DataRowView)bdsLTC.Current)["MAGV"];
            ChuyenTrangThaiDangCapNhat(true);
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có chắc muốn hoàn tác không?", "Xác nhận",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK) return;
            try
            {
                cmd.Undo();
                sP_LOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_LOPTINCHITableAdapter.Update(this.dS.SP_LOPTINCHI);
                TaiLTC();
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
                sP_LOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_LOPTINCHITableAdapter.Update(this.dS.SP_LOPTINCHI);
                TaiLTC();
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
            if (lkupMH.EditValue == null)
            {
                XtraMessageBox.Show("Bạn chưa chọn môn học của lớp tín chỉ!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                lkupMH.Focus();
                return;
            }
            string maMH = lkupMH.EditValue.ToString();
            if (spinNhom.Value < 1)
            {
                XtraMessageBox.Show("Số nhóm phải có giá trị dương!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                spinNhom.Focus();
                return;
            }
            int nhom = (int)spinNhom.Value;
            if (lkupGV.EditValue == null)
            {
                XtraMessageBox.Show("Bạn chưa chọn giảng viên dạy lớp tín chỉ!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                lkupGV.Focus();
                return;
            }
            string maGV = lkupGV.EditValue.ToString();
            if (spinSoSVToiThieu.Value < 1)
            {
                XtraMessageBox.Show("Số sinh viên tối thiểu phải có giá trị dương!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                spinSoSVToiThieu.Focus();
                return;
            }

            if (optionThem || (maMH != oldMaMH || nhom != oldNhom))
            {
                string strLenh = $"EXECUTE SP_CHECK_LOPTINCHI " +
                    $"'{cmbNK.Text}', {int.Parse(cmbHK.Text)}, '{maMH}', {spinNhom.Value}";
                int result = Program.Check(strLenh);
                if (result == -1)
                {
                    XtraMessageBox.Show("Lỗi kết nối với database. Mời bạn xem lại!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (result == 1)
                {
                    XtraMessageBox.Show("Môn học với số nhóm này đã có trong niên khóa - học kỳ này!", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (result == 2)
                {
                    XtraMessageBox.Show("Môn học với số nhóm này đã có trong niên khóa - học kỳ này ở khoa khác!", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            try
            {
                DataRowView current = (DataRowView)bdsLTC.Current;
                current["NIENKHOA"] = cmbNK.Text;
                current["HOCKY"] = int.Parse(cmbHK.Text);
                current["MAMH"] = maMH;
                current["MAGV"] = maGV;
                bdsLTC.EndEdit();
                bdsLTC.ResetCurrentItem();
                sP_LOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_LOPTINCHITableAdapter.Update(this.dS.SP_LOPTINCHI);
                TaiLTC();
                bdsLTC.Position = bdsLTC.Find(
                        new Key { PropertyName = "MAMH", Value = maMH },
                        new Key { PropertyName = "NHOM", Value = nhom });
                if (optionThem) cmd.Add(new InsertAction(bdsLTC, true));
                else
                {
                    object[] newData = (bdsLTC.Current as DataRowView).Row.ItemArray;
                    cmd.Add(new UpdateAction(bdsLTC, oldData, newData));
                }
                XtraMessageBox.Show("Đã ghi thông tin lớp tín chỉ vào cơ sở dữ liệu!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi ghi lớp tín chỉ!\n" + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ChuyenTrangThaiDangCapNhat(false);
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsLTC.CancelEdit();
            if (btnThem.Enabled == false) bdsLTC.Position = vitri;
            ChuyenTrangThaiDangCapNhat(false);
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TaiLTC();
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void cmbNK_SelectedIndexChanged(object sender, EventArgs e)
        {
            TaiLTC();
            cmd.Clear();
        }

        private void cmbHK_SelectedIndexChanged(object sender, EventArgs e)
        {
            TaiLTC();
            cmd.Clear();
        }
    }
}
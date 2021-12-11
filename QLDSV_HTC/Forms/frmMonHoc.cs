using DevExpress.Utils;
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
    public partial class frmMonHoc : DevExpress.XtraEditors.XtraForm
    {
        int vitri = 0;
        bool optionThem;
        private string oldMaMH = "";
        private string oldTenMH = "";
        private CommandManager cmd;
        private object[] oldData;

        public frmMonHoc()
        {
            InitializeComponent();
            cmd = new CommandManager(btnUndo, btnRedo);
        }

        private void TaiDuLieu()
        {
            try
            {
                mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.mONHOCTableAdapter.Fill(this.DS.MONHOC);
                lOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTINCHITableAdapter.Fill(this.DS.LOPTINCHI);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi tải môn học: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btnXoa.Enabled = btnSua.Enabled = bdsMonHoc.Count > 0;
            cmd.Clear();
        }

        private void ChuyenTrangThaiDangCapNhat(bool flag)
        {
            btnThem.Enabled = btnReload.Enabled = btnThoat.Enabled = nvgtMonHoc.Enabled = !flag;
            btnXoa.Enabled = btnSua.Enabled = !flag && (bdsMonHoc.Count > 0);
            btnUndo.Enabled = !flag && cmd.GetUndoStackSize() > 0;
            btnRedo.Enabled = !flag && cmd.GetRedoStackSize() > 0;
            btnGhi.Enabled = btnHuy.Enabled = flag;
            gridMonHoc.Enabled = !flag;
            groupMonHoc.Enabled = flag;
        }

        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            TaiDuLieu();
        }
        
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            optionThem = true;
            vitri = bdsMonHoc.Position;
            bdsMonHoc.AddNew();
            ChuyenTrangThaiDangCapNhat(true);
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsLopTinChi.Count > 0)
            {
                XtraMessageBox.Show("Không thể xóa môn học này vì đã có lớp tín chỉ mở cho môn học này!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (XtraMessageBox.Show("Bạn có chắc muốn xóa môn học này không?", "Xác nhận",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK) return;

            string maMH = "";
            try
            {
                maMH = ((DataRowView)bdsMonHoc[bdsMonHoc.Position])["MAMH"].ToString();
                cmd.Add(new DeleteAction(bdsMonHoc));
                bdsMonHoc.RemoveCurrent();
                mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.mONHOCTableAdapter.Update(this.DS.MONHOC);
                XtraMessageBox.Show("Đã xóa thông tin môn học!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi xóa môn học! Bạn hãy xóa lại!\n" + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.mONHOCTableAdapter.Fill(this.DS.MONHOC);
                bdsMonHoc.Position = bdsMonHoc.Find("MAMH", maMH);
                return;
            }

            if (bdsMonHoc.Count == 0) btnXoa.Enabled = btnSua.Enabled = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            optionThem = false;
            oldMaMH = Utils.ChuanHoaMa(txtMaMH.Text);
            oldTenMH = Utils.ChuanHoaTen(txtTenMH.Text);
            oldData = (bdsMonHoc.Current as DataRowView).Row.ItemArray;
            vitri = bdsMonHoc.Position;
            ChuyenTrangThaiDangCapNhat(true);
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có chắc muốn hoàn tác không?", "Xác nhận",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK) return;
            try
            {
                cmd.Undo();
                mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.mONHOCTableAdapter.Update(this.DS.MONHOC);
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
                mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.mONHOCTableAdapter.Update(this.DS.MONHOC);
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
            string maMH = Utils.ChuanHoaMa(txtMaMH.Text);
            if (maMH == "")
            {
                XtraMessageBox.Show("Mã môn học không được để trống!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaMH.Focus();
                return;
            }
            if (!Regex.IsMatch(maMH, @"^[A-Z0-9]+$"))
            {
                XtraMessageBox.Show("Mã môn học chỉ được chứa chữ cái in hoa A-Z và số 0-9!",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaMH.Focus();
                return;
            }
            string tenMH = Utils.ChuanHoaTen(txtTenMH.Text);
            if (tenMH == "")
            {
                XtraMessageBox.Show("Tên môn học không được để trống!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenMH.Focus();
                return;
            }
            if (!Regex.IsMatch(tenMH, Utils.TEN_MH))
            {
                XtraMessageBox.Show("Tên môn học chỉ được chứa chữ cái có hoặc không dấu, số, khoảng cách " +
                    "và một số ký tự đặc biệt như # + -",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenMH.Focus();
                return;
            }
            if (spinSoTietLT.Text.Trim() == "")
            {
                XtraMessageBox.Show("Số tiết lý thuyết không được để trống!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (spinSoTietTH.Text.Trim() == "")
            {
                XtraMessageBox.Show("Số tiết thực hành không được để trống!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (spinSoTietLT.Value + spinSoTietTH.Value == 0)
            {
                XtraMessageBox.Show("Môn học không thể không có tiết học nào!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (optionThem || maMH != oldMaMH)
            {
                string strLenh = $"EXECUTE SP_CHECKID '{maMH}', 'MAMH'";
                int result = Program.Check(strLenh);
                if (result == -1)
                {
                    XtraMessageBox.Show("Lỗi kết nối với database. Mời bạn xem lại!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (result == 1)
                {
                    XtraMessageBox.Show("Mã môn học đã tồn tại! Vui lòng nhập mã môn học khác!", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (optionThem || !string.Equals(tenMH, oldTenMH, StringComparison.OrdinalIgnoreCase))
            {
                string strLenh = $"EXECUTE SP_CHECKNAME N'{tenMH}', 'TENMH'";
                int result = Program.Check(strLenh);
                if (result == -1)
                {
                    XtraMessageBox.Show("Lỗi kết nối với database. Mời bạn xem lại!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (result == 1)
                {
                    XtraMessageBox.Show("Tên môn học đã tồn tại! Vui lòng nhập tên môn học khác!", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            try
            {
                bdsMonHoc.EndEdit();
                bdsMonHoc.ResetCurrentItem();
                DataRowView current = (DataRowView)bdsMonHoc.Current;
                current["MAMH"] = maMH;
                current["TENMH"] = tenMH;
                mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.mONHOCTableAdapter.Update(this.DS.MONHOC);
                if (optionThem) cmd.Add(new InsertAction(bdsMonHoc));
                else {
                    object[] newData = (bdsMonHoc.Current as DataRowView).Row.ItemArray;
                    cmd.Add(new UpdateAction(bdsMonHoc, oldData, newData));
                }
                XtraMessageBox.Show("Đã ghi thông tin môn học vào cơ sở dữ liệu!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi ghi môn học!\n" + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ChuyenTrangThaiDangCapNhat(false);
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsMonHoc.CancelEdit();
            if (btnThem.Enabled == false) bdsMonHoc.Position = vitri;
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

        //private void txtMaMH_EditValueChanged(object sender, EventArgs e)
        //{
        //    txtMaMH.Properties.CharacterCasing = CharacterCasing.Upper;
        //}
    }
}
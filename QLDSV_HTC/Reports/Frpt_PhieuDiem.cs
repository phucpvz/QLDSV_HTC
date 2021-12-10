using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV_HTC.Reports
{
    public partial class Frpt_PhieuDiem : DevExpress.XtraEditors.XtraForm
    {
        public Frpt_PhieuDiem()
        {
            InitializeComponent();
        }

        private void Frpt_PhieuDiem_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            hOTENSINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.hOTENSINHVIENTableAdapter.Fill(this.dS.HOTENSINHVIEN);
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
                hOTENSINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.hOTENSINHVIENTableAdapter.Fill(this.dS.HOTENSINHVIEN);
                lkupSinhVien.EditValue = null;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (lkupSinhVien.EditValue == null)
            {
                XtraMessageBox.Show("Bạn chưa chọn sinh viên!",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lkupSinhVien.Focus();
                return;
            }
            string maSV = lkupSinhVien.EditValue.ToString();
           
            Xrpt_PhieuDiem rpt =
                new Xrpt_PhieuDiem(maSV);

            rpt.lblKhoa.Text = "KHOA: " +
                (cmbKhoa.SelectedIndex == 0 ? "CÔNG NGHỆ THÔNG TIN" : "VIỄN THÔNG");
            rpt.lblMaSV.Text = "Mã sinh viên: " + maSV;
            rpt.lblHoTenSV.Text = "Họ và tên: " + lkupSinhVien.Properties.GetDisplayText(lkupSinhVien.EditValue);

            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }
    }
}
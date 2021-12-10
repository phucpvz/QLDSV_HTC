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
    public partial class Frpt_BangDiemTongKet : DevExpress.XtraEditors.XtraForm
    {
        public Frpt_BangDiemTongKet()
        {
            InitializeComponent();
        }

        private void Frpt_BangDiemTongKet_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);
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
                lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(this.dS.LOP);
                lkupLop.EditValue = null;
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (lkupLop.EditValue == null)
            {
                XtraMessageBox.Show("Bạn chưa chọn lớp!",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lkupLop.Focus();
                return;
            }
            string maLop = lkupLop.EditValue.ToString();
            string tenLop = (bdsLop[bdsLop.Position] as DataRowView)["TENLOP"].ToString();
            string khoaHoc = (bdsLop[bdsLop.Position] as DataRowView)["KHOAHOC"].ToString();
            string maKhoa = (bdsLop[bdsLop.Position] as DataRowView)["MAKHOA"].ToString();

            Xrpt_BangDiemTongKet rpt =
                new Xrpt_BangDiemTongKet(maLop);

            rpt.lblLop.Text = "LỚP: " + tenLop;
            rpt.lblKhoaHoc.Text = "KHÓA HỌC: " + khoaHoc;
            rpt.lblKhoa.Text = "KHOA: " + (maKhoa == "CNTT" ? "CÔNG NGHỆ THÔNG TIN" : "VIỄN THÔNG");

            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
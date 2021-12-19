using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
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

namespace QLDSV_HTC.Reports
{
    public partial class Frpt_DanhSachDongHocPhiLop : DevExpress.XtraEditors.XtraForm
    {
        public Frpt_DanhSachDongHocPhiLop()
        {
            InitializeComponent();
        }

        private void Frpt_DanhSachDongHocPhiLop_Load(object sender, EventArgs e)
        {
            dS_HOCPHI.EnforceConstraints = false;
            lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS_HOCPHI.LOP);
            cmbNK.DataSource = Utils.LayDSNienKhoa();
            cmbHK.DataSource = Utils.LayDSHocKy();
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
            string maKhoa = (bdsLop[bdsLop.Position] as DataRowView)["MAKHOA"].ToString();
            string nienKhoa = cmbNK.Text.Trim();
            if (string.IsNullOrEmpty(nienKhoa))
            {
                XtraMessageBox.Show("Niên khóa không được để trống!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbNK.Focus();
                return;
            }
            if (!Regex.IsMatch(nienKhoa, @"^\d{4}-\d{4}$"))
            {
                XtraMessageBox.Show("Định dạng niên khóa không hợp lệ!\n" +
                    "Niên khóa phải có dạng ####-####.\nVí dụ: 2021-2022",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbNK.Focus();
                return;
            }
            int hocKy = int.Parse(cmbHK.SelectedValue.ToString());
            

            Xrpt_DanhSachDongHocPhiLop rpt =
                new Xrpt_DanhSachDongHocPhiLop(maLop, nienKhoa, hocKy);

            rpt.lblMaLop.Text = "MÃ LỚP: " + maLop;
            rpt.lblKhoa.Text = "KHOA: " + (maKhoa == "CNTT" ? "CÔNG NGHỆ THÔNG TIN" : "VIỄN THÔNG");
            rpt.lblNienKhoa.Text = "Niên khóa: " + nienKhoa;
            rpt.lblHocKy.Text = "Học kỳ: " + hocKy;

            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
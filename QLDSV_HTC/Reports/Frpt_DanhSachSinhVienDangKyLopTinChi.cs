using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
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
    public partial class Frpt_DanhSachSinhVienDangKyLopTinChi : DevExpress.XtraEditors.XtraForm
    {
        public Frpt_DanhSachSinhVienDangKyLopTinChi()
        {
            InitializeComponent();
        }

        private List<string> LayDSNienKhoa()
        {
            List<string> dsNK = new List<string>();
            for (int i = 2010; i < 2100; i++)
            {
                dsNK.Add(string.Format($"{i}-{i + 1}"));
            }
            return dsNK;
        }

        private List<int> LayDSHocKy()
        {
            List<int> dsHK = new List<int>();
            for (int i = 1; i <= 4; i++)
            {
                dsHK.Add(i);
            }
            return dsHK;
        }

        private List<int> LayDSNhom()
        {
            List<int> dsNhom = new List<int>();
            for (int i = 1; i <= 10; i++)
            {
                dsNhom.Add(i);
            }
            return dsNhom;
        }

        private void frptDanhSachSinhVienDangKyLopTinChi_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            Program.bds_dspm.Filter = "TENKHOA LIKE 'Khoa%'";
            Program.LoadDataToComboBox(cmbKhoa, Program.bds_dspm);
            if (Program.mGroup == "PGV")
                cmbKhoa.Enabled = true;
            else
                cmbKhoa.Enabled = false;
            cmbNK.DataSource = LayDSNienKhoa();
            cmbHK.DataSource = LayDSHocKy();
            cmbNhom.DataSource = LayDSNhom();
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
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
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
            if (lkupMonHoc.EditValue == null)
            {
                XtraMessageBox.Show("Bạn chưa chọn môn học!",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lkupMonHoc.Focus();
                return;
            }
            string maMH = lkupMonHoc.EditValue.ToString();
            int nhom;
            try
            {
                nhom = int.Parse(cmbNhom.Text);
            }
            catch
            {
                XtraMessageBox.Show("Nhóm không hợp lệ! Nhóm phải là số nguyên dương!",
                                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lkupMonHoc.Focus();
                return;
            }
            if (nhom < 1)
            {
                XtraMessageBox.Show("Nhóm không hợp lệ! Nhóm phải là số nguyên dương!",
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lkupMonHoc.Focus();
                return;
            }

            Xrpt_DanhSachSinhVienDangKyLopTinChi rpt = 
                new Xrpt_DanhSachSinhVienDangKyLopTinChi(nienKhoa, hocKy, maMH, nhom);

            rpt.lblKhoa.Text = "KHOA: " +
                (cmbKhoa.SelectedIndex == 0 ? "CÔNG NGHỆ THÔNG TIN" : "VIỄN THÔNG");
            rpt.lblNienKhoa.Text = "Niên khóa: " + nienKhoa;
            rpt.lblHocKy.Text = "Học kỳ: " + hocKy;
            rpt.lblMonHoc.Text = "Môn học: " + lkupMonHoc.Properties.GetDisplayText(lkupMonHoc.EditValue);
            rpt.lblNhom.Text = "Nhóm: " + hocKy;

            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
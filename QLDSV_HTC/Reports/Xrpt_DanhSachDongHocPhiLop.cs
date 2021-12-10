using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLDSV_HTC.Reports
{
    public partial class Xrpt_DanhSachDongHocPhiLop : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_DanhSachDongHocPhiLop(string maLop, string nienKhoa, int hocKy)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = maLop;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = nienKhoa;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = hocKy;
            this.sqlDataSource1.Fill();
        }

        private void lblTienChu_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            double fieldValue = Convert.ToDouble(GetCurrentColumnValue("calTongSoTienDaDong"));
            lblTienChu.Text = $"({Utils.NumberToText(fieldValue)})";
        }
    }
}

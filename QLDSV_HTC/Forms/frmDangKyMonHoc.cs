using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV_HTC.Forms
{
    public partial class frmDangKyMonHoc : DevExpress.XtraEditors.XtraForm
    {
        private DataTable dt_maltc;
        private DataTable dt_DS_LTC_DADK;

        public frmDangKyMonHoc()
        {
            InitializeComponent();

            dt_DS_LTC_DADK = new DataTable();
            dt_DS_LTC_DADK.Columns.Add("MALTC", typeof(int));
            dt_DS_LTC_DADK.Columns.Add("MAMH", typeof(string));
            dt_DS_LTC_DADK.Columns.Add("TENMH", typeof(string));
            dt_DS_LTC_DADK.Columns.Add("NHOM", typeof(int));
            dt_DS_LTC_DADK.Columns.Add("HOTENGV", typeof(string));
            dt_DS_LTC_DADK.Columns.Add("SOSVTOITHIEU", typeof(int));
            dt_DS_LTC_DADK.Columns.Add("SOSVDADANGKY", typeof(int));
            dt_DS_LTC_DADK.Columns.Add("HUYDANGKY", typeof(bool));
            gc_DS_LTC_DADK.DataSource = dt_DS_LTC_DADK;
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

        private bool kiemTraMaLTCDaLuu(string maltc_xoa)
        {
            for (int i = 0; i < dt_maltc.Rows.Count; i++)
            {
                string maltc = dt_maltc.Rows[i]["MALTC"].ToString();
                if (maltc_xoa == maltc)
                {
                    return true;
                }
            }
            return false;
        }

        private void frmSVDangKy_Load(object sender, EventArgs e)
        {
            txtMaSV.Text = Program.username;
            txtHoTen.Text = Program.mHoten;
            txtMaLop.Text = Program.mLop;
            txtMaKhoa.Text = Program.mKhoa == 0 ? "CNTT" : "VT";

            cmbNK.DataSource = LayDSNienKhoa();
            cmbHK.DataSource = LayDSHocKy();
        }

        private object[] AppendToArray(ref object[] arr, object o)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = o;
            return arr;
        }

        private void TaiDSLTC()
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
                sP_LAY_DS_LTCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_LAY_DS_LTCTableAdapter.Fill(this.dS.SP_LAY_DS_LTC, nk, hk);

                if (dt_DS_LTC_DADK == null) return;
                dt_DS_LTC_DADK.Rows.Clear();
                string strLenh = $"EXEC SP_LAY_DS_MALTC_DADK " +
                    $"'{cmbNK.Text}', {int.Parse(cmbHK.Text)}, '{Program.username}'";
                dt_maltc = Program.ExecSqlDataTable(strLenh);
                for (int i = 0; i < dt_maltc.Rows.Count; i++)
                {
                    string maltc = dt_maltc.Rows[i]["MALTC"].ToString();
                    for (int j = 0; j < bdsDSLTC.Count; j++)
                    {
                        DataRowView drv = (DataRowView)bdsDSLTC[j];
                        if (drv["MALTC"].ToString() == maltc)
                        {
                            object[] a = drv.Row.ItemArray;
                            dt_DS_LTC_DADK.Rows.Add(AppendToArray(ref a, false));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Đã xảy ra lỗi khi tải lớp tín chỉ!\n" + ex.Message,
                     "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btnThemDK.Enabled = (bdsDSLTC.Count > 0);
            btnXoaDK.Enabled = btnLuuDK.Enabled = (dt_DS_LTC_DADK.Rows.Count > 0);
        }

        private void cmbHK_SelectedIndexChanged(object sender, EventArgs e)
        {
            TaiDSLTC();
        }

        private void cmbNK_SelectedIndexChanged(object sender, EventArgs e)
        {
            TaiDSLTC();
        }

        private void btnThemDK_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)bdsDSLTC[bdsDSLTC.Position];
            string tenMH = drv["TENMH"].ToString();
            for (int i = 0; i < dt_DS_LTC_DADK.Rows.Count; i++)
            {
                if (dt_DS_LTC_DADK.Rows[i]["TENMH"].ToString() == tenMH)
                {
                    XtraMessageBox.Show($"Không thể thêm lớp tín chỉ của môn \"{tenMH}\" " +
                        "vì đã có lớp tín chỉ của môn học này trong danh sách chờ đăng ký!",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            object[] a = drv.Row.ItemArray;
            dt_DS_LTC_DADK.Rows.Add(AppendToArray(ref a, false));
            btnXoaDK.Enabled = btnLuuDK.Enabled = true;
        }

        private void btnXoaDK_Click(object sender, EventArgs e)
        {
            string maltc_xoa = dt_DS_LTC_DADK.Rows[gv_DS_LTC_DADK.GetSelectedRows()[0]]["MALTC"].ToString();
            if (kiemTraMaLTCDaLuu(maltc_xoa))
            {
                XtraMessageBox.Show($"Không thể xóa đăng ký này vì đăng ký này đã lưu trong cơ sở dữ liệu trước đó!\n" +
                    "Vui lòng đánh dấu hủy đăng ký để thay thế!",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dt_DS_LTC_DADK.Rows.Remove(dt_DS_LTC_DADK.Select($"MALTC = '{maltc_xoa}'")[0]);
                if (dt_DS_LTC_DADK.Rows.Count == 0)
                {
                    btnXoaDK.Enabled = btnLuuDK.Enabled = false;
                }
            }
        }

        private void btnLuuDK_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MALTC", typeof(int));
            dt.Columns.Add("MASV", typeof(string));
            dt.Columns.Add("HUYDANGKY", typeof(bool));
            for (int i = 0; i < dt_DS_LTC_DADK.Rows.Count; i++)
            {
                dt.Rows.Add(dt_DS_LTC_DADK.Rows[i]["MALTC"], Program.username, dt_DS_LTC_DADK.Rows[i]["HUYDANGKY"]);
            }

            SqlParameter para = new SqlParameter();
            para.SqlDbType = SqlDbType.Structured;
            para.TypeName = "dbo.TYPE_SV_DANGKY";
            para.ParameterName = "@DSDANGKY";
            para.Value = dt;
            Program.KetNoi();

            SqlCommand Sqlcmd = new SqlCommand("SP_UPDATE_DANGKY", Program.conn);
            Sqlcmd.Parameters.Clear();
            Sqlcmd.CommandType = CommandType.StoredProcedure;
            try
            {
                Sqlcmd.Parameters.Add(para);
                Sqlcmd.ExecuteNonQuery();
                XtraMessageBox.Show("Đã lưu đăng ký vào cơ sở dữ liệu!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Đã xảy ra lỗi khi lưu đăng ký!\n" + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            TaiDSLTC();
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
    }
}
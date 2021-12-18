using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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
    public partial class frmDiem : DevExpress.XtraEditors.XtraForm
    {
        private DataTable dt_DS_DangKy;
        private string maltc = "";

        public frmDiem()
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

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void frmNhapDiem_Load(object sender, EventArgs e)
        {
            Program.bds_dspm.Filter = "TENKHOA LIKE 'Khoa%'";
            Program.LoadDataToComboBox(cmbKhoa, Program.bds_dspm);
            if (Program.mGroup == "PGV")
                cmbKhoa.Enabled = true;
            else
                cmbKhoa.Enabled = false;

            cmbNK.DataSource = LayDSNienKhoa();
            cmbHK.DataSource = LayDSHocKy();
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
                sP_LAY_DS_LTCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_LAY_DS_LTCTableAdapter.Fill(this.dS.SP_LAY_DS_LTC, nk, hk);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Đã xảy ra lỗi khi tải lớp tín chỉ!\n" + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            gc_DS_DangKy.DataSource = null;
            btnNhapDiem.Enabled = (bdsDSLTC.Count > 0);
            btnGhiDiem.Enabled = false;
        }

        private void btnNhapDiem_Click(object sender, EventArgs e)
        {
            maltc = ((DataRowView)bdsDSLTC[bdsDSLTC.Position])["MALTC"].ToString();
            string strLenh = "EXEC SP_LAY_DSSV_DANGKY " + maltc;
            dt_DS_DangKy = Program.ExecSqlDataTable(strLenh);
            gc_DS_DangKy.DataSource = dt_DS_DangKy;
            btnGhiDiem.Enabled = dt_DS_DangKy.Rows.Count > 0;
        }

        private void btnGhiDiem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MALTC", typeof(int));
            dt.Columns.Add("MASV", typeof(string));
            dt.Columns.Add("DIEM_CC", typeof(int));
            dt.Columns.Add("DIEM_GK", typeof(float));
            dt.Columns.Add("DIEM_CK", typeof(float));
            int intmaltc = int.Parse(maltc);
            for (int i = 0; i < dt_DS_DangKy.Rows.Count; i++)
            {
                dt.Rows.Add(intmaltc, dt_DS_DangKy.Rows[i]["MASV"], dt_DS_DangKy.Rows[i]["DIEM_CC"],
                    dt_DS_DangKy.Rows[i]["DIEM_GK"], dt_DS_DangKy.Rows[i]["DIEM_CK"]);
            }

            SqlParameter para = new SqlParameter();
            para.SqlDbType = SqlDbType.Structured;
            para.TypeName = "dbo.TYPE_DANGKY";
            para.ParameterName = "@DIEMTHI";
            para.Value = dt;
            Program.KetNoi();

            SqlCommand Sqlcmd = new SqlCommand("SP_UPDATE_DIEM", Program.conn);
            Sqlcmd.Parameters.Clear();
            Sqlcmd.CommandType = CommandType.StoredProcedure;
            try
            {
                Sqlcmd.Parameters.Add(para);
                Sqlcmd.ExecuteNonQuery();
                XtraMessageBox.Show("Đã ghi toàn bộ điểm vào cơ sở dữ liệu!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Đã xảy ra lỗi khi nhập điểm!\n" + ex.Message, 
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }          
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

        private void cmbNK_SelectedIndexChanged(object sender, EventArgs e)
        {
            TaiLTC();
        }

        private void cmbHK_SelectedIndexChanged(object sender, EventArgs e)
        {
            TaiLTC();
        }

        private void gvDiem_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            GridView view = sender as GridView;
            if (view.FocusedColumn.FieldName == "DIEM_CC")
            {
                if (string.IsNullOrEmpty(e.Value as string))
                    return;
                int diem;
                try
                {
                    diem = int.Parse(e.Value as string);
                }
                catch
                {
                    e.Valid = false;
                    e.ErrorText = "Điểm chuyên cần phải là số nguyên từ 0 đến 10!";
                    return;
                }
                if (diem < 0 || diem > 10)
                {
                    e.Valid = false;
                    e.ErrorText = "Điểm chuyên cần phải là số nguyên từ 0 đến 10!";
                    return;
                }
            }
            else if (view.FocusedColumn.FieldName == "DIEM_GK")
            {
                if (string.IsNullOrEmpty(e.Value as string))
                    return;
                float diem;
                try
                {
                    diem = float.Parse(e.Value as string);
                }
                catch
                {
                    e.Valid = false;
                    e.ErrorText = "Điểm giữa kỳ phải là số thực từ 0 đến 10!";
                    return;
                }
                if (diem < 0 || diem > 10)
                {
                    e.Valid = false;
                    e.ErrorText = "Điểm giữa kỳ phải là số thực từ 0 đến 10!";
                    return;
                }
                e.Value = Math.Round(diem * 2, MidpointRounding.AwayFromZero) / 2;
            }
            else if (view.FocusedColumn.FieldName == "DIEM_CK")
            {
                if (string.IsNullOrEmpty(e.Value as string))
                    return;
                float diem;
                try
                {
                    diem = float.Parse(e.Value as string);
                }
                catch
                {
                    e.Valid = false;
                    e.ErrorText = "Điểm cuối kỳ phải là số thực từ 0 đến 10!";
                    return;
                }
                if (diem < 0 || diem > 10)
                {
                    e.Valid = false;
                    e.ErrorText = "Điểm cuối kỳ phải là số thực từ 0 đến 10!";
                    return;
                }
                e.Value = Math.Round(diem * 2, MidpointRounding.AwayFromZero) / 2;
            }
        }
    }
}
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV_HTC.Forms
{
    public partial class frmDangNhap : XtraForm
    {
        private SqlConnection conn_publisher = new SqlConnection();

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void Lay_DSPM(string cmd)
        {
            DataTable dt = new DataTable();
            if (conn_publisher.State == ConnectionState.Closed) conn_publisher.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn_publisher);
            da.Fill(dt);
            conn_publisher.Close();
            Program.bds_dspm.DataSource = dt;
            Program.bds_dspm.Sort = "TENKHOA ASC";
            Program.bds_dspm.Filter = "TENKHOA LIKE '%'";
            Program.LoadDataToComboBox(cmbKhoa, Program.bds_dspm.DataSource);
        }

        private int KetNoi_CSDLGOC()
        {
            if (conn_publisher != null && conn_publisher.State == ConnectionState.Open)
                conn_publisher.Close();
            try
            {
                conn_publisher.ConnectionString = Program.connstr_publisher;
                conn_publisher.Open();
                return 1;
            }
            catch (Exception e)
            {
                XtraMessageBox.Show("Lỗi kết nối cơ sở dữ liệu gốc.\nBạn xem lại Tên Server của Publisher, và tên CSDL trong chuỗi kết nối.\n " + e.Message, "Lỗi kết nối", MessageBoxButtons.OK);
                return 0;
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            if (KetNoi_CSDLGOC() == 0) return;
            Lay_DSPM("SELECT * FROM V_DS_PHANMANH");
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKhoa.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            try
            {
                Program.serverName = cmbKhoa.SelectedValue.ToString();
            }
            catch (Exception) { }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close(); Program.frmChinh.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text.Trim() == "" || txtPass.Text.Trim() == "")
            {
                XtraMessageBox.Show("Login name và mật khẩu không được để trống", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (rbtnGV.Checked)
            {
                Program.mLogin = txtLogin.Text;
                Program.password = txtPass.Text;
                if (Program.KetNoi() == 0) return;

                Program.mKhoa = cmbKhoa.SelectedIndex;
                Program.mLoginDN = Program.mLogin;
                Program.passwordDN = Program.password;
                string strLenh = "EXEC SP_DANGNHAP '" + Program.mLogin + "'";

                Program.myReader = Program.ExecSqlDataReader(strLenh);
                if (Program.myReader == null) return;
                Program.myReader.Read();

                Program.username = Program.myReader.GetString(0);   // Lấy username
                if (Convert.IsDBNull(Program.username))
                {
                    XtraMessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu.\n" +
                        "Bạn hãy xem lại tài khoản và mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    Program.mHoten = Program.myReader.GetString(1);
                }
                catch
                {
                    XtraMessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu.\n" +
                        "Bạn hãy xem lại tài khoản và mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Program.mGroup = Program.myReader.GetString(2);
                Program.myReader.Close();
                Program.conn.Close();
            }
            else
            {
                Program.mLogin = Program.svLogin;
                Program.password = Program.svPassword;
                if (Program.KetNoi() == 0) return;

                Program.mKhoa = cmbKhoa.SelectedIndex;
                string strLenh = $"EXEC SP_SV_DANGNHAP '{txtLogin.Text}', '{txtPass.Text}'";
                Program.myReader = Program.ExecSqlDataReader(strLenh);
                if (Program.myReader == null) return;
                if (!Program.myReader.HasRows)
                {
                    XtraMessageBox.Show("Tên đăng nhập hoặc mật khẩu của bạn không chính xác!\n" +
                        "Bạn hãy xem lại tài khoản và mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Program.myReader.Read();
                Program.username = Program.myReader["MASV"].ToString();
                Program.mHoten = Program.myReader["HOTENSV"].ToString();
                Program.mLop = Program.myReader["MALOP"].ToString();
                Program.mGroup = "SV";
                Program.myReader.Close();
            }

            Close();
            Program.frmChinh.PhanQuyen();
        }

        private void ckbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = !txtPass.UseSystemPasswordChar;
        }

        private void rbtnGV_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnGV.Checked)
            {
                Program.bds_dspm.Filter = "TENKHOA LIKE '%'";
                lblLogin.Text = "Login:";
            }
            else
            {
                Program.bds_dspm.Filter = "TENKHOA LIKE 'Khoa%'";
                lblLogin.Text = "Mã sinh viên:";
            }
            lblLogin.Location = new Point
                (lblPassword.Location.X + lblPassword.Width - lblLogin.Width, lblLogin.Location.Y);
        }
    }
}

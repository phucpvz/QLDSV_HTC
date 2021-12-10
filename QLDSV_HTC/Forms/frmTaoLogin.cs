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
    public partial class frmTaoLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmTaoLogin()
        {
            InitializeComponent();
        }

        private void frmTaoTaiKhoan_Load(object sender, EventArgs e)
        {
            DS_HOCPHI.EnforceConstraints = false;
            gIANGVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIANGVIENTableAdapter.Fill(this.DS_HOCPHI.GIANGVIEN);

            if (Program.mGroup == "PGV" || Program.mGroup == "KHOA")
            {
                Program.bds_dspm.Filter = "TENKHOA LIKE 'Khoa%'";
                Program.LoadDataToComboBox(cmbKhoa, Program.bds_dspm);
            }
            else
            {
                cmbKhoa.DataSource = null;
            }
            
            if (Program.mGroup == "PGV")
            {
                pnlKhoa.Visible = cmbKhoa.Enabled = true;
                rbtnPGV.Visible = rbtnKHOA.Visible = true;
                rbtnPKT.Visible = false;
                rbtnPGV.Checked = true;
            }
            else if (Program.mGroup == "KHOA")
            {
                pnlKhoa.Visible = true;
                cmbKhoa.Enabled = false;
                rbtnKHOA.Visible = true;
                rbtnPGV.Visible = rbtnPKT.Visible = false;
                rbtnKHOA.Checked = true;
            }
            else if (Program.mGroup == "PKT")
            {
                pnlKhoa.Visible = cmbKhoa.Enabled = false;
                rbtnPKT.Visible = true;
                rbtnPGV.Visible = rbtnKHOA.Visible = false;
                rbtnPKT.Checked = true;
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string loginName = txtLogin.Text.Trim();
            if (string.IsNullOrEmpty(loginName))
            {
                XtraMessageBox.Show("Tên đăng nhập không được để trống!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string password = txtPassword.Text.Trim();
            if (string.IsNullOrEmpty(password))
            {
                XtraMessageBox.Show("Mật khẩu không được để trống!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string confirm = txtConfirm.Text.Trim();
            if (confirm != password)
            {
                XtraMessageBox.Show("Xác nhận mật khẩu không chính xác!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (lookUpGV.EditValue == null)
            {
                XtraMessageBox.Show("Bạn chưa chọn giảng viên dùng tài khoản này!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string username = lookUpGV.EditValue.ToString();
            string role = rbtnPGV.Checked ? "PGV" : (rbtnKHOA.Checked? "KHOA" : "PKT");

            string strLenh = $"EXEC SP_TAOLOGIN '{loginName}', '{password}', '{username}', '{role}'";
            int result = Program.Check(strLenh);
            if (result == 1)
            {
                XtraMessageBox.Show("Tên đăng nhập đã tồn tại trên phòng/khoa này!\n" +
                        "Hãy nhập tên login khác!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (result == 2)
            {
                XtraMessageBox.Show("Giảng viên này đã có tài khoản trên phòng/khoa hiện tại!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (result == 3)
            {
                XtraMessageBox.Show("Lỗi khi tạo login!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (result == 4)
            {
                XtraMessageBox.Show("Lỗi khi tạo user!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (result == 0)
            {
                XtraMessageBox.Show("Đã tạo tài khoản mới thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLogin.Text = txtPassword.Text = txtConfirm.Text = "";
                ckbShowPass.Checked = false;
                lookUpGV.EditValue = null;
                return;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.Properties.UseSystemPasswordChar = txtConfirm.Properties.UseSystemPasswordChar 
                = !ckbShowPass.Checked;
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
    }
}
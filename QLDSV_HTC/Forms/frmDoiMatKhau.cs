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
    public partial class frmDoiMatKhau : DevExpress.XtraEditors.XtraForm
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void ckbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtOldPassword.Properties.UseSystemPasswordChar 
                = txtNewPassword.Properties.UseSystemPasswordChar
                = txtConfirm.Properties.UseSystemPasswordChar
                = !ckbShowPass.Checked;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string oldPassword = txtOldPassword.Text.Trim();
            if (string.IsNullOrEmpty(oldPassword))
            {
                XtraMessageBox.Show("Vui lòng nhập mật khẩu cũ của bạn!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string newPassword = txtNewPassword.Text.Trim();
            if (string.IsNullOrEmpty(newPassword))
            {
                XtraMessageBox.Show("Mật khẩu mới không được để trống!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string confirm = txtConfirm.Text.Trim();
            if (confirm != newPassword)
            {
                XtraMessageBox.Show("Xác nhận mật khẩu mới không chính xác!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string lenh = $"EXEC SP_SV_DANGNHAP '{Program.username}', '{oldPassword}'";
            DataTable dt = Program.ExecSqlDataTable(lenh);
            if (dt == null) return;
            if (dt.Rows.Count == 0)
            {
                XtraMessageBox.Show("Mật khẩu cũ bạn nhập không chính xác! Vui lòng kiểm tra lại!", 
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (XtraMessageBox.Show("Bạn có chắc muốn thay đổi mật khẩu không?",
                "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK) return;
            try
            {
                string strLenh = $"EXECUTE SP_DATMATKHAU '{Program.username}', '{newPassword}'";
                int result = Program.ExecSqlNonQuery(strLenh);
                if (result == 0)
                {
                    XtraMessageBox.Show("Đã thay đổi mật khẩu của bạn!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi khi thay đổi mật khẩu của bạn! Bạn hãy thử lại!\n" + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
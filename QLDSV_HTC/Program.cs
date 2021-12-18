using DevExpress.Skins;
using DevExpress.UserSkins;
using DevExpress.XtraEditors;
using QLDSV_HTC.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace QLDSV_HTC
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        public static SqlConnection conn = new SqlConnection();
        public static string connstr;
        public static string connstr_publisher = "Data Source=DESKTOP-IKO3LOH;Initial Catalog=QLDSV_TC;" +
            "Integrated Security=True";

        public static SqlDataReader myReader;
        public static string serverName = "";
        public static string username = "";
        public static string mLogin = "";
        public static string password = "";

        public static string database = "QLDSV_TC";
        public static string remoteLogin = "HTKN";
        public static string remotePassword = "123456";
        public static string mLoginDN = "";
        public static string passwordDN = "";

        public static string svLogin = "ptit";
        public static string svPassword = "123";
        public static string mLop = "";

        public static string mGroup = "";
        public static string mHoten = "";
        public static int mKhoa = 0;

        public static BindingSource bds_dspm = new BindingSource();
        public static frmMain frmChinh;
        
        public static int KetNoi()
        {
            if (conn != null && conn.State == ConnectionState.Open)
                conn.Close();
            try
            {
                connstr = "Data Source=" + serverName + ";Initial Catalog=" +
                      database + ";User ID=" +
                      mLogin + ";Password=" + password;
                conn.ConnectionString = connstr;
                conn.Open();
                return 1;
            }
            catch (Exception e)
            {
                XtraMessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại username và password.\n " + e.Message, "Lỗi kết nối", MessageBoxButtons.OK);
                return 0;
            }
        }

        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myReader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                myReader = sqlcmd.ExecuteReader();
                return myReader;
            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                XtraMessageBox.Show(ex.Message);
                return null;
            }
        }

        public static DataTable ExecSqlDataTable(string cmd)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public static int ExecSqlNonQuery(string strLenh)
        {
            SqlCommand sqlcmd = new SqlCommand(strLenh, conn);
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandTimeout = 600; // 10 phút
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                sqlcmd.ExecuteNonQuery(); conn.Close();
                return 0;
            }
            catch (SqlException ex)
            {
                XtraMessageBox.Show(ex.Message);
                conn.Close();
                return ex.State; // Trạng thái lỗi gửi từ RAISERROR trong SQL Server qua
            }
        }

        public static void LoadDataToComboBox(System.Windows.Forms.ComboBox combo, object data)
        {
            combo.DataSource = data;
            combo.DisplayMember = "TENKHOA";
            combo.ValueMember = "TENSERVER";

            combo.SelectedIndex = 1;
            combo.SelectedIndex = Program.mKhoa;
        }

        public static int Check(string strLenh)
        {
            SqlDataReader dataReader = Program.ExecSqlDataReader(strLenh);
            if (dataReader == null)
            {
                return -1;
            }
            dataReader.Read();
            int result = int.Parse(dataReader.GetValue(0).ToString());
            dataReader.Close();
            return result;
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            frmChinh = new frmMain();
            Application.Run(frmChinh);
        }
    }
}

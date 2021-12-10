using QLDSV_HTC.Forms;
using QLDSV_HTC.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLDSV_HTC
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
            ShowMdiChildren(typeof(frmDangNhap));
        }

        public void PhanQuyen()
        {
            lblMAGV.Text = "MÃ: " + Program.username;
            lblHOTEN.Text = "HỌ VÀ TÊN: " + Program.mHoten;
            lblNHOM.Text = "NHÓM: " + Program.mGroup;
            
            if (Program.mGroup == "PGV" || Program.mGroup == "KHOA")
            {
                rbpQuanLy.Visible = true;
                rbpSinhVien.Visible = false;
                rbpHocPhi.Visible = false;
                rbpBaoCao.Visible = true;
                rpgBaoCaoLop.Visible = rpgBaoCaoDiem.Visible = true;
                rpgBaoCaoHocPhi.Visible = false;

                btnTaoTaiKhoan.Links[0].Visible = true;
                btnChangePassword.Links[0].Visible = false;
            }
            else if (Program.mGroup == "SV")
            {
                rbpQuanLy.Visible = false;
                rbpSinhVien.Visible = true;
                rbpHocPhi.Visible = false;
                rbpBaoCao.Visible = false;
                
                btnTaoTaiKhoan.Links[0].Visible = false;
                btnChangePassword.Links[0].Visible = true;
            }
            else if (Program.mGroup == "PKT")
            {
                rbpQuanLy.Visible = false;
                rbpSinhVien.Visible = false;
                rbpHocPhi.Visible = true;
                rbpBaoCao.Visible = true;
                rpgBaoCaoLop.Visible = rpgBaoCaoDiem.Visible = false;
                rpgBaoCaoHocPhi.Visible = true;

                btnTaoTaiKhoan.Links[0].Visible = true;
                btnChangePassword.Links[0].Visible = false;
            }
            rbpCaiDat.Visible = true;
        }

        private void ShowMdiChildren(Type fType)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == fType)
                {
                    f.Activate();
                    return;
                }
            }
            Form form = (Form)Activator.CreateInstance(fType);
            form.MdiParent = this;
            form.Show();
        }

        private void CloseAllMdiChildren()
        {
            foreach (Form f in this.MdiChildren)
            {
                f.Close();
            }
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.username = Program.mHoten = Program.mGroup = "";
            lblMAGV.Text = "MAGV";
            lblHOTEN.Text = "HOTEN";
            lblNHOM.Text = "NHOM";
            rbpQuanLy.Visible = rbpSinhVien.Visible = rbpHocPhi.Visible 
                = rbpBaoCao.Visible = rbpCaiDat.Visible = false;
            CloseAllMdiChildren();
            ShowMdiChildren(typeof(frmDangNhap));
        }

        private void btnLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(frmLop));
        }

        private void btnSinhVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(frmSinhVien));
        }

        private void btnMonHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(frmMonHoc));
        }

        private void btnGiangVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(frmGiangVien));
        }

        private void btnLopTinChi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(frmLopTinChi));
        }

        private void btnDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(frmDiem));
        }

        private void btnSVDangKy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(frmDangKyMonHoc));
        }

        private void btnHocPhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(frmHocPhi));
        }

        private void btnTaoTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(frmTaoLogin));
        }

        private void btnDSLTC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(Frpt_DanhSachLopTinChi));
        }

        private void btnDSSVDangKy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(Frpt_DanhSachSinhVienDangKyLopTinChi));
        }

        private void btnBDMonHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(Frpt_BangDiemMonHoc));
        }

        private void btnPhieuDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(Frpt_PhieuDiem));
        }

        private void btnDSDongHocPhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(Frpt_DanhSachDongHocPhiLop));
        }

        private void btnBDTongKet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(Frpt_BangDiemTongKet));
        }

        private void btnChangePassword_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(frmDoiMatKhau));
        }
    }
}

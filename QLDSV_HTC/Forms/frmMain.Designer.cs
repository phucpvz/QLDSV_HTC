
namespace QLDSV_HTC
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            DevExpress.Utils.Animation.PushTransition pushTransition1 = new DevExpress.Utils.Animation.PushTransition();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnLop = new DevExpress.XtraBars.BarButtonItem();
            this.btnSinhVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnMonHoc = new DevExpress.XtraBars.BarButtonItem();
            this.btnGiangVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnLopTinChi = new DevExpress.XtraBars.BarButtonItem();
            this.btnDiem = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnTaoTaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            this.btnSVDangKy = new DevExpress.XtraBars.BarButtonItem();
            this.btnHocPhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnDSLTC = new DevExpress.XtraBars.BarButtonItem();
            this.btnDSSVDangKy = new DevExpress.XtraBars.BarButtonItem();
            this.btnBDMonHoc = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhieuDiem = new DevExpress.XtraBars.BarButtonItem();
            this.btnDSDongHocPhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnBDTongKet = new DevExpress.XtraBars.BarButtonItem();
            this.btnChangePassword = new DevExpress.XtraBars.BarButtonItem();
            this.rbpQuanLy = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpSinhVien = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpHocPhi = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpBaoCao = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgBaoCaoLop = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgBaoCaoDiem = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgBaoCaoHocPhi = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpCaiDat = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblMAGV = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblHOTEN = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblNHOM = new System.Windows.Forms.ToolStripStatusLabel();
            this.workspaceManager1 = new DevExpress.Utils.WorkspaceManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnLop,
            this.btnSinhVien,
            this.btnMonHoc,
            this.btnGiangVien,
            this.btnLopTinChi,
            this.btnDiem,
            this.btnDangXuat,
            this.btnTaoTaiKhoan,
            this.btnSVDangKy,
            this.btnHocPhi,
            this.btnDSLTC,
            this.btnDSSVDangKy,
            this.btnBDMonHoc,
            this.btnPhieuDiem,
            this.btnDSDongHocPhi,
            this.btnBDTongKet,
            this.btnChangePassword});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 29;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbpQuanLy,
            this.rbpSinhVien,
            this.rbpHocPhi,
            this.rbpBaoCao,
            this.rbpCaiDat});
            this.ribbonControl1.Size = new System.Drawing.Size(960, 158);
            // 
            // btnLop
            // 
            this.btnLop.Caption = "Lớp";
            this.btnLop.Id = 6;
            this.btnLop.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLop.ImageOptions.Image")));
            this.btnLop.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLop.ImageOptions.LargeImage")));
            this.btnLop.Name = "btnLop";
            this.btnLop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLop_ItemClick);
            // 
            // btnSinhVien
            // 
            this.btnSinhVien.Caption = "Sinh viên";
            this.btnSinhVien.Id = 7;
            this.btnSinhVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSinhVien.ImageOptions.Image")));
            this.btnSinhVien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSinhVien.ImageOptions.LargeImage")));
            this.btnSinhVien.Name = "btnSinhVien";
            this.btnSinhVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSinhVien_ItemClick);
            // 
            // btnMonHoc
            // 
            this.btnMonHoc.Caption = "Môn học";
            this.btnMonHoc.Id = 8;
            this.btnMonHoc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMonHoc.ImageOptions.Image")));
            this.btnMonHoc.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMonHoc.ImageOptions.LargeImage")));
            this.btnMonHoc.Name = "btnMonHoc";
            this.btnMonHoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMonHoc_ItemClick);
            // 
            // btnGiangVien
            // 
            this.btnGiangVien.Caption = "Giảng viên";
            this.btnGiangVien.Id = 9;
            this.btnGiangVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGiangVien.ImageOptions.Image")));
            this.btnGiangVien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGiangVien.ImageOptions.LargeImage")));
            this.btnGiangVien.Name = "btnGiangVien";
            this.btnGiangVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGiangVien_ItemClick);
            // 
            // btnLopTinChi
            // 
            this.btnLopTinChi.Caption = "Lớp tín chỉ\r\n";
            this.btnLopTinChi.Id = 13;
            this.btnLopTinChi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLopTinChi.ImageOptions.Image")));
            this.btnLopTinChi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLopTinChi.ImageOptions.LargeImage")));
            this.btnLopTinChi.Name = "btnLopTinChi";
            this.btnLopTinChi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLopTinChi_ItemClick);
            // 
            // btnDiem
            // 
            this.btnDiem.Caption = "Điểm";
            this.btnDiem.Id = 14;
            this.btnDiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDiem.ImageOptions.Image")));
            this.btnDiem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDiem.ImageOptions.LargeImage")));
            this.btnDiem.Name = "btnDiem";
            this.btnDiem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDiem_ItemClick);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Caption = "Đăng xuất";
            this.btnDangXuat.Id = 1;
            this.btnDangXuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.ImageOptions.Image")));
            this.btnDangXuat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.ImageOptions.LargeImage")));
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangXuat_ItemClick);
            // 
            // btnTaoTaiKhoan
            // 
            this.btnTaoTaiKhoan.Caption = "Tạo tài khoản";
            this.btnTaoTaiKhoan.Id = 4;
            this.btnTaoTaiKhoan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTaoTaiKhoan.ImageOptions.Image")));
            this.btnTaoTaiKhoan.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTaoTaiKhoan.ImageOptions.LargeImage")));
            this.btnTaoTaiKhoan.Name = "btnTaoTaiKhoan";
            this.btnTaoTaiKhoan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTaoTaiKhoan_ItemClick);
            // 
            // btnSVDangKy
            // 
            this.btnSVDangKy.Caption = "Đăng ký lớp tín chỉ";
            this.btnSVDangKy.Id = 18;
            this.btnSVDangKy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSVDangKy.ImageOptions.Image")));
            this.btnSVDangKy.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSVDangKy.ImageOptions.LargeImage")));
            this.btnSVDangKy.Name = "btnSVDangKy";
            this.btnSVDangKy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSVDangKy_ItemClick);
            // 
            // btnHocPhi
            // 
            this.btnHocPhi.Caption = "Học phí";
            this.btnHocPhi.Id = 19;
            this.btnHocPhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHocPhi.ImageOptions.Image")));
            this.btnHocPhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHocPhi.ImageOptions.LargeImage")));
            this.btnHocPhi.Name = "btnHocPhi";
            this.btnHocPhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHocPhi_ItemClick);
            // 
            // btnDSLTC
            // 
            this.btnDSLTC.Caption = "Danh sách lớp tín chỉ";
            this.btnDSLTC.Id = 20;
            this.btnDSLTC.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDSLTC.ImageOptions.Image")));
            this.btnDSLTC.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDSLTC.ImageOptions.LargeImage")));
            this.btnDSLTC.Name = "btnDSLTC";
            this.btnDSLTC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDSLTC_ItemClick);
            // 
            // btnDSSVDangKy
            // 
            this.btnDSSVDangKy.Caption = "Danh sách sinh viên đăng ký lớp tín chỉ";
            this.btnDSSVDangKy.Id = 21;
            this.btnDSSVDangKy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDSSVDangKy.ImageOptions.Image")));
            this.btnDSSVDangKy.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDSSVDangKy.ImageOptions.LargeImage")));
            this.btnDSSVDangKy.Name = "btnDSSVDangKy";
            this.btnDSSVDangKy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDSSVDangKy_ItemClick);
            // 
            // btnBDMonHoc
            // 
            this.btnBDMonHoc.Caption = "Bảng điểm môn học của 1 lớp tín chỉ";
            this.btnBDMonHoc.Id = 22;
            this.btnBDMonHoc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBDMonHoc.ImageOptions.Image")));
            this.btnBDMonHoc.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBDMonHoc.ImageOptions.LargeImage")));
            this.btnBDMonHoc.Name = "btnBDMonHoc";
            this.btnBDMonHoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBDMonHoc_ItemClick);
            // 
            // btnPhieuDiem
            // 
            this.btnPhieuDiem.Caption = "Phiếu Điểm";
            this.btnPhieuDiem.Id = 23;
            this.btnPhieuDiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhieuDiem.ImageOptions.Image")));
            this.btnPhieuDiem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhieuDiem.ImageOptions.LargeImage")));
            this.btnPhieuDiem.Name = "btnPhieuDiem";
            this.btnPhieuDiem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhieuDiem_ItemClick);
            // 
            // btnDSDongHocPhi
            // 
            this.btnDSDongHocPhi.Caption = "Danh sách đóng học phí của lớp";
            this.btnDSDongHocPhi.Id = 24;
            this.btnDSDongHocPhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDSDongHocPhi.ImageOptions.Image")));
            this.btnDSDongHocPhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDSDongHocPhi.ImageOptions.LargeImage")));
            this.btnDSDongHocPhi.Name = "btnDSDongHocPhi";
            this.btnDSDongHocPhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDSDongHocPhi_ItemClick);
            // 
            // btnBDTongKet
            // 
            this.btnBDTongKet.Caption = "Bảng điểm tổng kết";
            this.btnBDTongKet.Id = 25;
            this.btnBDTongKet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBDTongKet.ImageOptions.Image")));
            this.btnBDTongKet.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBDTongKet.ImageOptions.LargeImage")));
            this.btnBDTongKet.Name = "btnBDTongKet";
            this.btnBDTongKet.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBDTongKet_ItemClick);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Caption = "Đổi mật khẩu";
            this.btnChangePassword.Id = 28;
            this.btnChangePassword.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnChangePassword.ImageOptions.Image")));
            this.btnChangePassword.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnChangePassword.ImageOptions.LargeImage")));
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChangePassword_ItemClick);
            // 
            // rbpQuanLy
            // 
            this.rbpQuanLy.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
            this.rbpQuanLy.Name = "rbpQuanLy";
            this.rbpQuanLy.Text = "Quản trị";
            this.rbpQuanLy.Visible = false;
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnMonHoc);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnGiangVien);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Quản lý chung";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.AllowTextClipping = false;
            this.ribbonPageGroup3.ItemLinks.Add(this.btnLop);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnSinhVien);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Quản lý sinh viên";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnLopTinChi);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnDiem);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Quản lý lớp tín chỉ";
            // 
            // rbpSinhVien
            // 
            this.rbpSinhVien.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5});
            this.rbpSinhVien.Name = "rbpSinhVien";
            this.rbpSinhVien.Text = "Sinh viên";
            this.rbpSinhVien.Visible = false;
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.AllowTextClipping = false;
            this.ribbonPageGroup5.ItemLinks.Add(this.btnSVDangKy);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Đăng ký môn học";
            // 
            // rbpHocPhi
            // 
            this.rbpHocPhi.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup6});
            this.rbpHocPhi.Name = "rbpHocPhi";
            this.rbpHocPhi.Text = "Học phí";
            this.rbpHocPhi.Visible = false;
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.AllowTextClipping = false;
            this.ribbonPageGroup6.ItemLinks.Add(this.btnHocPhi);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "Đóng học phí";
            // 
            // rbpBaoCao
            // 
            this.rbpBaoCao.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgBaoCaoLop,
            this.rpgBaoCaoDiem,
            this.rpgBaoCaoHocPhi});
            this.rbpBaoCao.Name = "rbpBaoCao";
            this.rbpBaoCao.Text = "Báo cáo";
            this.rbpBaoCao.Visible = false;
            // 
            // rpgBaoCaoLop
            // 
            this.rpgBaoCaoLop.AllowTextClipping = false;
            this.rpgBaoCaoLop.ItemLinks.Add(this.btnDSLTC);
            this.rpgBaoCaoLop.ItemLinks.Add(this.btnDSSVDangKy);
            this.rpgBaoCaoLop.Name = "rpgBaoCaoLop";
            this.rpgBaoCaoLop.Text = "Báo cáo lớp";
            // 
            // rpgBaoCaoDiem
            // 
            this.rpgBaoCaoDiem.AllowTextClipping = false;
            this.rpgBaoCaoDiem.ItemLinks.Add(this.btnBDMonHoc);
            this.rpgBaoCaoDiem.ItemLinks.Add(this.btnPhieuDiem);
            this.rpgBaoCaoDiem.ItemLinks.Add(this.btnBDTongKet);
            this.rpgBaoCaoDiem.Name = "rpgBaoCaoDiem";
            this.rpgBaoCaoDiem.Text = "Báo cáo điểm";
            // 
            // rpgBaoCaoHocPhi
            // 
            this.rpgBaoCaoHocPhi.AllowTextClipping = false;
            this.rpgBaoCaoHocPhi.ItemLinks.Add(this.btnDSDongHocPhi);
            this.rpgBaoCaoHocPhi.Name = "rpgBaoCaoHocPhi";
            this.rpgBaoCaoHocPhi.Text = "Báo cáo học phí";
            // 
            // rbpCaiDat
            // 
            this.rbpCaiDat.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.rbpCaiDat.Name = "rbpCaiDat";
            this.rbpCaiDat.Text = "Cài đặt";
            this.rbpCaiDat.Visible = false;
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnTaoTaiKhoan);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnChangePassword);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDangXuat);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Tài khoản";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            this.xtraTabbedMdiManager1.UseFormIconAsPageImage = DevExpress.Utils.DefaultBoolean.True;
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblMAGV,
            this.lblHOTEN,
            this.lblNHOM});
            this.statusStrip.Location = new System.Drawing.Point(0, 528);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.statusStrip.Size = new System.Drawing.Size(960, 24);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip";
            // 
            // lblMAGV
            // 
            this.lblMAGV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblMAGV.Name = "lblMAGV";
            this.lblMAGV.Size = new System.Drawing.Size(41, 19);
            this.lblMAGV.Text = "MAGV";
            this.lblMAGV.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // lblHOTEN
            // 
            this.lblHOTEN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblHOTEN.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.lblHOTEN.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.lblHOTEN.Name = "lblHOTEN";
            this.lblHOTEN.Size = new System.Drawing.Size(49, 19);
            this.lblHOTEN.Text = "HOTEN";
            // 
            // lblNHOM
            // 
            this.lblNHOM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblNHOM.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.lblNHOM.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.lblNHOM.Name = "lblNHOM";
            this.lblNHOM.Size = new System.Drawing.Size(49, 19);
            this.lblNHOM.Text = "NHOM";
            // 
            // workspaceManager1
            // 
            this.workspaceManager1.TargetControl = this;
            this.workspaceManager1.TransitionType = pushTransition1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 552);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("frmMain.IconOptions.LargeImage")));
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Quản lý điểm sinh viên - Hệ tín chỉ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpCaiDat;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btnDangXuat;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem btnTaoTaiKhoan;
        private System.Windows.Forms.StatusStrip statusStrip;
        public System.Windows.Forms.ToolStripStatusLabel lblMAGV;
        public System.Windows.Forms.ToolStripStatusLabel lblHOTEN;
        public System.Windows.Forms.ToolStripStatusLabel lblNHOM;
        private DevExpress.XtraBars.BarButtonItem btnLop;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpQuanLy;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnSinhVien;
        private DevExpress.XtraBars.BarButtonItem btnMonHoc;
        private DevExpress.XtraBars.BarButtonItem btnGiangVien;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.Utils.WorkspaceManager workspaceManager1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btnLopTinChi;
        private DevExpress.XtraBars.BarButtonItem btnDiem;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpHocPhi;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpBaoCao;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgBaoCaoLop;
        private DevExpress.XtraBars.BarButtonItem btnSVDangKy;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpSinhVien;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem btnHocPhi;
        private DevExpress.XtraBars.BarButtonItem btnDSLTC;
        private DevExpress.XtraBars.BarButtonItem btnDSSVDangKy;
        private DevExpress.XtraBars.BarButtonItem btnBDMonHoc;
        private DevExpress.XtraBars.BarButtonItem btnPhieuDiem;
        private DevExpress.XtraBars.BarButtonItem btnDSDongHocPhi;
        private DevExpress.XtraBars.BarButtonItem btnBDTongKet;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgBaoCaoDiem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgBaoCaoHocPhi;
        private DevExpress.XtraBars.BarButtonItem btnChangePassword;
    }
}


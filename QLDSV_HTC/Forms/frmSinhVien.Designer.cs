
namespace QLDSV_HTC.Forms
{
    partial class frmSinhVien
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
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label dANGHIHOCLabel;
            System.Windows.Forms.Label nGAYSINHLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label pHAILabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label mASVLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSinhVien));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.btnRedo = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnResetPassword = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.bdsLop = new System.Windows.Forms.BindingSource(this.components);
            this.DS = new QLDSV_HTC.DS();
            this.bdsSinhVien = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTableAdapter = new QLDSV_HTC.DSTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new QLDSV_HTC.DSTableAdapters.TableAdapterManager();
            this.sINHVIENTableAdapter = new QLDSV_HTC.DSTableAdapters.SINHVIENTableAdapter();
            this.bdsDangKy = new System.Windows.Forms.BindingSource(this.components);
            this.dANGKYTableAdapter = new QLDSV_HTC.DSTableAdapters.DANGKYTableAdapter();
            this.nvgtLop = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.positionLop = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.gcSinhVien = new DevExpress.XtraGrid.GridControl();
            this.gvSinhVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMALOP1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDANGHIHOC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nvgtSinhVien = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.positionSinhVien = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.gcLop = new DevExpress.XtraGrid.GridControl();
            this.gvLop = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKHOAHOC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupSinhVien = new DevExpress.XtraEditors.GroupControl();
            this.txtMaLop = new DevExpress.XtraEditors.TextEdit();
            this.ckeDaNghiHoc = new DevExpress.XtraEditors.CheckEdit();
            this.dateNgaySinh = new DevExpress.XtraEditors.DateEdit();
            this.txtDiaChi = new DevExpress.XtraEditors.MemoEdit();
            this.ckePhai = new DevExpress.XtraEditors.CheckEdit();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.txtHo = new DevExpress.XtraEditors.TextEdit();
            this.txtMaSV = new DevExpress.XtraEditors.TextEdit();
            mALOPLabel = new System.Windows.Forms.Label();
            dANGHIHOCLabel = new System.Windows.Forms.Label();
            nGAYSINHLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            pHAILabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            mASVLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDangKy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nvgtLop)).BeginInit();
            this.nvgtLop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nvgtSinhVien)).BeginInit();
            this.nvgtSinhVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupSinhVien)).BeginInit();
            this.groupSinhVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckeDaNghiHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgaySinh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgaySinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckePhai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSV.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Location = new System.Drawing.Point(1106, 39);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(42, 13);
            mALOPLabel.TabIndex = 15;
            mALOPLabel.Text = "Mã lớp:";
            // 
            // dANGHIHOCLabel
            // 
            dANGHIHOCLabel.AutoSize = true;
            dANGHIHOCLabel.Location = new System.Drawing.Point(1079, 87);
            dANGHIHOCLabel.Name = "dANGHIHOCLabel";
            dANGHIHOCLabel.Size = new System.Drawing.Size(68, 13);
            dANGHIHOCLabel.TabIndex = 14;
            dANGHIHOCLabel.Text = "Đã nghỉ học:";
            // 
            // nGAYSINHLabel
            // 
            nGAYSINHLabel.AutoSize = true;
            nGAYSINHLabel.Location = new System.Drawing.Point(481, 80);
            nGAYSINHLabel.Name = "nGAYSINHLabel";
            nGAYSINHLabel.Size = new System.Drawing.Size(58, 13);
            nGAYSINHLabel.TabIndex = 10;
            nGAYSINHLabel.Text = "Ngày sinh:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(702, 40);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(43, 13);
            dIACHILabel.TabIndex = 8;
            dIACHILabel.Text = "Địa chỉ:";
            // 
            // pHAILabel
            // 
            pHAILabel.AutoSize = true;
            pHAILabel.Location = new System.Drawing.Point(508, 41);
            pHAILabel.Name = "pHAILabel";
            pHAILabel.Size = new System.Drawing.Size(31, 13);
            pHAILabel.TabIndex = 6;
            pHAILabel.Text = "Phái:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(274, 82);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(29, 13);
            tENLabel.TabIndex = 4;
            tENLabel.Text = "Tên:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(278, 39);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(24, 13);
            hOLabel.TabIndex = 2;
            hOLabel.Text = "Họ:";
            // 
            // mASVLabel
            // 
            mASVLabel.AutoSize = true;
            mASVLabel.Location = new System.Drawing.Point(31, 39);
            mASVLabel.Name = "mASVLabel";
            mASVLabel.Size = new System.Drawing.Size(70, 13);
            mASVLabel.TabIndex = 0;
            mASVLabel.Text = "Mã sinh viên:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnXoa,
            this.btnSua,
            this.btnUndo,
            this.btnGhi,
            this.btnHuy,
            this.btnReload,
            this.btnThoat,
            this.btnResetPassword,
            this.btnRedo});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 10;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(443, 140);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUndo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRedo),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHuy, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnResetPassword),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 1;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 2;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.LargeImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnUndo
            // 
            this.btnUndo.Caption = "Phục hồi";
            this.btnUndo.Id = 3;
            this.btnUndo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUndo.ImageOptions.Image")));
            this.btnUndo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUndo.ImageOptions.LargeImage")));
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUndo_ItemClick);
            // 
            // btnRedo
            // 
            this.btnRedo.Caption = "Làm mới";
            this.btnRedo.Id = 9;
            this.btnRedo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRedo.ImageOptions.Image")));
            this.btnRedo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRedo.ImageOptions.LargeImage")));
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnRedo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRedo_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Enabled = false;
            this.btnGhi.Id = 4;
            this.btnGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.Image")));
            this.btnGhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.LargeImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Enabled = false;
            this.btnHuy.Id = 5;
            this.btnHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.Image")));
            this.btnHuy.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.LargeImage")));
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuy_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Tải lại";
            this.btnReload.Id = 6;
            this.btnReload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.Image")));
            this.btnReload.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.LargeImage")));
            this.btnReload.Name = "btnReload";
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.Caption = "Đặt lại mật khẩu";
            this.btnResetPassword.Id = 8;
            this.btnResetPassword.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnResetPassword.ImageOptions.Image")));
            this.btnResetPassword.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnResetPassword.ImageOptions.LargeImage")));
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnResetPassword.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnResetPassword_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 7;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1281, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 655);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1281, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 631);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1281, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 631);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cmbKhoa);
            this.panelControl1.Controls.Add(this.lblKhoa);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 24);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1281, 58);
            this.panelControl1.TabIndex = 6;
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(427, 18);
            this.cmbKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(235, 21);
            this.cmbKhoa.TabIndex = 2;
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhoa.Location = new System.Drawing.Point(371, 20);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(50, 19);
            this.lblKhoa.TabIndex = 3;
            this.lblKhoa.Text = "Khoa:";
            // 
            // bdsLop
            // 
            this.bdsLop.DataMember = "LOP";
            this.bdsLop.DataSource = this.DS;
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsSinhVien
            // 
            this.bdsSinhVien.DataMember = "FK_SINHVIEN_LOP";
            this.bdsSinhVien.DataSource = this.bdsLop;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = this.lOPTableAdapter;
            this.tableAdapterManager.LOPTINCHITableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = this.sINHVIENTableAdapter;
            this.tableAdapterManager.SP_LOPTINCHITableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV_HTC.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // bdsDangKy
            // 
            this.bdsDangKy.DataMember = "FK_CTLTC_SINHVIEN";
            this.bdsDangKy.DataSource = this.bdsSinhVien;
            // 
            // dANGKYTableAdapter
            // 
            this.dANGKYTableAdapter.ClearBeforeFill = true;
            // 
            // nvgtLop
            // 
            this.nvgtLop.AddNewItem = null;
            this.nvgtLop.BindingSource = this.bdsLop;
            this.nvgtLop.CountItem = this.bindingNavigatorCountItem1;
            this.nvgtLop.DeleteItem = null;
            this.nvgtLop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.positionLop,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5});
            this.nvgtLop.Location = new System.Drawing.Point(0, 82);
            this.nvgtLop.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.nvgtLop.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.nvgtLop.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.nvgtLop.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.nvgtLop.Name = "nvgtLop";
            this.nvgtLop.PositionItem = this.positionLop;
            this.nvgtLop.Size = new System.Drawing.Size(1281, 25);
            this.nvgtLop.TabIndex = 38;
            this.nvgtLop.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem1.Text = "of {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem1.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem1.Text = "Move previous";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // positionLop
            // 
            this.positionLop.AccessibleName = "Position";
            this.positionLop.AutoSize = false;
            this.positionLop.Name = "positionLop";
            this.positionLop.Size = new System.Drawing.Size(50, 23);
            this.positionLop.Text = "0";
            this.positionLop.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem1.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem1.Text = "Move last";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // gcSinhVien
            // 
            this.gcSinhVien.DataSource = this.bdsSinhVien;
            this.gcSinhVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcSinhVien.Location = new System.Drawing.Point(0, 329);
            this.gcSinhVien.MainView = this.gvSinhVien;
            this.gcSinhVien.MenuManager = this.barManager1;
            this.gcSinhVien.Name = "gcSinhVien";
            this.gcSinhVien.Size = new System.Drawing.Size(1281, 212);
            this.gcSinhVien.TabIndex = 41;
            this.gcSinhVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSinhVien});
            // 
            // gvSinhVien
            // 
            this.gvSinhVien.Appearance.ViewCaption.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.gvSinhVien.Appearance.ViewCaption.Options.UseFont = true;
            this.gvSinhVien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASV,
            this.colHO,
            this.colTEN,
            this.colPHAI,
            this.colDIACHI,
            this.colNGAYSINH,
            this.colMALOP1,
            this.colDANGHIHOC});
            this.gvSinhVien.GridControl = this.gcSinhVien;
            this.gvSinhVien.Name = "gvSinhVien";
            this.gvSinhVien.OptionsBehavior.Editable = false;
            this.gvSinhVien.OptionsView.ShowViewCaption = true;
            this.gvSinhVien.ViewCaption = "DANH SÁCH SINH VIÊN";
            // 
            // colMASV
            // 
            this.colMASV.AppearanceCell.Options.UseTextOptions = true;
            this.colMASV.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMASV.AppearanceHeader.BackColor = System.Drawing.Color.LawnGreen;
            this.colMASV.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colMASV.AppearanceHeader.Options.UseBackColor = true;
            this.colMASV.AppearanceHeader.Options.UseFont = true;
            this.colMASV.AppearanceHeader.Options.UseTextOptions = true;
            this.colMASV.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMASV.Caption = "Mã sinh viên";
            this.colMASV.FieldName = "MASV";
            this.colMASV.Name = "colMASV";
            this.colMASV.Visible = true;
            this.colMASV.VisibleIndex = 0;
            this.colMASV.Width = 148;
            // 
            // colHO
            // 
            this.colHO.AppearanceHeader.BackColor = System.Drawing.Color.LawnGreen;
            this.colHO.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colHO.AppearanceHeader.Options.UseBackColor = true;
            this.colHO.AppearanceHeader.Options.UseFont = true;
            this.colHO.AppearanceHeader.Options.UseTextOptions = true;
            this.colHO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHO.Caption = "Họ";
            this.colHO.FieldName = "HO";
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            this.colHO.Width = 187;
            // 
            // colTEN
            // 
            this.colTEN.AppearanceHeader.BackColor = System.Drawing.Color.LawnGreen;
            this.colTEN.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colTEN.AppearanceHeader.Options.UseBackColor = true;
            this.colTEN.AppearanceHeader.Options.UseFont = true;
            this.colTEN.AppearanceHeader.Options.UseTextOptions = true;
            this.colTEN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTEN.Caption = "Tên";
            this.colTEN.FieldName = "TEN";
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            this.colTEN.Width = 108;
            // 
            // colPHAI
            // 
            this.colPHAI.AppearanceHeader.BackColor = System.Drawing.Color.LawnGreen;
            this.colPHAI.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colPHAI.AppearanceHeader.Options.UseBackColor = true;
            this.colPHAI.AppearanceHeader.Options.UseFont = true;
            this.colPHAI.AppearanceHeader.Options.UseTextOptions = true;
            this.colPHAI.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPHAI.Caption = "Phái (Nữ)";
            this.colPHAI.FieldName = "PHAI";
            this.colPHAI.Name = "colPHAI";
            this.colPHAI.Visible = true;
            this.colPHAI.VisibleIndex = 3;
            this.colPHAI.Width = 79;
            // 
            // colDIACHI
            // 
            this.colDIACHI.AppearanceHeader.BackColor = System.Drawing.Color.LawnGreen;
            this.colDIACHI.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colDIACHI.AppearanceHeader.Options.UseBackColor = true;
            this.colDIACHI.AppearanceHeader.Options.UseFont = true;
            this.colDIACHI.AppearanceHeader.Options.UseTextOptions = true;
            this.colDIACHI.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDIACHI.Caption = "Địa chỉ";
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 4;
            this.colDIACHI.Width = 311;
            // 
            // colNGAYSINH
            // 
            this.colNGAYSINH.AppearanceCell.Options.UseTextOptions = true;
            this.colNGAYSINH.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNGAYSINH.AppearanceHeader.BackColor = System.Drawing.Color.LawnGreen;
            this.colNGAYSINH.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colNGAYSINH.AppearanceHeader.Options.UseBackColor = true;
            this.colNGAYSINH.AppearanceHeader.Options.UseFont = true;
            this.colNGAYSINH.AppearanceHeader.Options.UseTextOptions = true;
            this.colNGAYSINH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNGAYSINH.Caption = "Ngày sinh";
            this.colNGAYSINH.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colNGAYSINH.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNGAYSINH.FieldName = "NGAYSINH";
            this.colNGAYSINH.Name = "colNGAYSINH";
            this.colNGAYSINH.Visible = true;
            this.colNGAYSINH.VisibleIndex = 5;
            this.colNGAYSINH.Width = 135;
            // 
            // colMALOP1
            // 
            this.colMALOP1.AppearanceCell.Options.UseTextOptions = true;
            this.colMALOP1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMALOP1.AppearanceHeader.BackColor = System.Drawing.Color.LawnGreen;
            this.colMALOP1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colMALOP1.AppearanceHeader.Options.UseBackColor = true;
            this.colMALOP1.AppearanceHeader.Options.UseFont = true;
            this.colMALOP1.AppearanceHeader.Options.UseTextOptions = true;
            this.colMALOP1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMALOP1.Caption = "Mã lớp";
            this.colMALOP1.FieldName = "MALOP";
            this.colMALOP1.Name = "colMALOP1";
            this.colMALOP1.Visible = true;
            this.colMALOP1.VisibleIndex = 6;
            this.colMALOP1.Width = 121;
            // 
            // colDANGHIHOC
            // 
            this.colDANGHIHOC.AppearanceHeader.BackColor = System.Drawing.Color.LawnGreen;
            this.colDANGHIHOC.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colDANGHIHOC.AppearanceHeader.Options.UseBackColor = true;
            this.colDANGHIHOC.AppearanceHeader.Options.UseFont = true;
            this.colDANGHIHOC.AppearanceHeader.Options.UseTextOptions = true;
            this.colDANGHIHOC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDANGHIHOC.Caption = "Đã nghỉ học";
            this.colDANGHIHOC.FieldName = "DANGHIHOC";
            this.colDANGHIHOC.Name = "colDANGHIHOC";
            this.colDANGHIHOC.Visible = true;
            this.colDANGHIHOC.VisibleIndex = 7;
            this.colDANGHIHOC.Width = 107;
            // 
            // nvgtSinhVien
            // 
            this.nvgtSinhVien.AddNewItem = null;
            this.nvgtSinhVien.BindingSource = this.bdsSinhVien;
            this.nvgtSinhVien.CountItem = this.bindingNavigatorCountItem;
            this.nvgtSinhVien.DeleteItem = null;
            this.nvgtSinhVien.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.nvgtSinhVien.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.positionSinhVien,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.nvgtSinhVien.Location = new System.Drawing.Point(0, 302);
            this.nvgtSinhVien.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.nvgtSinhVien.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.nvgtSinhVien.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.nvgtSinhVien.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.nvgtSinhVien.Name = "nvgtSinhVien";
            this.nvgtSinhVien.PositionItem = this.positionSinhVien;
            this.nvgtSinhVien.Size = new System.Drawing.Size(1281, 27);
            this.nvgtSinhVien.TabIndex = 40;
            this.nvgtSinhVien.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // positionSinhVien
            // 
            this.positionSinhVien.AccessibleName = "Position";
            this.positionSinhVien.AutoSize = false;
            this.positionSinhVien.Name = "positionSinhVien";
            this.positionSinhVien.Size = new System.Drawing.Size(50, 23);
            this.positionSinhVien.Text = "0";
            this.positionSinhVien.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // gcLop
            // 
            this.gcLop.DataSource = this.bdsLop;
            this.gcLop.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcLop.Location = new System.Drawing.Point(0, 107);
            this.gcLop.MainView = this.gvLop;
            this.gcLop.MenuManager = this.barManager1;
            this.gcLop.Name = "gcLop";
            this.gcLop.Size = new System.Drawing.Size(1281, 195);
            this.gcLop.TabIndex = 39;
            this.gcLop.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLop});
            // 
            // gvLop
            // 
            this.gvLop.Appearance.ViewCaption.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvLop.Appearance.ViewCaption.Options.UseFont = true;
            this.gvLop.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALOP,
            this.colTENLOP,
            this.colKHOAHOC,
            this.colMAKHOA});
            this.gvLop.GridControl = this.gcLop;
            this.gvLop.Name = "gvLop";
            this.gvLop.OptionsBehavior.Editable = false;
            this.gvLop.OptionsView.ShowViewCaption = true;
            this.gvLop.ViewCaption = "DANH SÁCH LỚP";
            this.gvLop.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvLop_FocusedRowChanged);
            // 
            // colMALOP
            // 
            this.colMALOP.AppearanceCell.Options.UseTextOptions = true;
            this.colMALOP.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMALOP.AppearanceHeader.BackColor = System.Drawing.Color.Lime;
            this.colMALOP.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMALOP.AppearanceHeader.Options.UseBackColor = true;
            this.colMALOP.AppearanceHeader.Options.UseFont = true;
            this.colMALOP.AppearanceHeader.Options.UseTextOptions = true;
            this.colMALOP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMALOP.Caption = "Mã lớp";
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 0;
            // 
            // colTENLOP
            // 
            this.colTENLOP.AppearanceHeader.BackColor = System.Drawing.Color.Lime;
            this.colTENLOP.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTENLOP.AppearanceHeader.Options.UseBackColor = true;
            this.colTENLOP.AppearanceHeader.Options.UseFont = true;
            this.colTENLOP.AppearanceHeader.Options.UseTextOptions = true;
            this.colTENLOP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTENLOP.Caption = "Tên lớp";
            this.colTENLOP.FieldName = "TENLOP";
            this.colTENLOP.Name = "colTENLOP";
            this.colTENLOP.Visible = true;
            this.colTENLOP.VisibleIndex = 1;
            // 
            // colKHOAHOC
            // 
            this.colKHOAHOC.AppearanceCell.Options.UseTextOptions = true;
            this.colKHOAHOC.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKHOAHOC.AppearanceHeader.BackColor = System.Drawing.Color.Lime;
            this.colKHOAHOC.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colKHOAHOC.AppearanceHeader.Options.UseBackColor = true;
            this.colKHOAHOC.AppearanceHeader.Options.UseFont = true;
            this.colKHOAHOC.AppearanceHeader.Options.UseTextOptions = true;
            this.colKHOAHOC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKHOAHOC.Caption = "Khóa học";
            this.colKHOAHOC.FieldName = "KHOAHOC";
            this.colKHOAHOC.Name = "colKHOAHOC";
            this.colKHOAHOC.Visible = true;
            this.colKHOAHOC.VisibleIndex = 2;
            // 
            // colMAKHOA
            // 
            this.colMAKHOA.AppearanceCell.Options.UseTextOptions = true;
            this.colMAKHOA.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMAKHOA.AppearanceHeader.BackColor = System.Drawing.Color.Lime;
            this.colMAKHOA.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMAKHOA.AppearanceHeader.Options.UseBackColor = true;
            this.colMAKHOA.AppearanceHeader.Options.UseFont = true;
            this.colMAKHOA.AppearanceHeader.Options.UseTextOptions = true;
            this.colMAKHOA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMAKHOA.Caption = "Mã khoa";
            this.colMAKHOA.FieldName = "MAKHOA";
            this.colMAKHOA.Name = "colMAKHOA";
            this.colMAKHOA.Visible = true;
            this.colMAKHOA.VisibleIndex = 3;
            // 
            // groupSinhVien
            // 
            this.groupSinhVien.Controls.Add(mALOPLabel);
            this.groupSinhVien.Controls.Add(this.txtMaLop);
            this.groupSinhVien.Controls.Add(dANGHIHOCLabel);
            this.groupSinhVien.Controls.Add(this.ckeDaNghiHoc);
            this.groupSinhVien.Controls.Add(nGAYSINHLabel);
            this.groupSinhVien.Controls.Add(this.dateNgaySinh);
            this.groupSinhVien.Controls.Add(dIACHILabel);
            this.groupSinhVien.Controls.Add(this.txtDiaChi);
            this.groupSinhVien.Controls.Add(pHAILabel);
            this.groupSinhVien.Controls.Add(this.ckePhai);
            this.groupSinhVien.Controls.Add(tENLabel);
            this.groupSinhVien.Controls.Add(this.txtTen);
            this.groupSinhVien.Controls.Add(hOLabel);
            this.groupSinhVien.Controls.Add(this.txtHo);
            this.groupSinhVien.Controls.Add(mASVLabel);
            this.groupSinhVien.Controls.Add(this.txtMaSV);
            this.groupSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupSinhVien.Enabled = false;
            this.groupSinhVien.Location = new System.Drawing.Point(0, 541);
            this.groupSinhVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupSinhVien.Name = "groupSinhVien";
            this.groupSinhVien.Size = new System.Drawing.Size(1281, 114);
            this.groupSinhVien.TabIndex = 42;
            this.groupSinhVien.Text = "Thông tin sinh viên";
            // 
            // txtMaLop
            // 
            this.txtMaLop.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSinhVien, "MALOP", true));
            this.txtMaLop.Location = new System.Drawing.Point(1157, 36);
            this.txtMaLop.MenuManager = this.barManager1;
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Properties.ReadOnly = true;
            this.txtMaLop.Size = new System.Drawing.Size(100, 20);
            this.txtMaLop.TabIndex = 16;
            // 
            // ckeDaNghiHoc
            // 
            this.ckeDaNghiHoc.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSinhVien, "DANGHIHOC", true));
            this.ckeDaNghiHoc.Location = new System.Drawing.Point(1157, 84);
            this.ckeDaNghiHoc.MenuManager = this.barManager1;
            this.ckeDaNghiHoc.Name = "ckeDaNghiHoc";
            this.ckeDaNghiHoc.Properties.Caption = "";
            this.ckeDaNghiHoc.Size = new System.Drawing.Size(75, 20);
            this.ckeDaNghiHoc.TabIndex = 15;
            // 
            // dateNgaySinh
            // 
            this.dateNgaySinh.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSinhVien, "NGAYSINH", true));
            this.dateNgaySinh.EditValue = null;
            this.dateNgaySinh.Location = new System.Drawing.Point(549, 77);
            this.dateNgaySinh.MenuManager = this.barManager1;
            this.dateNgaySinh.Name = "dateNgaySinh";
            this.dateNgaySinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgaySinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgaySinh.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateNgaySinh.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateNgaySinh.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dateNgaySinh.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateNgaySinh.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateNgaySinh.Size = new System.Drawing.Size(120, 20);
            this.dateNgaySinh.TabIndex = 11;
            this.dateNgaySinh.Enter += new System.EventHandler(this.dateNgaySinh_Enter);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSinhVien, "DIACHI", true));
            this.txtDiaChi.Location = new System.Drawing.Point(755, 37);
            this.txtDiaChi.MenuManager = this.barManager1;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(293, 66);
            this.txtDiaChi.TabIndex = 9;
            // 
            // ckePhai
            // 
            this.ckePhai.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSinhVien, "PHAI", true));
            this.ckePhai.Location = new System.Drawing.Point(549, 38);
            this.ckePhai.MenuManager = this.barManager1;
            this.ckePhai.Name = "ckePhai";
            this.ckePhai.Properties.Caption = "Nữ";
            this.ckePhai.Size = new System.Drawing.Size(75, 20);
            this.ckePhai.TabIndex = 7;
            // 
            // txtTen
            // 
            this.txtTen.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSinhVien, "TEN", true));
            this.txtTen.Location = new System.Drawing.Point(310, 79);
            this.txtTen.MenuManager = this.barManager1;
            this.txtTen.Name = "txtTen";
            this.txtTen.Properties.MaxLength = 10;
            this.txtTen.Size = new System.Drawing.Size(134, 20);
            this.txtTen.TabIndex = 5;
            // 
            // txtHo
            // 
            this.txtHo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSinhVien, "HO", true));
            this.txtHo.Location = new System.Drawing.Point(310, 36);
            this.txtHo.MenuManager = this.barManager1;
            this.txtHo.Name = "txtHo";
            this.txtHo.Properties.MaxLength = 50;
            this.txtHo.Size = new System.Drawing.Size(134, 20);
            this.txtHo.TabIndex = 3;
            // 
            // txtMaSV
            // 
            this.txtMaSV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSinhVien, "MASV", true));
            this.txtMaSV.Location = new System.Drawing.Point(107, 34);
            this.txtMaSV.MenuManager = this.barManager1;
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Properties.MaxLength = 10;
            this.txtMaSV.Size = new System.Drawing.Size(134, 20);
            this.txtMaSV.TabIndex = 1;
            // 
            // frmSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1281, 655);
            this.Controls.Add(this.groupSinhVien);
            this.Controls.Add(this.gcSinhVien);
            this.Controls.Add(this.nvgtSinhVien);
            this.Controls.Add(this.gcLop);
            this.Controls.Add(this.nvgtLop);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frmSinhVien.IconOptions.Image")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmSinhVien";
            this.Text = "Sinh viên";
            this.Load += new System.EventHandler(this.frmSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDangKy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nvgtLop)).EndInit();
            this.nvgtLop.ResumeLayout(false);
            this.nvgtLop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nvgtSinhVien)).EndInit();
            this.nvgtSinhVien.ResumeLayout(false);
            this.nvgtSinhVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupSinhVien)).EndInit();
            this.groupSinhVien.ResumeLayout(false);
            this.groupSinhVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckeDaNghiHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgaySinh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgaySinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckePhai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSV.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.Label lblKhoa;
        private DS DS;
        private System.Windows.Forms.BindingSource bdsLop;
        private DSTableAdapters.LOPTableAdapter lOPTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DSTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private System.Windows.Forms.BindingSource bdsSinhVien;
        private System.Windows.Forms.BindingSource bdsDangKy;
        private DSTableAdapters.DANGKYTableAdapter dANGKYTableAdapter;
        private System.Windows.Forms.BindingNavigator nvgtLop;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox positionLop;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private DevExpress.XtraEditors.GroupControl groupSinhVien;
        private DevExpress.XtraEditors.TextEdit txtMaLop;
        private DevExpress.XtraEditors.CheckEdit ckeDaNghiHoc;
        private DevExpress.XtraEditors.DateEdit dateNgaySinh;
        private DevExpress.XtraEditors.MemoEdit txtDiaChi;
        private DevExpress.XtraEditors.CheckEdit ckePhai;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.TextEdit txtHo;
        private DevExpress.XtraEditors.TextEdit txtMaSV;
        private DevExpress.XtraGrid.GridControl gcSinhVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSinhVien;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP1;
        private DevExpress.XtraGrid.Columns.GridColumn colDANGHIHOC;
        private System.Windows.Forms.BindingNavigator nvgtSinhVien;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox positionSinhVien;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private DevExpress.XtraGrid.GridControl gcLop;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLop;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLOP;
        private DevExpress.XtraGrid.Columns.GridColumn colKHOAHOC;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHOA;
        private DevExpress.XtraBars.BarButtonItem btnResetPassword;
        private DevExpress.XtraBars.BarButtonItem btnRedo;
    }
}
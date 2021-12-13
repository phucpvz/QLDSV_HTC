
namespace QLDSV_HTC.Forms
{
    partial class frmLopTinChi
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
            System.Windows.Forms.Label mAKHOALabel;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label nHOMLabel;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label sOSVTOITHIEULabel;
            System.Windows.Forms.Label hUYLOPLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLopTinChi));
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
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cmbHK = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbNK = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.dS = new QLDSV_HTC.DS();
            this.tableAdapterManager = new QLDSV_HTC.DSTableAdapters.TableAdapterManager();
            this.nvgtLTC = new System.Windows.Forms.BindingNavigator(this.components);
            this.bdsLTC = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sP_LOPTINCHITableAdapter = new QLDSV_HTC.DSTableAdapters.SP_LOPTINCHITableAdapter();
            this.gcLTC = new DevExpress.XtraGrid.GridControl();
            this.gvLTC = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALTC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNHOM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTENGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOSVTOITHIEU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOSVDADANGKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHUYLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupLTC = new DevExpress.XtraEditors.GroupControl();
            this.ckeHuyLop = new DevExpress.XtraEditors.CheckEdit();
            this.spinSoSVToiThieu = new DevExpress.XtraEditors.SpinEdit();
            this.spinNhom = new DevExpress.XtraEditors.SpinEdit();
            this.lkupMH = new DevExpress.XtraEditors.LookUpEdit();
            this.bdsMonHoc = new System.Windows.Forms.BindingSource(this.components);
            this.txtMaKhoa = new DevExpress.XtraEditors.TextEdit();
            this.lkupGV = new DevExpress.XtraEditors.LookUpEdit();
            this.bdsGiangVien = new System.Windows.Forms.BindingSource(this.components);
            this.mONHOCTableAdapter = new QLDSV_HTC.DSTableAdapters.MONHOCTableAdapter();
            this.gIANGVIENTableAdapter = new QLDSV_HTC.DSTableAdapters.GIANGVIENTableAdapter();
            mAKHOALabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            nHOMLabel = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            sOSVTOITHIEULabel = new System.Windows.Forms.Label();
            hUYLOPLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nvgtLTC)).BeginInit();
            this.nvgtLTC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupLTC)).BeginInit();
            this.groupLTC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ckeHuyLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSoSVToiThieu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinNhom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkupMH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkupGV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGiangVien)).BeginInit();
            this.SuspendLayout();
            // 
            // mAKHOALabel
            // 
            mAKHOALabel.AutoSize = true;
            mAKHOALabel.Location = new System.Drawing.Point(773, 49);
            mAKHOALabel.Name = "mAKHOALabel";
            mAKHOALabel.Size = new System.Drawing.Size(51, 13);
            mAKHOALabel.TabIndex = 0;
            mAKHOALabel.Text = "Mã khoa:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(50, 49);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(51, 13);
            label3.TabIndex = 42;
            label3.Text = "Môn học:";
            // 
            // nHOMLabel
            // 
            nHOMLabel.AutoSize = true;
            nHOMLabel.Location = new System.Drawing.Point(63, 98);
            nHOMLabel.Name = "nHOMLabel";
            nHOMLabel.Size = new System.Drawing.Size(38, 13);
            nHOMLabel.TabIndex = 42;
            nHOMLabel.Text = "Nhóm:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(421, 49);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(61, 13);
            label4.TabIndex = 45;
            label4.Text = "Giảng viên:";
            // 
            // sOSVTOITHIEULabel
            // 
            sOSVTOITHIEULabel.AutoSize = true;
            sOSVTOITHIEULabel.Location = new System.Drawing.Point(372, 98);
            sOSVTOITHIEULabel.Name = "sOSVTOITHIEULabel";
            sOSVTOITHIEULabel.Size = new System.Drawing.Size(110, 13);
            sOSVTOITHIEULabel.TabIndex = 45;
            sOSVTOITHIEULabel.Text = "Số sinh viên tối thiểu:";
            // 
            // hUYLOPLabel
            // 
            hUYLOPLabel.AutoSize = true;
            hUYLOPLabel.Location = new System.Drawing.Point(777, 98);
            hUYLOPLabel.Name = "hUYLOPLabel";
            hUYLOPLabel.Size = new System.Drawing.Size(47, 13);
            hUYLOPLabel.TabIndex = 46;
            hUYLOPLabel.Text = "Hủy lớp:";
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
            this.btnRedo});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 9;
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
            this.btnRedo.Caption = "Làm lại";
            this.btnRedo.Id = 8;
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
            this.barDockControlTop.Size = new System.Drawing.Size(990, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 550);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(990, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 526);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(990, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 526);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cmbHK);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.cmbNK);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.cmbKhoa);
            this.panelControl1.Controls.Add(this.lblKhoa);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 24);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(990, 50);
            this.panelControl1.TabIndex = 6;
            // 
            // cmbHK
            // 
            this.cmbHK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHK.FormattingEnabled = true;
            this.cmbHK.Location = new System.Drawing.Point(731, 13);
            this.cmbHK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbHK.Name = "cmbHK";
            this.cmbHK.Size = new System.Drawing.Size(65, 21);
            this.cmbHK.TabIndex = 10;
            this.cmbHK.SelectedIndexChanged += new System.EventHandler(this.cmbHK_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(663, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Học kỳ:";
            // 
            // cmbNK
            // 
            this.cmbNK.FormattingEnabled = true;
            this.cmbNK.Location = new System.Drawing.Point(479, 16);
            this.cmbNK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbNK.Name = "cmbNK";
            this.cmbNK.Size = new System.Drawing.Size(157, 21);
            this.cmbNK.TabIndex = 8;
            this.cmbNK.SelectedIndexChanged += new System.EventHandler(this.cmbNK_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(390, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Niên khóa:";
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(97, 16);
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
            this.lblKhoa.Location = new System.Drawing.Point(41, 16);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(50, 19);
            this.lblKhoa.TabIndex = 3;
            this.lblKhoa.Text = "Khoa:";
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.LOPTINCHITableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.SP_LOPTINCHITableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV_HTC.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nvgtLTC
            // 
            this.nvgtLTC.AddNewItem = null;
            this.nvgtLTC.BindingSource = this.bdsLTC;
            this.nvgtLTC.CountItem = this.bindingNavigatorCountItem;
            this.nvgtLTC.DeleteItem = null;
            this.nvgtLTC.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.nvgtLTC.Location = new System.Drawing.Point(0, 74);
            this.nvgtLTC.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.nvgtLTC.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.nvgtLTC.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.nvgtLTC.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.nvgtLTC.Name = "nvgtLTC";
            this.nvgtLTC.PositionItem = this.bindingNavigatorPositionItem;
            this.nvgtLTC.Size = new System.Drawing.Size(990, 25);
            this.nvgtLTC.TabIndex = 7;
            this.nvgtLTC.Text = "bindingNavigator1";
            // 
            // bdsLTC
            // 
            this.bdsLTC.DataMember = "SP_LOPTINCHI";
            this.bdsLTC.DataSource = this.dS;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // sP_LOPTINCHITableAdapter
            // 
            this.sP_LOPTINCHITableAdapter.ClearBeforeFill = true;
            // 
            // gcLTC
            // 
            this.gcLTC.DataSource = this.bdsLTC;
            this.gcLTC.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcLTC.Location = new System.Drawing.Point(0, 99);
            this.gcLTC.MainView = this.gvLTC;
            this.gcLTC.MenuManager = this.barManager1;
            this.gcLTC.Name = "gcLTC";
            this.gcLTC.Size = new System.Drawing.Size(990, 233);
            this.gcLTC.TabIndex = 37;
            this.gcLTC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLTC});
            // 
            // gvLTC
            // 
            this.gvLTC.Appearance.ViewCaption.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.gvLTC.Appearance.ViewCaption.Options.UseFont = true;
            this.gvLTC.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALTC,
            this.colTENMH,
            this.colNHOM,
            this.colHOTENGV,
            this.colMAKHOA,
            this.colSOSVTOITHIEU,
            this.colSOSVDADANGKY,
            this.colHUYLOP});
            this.gvLTC.GridControl = this.gcLTC;
            this.gvLTC.Name = "gvLTC";
            this.gvLTC.OptionsBehavior.Editable = false;
            this.gvLTC.OptionsView.ShowViewCaption = true;
            this.gvLTC.ViewCaption = "DANH SÁCH LỚP TÍN CHỈ";
            // 
            // colMALTC
            // 
            this.colMALTC.AppearanceCell.Options.UseTextOptions = true;
            this.colMALTC.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMALTC.AppearanceHeader.BackColor = System.Drawing.Color.Yellow;
            this.colMALTC.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colMALTC.AppearanceHeader.Options.UseBackColor = true;
            this.colMALTC.AppearanceHeader.Options.UseFont = true;
            this.colMALTC.AppearanceHeader.Options.UseTextOptions = true;
            this.colMALTC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMALTC.Caption = "Mã lớp tín chỉ";
            this.colMALTC.FieldName = "MALTC";
            this.colMALTC.Name = "colMALTC";
            this.colMALTC.Visible = true;
            this.colMALTC.VisibleIndex = 0;
            this.colMALTC.Width = 89;
            // 
            // colTENMH
            // 
            this.colTENMH.AppearanceHeader.BackColor = System.Drawing.Color.Yellow;
            this.colTENMH.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colTENMH.AppearanceHeader.Options.UseBackColor = true;
            this.colTENMH.AppearanceHeader.Options.UseFont = true;
            this.colTENMH.AppearanceHeader.Options.UseTextOptions = true;
            this.colTENMH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTENMH.Caption = "Tên môn học";
            this.colTENMH.FieldName = "TENMH";
            this.colTENMH.Name = "colTENMH";
            this.colTENMH.Visible = true;
            this.colTENMH.VisibleIndex = 1;
            this.colTENMH.Width = 173;
            // 
            // colNHOM
            // 
            this.colNHOM.AppearanceCell.Options.UseTextOptions = true;
            this.colNHOM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNHOM.AppearanceHeader.BackColor = System.Drawing.Color.Yellow;
            this.colNHOM.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colNHOM.AppearanceHeader.Options.UseBackColor = true;
            this.colNHOM.AppearanceHeader.Options.UseFont = true;
            this.colNHOM.AppearanceHeader.Options.UseTextOptions = true;
            this.colNHOM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNHOM.Caption = "Nhóm";
            this.colNHOM.FieldName = "NHOM";
            this.colNHOM.Name = "colNHOM";
            this.colNHOM.Visible = true;
            this.colNHOM.VisibleIndex = 2;
            this.colNHOM.Width = 53;
            // 
            // colHOTENGV
            // 
            this.colHOTENGV.AppearanceHeader.BackColor = System.Drawing.Color.Yellow;
            this.colHOTENGV.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colHOTENGV.AppearanceHeader.Options.UseBackColor = true;
            this.colHOTENGV.AppearanceHeader.Options.UseFont = true;
            this.colHOTENGV.AppearanceHeader.Options.UseTextOptions = true;
            this.colHOTENGV.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHOTENGV.Caption = "Họ tên giảng viên giảng";
            this.colHOTENGV.FieldName = "HOTENGV";
            this.colHOTENGV.Name = "colHOTENGV";
            this.colHOTENGV.Visible = true;
            this.colHOTENGV.VisibleIndex = 3;
            this.colHOTENGV.Width = 172;
            // 
            // colMAKHOA
            // 
            this.colMAKHOA.AppearanceCell.Options.UseTextOptions = true;
            this.colMAKHOA.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMAKHOA.AppearanceHeader.BackColor = System.Drawing.Color.Yellow;
            this.colMAKHOA.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colMAKHOA.AppearanceHeader.Options.UseBackColor = true;
            this.colMAKHOA.AppearanceHeader.Options.UseFont = true;
            this.colMAKHOA.AppearanceHeader.Options.UseTextOptions = true;
            this.colMAKHOA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMAKHOA.Caption = "Mã khoa";
            this.colMAKHOA.FieldName = "MAKHOA";
            this.colMAKHOA.Name = "colMAKHOA";
            this.colMAKHOA.Visible = true;
            this.colMAKHOA.VisibleIndex = 4;
            this.colMAKHOA.Width = 73;
            // 
            // colSOSVTOITHIEU
            // 
            this.colSOSVTOITHIEU.AppearanceCell.Options.UseTextOptions = true;
            this.colSOSVTOITHIEU.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSOSVTOITHIEU.AppearanceHeader.BackColor = System.Drawing.Color.Yellow;
            this.colSOSVTOITHIEU.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colSOSVTOITHIEU.AppearanceHeader.Options.UseBackColor = true;
            this.colSOSVTOITHIEU.AppearanceHeader.Options.UseFont = true;
            this.colSOSVTOITHIEU.AppearanceHeader.Options.UseTextOptions = true;
            this.colSOSVTOITHIEU.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSOSVTOITHIEU.Caption = "Số sinh viên tối thiểu";
            this.colSOSVTOITHIEU.FieldName = "SOSVTOITHIEU";
            this.colSOSVTOITHIEU.Name = "colSOSVTOITHIEU";
            this.colSOSVTOITHIEU.Visible = true;
            this.colSOSVTOITHIEU.VisibleIndex = 5;
            this.colSOSVTOITHIEU.Width = 152;
            // 
            // colSOSVDADANGKY
            // 
            this.colSOSVDADANGKY.AppearanceCell.Options.UseTextOptions = true;
            this.colSOSVDADANGKY.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSOSVDADANGKY.AppearanceHeader.BackColor = System.Drawing.Color.Yellow;
            this.colSOSVDADANGKY.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colSOSVDADANGKY.AppearanceHeader.Options.UseBackColor = true;
            this.colSOSVDADANGKY.AppearanceHeader.Options.UseFont = true;
            this.colSOSVDADANGKY.AppearanceHeader.Options.UseTextOptions = true;
            this.colSOSVDADANGKY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSOSVDADANGKY.Caption = "Số sinh viên đã đăng ký";
            this.colSOSVDADANGKY.FieldName = "SOSVDADANGKY";
            this.colSOSVDADANGKY.Name = "colSOSVDADANGKY";
            this.colSOSVDADANGKY.Visible = true;
            this.colSOSVDADANGKY.VisibleIndex = 6;
            this.colSOSVDADANGKY.Width = 174;
            // 
            // colHUYLOP
            // 
            this.colHUYLOP.AppearanceHeader.BackColor = System.Drawing.Color.Yellow;
            this.colHUYLOP.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colHUYLOP.AppearanceHeader.Options.UseBackColor = true;
            this.colHUYLOP.AppearanceHeader.Options.UseFont = true;
            this.colHUYLOP.AppearanceHeader.Options.UseTextOptions = true;
            this.colHUYLOP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHUYLOP.Caption = "Hủy lớp";
            this.colHUYLOP.FieldName = "HUYLOP";
            this.colHUYLOP.Name = "colHUYLOP";
            this.colHUYLOP.Visible = true;
            this.colHUYLOP.VisibleIndex = 7;
            this.colHUYLOP.Width = 89;
            // 
            // groupLTC
            // 
            this.groupLTC.Controls.Add(hUYLOPLabel);
            this.groupLTC.Controls.Add(this.ckeHuyLop);
            this.groupLTC.Controls.Add(sOSVTOITHIEULabel);
            this.groupLTC.Controls.Add(this.spinSoSVToiThieu);
            this.groupLTC.Controls.Add(label4);
            this.groupLTC.Controls.Add(nHOMLabel);
            this.groupLTC.Controls.Add(this.spinNhom);
            this.groupLTC.Controls.Add(label3);
            this.groupLTC.Controls.Add(this.lkupMH);
            this.groupLTC.Controls.Add(mAKHOALabel);
            this.groupLTC.Controls.Add(this.txtMaKhoa);
            this.groupLTC.Controls.Add(this.lkupGV);
            this.groupLTC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupLTC.Enabled = false;
            this.groupLTC.Location = new System.Drawing.Point(0, 332);
            this.groupLTC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupLTC.Name = "groupLTC";
            this.groupLTC.Size = new System.Drawing.Size(990, 218);
            this.groupLTC.TabIndex = 38;
            this.groupLTC.Text = "Thông tin lớp tín chỉ";
            // 
            // ckeHuyLop
            // 
            this.ckeHuyLop.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLTC, "HUYLOP", true));
            this.ckeHuyLop.Location = new System.Drawing.Point(830, 95);
            this.ckeHuyLop.MenuManager = this.barManager1;
            this.ckeHuyLop.Name = "ckeHuyLop";
            this.ckeHuyLop.Properties.Caption = "";
            this.ckeHuyLop.Size = new System.Drawing.Size(75, 20);
            this.ckeHuyLop.TabIndex = 47;
            // 
            // spinSoSVToiThieu
            // 
            this.spinSoSVToiThieu.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLTC, "SOSVTOITHIEU", true));
            this.spinSoSVToiThieu.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinSoSVToiThieu.Location = new System.Drawing.Point(488, 95);
            this.spinSoSVToiThieu.MenuManager = this.barManager1;
            this.spinSoSVToiThieu.Name = "spinSoSVToiThieu";
            this.spinSoSVToiThieu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinSoSVToiThieu.Properties.DisplayFormat.FormatString = "n0";
            this.spinSoSVToiThieu.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinSoSVToiThieu.Properties.EditFormat.FormatString = "n0";
            this.spinSoSVToiThieu.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinSoSVToiThieu.Properties.IsFloatValue = false;
            this.spinSoSVToiThieu.Properties.Mask.EditMask = "N00";
            this.spinSoSVToiThieu.Properties.MaxValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.spinSoSVToiThieu.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinSoSVToiThieu.Size = new System.Drawing.Size(100, 20);
            this.spinSoSVToiThieu.TabIndex = 46;
            // 
            // spinNhom
            // 
            this.spinNhom.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLTC, "NHOM", true));
            this.spinNhom.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinNhom.Location = new System.Drawing.Point(110, 95);
            this.spinNhom.MenuManager = this.barManager1;
            this.spinNhom.Name = "spinNhom";
            this.spinNhom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinNhom.Properties.DisplayFormat.FormatString = "n0";
            this.spinNhom.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinNhom.Properties.EditFormat.FormatString = "n0";
            this.spinNhom.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinNhom.Properties.IsFloatValue = false;
            this.spinNhom.Properties.Mask.EditMask = "N00";
            this.spinNhom.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.spinNhom.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinNhom.Size = new System.Drawing.Size(100, 20);
            this.spinNhom.TabIndex = 43;
            // 
            // lkupMH
            // 
            this.lkupMH.Location = new System.Drawing.Point(110, 46);
            this.lkupMH.Name = "lkupMH";
            this.lkupMH.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lkupMH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkupMH.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MAMH", "MAMH", 53, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TENMH", "TENMH", 44, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lkupMH.Properties.DataSource = this.bdsMonHoc;
            this.lkupMH.Properties.DisplayMember = "TENMH";
            this.lkupMH.Properties.NullText = "Chọn một môn học ...";
            this.lkupMH.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSearch;
            this.lkupMH.Properties.ValueMember = "MAMH";
            this.lkupMH.Size = new System.Drawing.Size(237, 20);
            this.lkupMH.TabIndex = 41;
            // 
            // bdsMonHoc
            // 
            this.bdsMonHoc.DataMember = "MONHOC";
            this.bdsMonHoc.DataSource = this.dS;
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLTC, "MAKHOA", true));
            this.txtMaKhoa.Location = new System.Drawing.Point(834, 46);
            this.txtMaKhoa.MenuManager = this.barManager1;
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Properties.ReadOnly = true;
            this.txtMaKhoa.Size = new System.Drawing.Size(100, 20);
            this.txtMaKhoa.TabIndex = 1;
            // 
            // lkupGV
            // 
            this.lkupGV.Location = new System.Drawing.Point(488, 46);
            this.lkupGV.Name = "lkupGV";
            this.lkupGV.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lkupGV.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkupGV.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MAGV", "MAGV", 51, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MAKHOA", "MAKHOA", 53, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HO", "HO", 25, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TEN", "TEN", 29, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lkupGV.Properties.DataSource = this.bdsGiangVien;
            this.lkupGV.Properties.DisplayMember = "MAGV";
            this.lkupGV.Properties.NullText = "Chọn giảng viên...";
            this.lkupGV.Properties.PopupSizeable = false;
            this.lkupGV.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSearch;
            this.lkupGV.Properties.ValueMember = "MAGV";
            this.lkupGV.Size = new System.Drawing.Size(237, 20);
            this.lkupGV.TabIndex = 44;
            // 
            // bdsGiangVien
            // 
            this.bdsGiangVien.DataMember = "GIANGVIEN";
            this.bdsGiangVien.DataSource = this.dS;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // gIANGVIENTableAdapter
            // 
            this.gIANGVIENTableAdapter.ClearBeforeFill = true;
            // 
            // frmLopTinChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 550);
            this.Controls.Add(this.groupLTC);
            this.Controls.Add(this.gcLTC);
            this.Controls.Add(this.nvgtLTC);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frmLopTinChi.IconOptions.Image")));
            this.Name = "frmLopTinChi";
            this.Text = "Lớp tín chỉ";
            this.Load += new System.EventHandler(this.frmLopTinChi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nvgtLTC)).EndInit();
            this.nvgtLTC.ResumeLayout(false);
            this.nvgtLTC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupLTC)).EndInit();
            this.groupLTC.ResumeLayout(false);
            this.groupLTC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ckeHuyLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSoSVToiThieu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinNhom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkupMH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkupGV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGiangVien)).EndInit();
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
        private System.Windows.Forms.BindingNavigator nvgtLTC;
        private DS dS;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cmbHK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbNK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bdsLTC;
        private DSTableAdapters.SP_LOPTINCHITableAdapter sP_LOPTINCHITableAdapter;
        private DevExpress.XtraEditors.GroupControl groupLTC;
        private DevExpress.XtraGrid.GridControl gcLTC;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLTC;
        private DevExpress.XtraGrid.Columns.GridColumn colMALTC;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
        private DevExpress.XtraGrid.Columns.GridColumn colNHOM;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTENGV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHOA;
        private DevExpress.XtraGrid.Columns.GridColumn colSOSVTOITHIEU;
        private DevExpress.XtraGrid.Columns.GridColumn colSOSVDADANGKY;
        private DevExpress.XtraGrid.Columns.GridColumn colHUYLOP;
        private DevExpress.XtraEditors.TextEdit txtMaKhoa;
        private DevExpress.XtraEditors.LookUpEdit lkupMH;
        private System.Windows.Forms.BindingSource bdsMonHoc;
        private DSTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private DevExpress.XtraEditors.SpinEdit spinNhom;
        private DevExpress.XtraEditors.CheckEdit ckeHuyLop;
        private DevExpress.XtraEditors.SpinEdit spinSoSVToiThieu;
        private System.Windows.Forms.BindingSource bdsGiangVien;
        private DSTableAdapters.GIANGVIENTableAdapter gIANGVIENTableAdapter;
        private DevExpress.XtraBars.BarButtonItem btnRedo;
        private DevExpress.XtraEditors.LookUpEdit lkupGV;
    }
}

namespace QLDSV_HTC.Forms
{
    partial class frmHocPhi
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
            System.Windows.Forms.Label nGAYDONGLabel;
            System.Windows.Forms.Label sOTIENDONGLabel;
            System.Windows.Forms.Label hOCKYLabel;
            System.Windows.Forms.Label hOCPHILabel;
            System.Windows.Forms.Label nIENKHOALabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHocPhi));
            this.gbSinhVien = new DevExpress.XtraEditors.GroupControl();
            this.lkupSinhVien = new DevExpress.XtraEditors.LookUpEdit();
            this.bdsSinhVien = new System.Windows.Forms.BindingSource(this.components);
            this.DS_HOCPHI = new QLDSV_HTC.DS_HOCPHI();
            this.mAMHLabel = new System.Windows.Forms.Label();
            this.txtMaLop = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.tENMHLabel = new System.Windows.Forms.Label();
            this.txtTenSV = new DevExpress.XtraEditors.TextEdit();
            this.sINHVIENTableAdapter = new QLDSV_HTC.DS_HOCPHITableAdapters.SINHVIENTableAdapter();
            this.tableAdapterManager = new QLDSV_HTC.DS_HOCPHITableAdapters.TableAdapterManager();
            this.hOCPHITableAdapter = new QLDSV_HTC.DS_HOCPHITableAdapters.HOCPHITableAdapter();
            this.bdsHocPhi = new System.Windows.Forms.BindingSource(this.components);
            this.bdsCTDHP = new System.Windows.Forms.BindingSource(this.components);
            this.cT_DONGHOCPHITableAdapter = new QLDSV_HTC.DS_HOCPHITableAdapters.CT_DONGHOCPHITableAdapter();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.nvgtHocPhi = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.txtViTriHocPhi = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnThemHP = new System.Windows.Forms.ToolStripButton();
            this.btnXoaHP = new System.Windows.Forms.ToolStripButton();
            this.btnSuaHP = new System.Windows.Forms.ToolStripButton();
            this.btnGhiHP = new System.Windows.Forms.ToolStripButton();
            this.btnHuyHP = new System.Windows.Forms.ToolStripButton();
            this.btnTaiHP = new System.Windows.Forms.ToolStripButton();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar6 = new DevExpress.XtraBars.Bar();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gcHocPhi = new DevExpress.XtraGrid.GridControl();
            this.gvHocPhi = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNIENKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCPHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gbHocPhi = new DevExpress.XtraEditors.GroupControl();
            this.cmbNienKhoa = new System.Windows.Forms.ComboBox();
            this.spinHocPhi = new DevExpress.XtraEditors.SpinEdit();
            this.spinHocKy = new DevExpress.XtraEditors.SpinEdit();
            this.nvgtCTHocPhi = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.txtViTriCTDHP = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnThemCTDHP = new System.Windows.Forms.ToolStripButton();
            this.btnXoaCTDHP = new System.Windows.Forms.ToolStripButton();
            this.btnSuaCTDHP = new System.Windows.Forms.ToolStripButton();
            this.btnGhiCTDHP = new System.Windows.Forms.ToolStripButton();
            this.btnHuyCTDHP = new System.Windows.Forms.ToolStripButton();
            this.btnTaiCTDHP = new System.Windows.Forms.ToolStripButton();
            this.gcCTHocPhi = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNGAYDONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIENDONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.gbCTDHP = new DevExpress.XtraEditors.GroupControl();
            this.spinSoTienDong = new DevExpress.XtraEditors.SpinEdit();
            this.dateNgayDong = new DevExpress.XtraEditors.DateEdit();
            nGAYDONGLabel = new System.Windows.Forms.Label();
            sOTIENDONGLabel = new System.Windows.Forms.Label();
            hOCKYLabel = new System.Windows.Forms.Label();
            hOCPHILabel = new System.Windows.Forms.Label();
            nIENKHOALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gbSinhVien)).BeginInit();
            this.gbSinhVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkupSinhVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_HOCPHI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHocPhi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTDHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nvgtHocPhi)).BeginInit();
            this.nvgtHocPhi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcHocPhi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHocPhi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbHocPhi)).BeginInit();
            this.gbHocPhi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinHocPhi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinHocKy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nvgtCTHocPhi)).BeginInit();
            this.nvgtCTHocPhi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTHocPhi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbCTDHP)).BeginInit();
            this.gbCTDHP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinSoTienDong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayDong.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayDong.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // nGAYDONGLabel
            // 
            nGAYDONGLabel.AutoSize = true;
            nGAYDONGLabel.Location = new System.Drawing.Point(41, 41);
            nGAYDONGLabel.Name = "nGAYDONGLabel";
            nGAYDONGLabel.Size = new System.Drawing.Size(63, 13);
            nGAYDONGLabel.TabIndex = 0;
            nGAYDONGLabel.Text = "Ngày đóng:";
            // 
            // sOTIENDONGLabel
            // 
            sOTIENDONGLabel.AutoSize = true;
            sOTIENDONGLabel.Location = new System.Drawing.Point(395, 41);
            sOTIENDONGLabel.Name = "sOTIENDONGLabel";
            sOTIENDONGLabel.Size = new System.Drawing.Size(71, 13);
            sOTIENDONGLabel.TabIndex = 2;
            sOTIENDONGLabel.Text = "Số tiền đóng:";
            // 
            // hOCKYLabel
            // 
            hOCKYLabel.AutoSize = true;
            hOCKYLabel.Location = new System.Drawing.Point(263, 44);
            hOCKYLabel.Name = "hOCKYLabel";
            hOCKYLabel.Size = new System.Drawing.Size(43, 13);
            hOCKYLabel.TabIndex = 2;
            hOCKYLabel.Text = "Học kỳ:";
            // 
            // hOCPHILabel
            // 
            hOCPHILabel.AutoSize = true;
            hOCPHILabel.Location = new System.Drawing.Point(482, 44);
            hOCPHILabel.Name = "hOCPHILabel";
            hOCPHILabel.Size = new System.Drawing.Size(46, 13);
            hOCPHILabel.TabIndex = 4;
            hOCPHILabel.Text = "Học phí:";
            // 
            // nIENKHOALabel
            // 
            nIENKHOALabel.AutoSize = true;
            nIENKHOALabel.Location = new System.Drawing.Point(33, 44);
            nIENKHOALabel.Name = "nIENKHOALabel";
            nIENKHOALabel.Size = new System.Drawing.Size(58, 13);
            nIENKHOALabel.TabIndex = 5;
            nIENKHOALabel.Text = "Niên khóa:";
            // 
            // gbSinhVien
            // 
            this.gbSinhVien.Controls.Add(this.lkupSinhVien);
            this.gbSinhVien.Controls.Add(this.mAMHLabel);
            this.gbSinhVien.Controls.Add(this.txtMaLop);
            this.gbSinhVien.Controls.Add(this.label1);
            this.gbSinhVien.Controls.Add(this.tENMHLabel);
            this.gbSinhVien.Controls.Add(this.txtTenSV);
            this.gbSinhVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbSinhVien.Location = new System.Drawing.Point(0, 24);
            this.gbSinhVien.Margin = new System.Windows.Forms.Padding(4);
            this.gbSinhVien.Name = "gbSinhVien";
            this.gbSinhVien.Size = new System.Drawing.Size(1511, 77);
            this.gbSinhVien.TabIndex = 6;
            this.gbSinhVien.Text = "Thông tin sinh viên";
            // 
            // lkupSinhVien
            // 
            this.lkupSinhVien.Location = new System.Drawing.Point(121, 36);
            this.lkupSinhVien.Margin = new System.Windows.Forms.Padding(4);
            this.lkupSinhVien.Name = "lkupSinhVien";
            this.lkupSinhVien.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lkupSinhVien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkupSinhVien.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MASV", "Mã sinh viên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HO", "Họ"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TEN", "Tên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NGAYSINH", "Ngày sinh", 20, DevExpress.Utils.FormatType.DateTime, "dd/MM/yyyy", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MALOP", "Mã lớp"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DANGHIHOC", "Đã nghỉ học")});
            this.lkupSinhVien.Properties.DataSource = this.bdsSinhVien;
            this.lkupSinhVien.Properties.DisplayMember = "MASV";
            this.lkupSinhVien.Properties.NullText = "Chọn mã sinh viên...";
            this.lkupSinhVien.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSearch;
            this.lkupSinhVien.Properties.ValueMember = "MASV";
            this.lkupSinhVien.Size = new System.Drawing.Size(203, 20);
            this.lkupSinhVien.TabIndex = 4;
            this.lkupSinhVien.EditValueChanged += new System.EventHandler(this.lkupSinhVien_EditValueChanged);
            // 
            // bdsSinhVien
            // 
            this.bdsSinhVien.DataMember = "SINHVIEN";
            this.bdsSinhVien.DataSource = this.DS_HOCPHI;
            // 
            // DS_HOCPHI
            // 
            this.DS_HOCPHI.DataSetName = "DS_HOCPHI";
            this.DS_HOCPHI.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mAMHLabel
            // 
            this.mAMHLabel.AutoSize = true;
            this.mAMHLabel.Location = new System.Drawing.Point(43, 39);
            this.mAMHLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mAMHLabel.Name = "mAMHLabel";
            this.mAMHLabel.Size = new System.Drawing.Size(70, 13);
            this.mAMHLabel.TabIndex = 0;
            this.mAMHLabel.Text = "Mã sinh viên:";
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(797, 36);
            this.txtMaLop.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Properties.ReadOnly = true;
            this.txtMaLop.Size = new System.Drawing.Size(152, 20);
            this.txtMaLop.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(747, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã lớp:";
            // 
            // tENMHLabel
            // 
            this.tENMHLabel.AutoSize = true;
            this.tENMHLabel.Location = new System.Drawing.Point(369, 39);
            this.tENMHLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tENMHLabel.Name = "tENMHLabel";
            this.tENMHLabel.Size = new System.Drawing.Size(88, 13);
            this.tENMHLabel.TabIndex = 2;
            this.tENMHLabel.Text = "Họ tên sinh viên:";
            // 
            // txtTenSV
            // 
            this.txtTenSV.Location = new System.Drawing.Point(465, 36);
            this.txtTenSV.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.Properties.ReadOnly = true;
            this.txtTenSV.Size = new System.Drawing.Size(249, 20);
            this.txtTenSV.TabIndex = 3;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CT_DONGHOCPHITableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.HOCPHITableAdapter = this.hOCPHITableAdapter;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = this.sINHVIENTableAdapter;
            this.tableAdapterManager.UpdateOrder = QLDSV_HTC.DS_HOCPHITableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // hOCPHITableAdapter
            // 
            this.hOCPHITableAdapter.ClearBeforeFill = true;
            // 
            // bdsHocPhi
            // 
            this.bdsHocPhi.DataMember = "FK_HOCPHI_SINHVIEN";
            this.bdsHocPhi.DataSource = this.bdsSinhVien;
            // 
            // bdsCTDHP
            // 
            this.bdsCTDHP.DataMember = "FK_CT_DONGHOCPHI_HOCPHI";
            this.bdsCTDHP.DataSource = this.bdsHocPhi;
            // 
            // cT_DONGHOCPHITableAdapter
            // 
            this.cT_DONGHOCPHITableAdapter.ClearBeforeFill = true;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Thoát";
            this.barButtonItem1.Id = 7;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // nvgtHocPhi
            // 
            this.nvgtHocPhi.AddNewItem = null;
            this.nvgtHocPhi.BindingSource = this.bdsHocPhi;
            this.nvgtHocPhi.CountItem = this.bindingNavigatorCountItem;
            this.nvgtHocPhi.DeleteItem = null;
            this.nvgtHocPhi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.txtViTriHocPhi,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.btnThemHP,
            this.btnXoaHP,
            this.btnSuaHP,
            this.btnGhiHP,
            this.btnHuyHP,
            this.btnTaiHP});
            this.nvgtHocPhi.Location = new System.Drawing.Point(0, 101);
            this.nvgtHocPhi.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.nvgtHocPhi.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.nvgtHocPhi.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.nvgtHocPhi.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.nvgtHocPhi.Name = "nvgtHocPhi";
            this.nvgtHocPhi.PositionItem = this.txtViTriHocPhi;
            this.nvgtHocPhi.Size = new System.Drawing.Size(1511, 25);
            this.nvgtHocPhi.TabIndex = 24;
            this.nvgtHocPhi.Text = "bindingNavigator1";
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
            // txtViTriHocPhi
            // 
            this.txtViTriHocPhi.AccessibleName = "Position";
            this.txtViTriHocPhi.AutoSize = false;
            this.txtViTriHocPhi.Name = "txtViTriHocPhi";
            this.txtViTriHocPhi.Size = new System.Drawing.Size(50, 23);
            this.txtViTriHocPhi.Text = "0";
            this.txtViTriHocPhi.ToolTipText = "Current position";
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
            // btnThemHP
            // 
            this.btnThemHP.Image = global::QLDSV_HTC.Properties.Resources.btnThem_ImageOptions_Image;
            this.btnThemHP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThemHP.Name = "btnThemHP";
            this.btnThemHP.Size = new System.Drawing.Size(57, 22);
            this.btnThemHP.Text = "Thêm";
            this.btnThemHP.Click += new System.EventHandler(this.btnThemHP_Click);
            // 
            // btnXoaHP
            // 
            this.btnXoaHP.Image = global::QLDSV_HTC.Properties.Resources.btnXoa_ImageOptions_Image;
            this.btnXoaHP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoaHP.Name = "btnXoaHP";
            this.btnXoaHP.Size = new System.Drawing.Size(47, 22);
            this.btnXoaHP.Text = "Xóa";
            this.btnXoaHP.Click += new System.EventHandler(this.btnXoaHP_Click);
            // 
            // btnSuaHP
            // 
            this.btnSuaHP.Image = global::QLDSV_HTC.Properties.Resources.btnSua_ImageOptions_Image;
            this.btnSuaHP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSuaHP.Name = "btnSuaHP";
            this.btnSuaHP.Size = new System.Drawing.Size(46, 22);
            this.btnSuaHP.Text = "Sửa";
            this.btnSuaHP.Click += new System.EventHandler(this.btnSuaHP_Click);
            // 
            // btnGhiHP
            // 
            this.btnGhiHP.Enabled = false;
            this.btnGhiHP.Image = global::QLDSV_HTC.Properties.Resources.btnGhi_ImageOptions_Image;
            this.btnGhiHP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGhiHP.Name = "btnGhiHP";
            this.btnGhiHP.Size = new System.Drawing.Size(45, 22);
            this.btnGhiHP.Text = "Ghi";
            this.btnGhiHP.Click += new System.EventHandler(this.btnGhiHP_Click);
            // 
            // btnHuyHP
            // 
            this.btnHuyHP.Enabled = false;
            this.btnHuyHP.Image = global::QLDSV_HTC.Properties.Resources.btnHuy_ImageOptions_Image;
            this.btnHuyHP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHuyHP.Name = "btnHuyHP";
            this.btnHuyHP.Size = new System.Drawing.Size(49, 22);
            this.btnHuyHP.Text = "Hủy";
            this.btnHuyHP.Click += new System.EventHandler(this.btnHuyHP_Click);
            // 
            // btnTaiHP
            // 
            this.btnTaiHP.Image = global::QLDSV_HTC.Properties.Resources.btnReload_ImageOptions_Image;
            this.btnTaiHP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTaiHP.Name = "btnTaiHP";
            this.btnTaiHP.Size = new System.Drawing.Size(57, 22);
            this.btnTaiHP.Text = "Tải lại";
            this.btnTaiHP.Click += new System.EventHandler(this.btnTaiHP_Click);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar6});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThoat});
            this.barManager1.MainMenu = this.bar6;
            this.barManager1.MaxItemId = 1;
            // 
            // bar6
            // 
            this.bar6.BarName = "Main menu";
            this.bar6.DockCol = 0;
            this.bar6.DockRow = 0;
            this.bar6.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar6.FloatLocation = new System.Drawing.Point(459, 537);
            this.bar6.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThoat)});
            this.bar6.OptionsBar.MultiLine = true;
            this.bar6.OptionsBar.UseWholeRow = true;
            this.bar6.Text = "Main menu";
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 0;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1511, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 647);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1511, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 623);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1511, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 623);
            // 
            // gcHocPhi
            // 
            this.gcHocPhi.DataSource = this.bdsHocPhi;
            this.gcHocPhi.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcHocPhi.Location = new System.Drawing.Point(0, 126);
            this.gcHocPhi.MainView = this.gvHocPhi;
            this.gcHocPhi.Name = "gcHocPhi";
            this.gcHocPhi.Size = new System.Drawing.Size(1511, 174);
            this.gcHocPhi.TabIndex = 36;
            this.gcHocPhi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvHocPhi});
            // 
            // gvHocPhi
            // 
            this.gvHocPhi.Appearance.ViewCaption.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvHocPhi.Appearance.ViewCaption.Options.UseFont = true;
            this.gvHocPhi.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNIENKHOA,
            this.colHOCKY,
            this.colHOCPHI,
            this.gridColumn1,
            this.gridColumn2});
            this.gvHocPhi.GridControl = this.gcHocPhi;
            this.gvHocPhi.Name = "gvHocPhi";
            this.gvHocPhi.OptionsBehavior.Editable = false;
            this.gvHocPhi.OptionsView.ShowViewCaption = true;
            this.gvHocPhi.ViewCaption = "THÔNG TIN HỌC PHÍ";
            this.gvHocPhi.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvHocPhi_FocusedRowChanged);
            // 
            // colNIENKHOA
            // 
            this.colNIENKHOA.AppearanceCell.Options.UseTextOptions = true;
            this.colNIENKHOA.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNIENKHOA.AppearanceHeader.BackColor = System.Drawing.Color.LawnGreen;
            this.colNIENKHOA.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNIENKHOA.AppearanceHeader.Options.UseBackColor = true;
            this.colNIENKHOA.AppearanceHeader.Options.UseFont = true;
            this.colNIENKHOA.AppearanceHeader.Options.UseTextOptions = true;
            this.colNIENKHOA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNIENKHOA.Caption = "Niên khóa";
            this.colNIENKHOA.FieldName = "NIENKHOA";
            this.colNIENKHOA.Name = "colNIENKHOA";
            this.colNIENKHOA.Visible = true;
            this.colNIENKHOA.VisibleIndex = 0;
            // 
            // colHOCKY
            // 
            this.colHOCKY.AppearanceCell.Options.UseTextOptions = true;
            this.colHOCKY.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHOCKY.AppearanceHeader.BackColor = System.Drawing.Color.LawnGreen;
            this.colHOCKY.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colHOCKY.AppearanceHeader.Options.UseBackColor = true;
            this.colHOCKY.AppearanceHeader.Options.UseFont = true;
            this.colHOCKY.AppearanceHeader.Options.UseTextOptions = true;
            this.colHOCKY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHOCKY.Caption = "Học kỳ";
            this.colHOCKY.FieldName = "HOCKY";
            this.colHOCKY.Name = "colHOCKY";
            this.colHOCKY.Visible = true;
            this.colHOCKY.VisibleIndex = 1;
            // 
            // colHOCPHI
            // 
            this.colHOCPHI.AppearanceCell.Options.UseTextOptions = true;
            this.colHOCPHI.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colHOCPHI.AppearanceHeader.BackColor = System.Drawing.Color.LawnGreen;
            this.colHOCPHI.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colHOCPHI.AppearanceHeader.Options.UseBackColor = true;
            this.colHOCPHI.AppearanceHeader.Options.UseFont = true;
            this.colHOCPHI.AppearanceHeader.Options.UseTextOptions = true;
            this.colHOCPHI.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHOCPHI.Caption = "Học phí";
            this.colHOCPHI.DisplayFormat.FormatString = "n0";
            this.colHOCPHI.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colHOCPHI.FieldName = "HOCPHI";
            this.colHOCPHI.Name = "colHOCPHI";
            this.colHOCPHI.Visible = true;
            this.colHOCPHI.VisibleIndex = 2;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumn1.AppearanceHeader.BackColor = System.Drawing.Color.LawnGreen;
            this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn1.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn1.AppearanceHeader.Options.UseFont = true;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "Số tiền đã đóng";
            this.gridColumn1.DisplayFormat.FormatString = "n0";
            this.gridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn1.FieldName = "SOTIENDADONG";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.UnboundExpression = "Iif([FK_CT_DONGHOCPHI_HOCPHI][].Count() > 0, [FK_CT_DONGHOCPHI_HOCPHI][].Sum([SOT" +
    "IENDONG]), 0)";
            this.gridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumn2.AppearanceHeader.BackColor = System.Drawing.Color.LawnGreen;
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn2.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn2.AppearanceHeader.Options.UseFont = true;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "Số tiền cần đóng";
            this.gridColumn2.DisplayFormat.FormatString = "n0";
            this.gridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn2.FieldName = "SOTIENCANDONG";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.UnboundExpression = "[HOCPHI] - [SOTIENDADONG]";
            this.gridColumn2.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 4;
            // 
            // gbHocPhi
            // 
            this.gbHocPhi.Controls.Add(nIENKHOALabel);
            this.gbHocPhi.Controls.Add(this.cmbNienKhoa);
            this.gbHocPhi.Controls.Add(hOCPHILabel);
            this.gbHocPhi.Controls.Add(this.spinHocPhi);
            this.gbHocPhi.Controls.Add(hOCKYLabel);
            this.gbHocPhi.Controls.Add(this.spinHocKy);
            this.gbHocPhi.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbHocPhi.Enabled = false;
            this.gbHocPhi.Location = new System.Drawing.Point(0, 300);
            this.gbHocPhi.Margin = new System.Windows.Forms.Padding(4);
            this.gbHocPhi.Name = "gbHocPhi";
            this.gbHocPhi.Size = new System.Drawing.Size(1511, 89);
            this.gbHocPhi.TabIndex = 39;
            this.gbHocPhi.Text = "Thông tin học phí";
            // 
            // cmbNienKhoa
            // 
            this.cmbNienKhoa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsHocPhi, "NIENKHOA", true));
            this.cmbNienKhoa.FormattingEnabled = true;
            this.cmbNienKhoa.Location = new System.Drawing.Point(97, 41);
            this.cmbNienKhoa.Name = "cmbNienKhoa";
            this.cmbNienKhoa.Size = new System.Drawing.Size(121, 21);
            this.cmbNienKhoa.TabIndex = 6;
            // 
            // spinHocPhi
            // 
            this.spinHocPhi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsHocPhi, "HOCPHI", true));
            this.spinHocPhi.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinHocPhi.Location = new System.Drawing.Point(538, 41);
            this.spinHocPhi.MenuManager = this.barManager1;
            this.spinHocPhi.Name = "spinHocPhi";
            this.spinHocPhi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinHocPhi.Properties.DisplayFormat.FormatString = "n0";
            this.spinHocPhi.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinHocPhi.Properties.EditFormat.FormatString = "n0";
            this.spinHocPhi.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinHocPhi.Properties.Increment = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.spinHocPhi.Properties.IsFloatValue = false;
            this.spinHocPhi.Properties.Mask.EditMask = "N00";
            this.spinHocPhi.Size = new System.Drawing.Size(163, 20);
            this.spinHocPhi.TabIndex = 5;
            // 
            // spinHocKy
            // 
            this.spinHocKy.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsHocPhi, "HOCKY", true));
            this.spinHocKy.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinHocKy.Location = new System.Drawing.Point(314, 41);
            this.spinHocKy.MenuManager = this.barManager1;
            this.spinHocKy.Name = "spinHocKy";
            this.spinHocKy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinHocKy.Properties.IsFloatValue = false;
            this.spinHocKy.Properties.Mask.EditMask = "N00";
            this.spinHocKy.Properties.MaxValue = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.spinHocKy.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinHocKy.Size = new System.Drawing.Size(100, 20);
            this.spinHocKy.TabIndex = 3;
            // 
            // nvgtCTHocPhi
            // 
            this.nvgtCTHocPhi.AddNewItem = null;
            this.nvgtCTHocPhi.BindingSource = this.bdsCTDHP;
            this.nvgtCTHocPhi.CountItem = this.toolStripLabel1;
            this.nvgtCTHocPhi.DeleteItem = null;
            this.nvgtCTHocPhi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripSeparator1,
            this.txtViTriCTDHP,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton6,
            this.toolStripButton7,
            this.toolStripSeparator3,
            this.btnThemCTDHP,
            this.btnXoaCTDHP,
            this.btnSuaCTDHP,
            this.btnGhiCTDHP,
            this.btnHuyCTDHP,
            this.btnTaiCTDHP});
            this.nvgtCTHocPhi.Location = new System.Drawing.Point(0, 389);
            this.nvgtCTHocPhi.MoveFirstItem = this.toolStripButton4;
            this.nvgtCTHocPhi.MoveLastItem = this.toolStripButton7;
            this.nvgtCTHocPhi.MoveNextItem = this.toolStripButton6;
            this.nvgtCTHocPhi.MovePreviousItem = this.toolStripButton5;
            this.nvgtCTHocPhi.Name = "nvgtCTHocPhi";
            this.nvgtCTHocPhi.PositionItem = this.txtViTriCTDHP;
            this.nvgtCTHocPhi.Size = new System.Drawing.Size(1511, 25);
            this.nvgtCTHocPhi.TabIndex = 40;
            this.nvgtCTHocPhi.Text = "bindingNavigator2";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel1.Text = "of {0}";
            this.toolStripLabel1.ToolTipText = "Total number of items";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Move first";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Move previous";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // txtViTriCTDHP
            // 
            this.txtViTriCTDHP.AccessibleName = "Position";
            this.txtViTriCTDHP.AutoSize = false;
            this.txtViTriCTDHP.Name = "txtViTriCTDHP";
            this.txtViTriCTDHP.Size = new System.Drawing.Size(50, 23);
            this.txtViTriCTDHP.Text = "0";
            this.txtViTriCTDHP.ToolTipText = "Current position";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "Move next";
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.RightToLeftAutoMirrorImage = true;
            this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton7.Text = "Move last";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnThemCTDHP
            // 
            this.btnThemCTDHP.Image = global::QLDSV_HTC.Properties.Resources.btnThem_ImageOptions_Image;
            this.btnThemCTDHP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThemCTDHP.Name = "btnThemCTDHP";
            this.btnThemCTDHP.Size = new System.Drawing.Size(57, 22);
            this.btnThemCTDHP.Text = "Thêm";
            this.btnThemCTDHP.Click += new System.EventHandler(this.btnThemCTDHP_Click);
            // 
            // btnXoaCTDHP
            // 
            this.btnXoaCTDHP.Image = global::QLDSV_HTC.Properties.Resources.btnXoa_ImageOptions_Image;
            this.btnXoaCTDHP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoaCTDHP.Name = "btnXoaCTDHP";
            this.btnXoaCTDHP.Size = new System.Drawing.Size(47, 22);
            this.btnXoaCTDHP.Text = "Xóa";
            this.btnXoaCTDHP.Click += new System.EventHandler(this.btnXoaCTDHP_Click);
            // 
            // btnSuaCTDHP
            // 
            this.btnSuaCTDHP.Image = global::QLDSV_HTC.Properties.Resources.btnSua_ImageOptions_Image;
            this.btnSuaCTDHP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSuaCTDHP.Name = "btnSuaCTDHP";
            this.btnSuaCTDHP.Size = new System.Drawing.Size(46, 22);
            this.btnSuaCTDHP.Text = "Sửa";
            this.btnSuaCTDHP.Click += new System.EventHandler(this.btnSuaCTDHP_Click);
            // 
            // btnGhiCTDHP
            // 
            this.btnGhiCTDHP.Enabled = false;
            this.btnGhiCTDHP.Image = global::QLDSV_HTC.Properties.Resources.btnGhi_ImageOptions_Image;
            this.btnGhiCTDHP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGhiCTDHP.Name = "btnGhiCTDHP";
            this.btnGhiCTDHP.Size = new System.Drawing.Size(45, 22);
            this.btnGhiCTDHP.Text = "Ghi";
            this.btnGhiCTDHP.Click += new System.EventHandler(this.btnGhiCTDHP_Click);
            // 
            // btnHuyCTDHP
            // 
            this.btnHuyCTDHP.Enabled = false;
            this.btnHuyCTDHP.Image = global::QLDSV_HTC.Properties.Resources.btnHuy_ImageOptions_Image;
            this.btnHuyCTDHP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHuyCTDHP.Name = "btnHuyCTDHP";
            this.btnHuyCTDHP.Size = new System.Drawing.Size(49, 22);
            this.btnHuyCTDHP.Text = "Hủy";
            this.btnHuyCTDHP.Click += new System.EventHandler(this.btnHuyCTDHP_Click);
            // 
            // btnTaiCTDHP
            // 
            this.btnTaiCTDHP.Image = global::QLDSV_HTC.Properties.Resources.btnReload_ImageOptions_Image;
            this.btnTaiCTDHP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTaiCTDHP.Name = "btnTaiCTDHP";
            this.btnTaiCTDHP.Size = new System.Drawing.Size(57, 22);
            this.btnTaiCTDHP.Text = "Tải lại";
            this.btnTaiCTDHP.Click += new System.EventHandler(this.btnTaiCTDHP_Click);
            // 
            // gcCTHocPhi
            // 
            this.gcCTHocPhi.DataSource = this.bdsCTDHP;
            this.gcCTHocPhi.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcCTHocPhi.Location = new System.Drawing.Point(0, 414);
            this.gcCTHocPhi.MainView = this.gridView2;
            this.gcCTHocPhi.MenuManager = this.barManager1;
            this.gcCTHocPhi.Name = "gcCTHocPhi";
            this.gcCTHocPhi.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSpinEdit2});
            this.gcCTHocPhi.Size = new System.Drawing.Size(1511, 164);
            this.gcCTHocPhi.TabIndex = 40;
            this.gcCTHocPhi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Appearance.ViewCaption.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.ViewCaption.Options.UseFont = true;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNGAYDONG,
            this.colSOTIENDONG});
            this.gridView2.GridControl = this.gcCTHocPhi;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsView.ShowViewCaption = true;
            this.gridView2.ViewCaption = "CHI TIẾT ĐÓNG HỌC PHÍ";
            // 
            // colNGAYDONG
            // 
            this.colNGAYDONG.AppearanceCell.Options.UseTextOptions = true;
            this.colNGAYDONG.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNGAYDONG.AppearanceHeader.BackColor = System.Drawing.Color.DarkTurquoise;
            this.colNGAYDONG.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNGAYDONG.AppearanceHeader.Options.UseBackColor = true;
            this.colNGAYDONG.AppearanceHeader.Options.UseFont = true;
            this.colNGAYDONG.AppearanceHeader.Options.UseTextOptions = true;
            this.colNGAYDONG.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNGAYDONG.Caption = "Ngày đóng";
            this.colNGAYDONG.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colNGAYDONG.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNGAYDONG.FieldName = "NGAYDONG";
            this.colNGAYDONG.Name = "colNGAYDONG";
            this.colNGAYDONG.Visible = true;
            this.colNGAYDONG.VisibleIndex = 0;
            // 
            // colSOTIENDONG
            // 
            this.colSOTIENDONG.AppearanceCell.Options.UseTextOptions = true;
            this.colSOTIENDONG.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colSOTIENDONG.AppearanceHeader.BackColor = System.Drawing.Color.DarkTurquoise;
            this.colSOTIENDONG.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSOTIENDONG.AppearanceHeader.Options.UseBackColor = true;
            this.colSOTIENDONG.AppearanceHeader.Options.UseFont = true;
            this.colSOTIENDONG.AppearanceHeader.Options.UseTextOptions = true;
            this.colSOTIENDONG.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSOTIENDONG.Caption = "Số tiền đóng";
            this.colSOTIENDONG.ColumnEdit = this.repositoryItemSpinEdit2;
            this.colSOTIENDONG.DisplayFormat.FormatString = "n0";
            this.colSOTIENDONG.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSOTIENDONG.FieldName = "SOTIENDONG";
            this.colSOTIENDONG.Name = "colSOTIENDONG";
            this.colSOTIENDONG.Visible = true;
            this.colSOTIENDONG.VisibleIndex = 1;
            // 
            // repositoryItemSpinEdit2
            // 
            this.repositoryItemSpinEdit2.AutoHeight = false;
            this.repositoryItemSpinEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit2.DisplayFormat.FormatString = "n0";
            this.repositoryItemSpinEdit2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSpinEdit2.EditFormat.FormatString = "n0";
            this.repositoryItemSpinEdit2.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSpinEdit2.Increment = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.repositoryItemSpinEdit2.IsFloatValue = false;
            this.repositoryItemSpinEdit2.Mask.EditMask = "N00";
            this.repositoryItemSpinEdit2.Name = "repositoryItemSpinEdit2";
            // 
            // gbCTDHP
            // 
            this.gbCTDHP.Controls.Add(sOTIENDONGLabel);
            this.gbCTDHP.Controls.Add(this.spinSoTienDong);
            this.gbCTDHP.Controls.Add(nGAYDONGLabel);
            this.gbCTDHP.Controls.Add(this.dateNgayDong);
            this.gbCTDHP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCTDHP.Enabled = false;
            this.gbCTDHP.Location = new System.Drawing.Point(0, 578);
            this.gbCTDHP.Margin = new System.Windows.Forms.Padding(4);
            this.gbCTDHP.Name = "gbCTDHP";
            this.gbCTDHP.Size = new System.Drawing.Size(1511, 69);
            this.gbCTDHP.TabIndex = 41;
            this.gbCTDHP.Text = "Thông tin chi tiết đóng học phí";
            // 
            // spinSoTienDong
            // 
            this.spinSoTienDong.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTDHP, "SOTIENDONG", true));
            this.spinSoTienDong.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinSoTienDong.Location = new System.Drawing.Point(478, 38);
            this.spinSoTienDong.MenuManager = this.barManager1;
            this.spinSoTienDong.Name = "spinSoTienDong";
            this.spinSoTienDong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinSoTienDong.Properties.DisplayFormat.FormatString = "n0";
            this.spinSoTienDong.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinSoTienDong.Properties.EditFormat.FormatString = "n0";
            this.spinSoTienDong.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinSoTienDong.Properties.Increment = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.spinSoTienDong.Properties.IsFloatValue = false;
            this.spinSoTienDong.Properties.Mask.EditMask = "N00";
            this.spinSoTienDong.Properties.MaxValue = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.spinSoTienDong.Size = new System.Drawing.Size(152, 20);
            this.spinSoTienDong.TabIndex = 3;
            // 
            // dateNgayDong
            // 
            this.dateNgayDong.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTDHP, "NGAYDONG", true));
            this.dateNgayDong.EditValue = null;
            this.dateNgayDong.Location = new System.Drawing.Point(114, 38);
            this.dateNgayDong.MenuManager = this.barManager1;
            this.dateNgayDong.Name = "dateNgayDong";
            this.dateNgayDong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayDong.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayDong.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateNgayDong.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateNgayDong.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dateNgayDong.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateNgayDong.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateNgayDong.Properties.MaxValue = new System.DateTime(((long)(0)));
            this.dateNgayDong.Size = new System.Drawing.Size(174, 20);
            this.dateNgayDong.TabIndex = 1;
            this.dateNgayDong.Enter += new System.EventHandler(this.dateNgayDong_Enter);
            // 
            // frmHocPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1511, 647);
            this.Controls.Add(this.gbCTDHP);
            this.Controls.Add(this.gcCTHocPhi);
            this.Controls.Add(this.nvgtCTHocPhi);
            this.Controls.Add(this.gbHocPhi);
            this.Controls.Add(this.gcHocPhi);
            this.Controls.Add(this.nvgtHocPhi);
            this.Controls.Add(this.gbSinhVien);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frmHocPhi.IconOptions.Image")));
            this.Name = "frmHocPhi";
            this.Text = "Học phí";
            this.Load += new System.EventHandler(this.frmHocPhi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gbSinhVien)).EndInit();
            this.gbSinhVien.ResumeLayout(false);
            this.gbSinhVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkupSinhVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_HOCPHI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHocPhi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTDHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nvgtHocPhi)).EndInit();
            this.nvgtHocPhi.ResumeLayout(false);
            this.nvgtHocPhi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcHocPhi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHocPhi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbHocPhi)).EndInit();
            this.gbHocPhi.ResumeLayout(false);
            this.gbHocPhi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinHocPhi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinHocKy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nvgtCTHocPhi)).EndInit();
            this.nvgtCTHocPhi.ResumeLayout(false);
            this.nvgtCTHocPhi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTHocPhi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbCTDHP)).EndInit();
            this.gbCTDHP.ResumeLayout(false);
            this.gbCTDHP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinSoTienDong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayDong.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayDong.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl gbSinhVien;
        private DevExpress.XtraEditors.LookUpEdit lkupSinhVien;
        private System.Windows.Forms.Label mAMHLabel;
        private DevExpress.XtraEditors.TextEdit txtMaLop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tENMHLabel;
        private DevExpress.XtraEditors.TextEdit txtTenSV;
        private DS_HOCPHI DS_HOCPHI;
        private System.Windows.Forms.BindingSource bdsSinhVien;
        private DS_HOCPHITableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private DS_HOCPHITableAdapters.TableAdapterManager tableAdapterManager;
        private DS_HOCPHITableAdapters.HOCPHITableAdapter hOCPHITableAdapter;
        private System.Windows.Forms.BindingSource bdsHocPhi;
        private System.Windows.Forms.BindingSource bdsCTDHP;
        private DS_HOCPHITableAdapters.CT_DONGHOCPHITableAdapter cT_DONGHOCPHITableAdapter;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private System.Windows.Forms.BindingNavigator nvgtHocPhi;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox txtViTriHocPhi;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar6;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gcHocPhi;
        private DevExpress.XtraGrid.Views.Grid.GridView gvHocPhi;
        private DevExpress.XtraGrid.Columns.GridColumn colNIENKHOA;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCKY;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCPHI;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private System.Windows.Forms.BindingNavigator nvgtCTHocPhi;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox txtViTriCTDHP;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private DevExpress.XtraEditors.GroupControl gbHocPhi;
        private DevExpress.XtraGrid.GridControl gcCTHocPhi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYDONG;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIENDONG;
        private DevExpress.XtraEditors.GroupControl gbCTDHP;
        private DevExpress.XtraEditors.SpinEdit spinSoTienDong;
        private DevExpress.XtraEditors.DateEdit dateNgayDong;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit2;
        private System.Windows.Forms.ToolStripButton btnThemHP;
        private System.Windows.Forms.ToolStripButton btnXoaHP;
        private System.Windows.Forms.ToolStripButton btnSuaHP;
        private System.Windows.Forms.ToolStripButton btnGhiHP;
        private System.Windows.Forms.ToolStripButton btnHuyHP;
        private System.Windows.Forms.ToolStripButton btnTaiHP;
        private System.Windows.Forms.ToolStripButton btnThemCTDHP;
        private System.Windows.Forms.ToolStripButton btnXoaCTDHP;
        private System.Windows.Forms.ToolStripButton btnSuaCTDHP;
        private System.Windows.Forms.ToolStripButton btnGhiCTDHP;
        private System.Windows.Forms.ToolStripButton btnHuyCTDHP;
        private System.Windows.Forms.ToolStripButton btnTaiCTDHP;
        private DevExpress.XtraEditors.SpinEdit spinHocPhi;
        private DevExpress.XtraEditors.SpinEdit spinHocKy;
        private System.Windows.Forms.ComboBox cmbNienKhoa;
    }
}
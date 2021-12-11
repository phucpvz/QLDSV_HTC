
namespace QLDSV_HTC.Forms
{
    partial class frmDangKyMonHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangKyMonHoc));
            this.dS = new QLDSV_HTC.DS();
            this.bdsDSLTC = new System.Windows.Forms.BindingSource(this.components);
            this.sP_LAY_DS_LTCTableAdapter = new QLDSV_HTC.DSTableAdapters.SP_LAY_DS_LTCTableAdapter();
            this.tableAdapterManager = new QLDSV_HTC.DSTableAdapters.TableAdapterManager();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.sP_LAY_DS_LTCGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALTC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNHOM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTENGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOSVTOITHIEU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOSVDADANGKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nvgtDSLTC = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cmbHK = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbNK = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaKhoa = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaLop = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHoTen = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaSV = new DevExpress.XtraEditors.TextEdit();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.gc_DS_LTC_DADK = new DevExpress.XtraGrid.GridControl();
            this.gv_DS_LTC_DADK = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnXoaDK = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuuDK = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemDK = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSLTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LAY_DS_LTCGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nvgtDSLTC)).BeginInit();
            this.nvgtDSLTC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_DS_LTC_DADK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_DS_LTC_DADK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsDSLTC
            // 
            this.bdsDSLTC.DataMember = "SP_LAY_DS_LTC";
            this.bdsDSLTC.DataSource = this.dS;
            // 
            // sP_LAY_DS_LTCTableAdapter
            // 
            this.sP_LAY_DS_LTCTableAdapter.ClearBeforeFill = true;
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
            this.btnThoat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 2;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThoat)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 1;
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
            this.barDockControlTop.Size = new System.Drawing.Size(918, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 644);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(918, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 620);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(918, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 620);
            // 
            // sP_LAY_DS_LTCGridControl
            // 
            this.sP_LAY_DS_LTCGridControl.DataSource = this.bdsDSLTC;
            this.sP_LAY_DS_LTCGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.sP_LAY_DS_LTCGridControl.Location = new System.Drawing.Point(0, 154);
            this.sP_LAY_DS_LTCGridControl.MainView = this.gridView1;
            this.sP_LAY_DS_LTCGridControl.Name = "sP_LAY_DS_LTCGridControl";
            this.sP_LAY_DS_LTCGridControl.Size = new System.Drawing.Size(918, 206);
            this.sP_LAY_DS_LTCGridControl.TabIndex = 38;
            this.sP_LAY_DS_LTCGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ViewCaption.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.ViewCaption.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALTC,
            this.colMAMH,
            this.colTENMH,
            this.colNHOM,
            this.colHOTENGV,
            this.colSOSVTOITHIEU,
            this.colSOSVDADANGKY});
            this.gridView1.GridControl = this.sP_LAY_DS_LTCGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowViewCaption = true;
            this.gridView1.ViewCaption = "DANH SÁCH LỚP TÍN CHỈ";
            // 
            // colMALTC
            // 
            this.colMALTC.AppearanceCell.Options.UseTextOptions = true;
            this.colMALTC.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMALTC.AppearanceHeader.BackColor = System.Drawing.Color.Yellow;
            this.colMALTC.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.colMALTC.AppearanceHeader.Options.UseBackColor = true;
            this.colMALTC.AppearanceHeader.Options.UseFont = true;
            this.colMALTC.AppearanceHeader.Options.UseTextOptions = true;
            this.colMALTC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMALTC.Caption = "Mã lớp tín chỉ";
            this.colMALTC.FieldName = "MALTC";
            this.colMALTC.Name = "colMALTC";
            this.colMALTC.Visible = true;
            this.colMALTC.VisibleIndex = 0;
            this.colMALTC.Width = 119;
            // 
            // colMAMH
            // 
            this.colMAMH.AppearanceCell.Options.UseTextOptions = true;
            this.colMAMH.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMAMH.AppearanceHeader.BackColor = System.Drawing.Color.Yellow;
            this.colMAMH.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.colMAMH.AppearanceHeader.Options.UseBackColor = true;
            this.colMAMH.AppearanceHeader.Options.UseFont = true;
            this.colMAMH.AppearanceHeader.Options.UseTextOptions = true;
            this.colMAMH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMAMH.Caption = "Mã môn học";
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 1;
            this.colMAMH.Width = 147;
            // 
            // colTENMH
            // 
            this.colTENMH.AppearanceHeader.BackColor = System.Drawing.Color.Yellow;
            this.colTENMH.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.colTENMH.AppearanceHeader.Options.UseBackColor = true;
            this.colTENMH.AppearanceHeader.Options.UseFont = true;
            this.colTENMH.AppearanceHeader.Options.UseTextOptions = true;
            this.colTENMH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTENMH.Caption = "Tên môn học";
            this.colTENMH.FieldName = "TENMH";
            this.colTENMH.Name = "colTENMH";
            this.colTENMH.Visible = true;
            this.colTENMH.VisibleIndex = 2;
            this.colTENMH.Width = 298;
            // 
            // colNHOM
            // 
            this.colNHOM.AppearanceCell.Options.UseTextOptions = true;
            this.colNHOM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNHOM.AppearanceHeader.BackColor = System.Drawing.Color.Yellow;
            this.colNHOM.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.colNHOM.AppearanceHeader.Options.UseBackColor = true;
            this.colNHOM.AppearanceHeader.Options.UseFont = true;
            this.colNHOM.AppearanceHeader.Options.UseTextOptions = true;
            this.colNHOM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNHOM.Caption = "Nhóm";
            this.colNHOM.FieldName = "NHOM";
            this.colNHOM.Name = "colNHOM";
            this.colNHOM.Visible = true;
            this.colNHOM.VisibleIndex = 3;
            this.colNHOM.Width = 79;
            // 
            // colHOTENGV
            // 
            this.colHOTENGV.AppearanceHeader.BackColor = System.Drawing.Color.Yellow;
            this.colHOTENGV.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.colHOTENGV.AppearanceHeader.Options.UseBackColor = true;
            this.colHOTENGV.AppearanceHeader.Options.UseFont = true;
            this.colHOTENGV.AppearanceHeader.Options.UseTextOptions = true;
            this.colHOTENGV.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHOTENGV.Caption = "Họ tên giảng viên giảng";
            this.colHOTENGV.FieldName = "HOTENGV";
            this.colHOTENGV.Name = "colHOTENGV";
            this.colHOTENGV.Visible = true;
            this.colHOTENGV.VisibleIndex = 4;
            this.colHOTENGV.Width = 232;
            // 
            // colSOSVTOITHIEU
            // 
            this.colSOSVTOITHIEU.AppearanceCell.Options.UseTextOptions = true;
            this.colSOSVTOITHIEU.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colSOSVTOITHIEU.AppearanceHeader.BackColor = System.Drawing.Color.Yellow;
            this.colSOSVTOITHIEU.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.colSOSVTOITHIEU.AppearanceHeader.Options.UseBackColor = true;
            this.colSOSVTOITHIEU.AppearanceHeader.Options.UseFont = true;
            this.colSOSVTOITHIEU.AppearanceHeader.Options.UseTextOptions = true;
            this.colSOSVTOITHIEU.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSOSVTOITHIEU.Caption = "Số sinh viên tối thiểu";
            this.colSOSVTOITHIEU.FieldName = "SOSVTOITHIEU";
            this.colSOSVTOITHIEU.Name = "colSOSVTOITHIEU";
            this.colSOSVTOITHIEU.Visible = true;
            this.colSOSVTOITHIEU.VisibleIndex = 5;
            this.colSOSVTOITHIEU.Width = 160;
            // 
            // colSOSVDADANGKY
            // 
            this.colSOSVDADANGKY.AppearanceCell.Options.UseTextOptions = true;
            this.colSOSVDADANGKY.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colSOSVDADANGKY.AppearanceHeader.BackColor = System.Drawing.Color.Yellow;
            this.colSOSVDADANGKY.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.colSOSVDADANGKY.AppearanceHeader.Options.UseBackColor = true;
            this.colSOSVDADANGKY.AppearanceHeader.Options.UseFont = true;
            this.colSOSVDADANGKY.AppearanceHeader.Options.UseTextOptions = true;
            this.colSOSVDADANGKY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSOSVDADANGKY.Caption = "Số sinh viên đã đăng ký";
            this.colSOSVDADANGKY.FieldName = "SOSVDADANGKY";
            this.colSOSVDADANGKY.Name = "colSOSVDADANGKY";
            this.colSOSVDADANGKY.Visible = true;
            this.colSOSVDADANGKY.VisibleIndex = 6;
            this.colSOSVDADANGKY.Width = 161;
            // 
            // nvgtDSLTC
            // 
            this.nvgtDSLTC.AddNewItem = null;
            this.nvgtDSLTC.BindingSource = this.bdsDSLTC;
            this.nvgtDSLTC.CountItem = this.bindingNavigatorCountItem;
            this.nvgtDSLTC.DeleteItem = null;
            this.nvgtDSLTC.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.nvgtDSLTC.Location = new System.Drawing.Point(0, 129);
            this.nvgtDSLTC.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.nvgtDSLTC.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.nvgtDSLTC.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.nvgtDSLTC.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.nvgtDSLTC.Name = "nvgtDSLTC";
            this.nvgtDSLTC.PositionItem = this.bindingNavigatorPositionItem;
            this.nvgtDSLTC.Size = new System.Drawing.Size(918, 25);
            this.nvgtDSLTC.TabIndex = 37;
            this.nvgtDSLTC.Text = "bindingNavigator1";
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
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cmbHK);
            this.panelControl1.Controls.Add(this.label5);
            this.panelControl1.Controls.Add(this.cmbNK);
            this.panelControl1.Controls.Add(this.label6);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 79);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(918, 50);
            this.panelControl1.TabIndex = 36;
            // 
            // cmbHK
            // 
            this.cmbHK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHK.FormattingEnabled = true;
            this.cmbHK.Location = new System.Drawing.Point(621, 15);
            this.cmbHK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbHK.Name = "cmbHK";
            this.cmbHK.Size = new System.Drawing.Size(65, 21);
            this.cmbHK.TabIndex = 6;
            this.cmbHK.SelectedIndexChanged += new System.EventHandler(this.cmbHK_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(553, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Học kỳ:";
            // 
            // cmbNK
            // 
            this.cmbNK.FormattingEnabled = true;
            this.cmbNK.Location = new System.Drawing.Point(319, 15);
            this.cmbNK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbNK.Name = "cmbNK";
            this.cmbNK.Size = new System.Drawing.Size(157, 21);
            this.cmbNK.TabIndex = 4;
            this.cmbNK.SelectedIndexChanged += new System.EventHandler(this.cmbNK_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(230, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Niên khóa:";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.txtMaKhoa);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.txtMaLop);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.txtHoTen);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.txtMaSV);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 24);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(918, 55);
            this.groupControl1.TabIndex = 35;
            this.groupControl1.Text = "Thông tin sinh viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(724, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mã khoa:";
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.Location = new System.Drawing.Point(781, 26);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Properties.ReadOnly = true;
            this.txtMaKhoa.Size = new System.Drawing.Size(125, 20);
            this.txtMaKhoa.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(509, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã lớp:";
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(557, 26);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Properties.ReadOnly = true;
            this.txtMaLop.Size = new System.Drawing.Size(129, 20);
            this.txtMaLop.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Họ và tên:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(285, 26);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Properties.ReadOnly = true;
            this.txtHoTen.Size = new System.Drawing.Size(191, 20);
            this.txtHoTen.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã SV:";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(70, 26);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Properties.ReadOnly = true;
            this.txtMaSV.Size = new System.Drawing.Size(125, 20);
            this.txtMaSV.TabIndex = 0;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.btnXoaDK);
            this.panelControl3.Controls.Add(this.btnThemDK);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(0, 360);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(918, 47);
            this.panelControl3.TabIndex = 5;
            // 
            // gc_DS_LTC_DADK
            // 
            this.gc_DS_LTC_DADK.Dock = System.Windows.Forms.DockStyle.Top;
            this.gc_DS_LTC_DADK.Location = new System.Drawing.Point(0, 407);
            this.gc_DS_LTC_DADK.MainView = this.gv_DS_LTC_DADK;
            this.gc_DS_LTC_DADK.Name = "gc_DS_LTC_DADK";
            this.gc_DS_LTC_DADK.Size = new System.Drawing.Size(918, 188);
            this.gc_DS_LTC_DADK.TabIndex = 45;
            this.gc_DS_LTC_DADK.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_DS_LTC_DADK});
            // 
            // gv_DS_LTC_DADK
            // 
            this.gv_DS_LTC_DADK.Appearance.ViewCaption.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.gv_DS_LTC_DADK.Appearance.ViewCaption.Options.UseFont = true;
            this.gv_DS_LTC_DADK.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn8,
            this.gridColumn6,
            this.gridColumn7});
            this.gv_DS_LTC_DADK.GridControl = this.gc_DS_LTC_DADK;
            this.gv_DS_LTC_DADK.Name = "gv_DS_LTC_DADK";
            this.gv_DS_LTC_DADK.OptionsView.ShowViewCaption = true;
            this.gv_DS_LTC_DADK.ViewCaption = "DANH SÁCH ĐĂNG KÝ";
            this.gv_DS_LTC_DADK.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gv_DS_LTC_DADK_FocusedRowChanged);
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceHeader.BackColor = System.Drawing.Color.DarkTurquoise;
            this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn1.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn1.AppearanceHeader.Options.UseFont = true;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "Mã lớp tín chỉ";
            this.gridColumn1.FieldName = "MALTC";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 111;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.AppearanceHeader.BackColor = System.Drawing.Color.DarkTurquoise;
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn2.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn2.AppearanceHeader.Options.UseFont = true;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "Mã môn học";
            this.gridColumn2.FieldName = "MAMH";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 153;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceHeader.BackColor = System.Drawing.Color.DarkTurquoise;
            this.gridColumn3.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn3.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn3.AppearanceHeader.Options.UseFont = true;
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.Caption = "Tên môn học";
            this.gridColumn3.FieldName = "TENMH";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 268;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.AppearanceHeader.BackColor = System.Drawing.Color.DarkTurquoise;
            this.gridColumn4.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn4.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn4.AppearanceHeader.Options.UseFont = true;
            this.gridColumn4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.Caption = "Nhóm";
            this.gridColumn4.FieldName = "NHOM";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 74;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceHeader.BackColor = System.Drawing.Color.DarkTurquoise;
            this.gridColumn5.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn5.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn5.AppearanceHeader.Options.UseFont = true;
            this.gridColumn5.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn5.Caption = "Họ tên giảng viên giảng";
            this.gridColumn5.FieldName = "HOTENGV";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 185;
            // 
            // gridColumn8
            // 
            this.gridColumn8.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn8.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumn8.AppearanceHeader.BackColor = System.Drawing.Color.DarkTurquoise;
            this.gridColumn8.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn8.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn8.AppearanceHeader.Options.UseFont = true;
            this.gridColumn8.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn8.Caption = "Số sinh viên tối thiểu";
            this.gridColumn8.FieldName = "SOSVTOITHIEU";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 5;
            this.gridColumn8.Width = 142;
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumn6.AppearanceHeader.BackColor = System.Drawing.Color.DarkTurquoise;
            this.gridColumn6.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn6.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn6.AppearanceHeader.Options.UseFont = true;
            this.gridColumn6.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn6.Caption = "Số sinh viên đã đăng ký";
            this.gridColumn6.FieldName = "SOSVDADANGKY";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 6;
            this.gridColumn6.Width = 152;
            // 
            // gridColumn7
            // 
            this.gridColumn7.AppearanceHeader.BackColor = System.Drawing.Color.DarkTurquoise;
            this.gridColumn7.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn7.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn7.AppearanceHeader.Options.UseFont = true;
            this.gridColumn7.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn7.Caption = "Hủy đăng ký";
            this.gridColumn7.FieldName = "HUYDANGKY";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 7;
            this.gridColumn7.Width = 111;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnLuuDK);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 595);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(918, 49);
            this.panelControl2.TabIndex = 46;
            // 
            // btnXoaDK
            // 
            this.btnXoaDK.Enabled = false;
            this.btnXoaDK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaDK.ImageOptions.Image")));
            this.btnXoaDK.Location = new System.Drawing.Point(440, 5);
            this.btnXoaDK.Name = "btnXoaDK";
            this.btnXoaDK.Size = new System.Drawing.Size(115, 38);
            this.btnXoaDK.TabIndex = 4;
            this.btnXoaDK.Text = "Xóa đăng ký";
            this.btnXoaDK.Click += new System.EventHandler(this.btnXoaDK_Click);
            // 
            // btnLuuDK
            // 
            this.btnLuuDK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuDK.ImageOptions.Image")));
            this.btnLuuDK.Location = new System.Drawing.Point(377, 6);
            this.btnLuuDK.Name = "btnLuuDK";
            this.btnLuuDK.Size = new System.Drawing.Size(113, 38);
            this.btnLuuDK.TabIndex = 3;
            this.btnLuuDK.Text = "Lưu đăng ký";
            this.btnLuuDK.Click += new System.EventHandler(this.btnLuuDK_Click);
            // 
            // btnThemDK
            // 
            this.btnThemDK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemDK.ImageOptions.Image")));
            this.btnThemDK.Location = new System.Drawing.Point(319, 5);
            this.btnThemDK.Name = "btnThemDK";
            this.btnThemDK.Size = new System.Drawing.Size(115, 38);
            this.btnThemDK.TabIndex = 1;
            this.btnThemDK.Text = "Thêm đăng ký";
            this.btnThemDK.Click += new System.EventHandler(this.btnThemDK_Click);
            // 
            // frmDangKyMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 644);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.gc_DS_LTC_DADK);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.sP_LAY_DS_LTCGridControl);
            this.Controls.Add(this.nvgtDSLTC);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frmDangKyMonHoc.IconOptions.Image")));
            this.Name = "frmDangKyMonHoc";
            this.Text = "Đăng ký lớp tín chỉ";
            this.Load += new System.EventHandler(this.frmSVDangKy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSLTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LAY_DS_LTCGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nvgtDSLTC)).EndInit();
            this.nvgtDSLTC.ResumeLayout(false);
            this.nvgtDSLTC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_DS_LTC_DADK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_DS_LTC_DADK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DS dS;
        private System.Windows.Forms.BindingSource bdsDSLTC;
        private DSTableAdapters.SP_LAY_DS_LTCTableAdapter sP_LAY_DS_LTCTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl sP_LAY_DS_LTCGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMALTC;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
        private DevExpress.XtraGrid.Columns.GridColumn colNHOM;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTENGV;
        private DevExpress.XtraGrid.Columns.GridColumn colSOSVDADANGKY;
        private System.Windows.Forms.BindingNavigator nvgtDSLTC;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cmbHK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbNK;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txtMaKhoa;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtMaLop;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtHoTen;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtMaSV;
        private DevExpress.XtraGrid.Columns.GridColumn colSOSVTOITHIEU;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnLuuDK;
        private DevExpress.XtraGrid.GridControl gc_DS_LTC_DADK;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_DS_LTC_DADK;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton btnXoaDK;
        private DevExpress.XtraEditors.SimpleButton btnThemDK;
    }
}
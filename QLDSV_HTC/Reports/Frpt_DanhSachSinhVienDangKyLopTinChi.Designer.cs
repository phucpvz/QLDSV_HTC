
namespace QLDSV_HTC.Reports
{
    partial class Frpt_DanhSachSinhVienDangKyLopTinChi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frpt_DanhSachSinhVienDangKyLopTinChi));
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnPreview = new DevExpress.XtraEditors.SimpleButton();
            this.cmbHK = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbNK = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.lkupMonHoc = new DevExpress.XtraEditors.LookUpEdit();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new QLDSV_HTC.DS();
            this.mONHOCTableAdapter = new QLDSV_HTC.DSTableAdapters.MONHOCTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbNhom = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lkupMonHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.Image")));
            this.btnExit.Location = new System.Drawing.Point(426, 250);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(103, 42);
            this.btnExit.TabIndex = 26;
            this.btnExit.Text = "Thoát";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPreview.ImageOptions.Image")));
            this.btnPreview.Location = new System.Drawing.Point(276, 250);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(111, 42);
            this.btnPreview.TabIndex = 25;
            this.btnPreview.Text = "Xem trước";
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // cmbHK
            // 
            this.cmbHK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHK.FormattingEnabled = true;
            this.cmbHK.Location = new System.Drawing.Point(607, 105);
            this.cmbHK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbHK.Name = "cmbHK";
            this.cmbHK.Size = new System.Drawing.Size(65, 21);
            this.cmbHK.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(539, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = "Học kỳ:";
            // 
            // cmbNK
            // 
            this.cmbNK.FormattingEnabled = true;
            this.cmbNK.Location = new System.Drawing.Point(274, 104);
            this.cmbNK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbNK.Name = "cmbNK";
            this.cmbNK.Size = new System.Drawing.Size(142, 21);
            this.cmbNK.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 22;
            this.label1.Text = "Niên khóa:";
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(308, 40);
            this.cmbKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(235, 21);
            this.cmbKhoa.TabIndex = 19;
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhoa.Location = new System.Drawing.Point(257, 40);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(45, 19);
            this.lblKhoa.TabIndex = 20;
            this.lblKhoa.Text = "Khoa";
            // 
            // lkupMonHoc
            // 
            this.lkupMonHoc.Location = new System.Drawing.Point(274, 161);
            this.lkupMonHoc.Name = "lkupMonHoc";
            this.lkupMonHoc.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lkupMonHoc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkupMonHoc.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MAMH", "Mã môn học", 53, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TENMH", "Tên môn học", 44, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lkupMonHoc.Properties.DataSource = this.mONHOCBindingSource;
            this.lkupMonHoc.Properties.DisplayMember = "TENMH";
            this.lkupMonHoc.Properties.NullText = "Chọn một môn học ...";
            this.lkupMonHoc.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSearch;
            this.lkupMonHoc.Properties.ValueMember = "MAMH";
            this.lkupMonHoc.Size = new System.Drawing.Size(237, 20);
            this.lkupMonHoc.TabIndex = 27;
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(195, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 28;
            this.label3.Text = "Môn học:";
            // 
            // cmbNhom
            // 
            this.cmbNhom.FormattingEnabled = true;
            this.cmbNhom.Location = new System.Drawing.Point(607, 161);
            this.cmbNhom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbNhom.Name = "cmbNhom";
            this.cmbNhom.Size = new System.Drawing.Size(65, 21);
            this.cmbNhom.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(547, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 30;
            this.label4.Text = "Nhóm:";
            // 
            // Frpt_DanhSachSinhVienDangKyLopTinChi
            // 
            this.AcceptButton = this.btnPreview;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(889, 535);
            this.Controls.Add(this.cmbNhom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lkupMonHoc);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.cmbHK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbNK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbKhoa);
            this.Controls.Add(this.lblKhoa);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("Frpt_DanhSachSinhVienDangKyLopTinChi.IconOptions.Image")));
            this.Name = "Frpt_DanhSachSinhVienDangKyLopTinChi";
            this.Text = "Danh sách sinh viên đăng ký lớp tín chỉ";
            this.Load += new System.EventHandler(this.frptDanhSachSinhVienDangKyLopTinChi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lkupMonHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnPreview;
        private System.Windows.Forms.ComboBox cmbHK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbNK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.Label lblKhoa;
        private DevExpress.XtraEditors.LookUpEdit lkupMonHoc;
        private DS dS;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private DSTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbNhom;
        private System.Windows.Forms.Label label4;
    }
}
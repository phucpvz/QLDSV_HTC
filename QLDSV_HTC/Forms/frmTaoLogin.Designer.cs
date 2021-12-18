
namespace QLDSV_HTC.Forms
{
    partial class frmTaoLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaoLogin));
            this.pnlKhoa = new DevExpress.XtraEditors.PanelControl();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.ckbShowPass = new System.Windows.Forms.CheckBox();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnSignUp = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.rbtnPKT = new System.Windows.Forms.RadioButton();
            this.rbtnKHOA = new System.Windows.Forms.RadioButton();
            this.rbtnPGV = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.lookUpGV = new DevExpress.XtraEditors.LookUpEdit();
            this.bdsGiangVien = new System.Windows.Forms.BindingSource(this.components);
            this.DS_HOCPHI = new QLDSV_HTC.DS_HOCPHI();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConfirm = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLogin = new DevExpress.XtraEditors.TextEdit();
            this.gIANGVIENTableAdapter = new QLDSV_HTC.DS_HOCPHITableAdapters.GIANGVIENTableAdapter();
            this.hOTENGIANGVIENTableAdapter = new QLDSV_HTC.DS_HOCPHITableAdapters.HOTENGIANGVIENTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pnlKhoa)).BeginInit();
            this.pnlKhoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpGV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGiangVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_HOCPHI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConfirm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLogin.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlKhoa
            // 
            this.pnlKhoa.Controls.Add(this.cmbKhoa);
            this.pnlKhoa.Controls.Add(this.lblKhoa);
            this.pnlKhoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlKhoa.Location = new System.Drawing.Point(0, 0);
            this.pnlKhoa.Name = "pnlKhoa";
            this.pnlKhoa.Size = new System.Drawing.Size(893, 70);
            this.pnlKhoa.TabIndex = 6;
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(583, 22);
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
            this.lblKhoa.Location = new System.Drawing.Point(527, 25);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(50, 19);
            this.lblKhoa.TabIndex = 20;
            this.lblKhoa.Text = "Khoa:";
            // 
            // ckbShowPass
            // 
            this.ckbShowPass.AutoSize = true;
            this.ckbShowPass.Location = new System.Drawing.Point(513, 234);
            this.ckbShowPass.Name = "ckbShowPass";
            this.ckbShowPass.Size = new System.Drawing.Size(109, 17);
            this.ckbShowPass.TabIndex = 18;
            this.ckbShowPass.Text = "Hiển thị mật khẩu";
            this.ckbShowPass.UseVisualStyleBackColor = true;
            this.ckbShowPass.CheckedChanged += new System.EventHandler(this.chkShowPass_CheckedChanged);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.Image")));
            this.btnExit.Location = new System.Drawing.Point(713, 409);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(136, 39);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Thoát";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSignUp
            // 
            this.btnSignUp.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSignUp.ImageOptions.Image")));
            this.btnSignUp.Location = new System.Drawing.Point(513, 409);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(135, 39);
            this.btnSignUp.TabIndex = 16;
            this.btnSignUp.Text = "Đăng ký";
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.rbtnPKT);
            this.panelControl2.Controls.Add(this.rbtnKHOA);
            this.panelControl2.Controls.Add(this.rbtnPGV);
            this.panelControl2.Location = new System.Drawing.Point(513, 330);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(336, 56);
            this.panelControl2.TabIndex = 15;
            // 
            // rbtnPKT
            // 
            this.rbtnPKT.AutoSize = true;
            this.rbtnPKT.Location = new System.Drawing.Point(220, 23);
            this.rbtnPKT.Name = "rbtnPKT";
            this.rbtnPKT.Size = new System.Drawing.Size(94, 17);
            this.rbtnPKT.TabIndex = 2;
            this.rbtnPKT.TabStop = true;
            this.rbtnPKT.Text = "Phòng kế toán";
            this.rbtnPKT.UseVisualStyleBackColor = true;
            // 
            // rbtnKHOA
            // 
            this.rbtnKHOA.AutoSize = true;
            this.rbtnKHOA.Location = new System.Drawing.Point(141, 23);
            this.rbtnKHOA.Name = "rbtnKHOA";
            this.rbtnKHOA.Size = new System.Drawing.Size(49, 17);
            this.rbtnKHOA.TabIndex = 1;
            this.rbtnKHOA.TabStop = true;
            this.rbtnKHOA.Text = "Khoa";
            this.rbtnKHOA.UseVisualStyleBackColor = true;
            // 
            // rbtnPGV
            // 
            this.rbtnPGV.AutoSize = true;
            this.rbtnPGV.Location = new System.Drawing.Point(20, 23);
            this.rbtnPGV.Name = "rbtnPGV";
            this.rbtnPGV.Size = new System.Drawing.Size(93, 17);
            this.rbtnPGV.TabIndex = 0;
            this.rbtnPGV.TabStop = true;
            this.rbtnPGV.Text = "Phòng giáo vụ";
            this.rbtnPGV.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(451, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Vai trò:";
            // 
            // lookUpGV
            // 
            this.lookUpGV.Location = new System.Drawing.Point(513, 280);
            this.lookUpGV.Name = "lookUpGV";
            this.lookUpGV.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lookUpGV.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpGV.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MAGV", "Mã giảng viên", 51, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HOTENGV", "Họ tên giảng viên", 57, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MAKHOA", "Mã khoa", 53, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lookUpGV.Properties.DataSource = this.bdsGiangVien;
            this.lookUpGV.Properties.DisplayMember = "HOTENGV";
            this.lookUpGV.Properties.NullText = "Chọn giảng viên...";
            this.lookUpGV.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSearch;
            this.lookUpGV.Properties.ValueMember = "MAGV";
            this.lookUpGV.Size = new System.Drawing.Size(336, 20);
            this.lookUpGV.TabIndex = 13;
            // 
            // bdsGiangVien
            // 
            this.bdsGiangVien.DataMember = "HOTENGIANGVIEN";
            this.bdsGiangVien.DataSource = this.DS_HOCPHI;
            // 
            // DS_HOCPHI
            // 
            this.DS_HOCPHI.DataSetName = "DS_HOCPHI";
            this.DS_HOCPHI.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(425, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Người dùng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(380, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Xác nhận mật khẩu:";
            // 
            // txtConfirm
            // 
            this.txtConfirm.Location = new System.Drawing.Point(513, 188);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Properties.UseSystemPasswordChar = true;
            this.txtConfirm.Size = new System.Drawing.Size(336, 20);
            this.txtConfirm.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(435, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mật khẩu:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(513, 140);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.UseSystemPasswordChar = true;
            this.txtPassword.Size = new System.Drawing.Size(336, 20);
            this.txtPassword.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(405, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tên đăng nhập:";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(513, 93);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(336, 20);
            this.txtLogin.TabIndex = 6;
            // 
            // gIANGVIENTableAdapter
            // 
            this.gIANGVIENTableAdapter.ClearBeforeFill = true;
            // 
            // hOTENGIANGVIENTableAdapter
            // 
            this.hOTENGIANGVIENTableAdapter.ClearBeforeFill = true;
            // 
            // frmTaoLogin
            // 
            this.AcceptButton = this.btnSignUp;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(893, 480);
            this.Controls.Add(this.pnlKhoa);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.ckbShowPass);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.txtConfirm);
            this.Controls.Add(this.lookUpGV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLogin);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frmTaoLogin.IconOptions.Image")));
            this.Name = "frmTaoLogin";
            this.Text = "Tạo tài khoản";
            this.Load += new System.EventHandler(this.frmTaoTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlKhoa)).EndInit();
            this.pnlKhoa.ResumeLayout(false);
            this.pnlKhoa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpGV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGiangVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_HOCPHI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConfirm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLogin.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlKhoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtConfirm;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtLogin;
        private DevExpress.XtraEditors.LookUpEdit lookUpGV;
        private DS_HOCPHI DS_HOCPHI;
        private System.Windows.Forms.BindingSource bdsGiangVien;
        private DS_HOCPHITableAdapters.GIANGVIENTableAdapter gIANGVIENTableAdapter;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.RadioButton rbtnPGV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbtnPKT;
        private System.Windows.Forms.RadioButton rbtnKHOA;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnSignUp;
        private System.Windows.Forms.CheckBox ckbShowPass;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.Label lblKhoa;
        private DS_HOCPHITableAdapters.HOTENGIANGVIENTableAdapter hOTENGIANGVIENTableAdapter;
    }
}
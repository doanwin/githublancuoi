﻿namespace DiemDanhSinhVien.Views
{
    partial class frmGiaoVien
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
            System.Windows.Forms.Label cHUYENMONLabel;
            System.Windows.Forms.Label tRINHDOLabel;
            System.Windows.Forms.Label hOTENLabel;
            System.Windows.Forms.Label mADONVILabel;
            System.Windows.Forms.Label mAGVLabel;
            this.gIANGVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qldiemdanhsvDataSet = new DiemDanhSinhVien.qldiemdanhsvDataSet();
            this.gIANGVIENTableAdapter = new DiemDanhSinhVien.qldiemdanhsvDataSetTableAdapters.GIANGVIENTableAdapter();
            this.tableAdapterManager = new DiemDanhSinhVien.qldiemdanhsvDataSetTableAdapters.TableAdapterManager();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.cHUYENMONTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tRINHDOTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.hOTENTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.mAGVTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.lapTableAdapter1 = new DiemDanhSinhVien.qldiemdanhsvDataSetTableAdapters.LAPTableAdapter();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem11 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem12 = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem13 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem14 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem15 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem16 = new DevExpress.XtraBars.BarButtonItem();
            this.dgv_giaovien = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dONVIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dONVITableAdapter = new DiemDanhSinhVien.qldiemdanhsvDataSetTableAdapters.DONVITableAdapter();
            this.cbo_madv = new System.Windows.Forms.ComboBox();
            cHUYENMONLabel = new System.Windows.Forms.Label();
            tRINHDOLabel = new System.Windows.Forms.Label();
            hOTENLabel = new System.Windows.Forms.Label();
            mADONVILabel = new System.Windows.Forms.Label();
            mAGVLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gIANGVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qldiemdanhsvDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUYENMONTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRINHDOTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOTENTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAGVTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_giaovien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dONVIBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cHUYENMONLabel
            // 
            cHUYENMONLabel.AutoSize = true;
            cHUYENMONLabel.Location = new System.Drawing.Point(516, 124);
            cHUYENMONLabel.Name = "cHUYENMONLabel";
            cHUYENMONLabel.Size = new System.Drawing.Size(80, 13);
            cHUYENMONLabel.TabIndex = 9;
            cHUYENMONLabel.Text = "CHUYENMON:";
            // 
            // tRINHDOLabel
            // 
            tRINHDOLabel.AutoSize = true;
            tRINHDOLabel.Location = new System.Drawing.Point(536, 98);
            tRINHDOLabel.Name = "tRINHDOLabel";
            tRINHDOLabel.Size = new System.Drawing.Size(60, 13);
            tRINHDOLabel.TabIndex = 7;
            tRINHDOLabel.Text = "TRINHDO:";
            // 
            // hOTENLabel
            // 
            hOTENLabel.AutoSize = true;
            hOTENLabel.Location = new System.Drawing.Point(63, 146);
            hOTENLabel.Name = "hOTENLabel";
            hOTENLabel.Size = new System.Drawing.Size(48, 13);
            hOTENLabel.TabIndex = 5;
            hOTENLabel.Text = "HOTEN:";
            // 
            // mADONVILabel
            // 
            mADONVILabel.AutoSize = true;
            mADONVILabel.Location = new System.Drawing.Point(63, 120);
            mADONVILabel.Name = "mADONVILabel";
            mADONVILabel.Size = new System.Drawing.Size(60, 13);
            mADONVILabel.TabIndex = 3;
            mADONVILabel.Text = "MADONVI:";
            // 
            // mAGVLabel
            // 
            mAGVLabel.AutoSize = true;
            mAGVLabel.Location = new System.Drawing.Point(63, 94);
            mAGVLabel.Name = "mAGVLabel";
            mAGVLabel.Size = new System.Drawing.Size(41, 13);
            mAGVLabel.TabIndex = 1;
            mAGVLabel.Text = "MAGV:";
            // 
            // gIANGVIENBindingSource
            // 
            this.gIANGVIENBindingSource.DataMember = "GIANGVIEN";
            this.gIANGVIENBindingSource.DataSource = this.qldiemdanhsvDataSet;
            // 
            // qldiemdanhsvDataSet
            // 
            this.qldiemdanhsvDataSet.DataSetName = "qldiemdanhsvDataSet";
            this.qldiemdanhsvDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gIANGVIENTableAdapter
            // 
            this.gIANGVIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BOTRILOPTableAdapter = null;
            this.tableAdapterManager.CAHOCTableAdapter = null;
            this.tableAdapterManager.CHITIETDIEMDANHTableAdapter = null;
            this.tableAdapterManager.DIEMDANHTableAdapter = null;
            this.tableAdapterManager.DM_ManHinhTableAdapter = null;
            this.tableAdapterManager.DONVITableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = this.gIANGVIENTableAdapter;
            this.tableAdapterManager.HOCTableAdapter = null;
            this.tableAdapterManager.LAPTableAdapter = null;
            this.tableAdapterManager.LOPMONHOCTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.PHANCONGTableAdapter = null;
            this.tableAdapterManager.PHONGHOCTableAdapter = null;
            this.tableAdapterManager.QL_NguoiDungNhomNguoiDungTableAdapter = null;
            this.tableAdapterManager.QL_NguoiDungTableAdapter = null;
            this.tableAdapterManager.QL_NhomNguoiDungTableAdapter = null;
            this.tableAdapterManager.QL_PhanQuyenTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DiemDanhSinhVien.qldiemdanhsvDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Thêm";
            this.barButtonItem1.Glyph = global::DiemDanhSinhVien.Properties.Resources.Actions_list_add_user_icon;
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Xóa";
            this.barButtonItem6.Glyph = global::DiemDanhSinhVien.Properties.Resources.Actions_list_remove_user_icon;
            this.barButtonItem6.Id = 8;
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Cập nhật";
            this.barButtonItem7.Glyph = global::DiemDanhSinhVien.Properties.Resources.Refresh_icon;
            this.barButtonItem7.Id = 9;
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Lưu lại";
            this.barButtonItem8.Glyph = global::DiemDanhSinhVien.Properties.Resources.Open_folder_accept_icon;
            this.barButtonItem8.Id = 10;
            this.barButtonItem8.Name = "barButtonItem8";
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Size = new System.Drawing.Size(0, 0);
            // 
            // cHUYENMONTextEdit
            // 
            this.cHUYENMONTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gIANGVIENBindingSource, "CHUYENMON", true));
            this.cHUYENMONTextEdit.Location = new System.Drawing.Point(622, 121);
            this.cHUYENMONTextEdit.Name = "cHUYENMONTextEdit";
            this.cHUYENMONTextEdit.Size = new System.Drawing.Size(256, 20);
            this.cHUYENMONTextEdit.TabIndex = 10;
            // 
            // tRINHDOTextEdit
            // 
            this.tRINHDOTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gIANGVIENBindingSource, "TRINHDO", true));
            this.tRINHDOTextEdit.Location = new System.Drawing.Point(622, 95);
            this.tRINHDOTextEdit.Name = "tRINHDOTextEdit";
            this.tRINHDOTextEdit.Size = new System.Drawing.Size(256, 20);
            this.tRINHDOTextEdit.TabIndex = 8;
            // 
            // hOTENTextEdit
            // 
            this.hOTENTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gIANGVIENBindingSource, "HOTEN", true));
            this.hOTENTextEdit.Location = new System.Drawing.Point(149, 143);
            this.hOTENTextEdit.Name = "hOTENTextEdit";
            this.hOTENTextEdit.Size = new System.Drawing.Size(268, 20);
            this.hOTENTextEdit.TabIndex = 6;
            // 
            // mAGVTextEdit
            // 
            this.mAGVTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gIANGVIENBindingSource, "MAGV", true));
            this.mAGVTextEdit.Enabled = false;
            this.mAGVTextEdit.Location = new System.Drawing.Point(149, 91);
            this.mAGVTextEdit.Name = "mAGVTextEdit";
            this.mAGVTextEdit.Size = new System.Drawing.Size(268, 20);
            this.mAGVTextEdit.TabIndex = 2;
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Id = -1;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Id = -1;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Id = -1;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Id = -1;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // lapTableAdapter1
            // 
            this.lapTableAdapter1.ClearBeforeFill = true;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem9,
            this.barButtonItem13,
            this.barButtonItem14,
            this.barButtonItem15,
            this.barButtonItem16,
            this.barButtonItem10,
            this.barButtonItem11,
            this.barButtonItem12});
            this.barManager1.MainMenu = this.bar1;
            this.barManager1.MaxItemId = 11;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Main menu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem9, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem10, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem11, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem12, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Main menu";
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "Thêm";
            this.barButtonItem9.Glyph = global::DiemDanhSinhVien.Properties.Resources.Actions_list_add_user_icon;
            this.barButtonItem9.Id = 0;
            this.barButtonItem9.Name = "barButtonItem9";
            this.barButtonItem9.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem9_ItemClick);
            // 
            // barButtonItem10
            // 
            this.barButtonItem10.Caption = "Xóa";
            this.barButtonItem10.Glyph = global::DiemDanhSinhVien.Properties.Resources.Actions_list_remove_user_icon;
            this.barButtonItem10.Id = 8;
            this.barButtonItem10.Name = "barButtonItem10";
            // 
            // barButtonItem11
            // 
            this.barButtonItem11.Caption = "Cập nhật";
            this.barButtonItem11.Glyph = global::DiemDanhSinhVien.Properties.Resources.Refresh_icon;
            this.barButtonItem11.Id = 9;
            this.barButtonItem11.Name = "barButtonItem11";
            // 
            // barButtonItem12
            // 
            this.barButtonItem12.Caption = "Lưu lại";
            this.barButtonItem12.Glyph = global::DiemDanhSinhVien.Properties.Resources.Open_folder_accept_icon;
            this.barButtonItem12.Id = 10;
            this.barButtonItem12.Name = "barButtonItem12";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1244, 32);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 534);
            this.barDockControlBottom.Size = new System.Drawing.Size(1244, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 32);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 502);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1244, 32);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 502);
            // 
            // barButtonItem13
            // 
            this.barButtonItem13.Caption = "Xóa";
            this.barButtonItem13.Glyph = global::DiemDanhSinhVien.Properties.Resources.Actions_list_remove_user_icon;
            this.barButtonItem13.Id = 1;
            this.barButtonItem13.Name = "barButtonItem13";
            // 
            // barButtonItem14
            // 
            this.barButtonItem14.Caption = "Sửa";
            this.barButtonItem14.Id = 2;
            this.barButtonItem14.Name = "barButtonItem14";
            // 
            // barButtonItem15
            // 
            this.barButtonItem15.Caption = "Lưu lại";
            this.barButtonItem15.Id = 3;
            this.barButtonItem15.Name = "barButtonItem15";
            // 
            // barButtonItem16
            // 
            this.barButtonItem16.Caption = "Xóa";
            this.barButtonItem16.Id = 5;
            this.barButtonItem16.Name = "barButtonItem16";
            // 
            // dgv_giaovien
            // 
            this.dgv_giaovien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_giaovien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgv_giaovien.Location = new System.Drawing.Point(66, 197);
            this.dgv_giaovien.Name = "dgv_giaovien";
            this.dgv_giaovien.Size = new System.Drawing.Size(796, 314);
            this.dgv_giaovien.TabIndex = 15;
            this.dgv_giaovien.SelectionChanged += new System.EventHandler(this.dgv_giaovien_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MAGV";
            this.Column1.HeaderText = "MÃ GIÁO VIÊN";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MADONVI";
            this.Column2.HeaderText = "MÃ ĐƠN VỊ";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "HOTEN";
            this.Column3.HeaderText = "HỌ TÊN";
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TRINHDO";
            this.Column4.HeaderText = "TRÌNH ĐỘ";
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "CHUYEMON";
            this.Column5.HeaderText = "CHUYÊN MÔN";
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // dONVIBindingSource
            // 
            this.dONVIBindingSource.DataMember = "DONVI";
            this.dONVIBindingSource.DataSource = this.qldiemdanhsvDataSet;
            // 
            // dONVITableAdapter
            // 
            this.dONVITableAdapter.ClearBeforeFill = true;
            // 
            // cbo_madv
            // 
            this.cbo_madv.DataSource = this.dONVIBindingSource;
            this.cbo_madv.DisplayMember = "TENDONVI";
            this.cbo_madv.FormattingEnabled = true;
            this.cbo_madv.Location = new System.Drawing.Point(149, 117);
            this.cbo_madv.Name = "cbo_madv";
            this.cbo_madv.Size = new System.Drawing.Size(268, 21);
            this.cbo_madv.TabIndex = 19;
            this.cbo_madv.ValueMember = "MADONVI";
            // 
            // frmGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 557);
            this.Controls.Add(this.cbo_madv);
            this.Controls.Add(this.dgv_giaovien);
            this.Controls.Add(mAGVLabel);
            this.Controls.Add(this.mAGVTextEdit);
            this.Controls.Add(mADONVILabel);
            this.Controls.Add(hOTENLabel);
            this.Controls.Add(this.hOTENTextEdit);
            this.Controls.Add(tRINHDOLabel);
            this.Controls.Add(this.tRINHDOTextEdit);
            this.Controls.Add(cHUYENMONLabel);
            this.Controls.Add(this.cHUYENMONTextEdit);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmGiaoVien";
            this.Text = "frmGiaoVien";
            this.Load += new System.EventHandler(this.frmGiaoVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gIANGVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qldiemdanhsvDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUYENMONTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRINHDOTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOTENTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAGVTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_giaovien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dONVIBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private qldiemdanhsvDataSet qldiemdanhsvDataSet;
        private System.Windows.Forms.BindingSource gIANGVIENBindingSource;
        private qldiemdanhsvDataSetTableAdapters.GIANGVIENTableAdapter gIANGVIENTableAdapter;
        private qldiemdanhsvDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraEditors.TextEdit cHUYENMONTextEdit;
        private DevExpress.XtraEditors.TextEdit tRINHDOTextEdit;
        private DevExpress.XtraEditors.TextEdit hOTENTextEdit;
        private DevExpress.XtraEditors.TextEdit mAGVTextEdit;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private qldiemdanhsvDataSetTableAdapters.LAPTableAdapter lapTableAdapter1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
        private DevExpress.XtraBars.BarButtonItem barButtonItem11;
        private DevExpress.XtraBars.BarButtonItem barButtonItem12;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem13;
        private DevExpress.XtraBars.BarButtonItem barButtonItem14;
        private DevExpress.XtraBars.BarButtonItem barButtonItem15;
        private DevExpress.XtraBars.BarButtonItem barButtonItem16;
        private System.Windows.Forms.DataGridView dgv_giaovien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.BindingSource dONVIBindingSource;
        private qldiemdanhsvDataSetTableAdapters.DONVITableAdapter dONVITableAdapter;
        private System.Windows.Forms.ComboBox cbo_madv;
    }
}
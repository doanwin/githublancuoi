namespace DiemDanhSinhVien.Views
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
            System.Windows.Forms.Label mAGVLabel;
            System.Windows.Forms.Label mADONVILabel;
            System.Windows.Forms.Label hOTENLabel;
            System.Windows.Forms.Label tRINHDOLabel;
            System.Windows.Forms.Label cHUYENMONLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiaoVien));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cHUYENMONTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.gIANGVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qldiemdanhsvDataSet = new DiemDanhSinhVien.qldiemdanhsvDataSet();
            this.tRINHDOTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.hOTENTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.mADONVIComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.mAGVComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.gIANGVIENTableAdapter = new DiemDanhSinhVien.qldiemdanhsvDataSetTableAdapters.GIANGVIENTableAdapter();
            this.tableAdapterManager = new DiemDanhSinhVien.qldiemdanhsvDataSetTableAdapters.TableAdapterManager();
            this.gIANGVIENBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.gIANGVIENBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridSplitContainer1 = new DevExpress.XtraGrid.GridSplitContainer();
            this.gIANGVIENGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colHOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMADONVI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRINHDO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCHUYENMON = new DevExpress.XtraGrid.Columns.GridColumn();
            mAGVLabel = new System.Windows.Forms.Label();
            mADONVILabel = new System.Windows.Forms.Label();
            hOTENLabel = new System.Windows.Forms.Label();
            tRINHDOLabel = new System.Windows.Forms.Label();
            cHUYENMONLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cHUYENMONTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIANGVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qldiemdanhsvDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRINHDOTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOTENTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mADONVIComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAGVComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIANGVIENBindingNavigator)).BeginInit();
            this.gIANGVIENBindingNavigator.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).BeginInit();
            this.gridSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gIANGVIENGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mAGVLabel
            // 
            mAGVLabel.AutoSize = true;
            mAGVLabel.Location = new System.Drawing.Point(65, 21);
            mAGVLabel.Name = "mAGVLabel";
            mAGVLabel.Size = new System.Drawing.Size(77, 13);
            mAGVLabel.TabIndex = 0;
            mAGVLabel.Text = "Mã giảng viên:";
            // 
            // mADONVILabel
            // 
            mADONVILabel.AutoSize = true;
            mADONVILabel.Location = new System.Drawing.Point(79, 51);
            mADONVILabel.Name = "mADONVILabel";
            mADONVILabel.Size = new System.Drawing.Size(58, 13);
            mADONVILabel.TabIndex = 2;
            mADONVILabel.Text = "Mã đơn vị:";
            // 
            // hOTENLabel
            // 
            hOTENLabel.AutoSize = true;
            hOTENLabel.Location = new System.Drawing.Point(151, 93);
            hOTENLabel.Name = "hOTENLabel";
            hOTENLabel.Size = new System.Drawing.Size(46, 13);
            hOTENLabel.TabIndex = 4;
            hOTENLabel.Text = "Họ Tên:";
            // 
            // tRINHDOLabel
            // 
            tRINHDOLabel.AutoSize = true;
            tRINHDOLabel.Location = new System.Drawing.Point(335, 21);
            tRINHDOLabel.Name = "tRINHDOLabel";
            tRINHDOLabel.Size = new System.Drawing.Size(50, 13);
            tRINHDOLabel.TabIndex = 6;
            tRINHDOLabel.Text = "Trình độ:";
            // 
            // cHUYENMONLabel
            // 
            cHUYENMONLabel.AutoSize = true;
            cHUYENMONLabel.Location = new System.Drawing.Point(315, 57);
            cHUYENMONLabel.Name = "cHUYENMONLabel";
            cHUYENMONLabel.Size = new System.Drawing.Size(69, 13);
            cHUYENMONLabel.TabIndex = 8;
            cHUYENMONLabel.Text = "Chuyên môn:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(cHUYENMONLabel);
            this.panel1.Controls.Add(this.cHUYENMONTextEdit);
            this.panel1.Controls.Add(tRINHDOLabel);
            this.panel1.Controls.Add(this.tRINHDOTextEdit);
            this.panel1.Controls.Add(hOTENLabel);
            this.panel1.Controls.Add(this.hOTENTextEdit);
            this.panel1.Controls.Add(mADONVILabel);
            this.panel1.Controls.Add(this.mADONVIComboBoxEdit);
            this.panel1.Controls.Add(mAGVLabel);
            this.panel1.Controls.Add(this.mAGVComboBoxEdit);
            this.panel1.Location = new System.Drawing.Point(242, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 127);
            this.panel1.TabIndex = 0;
            // 
            // cHUYENMONTextEdit
            // 
            this.cHUYENMONTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gIANGVIENBindingSource, "CHUYENMON", true));
            this.cHUYENMONTextEdit.Location = new System.Drawing.Point(401, 54);
            this.cHUYENMONTextEdit.Name = "cHUYENMONTextEdit";
            this.cHUYENMONTextEdit.Size = new System.Drawing.Size(100, 20);
            this.cHUYENMONTextEdit.TabIndex = 9;
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
            // tRINHDOTextEdit
            // 
            this.tRINHDOTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gIANGVIENBindingSource, "TRINHDO", true));
            this.tRINHDOTextEdit.Location = new System.Drawing.Point(401, 18);
            this.tRINHDOTextEdit.Name = "tRINHDOTextEdit";
            this.tRINHDOTextEdit.Size = new System.Drawing.Size(100, 20);
            this.tRINHDOTextEdit.TabIndex = 7;
            // 
            // hOTENTextEdit
            // 
            this.hOTENTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gIANGVIENBindingSource, "HOTEN", true));
            this.hOTENTextEdit.Location = new System.Drawing.Point(205, 90);
            this.hOTENTextEdit.Name = "hOTENTextEdit";
            this.hOTENTextEdit.Size = new System.Drawing.Size(261, 20);
            this.hOTENTextEdit.TabIndex = 5;
            // 
            // mADONVIComboBoxEdit
            // 
            this.mADONVIComboBoxEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gIANGVIENBindingSource, "MADONVI", true));
            this.mADONVIComboBoxEdit.Location = new System.Drawing.Point(145, 48);
            this.mADONVIComboBoxEdit.Name = "mADONVIComboBoxEdit";
            this.mADONVIComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.mADONVIComboBoxEdit.Size = new System.Drawing.Size(100, 20);
            this.mADONVIComboBoxEdit.TabIndex = 3;
            // 
            // mAGVComboBoxEdit
            // 
            this.mAGVComboBoxEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gIANGVIENBindingSource, "MAGV", true));
            this.mAGVComboBoxEdit.Location = new System.Drawing.Point(145, 18);
            this.mAGVComboBoxEdit.Name = "mAGVComboBoxEdit";
            this.mAGVComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.mAGVComboBoxEdit.Size = new System.Drawing.Size(100, 20);
            this.mAGVComboBoxEdit.TabIndex = 1;
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
            // gIANGVIENBindingNavigator
            // 
            this.gIANGVIENBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.gIANGVIENBindingNavigator.BindingSource = this.gIANGVIENBindingSource;
            this.gIANGVIENBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.gIANGVIENBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.gIANGVIENBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.gIANGVIENBindingNavigatorSaveItem});
            this.gIANGVIENBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.gIANGVIENBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.gIANGVIENBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.gIANGVIENBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.gIANGVIENBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.gIANGVIENBindingNavigator.Name = "gIANGVIENBindingNavigator";
            this.gIANGVIENBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.gIANGVIENBindingNavigator.Size = new System.Drawing.Size(1076, 25);
            this.gIANGVIENBindingNavigator.TabIndex = 1;
            this.gIANGVIENBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(74, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(60, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
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
            // gIANGVIENBindingNavigatorSaveItem
            // 
            this.gIANGVIENBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("gIANGVIENBindingNavigatorSaveItem.Image")));
            this.gIANGVIENBindingNavigatorSaveItem.Name = "gIANGVIENBindingNavigatorSaveItem";
            this.gIANGVIENBindingNavigatorSaveItem.Size = new System.Drawing.Size(78, 22);
            this.gIANGVIENBindingNavigatorSaveItem.Text = "Save Data";
            this.gIANGVIENBindingNavigatorSaveItem.Click += new System.EventHandler(this.gIANGVIENBindingNavigatorSaveItem_Click_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridSplitContainer1);
            this.panel2.Location = new System.Drawing.Point(244, 161);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(620, 304);
            this.panel2.TabIndex = 10;
            // 
            // gridSplitContainer1
            // 
            this.gridSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSplitContainer1.Grid = this.gIANGVIENGridControl;
            this.gridSplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.gridSplitContainer1.Name = "gridSplitContainer1";
            this.gridSplitContainer1.Panel1.Controls.Add(this.gIANGVIENGridControl);
            this.gridSplitContainer1.Size = new System.Drawing.Size(620, 304);
            this.gridSplitContainer1.TabIndex = 0;
            // 
            // gIANGVIENGridControl
            // 
            this.gIANGVIENGridControl.DataSource = this.gIANGVIENBindingSource;
            this.gIANGVIENGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gIANGVIENGridControl.Location = new System.Drawing.Point(0, 0);
            this.gIANGVIENGridControl.MainView = this.gridView1;
            this.gIANGVIENGridControl.Name = "gIANGVIENGridControl";
            this.gIANGVIENGridControl.Size = new System.Drawing.Size(620, 304);
            this.gIANGVIENGridControl.TabIndex = 0;
            this.gIANGVIENGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colHOTEN,
            this.colMADONVI,
            this.colMAGV,
            this.colTRINHDO,
            this.colCHUYENMON});
            this.gridView1.GridControl = this.gIANGVIENGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colHOTEN
            // 
            this.colHOTEN.Caption = "Họ Tên";
            this.colHOTEN.FieldName = "HOTEN";
            this.colHOTEN.Name = "colHOTEN";
            this.colHOTEN.Visible = true;
            this.colHOTEN.VisibleIndex = 2;
            // 
            // colMADONVI
            // 
            this.colMADONVI.Caption = "Mã đơn vị";
            this.colMADONVI.FieldName = "MADONVI";
            this.colMADONVI.Name = "colMADONVI";
            this.colMADONVI.Visible = true;
            this.colMADONVI.VisibleIndex = 1;
            // 
            // colMAGV
            // 
            this.colMAGV.Caption = "Mã giảng viên";
            this.colMAGV.FieldName = "MAGV";
            this.colMAGV.Name = "colMAGV";
            this.colMAGV.Visible = true;
            this.colMAGV.VisibleIndex = 0;
            // 
            // colTRINHDO
            // 
            this.colTRINHDO.Caption = "Trình độ";
            this.colTRINHDO.FieldName = "TRINHDO";
            this.colTRINHDO.Name = "colTRINHDO";
            this.colTRINHDO.Visible = true;
            this.colTRINHDO.VisibleIndex = 3;
            // 
            // colCHUYENMON
            // 
            this.colCHUYENMON.Caption = "Chuyên môn";
            this.colCHUYENMON.FieldName = "CHUYENMON";
            this.colCHUYENMON.Name = "colCHUYENMON";
            this.colCHUYENMON.Visible = true;
            this.colCHUYENMON.VisibleIndex = 4;
            // 
            // frmGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 557);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gIANGVIENBindingNavigator);
            this.Controls.Add(this.panel1);
            this.Name = "frmGiaoVien";
            this.Text = "frmGiaoVien";
            this.Load += new System.EventHandler(this.frmGiaoVien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cHUYENMONTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIANGVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qldiemdanhsvDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRINHDOTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOTENTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mADONVIComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAGVComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIANGVIENBindingNavigator)).EndInit();
            this.gIANGVIENBindingNavigator.ResumeLayout(false);
            this.gIANGVIENBindingNavigator.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).EndInit();
            this.gridSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gIANGVIENGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private qldiemdanhsvDataSet qldiemdanhsvDataSet;
        private System.Windows.Forms.BindingSource gIANGVIENBindingSource;
        private qldiemdanhsvDataSetTableAdapters.GIANGVIENTableAdapter gIANGVIENTableAdapter;
        private qldiemdanhsvDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator gIANGVIENBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton gIANGVIENBindingNavigatorSaveItem;
        private DevExpress.XtraEditors.TextEdit cHUYENMONTextEdit;
        private DevExpress.XtraEditors.TextEdit tRINHDOTextEdit;
        private DevExpress.XtraEditors.TextEdit hOTENTextEdit;
        private DevExpress.XtraEditors.ComboBoxEdit mADONVIComboBoxEdit;
        private DevExpress.XtraEditors.ComboBoxEdit mAGVComboBoxEdit;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl gIANGVIENGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridSplitContainer gridSplitContainer1;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colMADONVI;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private DevExpress.XtraGrid.Columns.GridColumn colTRINHDO;
        private DevExpress.XtraGrid.Columns.GridColumn colCHUYENMON;
    }
}
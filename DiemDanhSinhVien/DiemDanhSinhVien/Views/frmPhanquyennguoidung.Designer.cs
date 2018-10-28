namespace DiemDanhSinhVien.Views
{
    partial class frmPhanquyennguoidung
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
            System.Windows.Forms.Label tenDangNhapLabel;
            System.Windows.Forms.Label matKhauLabel;
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.qL_NguoiDungDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.qL_NguoiDungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qldiemdanhsvDataSet = new DiemDanhSinhVien.qldiemdanhsvDataSet();
            this.btnSuuNguoidung = new System.Windows.Forms.Button();
            this.btnXoaNguoidung = new System.Windows.Forms.Button();
            this.btnthemnguoidung = new System.Windows.Forms.Button();
            this.txtTendangnhap = new DevExpress.XtraEditors.TextEdit();
            this.txtMatkhau = new DevExpress.XtraEditors.TextEdit();
            this.qL_NguoiDungTableAdapter = new DiemDanhSinhVien.qldiemdanhsvDataSetTableAdapters.QL_NguoiDungTableAdapter();
            this.tableAdapterManager = new DiemDanhSinhVien.qldiemdanhsvDataSetTableAdapters.TableAdapterManager();
            this.qL_NguoiDungBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgv_chucnangquyen = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgv_1 = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLuu = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLayra = new System.Windows.Forms.Button();
            this.btnThemvao = new System.Windows.Forms.Button();
            this.dgv_nguoidungnhomnguoidung = new System.Windows.Forms.DataGridView();
            this.TenDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_nhomnguoidung = new System.Windows.Forms.ComboBox();
            this.qL_NhomNguoiDungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_NhomNguoiDungTableAdapter = new DiemDanhSinhVien.qldiemdanhsvDataSetTableAdapters.QL_NhomNguoiDungTableAdapter();
            this.qldiemdanhsv1 = new DAL.qldiemdanhsv();
            tenDangNhapLabel = new System.Windows.Forms.Label();
            matKhauLabel = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qldiemdanhsvDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTendangnhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatkhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungBindingNavigator)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chucnangquyen)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nguoidungnhomnguoidung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NhomNguoiDungBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qldiemdanhsv1)).BeginInit();
            this.SuspendLayout();
            // 
            // tenDangNhapLabel
            // 
            tenDangNhapLabel.AutoSize = true;
            tenDangNhapLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tenDangNhapLabel.Location = new System.Drawing.Point(6, 24);
            tenDangNhapLabel.Name = "tenDangNhapLabel";
            tenDangNhapLabel.Size = new System.Drawing.Size(87, 13);
            tenDangNhapLabel.TabIndex = 0;
            tenDangNhapLabel.Text = "Tên Đăng Nhập:";
            // 
            // matKhauLabel
            // 
            matKhauLabel.AutoSize = true;
            matKhauLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            matKhauLabel.Location = new System.Drawing.Point(37, 50);
            matKhauLabel.Name = "matKhauLabel";
            matKhauLabel.Size = new System.Drawing.Size(55, 13);
            matKhauLabel.TabIndex = 2;
            matKhauLabel.Text = "Mật khẩu:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.qL_NguoiDungDataGridView);
            this.groupBox2.Controls.Add(this.btnSuuNguoidung);
            this.groupBox2.Controls.Add(this.btnXoaNguoidung);
            this.groupBox2.Controls.Add(this.btnthemnguoidung);
            this.groupBox2.Controls.Add(tenDangNhapLabel);
            this.groupBox2.Controls.Add(this.txtTendangnhap);
            this.groupBox2.Controls.Add(matKhauLabel);
            this.groupBox2.Controls.Add(this.txtMatkhau);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(39, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(576, 277);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách người dùng";
            // 
            // qL_NguoiDungDataGridView
            // 
            this.qL_NguoiDungDataGridView.AutoGenerateColumns = false;
            this.qL_NguoiDungDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.qL_NguoiDungDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Column1});
            this.qL_NguoiDungDataGridView.DataSource = this.qL_NguoiDungBindingSource;
            this.qL_NguoiDungDataGridView.Location = new System.Drawing.Point(9, 73);
            this.qL_NguoiDungDataGridView.Name = "qL_NguoiDungDataGridView";
            this.qL_NguoiDungDataGridView.Size = new System.Drawing.Size(547, 195);
            this.qL_NguoiDungDataGridView.TabIndex = 7;
            this.qL_NguoiDungDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.qL_NguoiDungDataGridView_CellContentClick);
            this.qL_NguoiDungDataGridView.SelectionChanged += new System.EventHandler(this.qL_NguoiDungDataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TenDangNhap";
            this.dataGridViewTextBoxColumn1.HeaderText = "Tên Đăng Nhập";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MatKhau";
            this.dataGridViewTextBoxColumn2.HeaderText = "Mật khẩu";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "HoatDong";
            this.Column1.HeaderText = "Khóa Người dùng";
            this.Column1.Name = "Column1";
            // 
            // qL_NguoiDungBindingSource
            // 
            this.qL_NguoiDungBindingSource.DataMember = "QL_NguoiDung";
            this.qL_NguoiDungBindingSource.DataSource = this.qldiemdanhsvDataSet;
            // 
            // qldiemdanhsvDataSet
            // 
            this.qldiemdanhsvDataSet.DataSetName = "qldiemdanhsvDataSet";
            this.qldiemdanhsvDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSuuNguoidung
            // 
            this.btnSuuNguoidung.Location = new System.Drawing.Point(481, 37);
            this.btnSuuNguoidung.Name = "btnSuuNguoidung";
            this.btnSuuNguoidung.Size = new System.Drawing.Size(75, 30);
            this.btnSuuNguoidung.TabIndex = 7;
            this.btnSuuNguoidung.Text = "Sửa";
            this.btnSuuNguoidung.UseVisualStyleBackColor = true;
            this.btnSuuNguoidung.Click += new System.EventHandler(this.btnLuuNguoidung_Click);
            // 
            // btnXoaNguoidung
            // 
            this.btnXoaNguoidung.Location = new System.Drawing.Point(384, 37);
            this.btnXoaNguoidung.Name = "btnXoaNguoidung";
            this.btnXoaNguoidung.Size = new System.Drawing.Size(75, 30);
            this.btnXoaNguoidung.TabIndex = 6;
            this.btnXoaNguoidung.Text = "Xóa";
            this.btnXoaNguoidung.UseVisualStyleBackColor = true;
            this.btnXoaNguoidung.Click += new System.EventHandler(this.btnXoaNguoidung_Click);
            // 
            // btnthemnguoidung
            // 
            this.btnthemnguoidung.Location = new System.Drawing.Point(290, 37);
            this.btnthemnguoidung.Name = "btnthemnguoidung";
            this.btnthemnguoidung.Size = new System.Drawing.Size(75, 30);
            this.btnthemnguoidung.TabIndex = 5;
            this.btnthemnguoidung.Text = "Thêm";
            this.btnthemnguoidung.UseVisualStyleBackColor = true;
            this.btnthemnguoidung.Click += new System.EventHandler(this.btnthemnguoidung_Click);
            // 
            // txtTendangnhap
            // 
            this.txtTendangnhap.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.qL_NguoiDungBindingSource, "TenDangNhap", true));
            this.txtTendangnhap.Location = new System.Drawing.Point(99, 21);
            this.txtTendangnhap.Name = "txtTendangnhap";
            this.txtTendangnhap.Size = new System.Drawing.Size(185, 20);
            this.txtTendangnhap.TabIndex = 1;
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.qL_NguoiDungBindingSource, "MatKhau", true));
            this.txtMatkhau.Location = new System.Drawing.Point(99, 47);
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.Size = new System.Drawing.Size(185, 20);
            this.txtMatkhau.TabIndex = 3;
            // 
            // qL_NguoiDungTableAdapter
            // 
            this.qL_NguoiDungTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.HOCTableAdapter = null;
            this.tableAdapterManager.LAPTableAdapter = null;
            this.tableAdapterManager.LOPMONHOCTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.PHANCONGTableAdapter = null;
            this.tableAdapterManager.PHONGHOCTableAdapter = null;
            this.tableAdapterManager.QL_NguoiDungNhomNguoiDungTableAdapter = null;
            this.tableAdapterManager.QL_NguoiDungTableAdapter = this.qL_NguoiDungTableAdapter;
            this.tableAdapterManager.QL_NhomNguoiDungTableAdapter = null;
            this.tableAdapterManager.QL_PhanQuyenTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DiemDanhSinhVien.qldiemdanhsvDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // qL_NguoiDungBindingNavigator
            // 
            this.qL_NguoiDungBindingNavigator.AddNewItem = null;
            this.qL_NguoiDungBindingNavigator.BindingSource = this.qL_NguoiDungBindingSource;
            this.qL_NguoiDungBindingNavigator.CountItem = null;
            this.qL_NguoiDungBindingNavigator.DeleteItem = null;
            this.qL_NguoiDungBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.qL_NguoiDungBindingNavigator.MoveFirstItem = null;
            this.qL_NguoiDungBindingNavigator.MoveLastItem = null;
            this.qL_NguoiDungBindingNavigator.MoveNextItem = null;
            this.qL_NguoiDungBindingNavigator.MovePreviousItem = null;
            this.qL_NguoiDungBindingNavigator.Name = "qL_NguoiDungBindingNavigator";
            this.qL_NguoiDungBindingNavigator.PositionItem = null;
            this.qL_NguoiDungBindingNavigator.Size = new System.Drawing.Size(1307, 25);
            this.qL_NguoiDungBindingNavigator.TabIndex = 10;
            this.qL_NguoiDungBindingNavigator.Text = "bindingNavigator1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.btnLuu);
            this.groupBox3.Location = new System.Drawing.Point(39, 324);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1049, 268);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cấp quyền cho nhóm người dùng";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgv_chucnangquyen);
            this.groupBox4.Location = new System.Drawing.Point(376, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(541, 229);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách chức năng quyền";
            // 
            // dgv_chucnangquyen
            // 
            this.dgv_chucnangquyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_chucnangquyen.Location = new System.Drawing.Point(6, 17);
            this.dgv_chucnangquyen.Name = "dgv_chucnangquyen";
            this.dgv_chucnangquyen.Size = new System.Drawing.Size(529, 200);
            this.dgv_chucnangquyen.TabIndex = 1;
            this.dgv_chucnangquyen.Visible = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgv_1);
            this.groupBox5.Location = new System.Drawing.Point(12, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(364, 229);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = " Danh sách nhóm người dùng";
            // 
            // dgv_1
            // 
            this.dgv_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column5});
            this.dgv_1.Location = new System.Drawing.Point(6, 17);
            this.dgv_1.Name = "dgv_1";
            this.dgv_1.Size = new System.Drawing.Size(352, 200);
            this.dgv_1.TabIndex = 0;
            this.dgv_1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_1_CellContentClick);
            this.dgv_1.SelectionChanged += new System.EventHandler(this.dgv_1_SelectionChanged);
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MaNhom";
            this.Column2.HeaderText = "Mã nhóm";
            this.Column2.Name = "Column2";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TenNhom";
            this.Column5.HeaderText = "Tên nhóm";
            this.Column5.Name = "Column5";
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.Control;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLuu.Location = new System.Drawing.Point(930, 36);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(113, 42);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLayra);
            this.groupBox1.Controls.Add(this.btnThemvao);
            this.groupBox1.Controls.Add(this.dgv_nguoidungnhomnguoidung);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbo_nhomnguoidung);
//<<<<<<< HEAD
            this.groupBox1.Location = new System.Drawing.Point(91, 61);
//=======
            this.groupBox1.Location = new System.Drawing.Point(616, 41);
//>>>>>>> master
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 277);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm người dùng vào nhóm";
            // 
            // btnLayra
            // 
            this.btnLayra.Location = new System.Drawing.Point(6, 157);
            this.btnLayra.Name = "btnLayra";
            this.btnLayra.Size = new System.Drawing.Size(29, 31);
            this.btnLayra.TabIndex = 12;
            this.btnLayra.Text = "<<";
            this.btnLayra.UseVisualStyleBackColor = true;
            this.btnLayra.Click += new System.EventHandler(this.btnLayra_Click_1);
            // 
            // btnThemvao
            // 
            this.btnThemvao.Location = new System.Drawing.Point(6, 126);
            this.btnThemvao.Name = "btnThemvao";
            this.btnThemvao.Size = new System.Drawing.Size(29, 31);
            this.btnThemvao.TabIndex = 11;
            this.btnThemvao.Text = ">>";
            this.btnThemvao.UseVisualStyleBackColor = true;
            this.btnThemvao.Click += new System.EventHandler(this.btnThemvao_Click_1);
            // 
            // dgv_nguoidungnhomnguoidung
            // 
            this.dgv_nguoidungnhomnguoidung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nguoidungnhomnguoidung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenDangNhap,
            this.Column3,
            this.Column4});
            this.dgv_nguoidungnhomnguoidung.Location = new System.Drawing.Point(41, 43);
            this.dgv_nguoidungnhomnguoidung.Name = "dgv_nguoidungnhomnguoidung";
            this.dgv_nguoidungnhomnguoidung.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_nguoidungnhomnguoidung.Size = new System.Drawing.Size(425, 225);
            this.dgv_nguoidungnhomnguoidung.TabIndex = 10;
            // 
            // TenDangNhap
            // 
            this.TenDangNhap.DataPropertyName = "TenDangNhap";
            this.TenDangNhap.HeaderText = "Tên đăng nhập";
            this.TenDangNhap.Name = "TenDangNhap";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MatKhau";
            this.Column3.HeaderText = "Mật khẩu";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "GhiChu";
            this.Column4.HeaderText = "Ghi chú";
            this.Column4.Name = "Column4";
            this.Column4.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tên nhóm người dùng:";
            // 
            // cbo_nhomnguoidung
            // 
            this.cbo_nhomnguoidung.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_nhomnguoidung.FormattingEnabled = true;
            this.cbo_nhomnguoidung.Location = new System.Drawing.Point(184, 15);
            this.cbo_nhomnguoidung.Name = "cbo_nhomnguoidung";
            this.cbo_nhomnguoidung.Size = new System.Drawing.Size(282, 21);
            this.cbo_nhomnguoidung.TabIndex = 7;
            this.cbo_nhomnguoidung.SelectedIndexChanged += new System.EventHandler(this.cbo_nhomnguoidung_SelectedIndexChanged_1);
            // 
            // qL_NhomNguoiDungBindingSource
            // 
            this.qL_NhomNguoiDungBindingSource.DataMember = "QL_NhomNguoiDung";
            this.qL_NhomNguoiDungBindingSource.DataSource = this.qldiemdanhsvDataSet;
            // 
            // qL_NhomNguoiDungTableAdapter
            // 
            this.qL_NhomNguoiDungTableAdapter.ClearBeforeFill = true;
            // 
            // qldiemdanhsv1
            // 
            this.qldiemdanhsv1.DataSetName = "qldiemdanhsv";
            this.qldiemdanhsv1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmPhanquyennguoidung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 639);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.qL_NguoiDungBindingNavigator);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmPhanquyennguoidung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Phân quyền người dùng";
            this.Load += new System.EventHandler(this.frmPhanquyennguoidung_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qldiemdanhsvDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTendangnhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatkhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungBindingNavigator)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chucnangquyen)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nguoidungnhomnguoidung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NhomNguoiDungBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qldiemdanhsv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private qldiemdanhsvDataSet qldiemdanhsvDataSet;
        private System.Windows.Forms.BindingSource qL_NguoiDungBindingSource;
        private qldiemdanhsvDataSetTableAdapters.QL_NguoiDungTableAdapter qL_NguoiDungTableAdapter;
        private qldiemdanhsvDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.TextEdit txtTendangnhap;
        private DevExpress.XtraEditors.TextEdit txtMatkhau;
        private System.Windows.Forms.Button btnSuuNguoidung;
        private System.Windows.Forms.Button btnXoaNguoidung;
        private System.Windows.Forms.Button btnthemnguoidung;
        private System.Windows.Forms.BindingNavigator qL_NguoiDungBindingNavigator;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgv_chucnangquyen;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLayra;
        private System.Windows.Forms.Button btnThemvao;
        private System.Windows.Forms.DataGridView dgv_nguoidungnhomnguoidung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_nhomnguoidung;
        private System.Windows.Forms.DataGridView qL_NguoiDungDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDangNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.BindingSource qL_NhomNguoiDungBindingSource;
        private qldiemdanhsvDataSetTableAdapters.QL_NhomNguoiDungTableAdapter qL_NhomNguoiDungTableAdapter;
        private System.Windows.Forms.DataGridView dgv_1;
        private DAL.qldiemdanhsv qldiemdanhsv1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;

    }
}
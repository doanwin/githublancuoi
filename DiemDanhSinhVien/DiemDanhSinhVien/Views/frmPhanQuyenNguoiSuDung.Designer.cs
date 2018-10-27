namespace DiemDanhSinhVien.Views
{
    partial class frmPhanQuyenNguoiSuDung
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLayra = new System.Windows.Forms.Button();
            this.btnThemvao = new System.Windows.Forms.Button();
            this.dgv_nguoidungnhomnguoidung = new System.Windows.Forms.DataGridView();
            this.dgv_Nguoidung = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_nhomnguoidung = new System.Windows.Forms.ComboBox();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nguoidungnhomnguoidung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Nguoidung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.groupBox1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(721, 472);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(721, 472);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLayra);
            this.groupBox1.Controls.Add(this.btnThemvao);
            this.groupBox1.Controls.Add(this.dgv_nguoidungnhomnguoidung);
            this.groupBox1.Controls.Add(this.dgv_Nguoidung);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbo_nhomnguoidung);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(697, 448);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm người dùng vào nhóm";
            // 
            // btnLayra
            // 
            this.btnLayra.Location = new System.Drawing.Point(255, 163);
            this.btnLayra.Name = "btnLayra";
            this.btnLayra.Size = new System.Drawing.Size(29, 31);
            this.btnLayra.TabIndex = 12;
            this.btnLayra.Text = "<<";
            this.btnLayra.UseVisualStyleBackColor = true;
            // 
            // btnThemvao
            // 
            this.btnThemvao.Location = new System.Drawing.Point(255, 132);
            this.btnThemvao.Name = "btnThemvao";
            this.btnThemvao.Size = new System.Drawing.Size(29, 31);
            this.btnThemvao.TabIndex = 11;
            this.btnThemvao.Text = ">>";
            this.btnThemvao.UseVisualStyleBackColor = true;
            // 
            // dgv_nguoidungnhomnguoidung
            // 
            this.dgv_nguoidungnhomnguoidung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nguoidungnhomnguoidung.Location = new System.Drawing.Point(290, 43);
            this.dgv_nguoidungnhomnguoidung.Name = "dgv_nguoidungnhomnguoidung";
            this.dgv_nguoidungnhomnguoidung.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_nguoidungnhomnguoidung.Size = new System.Drawing.Size(346, 294);
            this.dgv_nguoidungnhomnguoidung.TabIndex = 10;
            // 
            // dgv_Nguoidung
            // 
            this.dgv_Nguoidung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Nguoidung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5});
            this.dgv_Nguoidung.Location = new System.Drawing.Point(6, 43);
            this.dgv_Nguoidung.Name = "dgv_Nguoidung";
            this.dgv_Nguoidung.Size = new System.Drawing.Size(246, 294);
            this.dgv_Nguoidung.TabIndex = 9;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TenDangNhap";
            this.Column4.HeaderText = "Tên đăng nhập";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "MatKhau";
            this.Column5.HeaderText = "Mật khẩu";
            this.Column5.Name = "Column5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tên nhóm người dùng:";
            // 
            // cbo_nhomnguoidung
            // 
            this.cbo_nhomnguoidung.FormattingEnabled = true;
            this.cbo_nhomnguoidung.Location = new System.Drawing.Point(407, 13);
            this.cbo_nhomnguoidung.Name = "cbo_nhomnguoidung";
            this.cbo_nhomnguoidung.Size = new System.Drawing.Size(229, 21);
            this.cbo_nhomnguoidung.TabIndex = 7;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.groupBox1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(701, 452);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // frmPhanQuyenNguoiSuDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 472);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmPhanQuyenNguoiSuDung";
            this.Text = "frmPhanQuyenNguoiSuDung";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nguoidungnhomnguoidung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Nguoidung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLayra;
        private System.Windows.Forms.Button btnThemvao;
        private System.Windows.Forms.DataGridView dgv_nguoidungnhomnguoidung;
        private System.Windows.Forms.DataGridView dgv_Nguoidung;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_nhomnguoidung;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}
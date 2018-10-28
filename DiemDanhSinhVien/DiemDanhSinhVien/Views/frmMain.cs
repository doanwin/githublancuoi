using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DiemDanhSinhVien.ClassXuLy;
using DiemDanhSinhVien.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;

namespace DiemDanhSinhVien
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        BLL_DM_ManHinh manhinh = new BLL_DM_ManHinh();
        private DTO_NguoiDung nguoiDung;

        public DTO_NguoiDung NguoiDung
        {
            get { return nguoiDung; }
            set { nguoiDung = value; }
        }
        public frmMain(DTO_NguoiDung nguoiDung)
        {
            InitializeComponent();
            this.NguoiDung = nguoiDung;
        }


        private void btnPhanQuyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var from = new frmPhanquyennguoidung();
            if (ExistForm(from))
                return;
            from.MdiParent = this;
            from.Show();
        }
        private void btnDSCahoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new frmCaHoc();

            if (ExistForm(form))
                return;

            form.MdiParent = this;
            form.Show();
        }
        public bool ExistForm(Form form)
        {
            foreach (var child in MdiChildren)
            {
                if(child.Name==form.Name)
                {
                    child.Activate();
                    return true;
                }
            }
            return false;
        }

        private void btnTheodoidiemdanh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form1 = new frmDiemdanh();
            if (ExistForm(form1))
                return;
            form1.MdiParent = this;
            form1.Show();
        }

        private void btnChitietgiangvien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form1 = new frmGiaoVien();
            if (ExistForm(form1))
                return;
            form1.MdiParent = this;
            form1.Show();
        }

        private void btnChitietSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form1 = new frmSinhVien();
            if (ExistForm(form1))
                return;
            form1.MdiParent = this;
            form1.Show();
        }

        private void btnBaocaotinhtrang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form1 = new frmBaoCaoTinhTrang();
            if (ExistForm(form1))
                return;
            form1.MdiParent = this;
            form1.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            stt_ngaygio.Caption = DateTime.Now.ToString();
            stt_user.Caption = "Xin chào, " + NguoiDung.TenDangNhap;
        }
        private void btnDanhsachlophoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form1 = new frmLopMonHoc();
            if (ExistForm(form1))
                return;
            form1.MdiParent = this;
            form1.Show();
        }
    }
}

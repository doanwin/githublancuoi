using DevExpress.XtraEditors;
using DiemDanhSinhVien.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DiemDanhSinhVien
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void tabHienThi_Click(object sender, EventArgs e)
        {

        }

        private void btnPhanQuyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var from = new frmPhanQuyenNguoiSuDung();
            if (ExistForm(from))
                return;
            from.MdiParent = this;
            from.Show();
        }

       /* private Form KiemTraTonTai(Type fType)
        {
            foreach(Form f in this.MdiChildren)
            {
                if (f.GetType() == fType)
                {
                    return f;
                }
            }
            return null;
        }*/
        private void btnDSCahoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           /* Form frm = this.KiemTraTonTai(typeof(frmCaHoc));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmCaHoc f = new frmCaHoc();
                f.MdiParent = this;
                f.Show();
            }*/
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
    }
}

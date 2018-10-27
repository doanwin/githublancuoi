using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiemDanhSinhVien.Views
{
    public partial class frmGiaoVien : Form
    {
        public frmGiaoVien()
        {
            InitializeComponent();
        }

        private void gIANGVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gIANGVIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qldiemdanhsvDataSet);

        }

        private void gIANGVIENBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.gIANGVIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qldiemdanhsvDataSet);

        }

        private void frmGiaoVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qldiemdanhsvDataSet.GIANGVIEN' table. You can move, or remove it, as needed.
            this.gIANGVIENTableAdapter.Fill(this.qldiemdanhsvDataSet.GIANGVIEN);

        }

       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiemDanhSinhVien.ClassXuLy
{
    public class DAONguoiDung
    {
        private string tenDangNhap, matKhau;

        public string TenDangNhap
        {
            get { return tenDangNhap; }
            set { tenDangNhap = value; }
        }

        public string MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }


        private bool hoatdong;

        public bool Hoatdong
        {
            get { return hoatdong; }
            set { hoatdong = value; }
        }
        public DAONguoiDung()
        { }
    }
}

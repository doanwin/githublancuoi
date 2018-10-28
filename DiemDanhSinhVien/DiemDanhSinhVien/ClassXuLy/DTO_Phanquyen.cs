using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiemDanhSinhVien.ClassXuLy
{
    public class DTO_Phanquyen
    {
        private string maManHinh, maNhom;

        public string MaNhom
        {
            get { return maNhom; }
            set { maNhom = value; }
        }

        public string MaManHinh
        {
            get { return maManHinh; }
            set { maManHinh = value; }
        }
        private bool coQuyen;

        public bool CoQuyen
        {
            get { return coQuyen; }
            set { coQuyen = value; }
        }
    }
}

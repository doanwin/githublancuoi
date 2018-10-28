using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.qldiemdanhsvTableAdapters;
using System.Data;

namespace DAL
{
    public class DAL_QuyenChucNang
    {
        QuyenChucNangTableAdapter atp_quyenchucnang = new QuyenChucNangTableAdapter();
        public DataTable GetDataQuyenChucNang()
        {
            return atp_quyenchucnang.GetData();
        }
    }
}

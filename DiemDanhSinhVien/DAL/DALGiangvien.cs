using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.qldiemdanhsvTableAdapters;
using System.Data;

namespace DAL
{
    public class DALGiangvien
    {
        GIANGVIENTableAdapter atp_gv = new GIANGVIENTableAdapter();
        public DataTable GetData()
        {
            return atp_gv.GetData();
        }
    }
}

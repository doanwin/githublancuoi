using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.qldiemdanhsvTableAdapters;
using System.Data;

namespace DAL
{
    public class DALSinhvien
    {
        SINHVIENTableAdapter atp_sinhvien = new SINHVIENTableAdapter();
        public DataTable load()
        {
            return atp_sinhvien.GetData();
        }
    }
}

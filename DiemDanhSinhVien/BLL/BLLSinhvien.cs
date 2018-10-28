using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class BLLSinhvien
    {
        DALSinhvien sv = new DALSinhvien();
        public DataTable load()
        {
            return sv.load();
        }
    }
}

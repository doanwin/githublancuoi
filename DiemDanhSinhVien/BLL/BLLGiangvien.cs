﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class BLLGiangvien
    {
        DALGiangvien gv = new DALGiangvien();

        public DataTable GetData()
        {
            return gv.GetData();
        }
    }
}

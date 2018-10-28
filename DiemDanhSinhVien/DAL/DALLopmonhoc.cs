using DAL.qldiemdanhsvTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALLopmonhoc
    {
        LOPMONHOCTableAdapter mh = new LOPMONHOCTableAdapter();

        public DataTable load()
        {
            return mh.GetData();
        }
    }
}

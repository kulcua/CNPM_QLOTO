using QLOTDAL;
using QLOTDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLOTBUS
{
    public class TienCongBUS
    {
        private TienCongDAL tcDal;
        public TienCongBUS()
        {
            tcDal = new TienCongDAL();
        }
        public bool them(TienCongDTO tc)
        {
            bool re = tcDal.them(tc);
            return re;
        }

        public bool xoa(TienCongDTO tc)
        {
            bool re = tcDal.xoa(tc);
            return re;
        }


        public bool sua(TienCongDTO tc)
        {
            bool re = tcDal.sua(tc);
            return re;
        }
        public List<TienCongDTO> select()
        {
            return tcDal.select();
        }
    }
}

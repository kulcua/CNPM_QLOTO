using QLOTDAL;
using QLOTDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLOTBUS
{
    public class ThoiGianBUS
    {
        private ThoiGianDAL tgDal;
        public ThoiGianBUS()
        {
           tgDal  = new ThoiGianDAL();
        }

        public List<ThoiGianDTO> select()
        {
            return tgDal.select();
        }
    }
}

using QLOTDAL;
using QLOTDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLOTBUS
{
    public class ThayDoiQuyDinhBUS
    {
        public ThayDoiQuyDinhDAL tdqdDal;
        public ThayDoiQuyDinhBUS()
        {
            tdqdDal = new ThayDoiQuyDinhDAL();
        }

        public bool ThayDoiQD(ThayDoiQuyDinhDTO tdqd)
        {
            bool re = tdqdDal.ThayDoiQD(tdqd);
            return re;
        }
        public ThayDoiQuyDinhDTO select()
        {
            return tdqdDal.select();
        }
    }
}

using QLOTDAL;
using QLOTDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLOTBUS
{
    public class HieuXeBUS
    {
        private HieuXeDAL hxDal;
        public HieuXeBUS()
        {
            hxDal = new HieuXeDAL();
        }

        public bool them(HieuXeDTO hx)
        {
            bool re = hxDal.them(hx);
            return re;
        }

        public bool xoa(HieuXeDTO hx)
        {
            bool re = hxDal.xoa(hx);
            return re;
        }


        public bool sua(HieuXeDTO hx)
        {
            bool re = hxDal.sua(hx);
            return re;
        }

        public List<HieuXeDTO> select()
        {
            return hxDal.select();
        }

        public List<HieuXeDTO> selectByKeyWord(string sKwThoiGian)
        {
            return hxDal.selectByKeyWord(sKwThoiGian);
        }
    }
}

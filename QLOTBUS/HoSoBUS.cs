using QLOTDAL;
using QLOTDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLOTBUS
{
    public class HoSoBUS
    {
        public HoSoDAL hsDal;
        public HoSoBUS()
        {
            hsDal = new HoSoDAL();
        }
        public bool them(HoSoDTO hs)
        {
            bool re = hsDal.them(hs);
            return re;
        }

        public bool xoa(HoSoDTO hs)
        {
            bool re = hsDal.xoa(hs);
            return re;
        }


        public bool sua(HoSoDTO hs)
        {
            bool re = hsDal.sua(hs);
            return re;
        }

        public List<HoSoDTO> select()
        {
            return hsDal.select();
        }

        public List<HoSoDTO> selectByKeyWord(string sKwBienSo, string sKwHieuXe, string sKwChuxe, string sKwMaHoSo, string sKwDienthoai)
        {
            return hsDal.selectByKeyWord(sKwBienSo, sKwHieuXe, sKwChuxe, sKwMaHoSo, sKwDienthoai);
        }
    }

}

using QLOTDAL;
using QLOTDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLOTBUS
{
    public class ChiTietPhieuXuatBUS
    {
        public ChiTietPhieuXuatDAL ctpxDal;
        public ChiTietPhieuXuatBUS()
        {
            ctpxDal = new ChiTietPhieuXuatDAL();
        }
        public bool them(ChiTietPhieuXuatDTO ctpx)
        {
            bool re = ctpxDal.them(ctpx);
            return re;
        }

        public bool xoa(ChiTietPhieuXuatDTO ctpx)
        {
            bool re = ctpxDal.xoa(ctpx);
            return re;
        }


        public bool sua(ChiTietPhieuXuatDTO ctpx)
        {
            bool re = ctpxDal.sua(ctpx);
            return re;
        }

        public List<ChiTietPhieuXuatDTO> select(string sKmahs)
        {
            return ctpxDal.select(sKmahs);
        }
    }

}


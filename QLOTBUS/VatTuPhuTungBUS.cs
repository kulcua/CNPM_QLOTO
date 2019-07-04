using QLOTDAL;
using QLOTDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLOTBUS
{
    public class VatTuPhuTungBUS
    {
        private VatTuPhuTungDAL vtptDal;
        public VatTuPhuTungBUS()
        {
            vtptDal = new VatTuPhuTungDAL();
        }

        public List<VatTuPhuTungDTO> select()
        {
            return vtptDal.select();
        }

        public List<VatTuPhuTungDTO> select_ton()
        {
            return vtptDal.select_ton();
        }

        public List<VatTuPhuTungDTO> select_het()
        {
            return vtptDal.select_het();
        }

        public bool them(VatTuPhuTungDTO vtpt)
        {
            bool re = vtptDal.them(vtpt);
            return re;
        }

        public bool xoa(VatTuPhuTungDTO vtpt)
        {
            bool re = vtptDal.xoa(vtpt);
            return re;
        }


        public bool sua(VatTuPhuTungDTO vtpt)
        {
            bool re = vtptDal.sua(vtpt);
            return re;
        }

        //public bool rangbuoc(VatTuPhuTungDTO vtpt)
        //{
        //    bool re = vtptDal.rangbuoc(vtpt);
        //    return re;
        //}
    }
}

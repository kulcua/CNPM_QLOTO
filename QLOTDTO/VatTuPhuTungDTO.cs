using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLOTDTO
{
    public class VatTuPhuTungDTO
    {
        private int maloaivattu;
        private string tenloaivattu;
        private int soluongton;
        private int dongia;

        public int Maloaivattu { get => maloaivattu; set => maloaivattu = value; }
        public string Tenloaivattu { get => tenloaivattu; set => tenloaivattu = value; }
        public int Soluongton { get => soluongton; set => soluongton = value; }
        public int Dongia { get => dongia; set => dongia = value; }
    }
}

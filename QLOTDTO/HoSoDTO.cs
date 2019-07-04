using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace QLOTDTO
{
    public class HoSoDTO
    {
        private string ten;
        private string diachi;
        private string bienso;
        private int dienthoai;
        private int hieuxe;
        private string tenhieuxe;
        private DateTime ngaytiepnhan;
        private int mahs;
        private int tongtien;

        public string Ten { get => ten; set => ten = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Bienso { get => bienso; set => bienso = value; }
        public int Dienthoai { get => dienthoai; set => dienthoai = value; }
        public int Hieuxe { get => hieuxe; set => hieuxe = value; }
        public DateTime Ngaytiepnhan { get => ngaytiepnhan; set => ngaytiepnhan = value; }
        public int Mahs { get => mahs; set => mahs = value; }
        public string Tenhieuxe { get => tenhieuxe; set => tenhieuxe = value; }
        public int Tongtien { get => tongtien; set => tongtien = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLOTDTO
{
    public class HieuXeDTO
    {
        private int mahieuxe;
        private string tenhieuxe;
        private int soluotsua;
        private int thanhtien;
        public int Mahieuxe { get => mahieuxe; set => mahieuxe = value; }
        public string Tenhieuxe { get => tenhieuxe; set => tenhieuxe = value; }
        public int Soluotsua { get => soluotsua; set => soluotsua = value; }
        public int Thanhtien { get => thanhtien; set => thanhtien = value; }
    }
}

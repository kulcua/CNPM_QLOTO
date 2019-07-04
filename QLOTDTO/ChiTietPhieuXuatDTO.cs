using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLOTDTO
{
    public class ChiTietPhieuXuatDTO
    {
        private int mactpx;
        private int mavtpt;
        private int mahs;
        private string nd;
        private int soluong;
        private int dongia;
        private int maloaitc;
        private int tiencong;
        private string tenloaitc;
        private string vtpt; 
        private int thanhtien;
        private string bienso;
        private DateTime ngaysuachua;

        public int Mactpx { get => mactpx; set => mactpx = value; }
        public int Mavtpt { get => mavtpt; set => mavtpt = value; }
        public string Nd { get => nd; set => nd = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public int Dongia { get => dongia; set => dongia = value; }
        public int Maloaitc { get => maloaitc; set => maloaitc = value; }
        public string Bienso { get => bienso; set => bienso = value; }
        public DateTime Ngaysuachua { get => ngaysuachua; set => ngaysuachua = value; }
        public int Tiencong { get => tiencong; set => tiencong = value; }
        public string Vtpt { get => vtpt; set => vtpt = value; }
        public int Thanhtien { get => thanhtien; set => thanhtien = value; }
        public int Mahs { get => mahs; set => mahs = value; }
        public string Tenloaitc { get => tenloaitc; set => tenloaitc = value; }
    }
}

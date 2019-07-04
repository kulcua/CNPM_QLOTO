using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLOTDTO
{
    public class TienCongDTO
    {
        private int maloaitiencong;
        private int tiencong;
        private string tenloaitiencong;
        public int Maloaitiencong { get => maloaitiencong; set => maloaitiencong = value; }
        public int Tiencong { get => tiencong; set => tiencong = value; }
        public string Tenloaitiencong { get => tenloaitiencong; set => tenloaitiencong = value; }
    }
}

using QLOTBUS;
using QLOTDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmPhieuThuTien : Form
    {

        private HoSoDTO hsDTO = null;
        private HoSoBUS hsBus;
        private ChiTietPhieuXuatBUS ctpxBus;
        public frmPhieuThuTien()
        {
            InitializeComponent();
        }

        public frmPhieuThuTien(HoSoDTO hs)
        {
            hsBus = new HoSoBUS();
            this.hsDTO = hs;
            InitializeComponent();
        }

        private void frmPhieuThuTien_Load(object sender, EventArgs e)
        {
            if (this.hsDTO != null)
            {
                tb_bienso.Text = hsDTO.Bienso.ToString();
                tb_diachi.Text = hsDTO.Diachi.ToString();
                tb_dienthoai.Text = hsDTO.Dienthoai.ToString();
                tb_tenchuxe.Text = hsDTO.Ten.ToString();
            }
            




        }
    }
}

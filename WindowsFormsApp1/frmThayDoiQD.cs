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
    public partial class frmThayDoiQD : Form
    {
        private ThayDoiQuyDinhBUS thaydoiBus = new ThayDoiQuyDinhBUS();
        public frmThayDoiQD()
        {
            InitializeComponent();           
        }

        private void bt_luu_Click(object sender, EventArgs e)
        {
            
            ThayDoiQuyDinhDTO thaydoi = new ThayDoiQuyDinhDTO();
            thaydoi.SoLuongHieuXe1 = int.Parse(tb_sohieuxe.Text);
            thaydoi.SoLuongSuaChuaToiDa1 = int.Parse(tb_max_xe.Text);
            thaydoi.SoLoaiTienCong1 = int.Parse(tb_sotiencong.Text);
            thaydoi.SoLoaiVTPT1 = int.Parse(tb_sovattu.Text);

            //2. Kiểm tra data hợp lệ or not

            //3. Thêm vào DB
            bool kq = thaydoiBus.ThayDoiQD(thaydoi);
            if (kq == false)
                MessageBox.Show("Thất bại. Vui lòng kiểm tra lại dữ liệu");
            else
            {
                MessageBox.Show("Thành công");
            }
            loadData_Vao_Textbox();
        }
        private void frmThayDoiQD_Load(object sender, EventArgs e)
        {
            loadData_Vao_Textbox();           
        }
        private void loadData_Vao_Textbox()
        {           
            ThayDoiQuyDinhDTO thaydoi = thaydoiBus.select();
            if (thaydoi == null)
            {
                MessageBox.Show("Có lỗi khi lấy DB");
                return;
            }
            tb_sohieuxe.Text = thaydoi.SoLuongHieuXe1.ToString();
            tb_max_xe.Text = thaydoi.SoLuongSuaChuaToiDa1.ToString();
            tb_sotiencong.Text = thaydoi.SoLoaiTienCong1.ToString();
            tb_sovattu.Text = thaydoi.SoLoaiVTPT1.ToString();
        }
    }
}

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
    public partial class frmTraCuuXe : Form
    {
        private HoSoBUS hsBus;
        private HieuXeBUS hxBus;
        public frmTraCuuXe()
        {
            InitializeComponent();
        }

        private void bt_lapphieuthutien_Click(object sender, EventArgs e)
        {
            int currentRowIndex = data_tracuu.CurrentCellAddress.Y;// 'current row selected


            //'Verify that indexing OK
            if (-1 < currentRowIndex && currentRowIndex < data_tracuu.RowCount)
            {
                HoSoDTO hs = (HoSoDTO)data_tracuu.Rows[currentRowIndex].DataBoundItem;
                if (hs != null)
                {
                    frmPhieuThuTien frm = new frmPhieuThuTien(hs);
                    frm.ShowDialog();
                }
            }
        }

        private void loadHieuXeVao_combobox()
        {
            List<HieuXeDTO> listHieuxe = hxBus.select();

            if (listHieuxe == null)
            {
                MessageBox.Show("Có lỗi khi lấy Hiệu Xe từ DB");
                return;
            }
            cb_hieuxe.DataSource = new BindingSource(listHieuxe, String.Empty);
            cb_hieuxe.DisplayMember = "tenhieuxe";
            cb_hieuxe.ValueMember = "mahieuxe";

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[cb_hieuxe.DataSource];
            myCurrencyManager.Refresh();

            if (cb_hieuxe.Items.Count > 0)
            {
                cb_hieuxe.SelectedIndex = 0;
            }
        }

        private void bt_tracuu_Click(object sender, EventArgs e)
        {
            string kw_bienso = tb_bienso.Text.Trim();
            string kw_hieuxe = cb_hieuxe.Text.Trim();
            string kw_chuxe = tb_chuxe.Text.Trim();
            string kw_dienthoai = tb_dienthoai.Text.Trim();
            string kw_ma = tb_ma.Text.Trim();
            if ((kw_bienso == null || kw_bienso == string.Empty || kw_bienso.Length == 0) && (kw_hieuxe == null || kw_hieuxe == string.Empty || kw_hieuxe.Length == 0) && (kw_chuxe == null || kw_chuxe == string.Empty || kw_chuxe.Length == 0) && (kw_dienthoai == null || kw_dienthoai == string.Empty || kw_dienthoai.Length == 0) && (kw_bienso == null || kw_bienso == string.Empty || kw_bienso.Length == 0) && (kw_ma == null || kw_ma == string.Empty || kw_ma.Length == 0)) // tìm tất cả
            {
                List<HoSoDTO> listHoSo = hsBus.select();
                this.loadData_Vao_GridView(listHoSo);
            }
            else
            {
                List<HoSoDTO> listHoso = hsBus.selectByKeyWord(kw_bienso, kw_hieuxe, kw_chuxe, kw_ma, kw_dienthoai);                
                this.loadData_Vao_GridView(listHoso);
            }
        }

        private void frmTraCuuXe_Load(object sender, EventArgs e)
        {
            hsBus = new HoSoBUS();
            hxBus = new HieuXeBUS();
            loadHieuXeVao_combobox();
        }

        private void loadData_Vao_GridView(List<HoSoDTO> listHoSo)
        {
            if (listHoSo == null)
            {
                MessageBox.Show("Có lỗi khi lấy DB");
                return;
            }

            data_tracuu.Columns.Clear();
            data_tracuu.DataSource = null;

            data_tracuu.AutoGenerateColumns = false;
            data_tracuu.AllowUserToAddRows = false;
            data_tracuu.DataSource = listHoSo;

            DataGridViewTextBoxColumn clMa = new DataGridViewTextBoxColumn();
            clMa.Name = "Mahs";
            clMa.HeaderText = "Mã hồ sơ";
            clMa.DataPropertyName = "Mahs";
            data_tracuu.Columns.Add(clMa);

            DataGridViewTextBoxColumn clTen = new DataGridViewTextBoxColumn();
            clTen.Name = "Ten";
            clTen.HeaderText = "Tên chủ xe";
            clTen.DataPropertyName = "Ten";
            data_tracuu.Columns.Add(clTen);

            DataGridViewTextBoxColumn clDiachi = new DataGridViewTextBoxColumn();
            clDiachi.Name = "Diachi";
            clDiachi.HeaderText = "Địa chỉ";
            clDiachi.DataPropertyName = "Diachi";
            data_tracuu.Columns.Add(clDiachi);

            DataGridViewTextBoxColumn clBienso = new DataGridViewTextBoxColumn();
            clBienso.Name = "Bienso";
            clBienso.HeaderText = "Biển số";
            clBienso.DataPropertyName = "Bienso";
            data_tracuu.Columns.Add(clBienso);

            DataGridViewTextBoxColumn clDienthoai = new DataGridViewTextBoxColumn();
            clDienthoai.Name = "Dienthoai";
            clDienthoai.HeaderText = "Điện thoại";
            clDienthoai.DataPropertyName = "Dienthoai";
            data_tracuu.Columns.Add(clDienthoai);

            DataGridViewTextBoxColumn clHieuxe = new DataGridViewTextBoxColumn();
            clHieuxe.Name = "Hieuxe";
            clHieuxe.HeaderText = "Hiệu xe";
            clHieuxe.DataPropertyName = "Tenhieuxe";
            data_tracuu.Columns.Add(clHieuxe);

            DataGridViewTextBoxColumn clNgaytiepnhan = new DataGridViewTextBoxColumn();
            clNgaytiepnhan.Name = "Ngaytiepnhan";
            clNgaytiepnhan.HeaderText = "Ngày tiếp nhận";
            clNgaytiepnhan.DataPropertyName = "Ngaytiepnhan";
            data_tracuu.Columns.Add(clNgaytiepnhan);

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[data_tracuu.DataSource];
            myCurrencyManager.Refresh();
        }

        private void data_tracuu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                
                DataGridViewRow row = this.data_tracuu.Rows[e.RowIndex];
                tb_bienso.Text = row.Cells["Bienso"].Value.ToString();
                tb_chuxe.Text = row.Cells["Ten"].Value.ToString();
                tb_ma.Text = row.Cells["Mahs"].Value.ToString();
                cb_hieuxe.Text = row.Cells["Hieuxe"].Value.ToString();
                tb_dienthoai.Text = row.Cells["Dienthoai"].Value.ToString();
            }
        }
    }
}

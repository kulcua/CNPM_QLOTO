using QLOTBUS;
using QLOTDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmPhieuSuaChua : Form
    {
        private VatTuPhuTungBUS vtptBus;
        private TienCongBUS tcBus;
        private HoSoDTO hsDTO = null;
        private HoSoBUS hsBus;
        private ChiTietPhieuXuatBUS ctpxBus;
        public frmPhieuSuaChua()
        {            
            InitializeComponent();
        }

        private void bt_luu_Click(object sender, EventArgs e)
        {
            if (check_null())
            {
                ChiTietPhieuXuatDTO ctpx = new ChiTietPhieuXuatDTO();              
                ctpx.Mactpx = int.Parse(tb_machitiet.Text);
                ctpx.Mahs = int.Parse(lb_mahs.Text);
                ctpx.Mavtpt = int.Parse(cb_vattu.SelectedValue.ToString());
                ctpx.Nd = tb_noidung.Text;
                ctpx.Soluong = int.Parse(tb_soluong.Text);
                ctpx.Dongia = int.Parse(tb_dongia.Text);
                ctpx.Maloaitc = int.Parse(cb_tiencong.SelectedValue.ToString());
                ctpx.Tiencong = int.Parse(tb_giatiencong.Text);
                ctpx.Thanhtien = ctpx.Tiencong + ctpx.Soluong * ctpx.Dongia;
                //ctpx.Thanhtien = int.Parse(tb_thanhtien.Text);
                ctpx.Bienso = tb_bienso.Text;
                ctpx.Ngaysuachua = time_ngaysuachua.Value;

                //2. Kiểm tra data hợp lệ or not
                
                //3. Thêm vào DB
                bool kq = ctpxBus.them(ctpx);
                if (kq == false)
                    MessageBox.Show("Thêm phiếu thất bại. Vui lòng kiểm tra lại dữ liệu");
                else
                {
                    MessageBox.Show("Thêm phiếu thành công");
                    this.loadData_Vao_GridView();
                }
                CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[data_suachua.DataSource];
                myCurrencyManager.Refresh();
            }          
        } 

        public frmPhieuSuaChua(HoSoDTO hs)
        {
            hsBus = new HoSoBUS();
            this.hsDTO = hs;
            InitializeComponent();
        }
      
        private void frmPhieuSuaChua_Load(object sender, EventArgs e)
        {
            vtptBus = new VatTuPhuTungBUS();
            tcBus = new TienCongBUS();
            ctpxBus = new ChiTietPhieuXuatBUS();
            loadVatTuPhuTung_combobox();
            loadTienCong_combobox();
            this.loadData_Vao_GridView();
            tb_machitiet.Clear();
            tb_noidung.Clear();
            tb_soluong.Clear();
            bt_sua.Enabled = false;
            bt_xoa.Enabled = false;
            tb_giatiencong.Clear();
            tb_dongia.Clear();
            cb_tiencong.Text = null;
            cb_vattu.Text = null;
            int mactpx = data_suachua.RowCount + 1;
            tb_machitiet.Text = mactpx.ToString();
            if (this.hsDTO != null)
            {
                lb_mahs.Text = hsDTO.Mahs.ToString();
                tb_bienso.Text = hsDTO.Bienso;
                time_ngaysuachua.Text = hsDTO.Ngaytiepnhan.ToString();
            }
        }
        private bool check_null()
        {
            if (string.IsNullOrEmpty(tb_machitiet.Text))
            {
                MessageBox.Show("Bạn chưa mã chi tiết");
                tb_machitiet.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(tb_soluong.Text))
            {
                MessageBox.Show("Bạn chưa nhập số lượng");
                tb_soluong.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(cb_vattu.Text))
            {
                MessageBox.Show("Bạn chưa chọn vật tư");
                cb_vattu.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(cb_tiencong.Text))
            {
                MessageBox.Show("Bạn chưa chọn tiền công");
                cb_tiencong.Focus();
                return false;
            }
            return true;

        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            if (check_null())
            {
                ChiTietPhieuXuatDTO ctpx = new ChiTietPhieuXuatDTO();
                ctpx.Mactpx = int.Parse(tb_machitiet.Text);
                ctpx.Mahs = int.Parse(lb_mahs.Text);
                ctpx.Mavtpt = int.Parse(cb_vattu.SelectedValue.ToString());
                ctpx.Nd = tb_noidung.Text;
                ctpx.Soluong = int.Parse(tb_soluong.Text);
                ctpx.Dongia = int.Parse(tb_dongia.Text);
                ctpx.Maloaitc = int.Parse(cb_tiencong.SelectedValue.ToString());
                ctpx.Tiencong = int.Parse(tb_giatiencong.Text);
                //ctpx.Vtpt = 
                ctpx.Thanhtien = ctpx.Tiencong + ctpx.Soluong * ctpx.Dongia;
                //tb_thanhtien.Text = ctpx.Thanhtien.ToString();
                ctpx.Bienso = tb_bienso.Text;
                ctpx.Ngaysuachua = time_ngaysuachua.Value;

                bool kq = ctpxBus.sua(ctpx);
                if (kq == false)
                    MessageBox.Show("Sửa phiếu thất bại. Vui lòng kiểm tra lại dữ liệu");
                else
                {
                    this.loadData_Vao_GridView();
                    MessageBox.Show("Sửa phiếu thành công");
                }
            }               
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            ChiTietPhieuXuatDTO ctpx = new ChiTietPhieuXuatDTO();
            ctpx.Mactpx = int.Parse(tb_machitiet.Text);
            //2. Kiểm tra data hợp lệ or not

            //3. Thêm vào DB
            bool kq = ctpxBus.xoa(ctpx);
            if (kq == false)
                MessageBox.Show("Xóa phiếu thất bại. Vui lòng kiểm tra lại dữ liệu");
            else
            {
                this.loadData_Vao_GridView();
                MessageBox.Show("Xóa phiếu thành công");
            }            
        }

        private void loadVatTuPhuTung_combobox()
        {
            List<VatTuPhuTungDTO> listVatTuPhuTung = vtptBus.select();

            if (listVatTuPhuTung == null)
            {
                MessageBox.Show("Có lỗi khi lấy Vật Tư Phụ Tùng từ DB");
                return;
            }
            cb_vattu.DataSource = new BindingSource(listVatTuPhuTung, String.Empty);
            cb_vattu.DisplayMember = "tenloaivattu";
            cb_vattu.ValueMember = "maloaivattu";
            tb_dongia.DataBindings.Clear();
            tb_dongia.DataBindings.Add("Text", cb_vattu.DataSource, "DonGia");
            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[cb_vattu.DataSource];
            myCurrencyManager.Refresh();

            if (cb_vattu.Items.Count > 0)
            {
                cb_vattu.SelectedIndex = 0;
            }
        }

        private void loadTienCong_combobox()
        {
            List<TienCongDTO> listTienCong = tcBus.select();

            if (listTienCong == null)
            {
                MessageBox.Show("Có lỗi khi lấy loại Tiền Công từ DB");
                return;
            }
            cb_tiencong.DataSource = new BindingSource(listTienCong, String.Empty);
            cb_tiencong.DisplayMember = "tenloaitiencong";
            cb_tiencong.ValueMember = "maloaitiencong";
            tb_giatiencong.DataBindings.Clear();
            tb_giatiencong.DataBindings.Add("Text", cb_tiencong.DataSource, "TienCong");
            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[cb_tiencong.DataSource];
            myCurrencyManager.Refresh();

            if (cb_tiencong.Items.Count > 0)
            {
                cb_tiencong.SelectedIndex = 0;
            }
        }

        private void loadData_Vao_GridView()
        {
            string sKmahs = hsDTO.Mahs.ToString();
            List<ChiTietPhieuXuatDTO> listChitietphieuxuat = ctpxBus.select(sKmahs);
            if (listChitietphieuxuat == null)
            {
                MessageBox.Show("Có lỗi khi lấy DB");
                return;
            }

            data_suachua.Columns.Clear();
            data_suachua.DataSource = null;

            data_suachua.AutoGenerateColumns = false;
            data_suachua.AllowUserToAddRows = false;
            data_suachua.DataSource = listChitietphieuxuat;

            DataGridViewTextBoxColumn clMa = new DataGridViewTextBoxColumn();
            clMa.Name = "Mactpx";
            clMa.HeaderText = "Mã CTPX";
            clMa.DataPropertyName = "Mactpx";
            data_suachua.Columns.Add(clMa);

            DataGridViewTextBoxColumn clMahs = new DataGridViewTextBoxColumn();
            clMahs.Name = "Mahs";
            clMahs.HeaderText = "Mã HS";
            clMahs.DataPropertyName = "Mahs";
            data_suachua.Columns.Add(clMahs);

            DataGridViewTextBoxColumn clBienso = new DataGridViewTextBoxColumn();
            clBienso.Name = "Bienso";
            clBienso.HeaderText = "Biển số xe";
            clBienso.DataPropertyName = "Bienso";
            data_suachua.Columns.Add(clBienso);

            DataGridViewTextBoxColumn clNoidung = new DataGridViewTextBoxColumn();
            clNoidung.Name = "Noidung";
            clNoidung.HeaderText = "Nội dung";
            clNoidung.DataPropertyName = "Nd";
            data_suachua.Columns.Add(clNoidung);

            DataGridViewTextBoxColumn clVattuphutung = new DataGridViewTextBoxColumn();
            clVattuphutung.Name = "Vtpt";
            clVattuphutung.HeaderText = "Vật tư phụ tùng";
            clVattuphutung.DataPropertyName = "Vtpt";
            data_suachua.Columns.Add(clVattuphutung);

            DataGridViewTextBoxColumn clSoluong = new DataGridViewTextBoxColumn();
            clSoluong.Name = "Soluong";
            clSoluong.HeaderText = "Số lượng";
            clSoluong.DataPropertyName = "Soluong";
            data_suachua.Columns.Add(clSoluong);

            DataGridViewTextBoxColumn clDongia = new DataGridViewTextBoxColumn();
            clDongia.Name = "Dongia";
            clDongia.HeaderText = "Đơn giá";
            clDongia.DataPropertyName = "Dongia";
            data_suachua.Columns.Add(clDongia);

            DataGridViewTextBoxColumn clTCong = new DataGridViewTextBoxColumn();
            clTCong.Name = "Tenloaitc";
            clTCong.HeaderText = "Công";
            clTCong.DataPropertyName = "Tenloaitc";
            data_suachua.Columns.Add(clTCong);

            DataGridViewTextBoxColumn clTiencong = new DataGridViewTextBoxColumn();
            clTiencong.Name = "Tiencong";
            clTiencong.HeaderText = "Tiền công";
            clTiencong.DataPropertyName = "Tiencong";
            data_suachua.Columns.Add(clTiencong);

            DataGridViewTextBoxColumn clThanhtien = new DataGridViewTextBoxColumn();
            clThanhtien.Name = "Thanhtien";
            clThanhtien.HeaderText = "Thành tiền";
            clThanhtien.DataPropertyName = "Thanhtien";
            data_suachua.Columns.Add(clThanhtien);

            DataGridViewTextBoxColumn clNgaytiepnhan = new DataGridViewTextBoxColumn();
            clNgaytiepnhan.Name = "Ngaysuachua";
            clNgaytiepnhan.HeaderText = "Ngày sửa chữa";
            clNgaytiepnhan.DataPropertyName = "Ngaysuachua";
            data_suachua.Columns.Add(clNgaytiepnhan);

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[data_suachua.DataSource];
            myCurrencyManager.Refresh();
        }

        private void data_suachua_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                bt_xoa.Enabled = true;
                bt_sua.Enabled = true;
                bt_luu.Enabled = false;
                DataGridViewRow row = this.data_suachua.Rows[e.RowIndex];
                tb_bienso.Text = row.Cells["Bienso"].Value.ToString();
                tb_dongia.Text = row.Cells["Dongia"].Value.ToString();
                tb_noidung.Text = row.Cells["Noidung"].Value.ToString();
                time_ngaysuachua.Text = row.Cells["Ngaysuachua"].Value.ToString();
                cb_vattu.Text = row.Cells["Vtpt"].Value.ToString();
                cb_tiencong.Text = row.Cells["Tenloaitc"].Value.ToString();
                tb_giatiencong.Text = row.Cells["Tiencong"].Value.ToString();
                tb_soluong.Text = row.Cells["Soluong"].Value.ToString();
                tb_thanhtien.Text = row.Cells["Thanhtien"].Value.ToString();
                tb_machitiet.Text = row.Cells["Mactpx"].Value.ToString();
            }
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            tb_noidung.Clear();
            tb_soluong.Clear();
            tb_thanhtien.Clear();
            tb_giatiencong.Clear();
            tb_dongia.Clear();
            cb_tiencong.Text = null;
            cb_vattu.Text = null;
            bt_xoa.Enabled = false;
            bt_sua.Enabled = false;
            bt_luu.Enabled = true;
            int mactpx = data_suachua.RowCount + 1;
            tb_machitiet.Text = mactpx.ToString();         
        }

        private void cb_tiencong_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int sl, tc, dg;
            //sl = int.Parse(tb_soluong.Text);
            //tc = int.Parse(tb_giatiencong.Text);
            //dg = int.Parse(tb_dongia.Text);
            //int thanhtien = sl * dg + tc;
            //tb_thanhtien.Text = thanhtien.ToString();
            //tb_thanhtien.Text = (int.Parse(tb_giatiencong.Text) + int.Parse(tb_soluong.Text) * int.Parse(tb_dongia.Text)).ToString();
        }

        private void cb_vattu_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int sl, tc, dg;
            //sl = int.Parse(tb_soluong.Text);
            //tc = int.Parse(tb_giatiencong.Text);
            //dg = int.Parse(tb_dongia.Text);
            //int thanhtien = sl * dg + tc;
            //tb_thanhtien.Text = thanhtien.ToString();
        }
    }
}

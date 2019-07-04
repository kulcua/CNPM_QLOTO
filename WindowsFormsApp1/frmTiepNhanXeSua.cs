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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmTiepNhanXeSua : Form
    {       
        private HoSoBUS hsBus;
        private HieuXeBUS hxBus;
        public frmTiepNhanXeSua()
        {
            InitializeComponent();
        }

        private void frmTiepNhanXeSua_Load(object sender, EventArgs e)
        {
            hsBus = new HoSoBUS();
            hxBus = new HieuXeBUS();
            loadHieuXeVao_combobox();
            this.loadData_Vao_GridView();
            bt_sua.Enabled = false;
            bt_xoa.Enabled = false;
            cb_hieuxe.Text = "";
            int mahs = data_tiepnhan.RowCount + 1;
            tb_ma.Text = mahs.ToString();
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            if (check_null())
            {
                HoSoDTO hs = new HoSoDTO();
                hs.Mahs = int.Parse(tb_ma.Text);
                hs.Ten = tb_tenchuxe.Text;
                hs.Diachi = tb_diachi.Text;
                hs.Bienso = tb_bienso.Text;
                hs.Dienthoai = int.Parse(tb_dienthoai.Text);
                hs.Hieuxe = int.Parse(cb_hieuxe.SelectedValue.ToString());
                hs.Ngaytiepnhan = time_ngaytiepnhan.Value;

                //2. Kiểm tra data hợp lệ or not

                //3. Thêm vào DB
                bool kq = hsBus.sua(hs);
                if (kq == false)
                    MessageBox.Show("Sửa hồ sơ thất bại. Vui lòng kiểm tra lại dữ liệu");
                else
                {
                    MessageBox.Show("Sửa hồ sơ thành công");
                    this.loadData_Vao_GridView();
                }
                CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[data_tiepnhan.DataSource];
                myCurrencyManager.Refresh();
            }
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            int currentRowIndex = data_tiepnhan.CurrentCellAddress.Y;// 'current row selected
            //'Verify that indexing OK
            if (-1 < currentRowIndex && currentRowIndex < data_tiepnhan.RowCount)
            {
                HoSoDTO hs = new HoSoDTO();
                hs.Mahs = int.Parse(tb_ma.Text);

                //2. Kiểm tra data hợp lệ or not

                //3. Thêm vào DB
                bool kq = hsBus.xoa(hs);
                if (kq == false)
                    MessageBox.Show("Xóa hồ sơ thất bại. Vui lòng kiểm tra lại dũ liệu");
                else
                {
                    MessageBox.Show("Xóa hồ sơ thành công");
                    this.loadData_Vao_GridView();
                }
            }
            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[data_tiepnhan.DataSource];
            myCurrencyManager.Refresh();
        }

        private void bt_luu_Click(object sender, EventArgs e)
        {
            if(check_null())
            {
                HoSoDTO hs = new HoSoDTO();
                hs.Mahs = int.Parse(tb_ma.Text);
                hs.Ten = tb_tenchuxe.Text;
                hs.Diachi = tb_diachi.Text;
                hs.Bienso = tb_bienso.Text;
                hs.Dienthoai = int.Parse(tb_dienthoai.Text);
                hs.Hieuxe = int.Parse(cb_hieuxe.SelectedValue.ToString());
                hs.Ngaytiepnhan = time_ngaytiepnhan.Value;

                //2. Kiểm tra data hợp lệ or not

                //3. Thêm vào DB
                bool kq = hsBus.them(hs);
                if (kq == false)
                    MessageBox.Show("Thêm hồ sơ thất bại. Vui lòng kiểm tra lại dữ liệu");
                else
                {
                    MessageBox.Show("Thêm hồ sơ thành công");
                    this.loadData_Vao_GridView();
                }
                CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[data_tiepnhan.DataSource];
                myCurrencyManager.Refresh();
            }
            
        }

        private void bt_lapphieusuachua_Click(object sender, EventArgs e)
        {
            //frmPhieuSuaChua frm = new frmPhieuSuaChua();
            //frm.MdiParent = this;
            //frm.Show();//
            int currentRowIndex = data_tiepnhan.CurrentCellAddress.Y;// 'current row selected


            //'Verify that indexing OK
            if (-1 < currentRowIndex && currentRowIndex < data_tiepnhan.RowCount)
            {
                HoSoDTO hs = (HoSoDTO)data_tiepnhan.Rows[currentRowIndex].DataBoundItem;
                if (hs != null)
                {
                    frmPhieuSuaChua frm = new frmPhieuSuaChua(hs);
                    frm.ShowDialog();
                }
            }
        }

        private void traCứuToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frmTraCuuXe frm = new frmTraCuuXe();
            frm.Show();
        }

        private void doanhSốToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBCDoanhSo frm = new frmBCDoanhSo();
            frm.Show();
        }

        private void báoCáoTồnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBCTon frm = new frmBCTon();
            frm.Show();
        }

        private void thayĐổiQuyĐịnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThayDoiQD frm = new frmThayDoiQD();
            frm.Show();
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
        private void loadData_Vao_GridView()
        {
            List<HoSoDTO> listHoSo = hsBus.select();
            if (listHoSo == null)
            {
                MessageBox.Show("Có lỗi khi lấy DB");
                return;
            }

            data_tiepnhan.Columns.Clear();
            data_tiepnhan.DataSource = null;

            data_tiepnhan.AutoGenerateColumns = false;
            data_tiepnhan.AllowUserToAddRows = false;
            data_tiepnhan.DataSource = listHoSo;

            DataGridViewTextBoxColumn clMa = new DataGridViewTextBoxColumn();
            clMa.Name = "Mahs";
            clMa.HeaderText = "Mã hồ sơ";
            clMa.DataPropertyName = "Mahs";
            data_tiepnhan.Columns.Add(clMa);

            DataGridViewTextBoxColumn clTen = new DataGridViewTextBoxColumn();
            clTen.Name = "Ten";
            clTen.HeaderText = "Tên chủ xe";
            clTen.DataPropertyName = "Ten";
            data_tiepnhan.Columns.Add(clTen);

            DataGridViewTextBoxColumn clDiachi = new DataGridViewTextBoxColumn();
            clDiachi.Name = "Diachi";
            clDiachi.HeaderText = "Địa chỉ";
            clDiachi.DataPropertyName = "Diachi";
            data_tiepnhan.Columns.Add(clDiachi);

            DataGridViewTextBoxColumn clBienso = new DataGridViewTextBoxColumn();
            clBienso.Name = "Bienso";
            clBienso.HeaderText = "Biển số";
            clBienso.DataPropertyName = "Bienso";
            data_tiepnhan.Columns.Add(clBienso);

            DataGridViewTextBoxColumn clDienthoai = new DataGridViewTextBoxColumn();
            clDienthoai.Name = "Dienthoai";
            clDienthoai.HeaderText = "Điện thoại";
            clDienthoai.DataPropertyName = "Dienthoai";
            data_tiepnhan.Columns.Add(clDienthoai);

            DataGridViewTextBoxColumn clHieuxe = new DataGridViewTextBoxColumn();
            clHieuxe.Name = "Hieuxe";
            clHieuxe.HeaderText = "Hiệu xe";
            clHieuxe.DataPropertyName = "Tenhieuxe";
            data_tiepnhan.Columns.Add(clHieuxe);

            DataGridViewTextBoxColumn clNgaytiepnhan = new DataGridViewTextBoxColumn();
            clNgaytiepnhan.Name = "Ngaytiepnhan";
            clNgaytiepnhan.HeaderText = "Ngày tiếp nhận";
            clNgaytiepnhan.DataPropertyName = "Ngaytiepnhan";
            data_tiepnhan.Columns.Add(clNgaytiepnhan);

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[data_tiepnhan.DataSource];
            myCurrencyManager.Refresh();
        }

        private void data_tiepnhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                if (e.RowIndex >= 0)
                {
                    bt_xoa.Enabled = true;
                    bt_sua.Enabled = true;
                    bt_luu.Enabled = false;
                    DataGridViewRow row = this.data_tiepnhan.Rows[e.RowIndex];
                    tb_ma.Text = row.Cells["Mahs"].Value.ToString();
                    tb_tenchuxe.Text = row.Cells["Ten"].Value.ToString();
                    tb_bienso.Text = row.Cells["Bienso"].Value.ToString();
                    tb_diachi.Text = row.Cells["Diachi"].Value.ToString();
                    tb_dienthoai.Text = row.Cells["Dienthoai"].Value.ToString();
                    time_ngaytiepnhan.Text = row.Cells["Ngaytiepnhan"].Value.ToString();
                    cb_hieuxe.Text = row.Cells["Hieuxe"].Value.ToString();
                }
        }

        private void quảnLýHiệuXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyHieuXe frm = new frmQuanLyHieuXe();
            frm.Show();
        }

        private void quảnLýVTPTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyVTPT frm = new frmQuanLyVTPT();
            frm.Show();
        }

        private bool check_null()
        {
            if (string.IsNullOrEmpty(tb_tenchuxe.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên chủ xe");
                tb_tenchuxe.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(tb_ma.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã hồ sơ");
                tb_ma.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(tb_diachi.Text))
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ");
                tb_diachi.Focus();
                return false;
            }
            
            if (string.IsNullOrEmpty(tb_dienthoai.Text))
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại");
                tb_dienthoai.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(tb_bienso.Text))
            {
                MessageBox.Show("Bạn chưa nhập biển số");
                tb_bienso.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(cb_hieuxe.Text))
            {
                MessageBox.Show("Bạn chưa chọn hiệu xe");
                cb_hieuxe.Focus();
                return false;
            }
            return true;
       
        }

        private void quảnLýTiềnCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyTienCong frm = new frmQuanLyTienCong();
            frm.Show();
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            tb_bienso.Clear();
            tb_diachi.Clear();
            tb_dienthoai.Clear();
            tb_tenchuxe.Clear();
            cb_hieuxe.Text = null;
            bt_xoa.Enabled = false;
            bt_sua.Enabled = false;
            bt_luu.Enabled = true;
            int mahs = data_tiepnhan.RowCount + 1;
            tb_ma.Text = mahs.ToString();
        }
    }
}

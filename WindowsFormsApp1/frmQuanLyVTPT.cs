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
    public partial class frmQuanLyVTPT : Form
    {
        private VatTuPhuTungBUS vtptBus;
        private ThayDoiQuyDinhBUS thaydoiBus = new ThayDoiQuyDinhBUS();
        public frmQuanLyVTPT()
        {
            InitializeComponent();
        }

        private void bt_luu_Click(object sender, EventArgs e)
        {
            if(check_null())
            {
                ThayDoiQuyDinhDTO thaydoi = thaydoiBus.select();
                int line = data_vtpt.RowCount;
                if (line < thaydoi.SoLoaiVTPT1)
                {
                    VatTuPhuTungDTO vtpt = new VatTuPhuTungDTO();
                    vtpt.Maloaivattu = int.Parse(tb_mavtpt.Text);
                    vtpt.Tenloaivattu = tb_tenvtpt.Text;
                    vtpt.Soluongton = int.Parse(tb_soluongton.Text);
                    vtpt.Dongia = int.Parse(tb_dongia.Text);

                    bool kq = vtptBus.them(vtpt);
                    if (kq == false)
                        MessageBox.Show("Thêm vật tư phụ tùng thất bại. Vui lòng kiểm tra lại dữ liệu");
                    else
                    {
                        MessageBox.Show("Thêm vật tư phụ tùng thành công");
                        this.loadData_Vao_GridView();
                    }
                    CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[data_vtpt.DataSource];
                    myCurrencyManager.Refresh();
                }
                else
                    MessageBox.Show("Vượt quá số vtpt cho phép");
            }
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            if(check_null())
            {
                VatTuPhuTungDTO vtpt = new VatTuPhuTungDTO();
                vtpt.Maloaivattu = int.Parse(tb_mavtpt.Text);
                vtpt.Tenloaivattu = tb_tenvtpt.Text;
                vtpt.Soluongton = int.Parse(tb_soluongton.Text);
                vtpt.Dongia = int.Parse(tb_dongia.Text);


                bool kq = vtptBus.sua(vtpt);
                if (kq == false)
                    MessageBox.Show("Sửa vật tư phụ tùng thất bại. Vui lòng kiểm tra lại dữ liệu");
                else
                {
                    MessageBox.Show("Sửa vật tư phụ tùng thành công");
                    this.loadData_Vao_GridView();
                }
                CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[data_vtpt.DataSource];
                myCurrencyManager.Refresh();
            }
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            int currentRowIndex = data_vtpt.CurrentCellAddress.Y;// 'current row selected
            //'Verify that indexing OK
            if (-1 < currentRowIndex && currentRowIndex < data_vtpt.RowCount)
            {
                VatTuPhuTungDTO vtpt = new VatTuPhuTungDTO();
                vtpt.Maloaivattu = int.Parse(tb_mavtpt.Text);

                //2. Kiểm tra data hợp lệ or not

                //3. Thêm vào DB
                bool kq = vtptBus.xoa(vtpt);
                if (kq == false)
                    MessageBox.Show("Xóa vật tư phụ tùng thất bại. Vui lòng kiểm tra lại dũ liệu");
                else
                {
                    MessageBox.Show("Xóa vật tư phụ tùng thành công");
                    this.loadData_Vao_GridView();
                    tb_mavtpt.Clear();
                    tb_tenvtpt.Clear();
                    tb_soluongton.Clear();
                    tb_dongia.Clear();
                }
            }
            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[data_vtpt.DataSource];
            myCurrencyManager.Refresh();
        }

        private void frmQuanLyVTPT_Load(object sender, EventArgs e)
        {
            vtptBus = new VatTuPhuTungBUS();
            this.loadData_Vao_GridView();
            bt_sua.Enabled = false;
            bt_xoa.Enabled = false;
            int mavtpt = data_vtpt.RowCount+1;
            tb_mavtpt.Text = mavtpt.ToString(); // auto nhap mavpt
        }

        private void loadData_Vao_GridView()
        {
            List<VatTuPhuTungDTO> listVatTuPhuTung = vtptBus.select();
            if (listVatTuPhuTung == null)
            {
                MessageBox.Show("Có lỗi khi lấy DB");
                return;
            }

            data_vtpt.Columns.Clear();
            data_vtpt.DataSource = null;

            data_vtpt.AutoGenerateColumns = false;
            data_vtpt.AllowUserToAddRows = false;
            data_vtpt.DataSource = listVatTuPhuTung;

            DataGridViewTextBoxColumn clMa = new DataGridViewTextBoxColumn();
            clMa.Name = "Mavtpt";
            clMa.HeaderText = "Mã VTPT";
            clMa.DataPropertyName = "Maloaivattu";
            data_vtpt.Columns.Add(clMa);

            DataGridViewTextBoxColumn clTen = new DataGridViewTextBoxColumn();
            clTen.Name = "Tenvtpt";
            clTen.HeaderText = "Tên VTPT";
            clTen.DataPropertyName = "Tenloaivattu";
            data_vtpt.Columns.Add(clTen);

            DataGridViewTextBoxColumn clTon = new DataGridViewTextBoxColumn();
            clTon.Name = "Soluongton";
            clTon.HeaderText = "Số lượng tồn";
            clTon.DataPropertyName = "Soluongton";
            data_vtpt.Columns.Add(clTon);

            DataGridViewTextBoxColumn clDongia = new DataGridViewTextBoxColumn();
            clDongia.Name = "Dongia";
            clDongia.HeaderText = "Đơn giá";
            clDongia.DataPropertyName = "Dongia";
            data_vtpt.Columns.Add(clDongia);

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[data_vtpt.DataSource];
            myCurrencyManager.Refresh();
        }

        private void data_vtpt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                bt_xoa.Enabled = true;
                bt_sua.Enabled = true;
                bt_luu.Enabled = false;
                DataGridViewRow row = this.data_vtpt.Rows[e.RowIndex];
                tb_mavtpt.Text = row.Cells["Mavtpt"].Value.ToString();
                tb_tenvtpt.Text = row.Cells["Tenvtpt"].Value.ToString();
                tb_dongia.Text = row.Cells["Dongia"].Value.ToString();
                tb_soluongton.Text = row.Cells["Soluongton"].Value.ToString();
            }
        }

        private bool check_null()
        {
            if (string.IsNullOrEmpty(tb_dongia.Text))
            {
                MessageBox.Show("Bạn chưa nhập đơn giá");
                tb_dongia.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(tb_mavtpt.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã vật tư");
                tb_mavtpt.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(tb_soluongton.Text))
            {
                MessageBox.Show("Bạn chưa nhập số lượng tồn");
                tb_soluongton.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(tb_tenvtpt.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên loại vật tư");
                tb_tenvtpt.Focus();
                return false;
            }
           
            return true;

        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            tb_dongia.Clear();
            tb_soluongton.Clear();
            tb_tenvtpt.Clear();
            bt_xoa.Enabled = false;
            bt_sua.Enabled = false;
            bt_luu.Enabled = true;
            int mavtpt = data_vtpt.RowCount + 1;
            tb_mavtpt.Text = mavtpt.ToString();
        }
    }
}

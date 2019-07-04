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
    public partial class frmQuanLyHieuXe : Form
    {
        private HieuXeBUS hxBus;
        private ThayDoiQuyDinhBUS thaydoiBus = new ThayDoiQuyDinhBUS();
        public frmQuanLyHieuXe()
        {
            InitializeComponent();
        }

        private void bt_luu_Click(object sender, EventArgs e)
        {
            if (check_null())
            {                              
                ThayDoiQuyDinhDTO thaydoi = thaydoiBus.select();
                int line = data_hieuxe.RowCount;               
                if (line < thaydoi.SoLuongHieuXe1)
                {
                    HieuXeDTO hx = new HieuXeDTO();
                    hx.Mahieuxe = int.Parse(tb_mahieuxe.Text);
                    hx.Tenhieuxe = tb_hieuxe.Text;
                    bool kq = hxBus.them(hx);
                    if (kq == false)
                        MessageBox.Show("Thêm hiệu xe thất bại. Vui lòng kiểm tra lại dữ liệu");
                    else
                    {
                        MessageBox.Show("Thêm hiệu xe thành công");
                        this.loadData_Vao_GridView();
                    }
                    CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[data_hieuxe.DataSource];
                    myCurrencyManager.Refresh();
                }
                else
                    MessageBox.Show("Vượt quá số hiệu xe cho phép");
          }
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            if(check_null())
            {
                HieuXeDTO hx = new HieuXeDTO();
                
                hx.Mahieuxe = int.Parse(tb_mahieuxe.Text);
                hx.Tenhieuxe = tb_hieuxe.Text;
          
                bool kq = hxBus.sua(hx);
                if (kq == false)
                    MessageBox.Show("Sửa hiệu xe thất bại. Vui lòng kiểm tra lại dữ liệu");
                else
                {
                    MessageBox.Show("Sửa hiệu xe thành công");
                    this.loadData_Vao_GridView();
                }
                CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[data_hieuxe.DataSource];
                myCurrencyManager.Refresh();
            }
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            int currentRowIndex = data_hieuxe.CurrentCellAddress.Y;// 'current row selected
            //'Verify that indexing OK
            if (-1 < currentRowIndex && currentRowIndex < data_hieuxe.RowCount)
            {
                HieuXeDTO hx = new HieuXeDTO();
                hx.Mahieuxe = int.Parse(tb_mahieuxe.Text);

                //2. Kiểm tra data hợp lệ or not

                //3. Thêm vào DB
                bool kq = hxBus.xoa(hx);
                if (kq == false)
                    MessageBox.Show("Xóa hiệu xe thất bại. Vui lòng kiểm tra lại dũ liệu");
                else
                {
                    MessageBox.Show("Xóa hiệu xe thành công");
                    this.loadData_Vao_GridView();
                    tb_mahieuxe.Clear();
                    tb_hieuxe.Clear();
                }
            }
            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[data_hieuxe.DataSource];
            myCurrencyManager.Refresh();
        }

        private void frmQuanLyHieuXe_Load(object sender, EventArgs e)
        {
            hxBus = new HieuXeBUS();
            this.loadData_Vao_GridView();
            bt_sua.Enabled = false;
            bt_xoa.Enabled = false;
            int mahx = data_hieuxe.RowCount + 1;
            tb_mahieuxe.Text = mahx.ToString();
        }

        private void loadData_Vao_GridView()
        {
            List<HieuXeDTO> listHieuXe = hxBus.select();
            if (listHieuXe == null)
            {
                MessageBox.Show("Có lỗi khi lấy DB");
                return;
            }

            data_hieuxe.Columns.Clear();
            data_hieuxe.DataSource = null;

            data_hieuxe.AutoGenerateColumns = false;
            data_hieuxe.AllowUserToAddRows = false;
            data_hieuxe.DataSource = listHieuXe;

            DataGridViewTextBoxColumn clMa = new DataGridViewTextBoxColumn();
            clMa.Name = "Mahx";
            clMa.HeaderText = "Mã hiệu xe";
            clMa.DataPropertyName = "Mahieuxe";
            data_hieuxe.Columns.Add(clMa);

            DataGridViewTextBoxColumn clTen = new DataGridViewTextBoxColumn();
            clTen.Name = "Hieuxe";
            clTen.HeaderText = "Tên hiệu xe";
            clTen.DataPropertyName = "Tenhieuxe";
            data_hieuxe.Columns.Add(clTen);

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[data_hieuxe.DataSource];
            myCurrencyManager.Refresh();
        }

        private void data_hieuxe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                bt_xoa.Enabled = true;
                bt_sua.Enabled = true;
                bt_luu.Enabled = false;
                DataGridViewRow row = this.data_hieuxe.Rows[e.RowIndex];
                tb_mahieuxe.Text = row.Cells["Mahx"].Value.ToString();
                tb_hieuxe.Text = row.Cells["Hieuxe"].Value.ToString();
            }
        }

        private bool check_null()
        {
            if (string.IsNullOrEmpty(tb_mahieuxe.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã hiệu xe");
                tb_mahieuxe.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(tb_hieuxe.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên hiệu xe");
                tb_hieuxe.Focus();
                return false;
            }
            return true;
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            tb_hieuxe.Clear();
            bt_xoa.Enabled = false;
            bt_sua.Enabled = false;
            bt_luu.Enabled = true;
            int mahx = data_hieuxe.RowCount + 1;
            tb_mahieuxe.Text = mahx.ToString();
        }
    }
}

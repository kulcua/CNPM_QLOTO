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
    public partial class frmQuanLyTienCong : Form
    {
        private TienCongBUS tcBus;
        private ThayDoiQuyDinhBUS thaydoiBus = new ThayDoiQuyDinhBUS();
        public frmQuanLyTienCong()
        {
            InitializeComponent();
        }
        private void bt_luu_Click(object sender, EventArgs e)
        {
            if (check_null())
            {
                ThayDoiQuyDinhDTO thaydoi = thaydoiBus.select();
                int line = data_tiencong.RowCount;
                if (line < thaydoi.SoLoaiTienCong1)
                {
                    TienCongDTO tc = new TienCongDTO();
                    tc.Maloaitiencong = int.Parse(tb_matiencong.Text);
                    tc.Tenloaitiencong = tb_tenloaitc.Text;
                    tc.Tiencong = int.Parse(tb_tiencong.Text);
                    bool kq = tcBus.them(tc);
                    if (kq == false)
                        MessageBox.Show("Thêm tiền công thất bại. Vui lòng kiểm tra lại dữ liệu");
                    else
                    {
                        MessageBox.Show("Thêm tiền công thành công");
                        this.loadData_Vao_GridView();
                    }
                    CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[data_tiencong.DataSource];
                    myCurrencyManager.Refresh();
                }
                else
                    MessageBox.Show("Vượt quá số tiền công cho phép");
            }
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            if (check_null())
            {
                TienCongDTO tc = new TienCongDTO();

                tc.Maloaitiencong = int.Parse(tb_matiencong.Text);
                tc.Tenloaitiencong = tb_tenloaitc.Text;
                tc.Tiencong = int.Parse(tb_tiencong.Text);

                bool kq = tcBus.sua(tc);
                if (kq == false)
                    MessageBox.Show("Sửa tiền công thất bại. Vui lòng kiểm tra lại dữ liệu");
                else
                {
                    MessageBox.Show("Sửa tiền công thành công");
                    this.loadData_Vao_GridView();
                }
                CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[data_tiencong.DataSource];
                myCurrencyManager.Refresh();
            }
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            int currentRowIndex = data_tiencong.CurrentCellAddress.Y;// 'current row selected
            //'Verify that indexing OK
            if (-1 < currentRowIndex && currentRowIndex < data_tiencong.RowCount)
            {
                TienCongDTO tc = new TienCongDTO();
                tc.Maloaitiencong = int.Parse(tb_matiencong.Text);

                //2. Kiểm tra data hợp lệ or not

                //3. Thêm vào DB
                bool kq = tcBus.xoa(tc);
                if (kq == false)
                    MessageBox.Show("Xóa tiền công thất bại. Vui lòng kiểm tra lại dũ liệu");
                else
                {
                    MessageBox.Show("Xóa tiền công thành công");
                    this.loadData_Vao_GridView();
                    tb_matiencong.Clear();
                    tb_tenloaitc.Clear();
                    tb_tiencong.Clear();
                }
            }
            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[data_tiencong.DataSource];
            myCurrencyManager.Refresh();
        }
        private void loadData_Vao_GridView()
        {
            List<TienCongDTO> listTienCong = tcBus.select();
            if (listTienCong == null)
            {
                MessageBox.Show("Có lỗi khi lấy DB");
                return;
            }

            data_tiencong.Columns.Clear();
            data_tiencong.DataSource = null;

            data_tiencong.AutoGenerateColumns = false;
            data_tiencong.AllowUserToAddRows = false;
            data_tiencong.DataSource = listTienCong;

            DataGridViewTextBoxColumn clMa = new DataGridViewTextBoxColumn();
            clMa.Name = "Matc";
            clMa.HeaderText = "Mã tiền công";
            clMa.DataPropertyName = "Maloaitiencong";
            data_tiencong.Columns.Add(clMa);

            DataGridViewTextBoxColumn clTen = new DataGridViewTextBoxColumn();
            clTen.Name = "Tenloaitc";
            clTen.HeaderText = "Tên tiền công";
            clTen.DataPropertyName = "Tenloaitiencong";
            data_tiencong.Columns.Add(clTen);

            DataGridViewTextBoxColumn clTiencong = new DataGridViewTextBoxColumn();
            clTiencong.Name = "Tiencong";
            clTiencong.HeaderText = "Tiền công";
            clTiencong.DataPropertyName = "Tiencong";
            data_tiencong.Columns.Add(clTiencong);

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[data_tiencong.DataSource];
            myCurrencyManager.Refresh();
        }

        private bool check_null()
        {
            if (string.IsNullOrEmpty(tb_matiencong.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã tiền công");
                tb_matiencong.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(tb_tenloaitc.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên tiền công");
                tb_tenloaitc.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(tb_tiencong.Text))
            {
                MessageBox.Show("Bạn chưa nhập tiền công");
                tb_tiencong.Focus();
                return false;
            }
            return true;
        }

        private void frmQuanLyTienCong_Load(object sender, EventArgs e)
        {
            tcBus = new TienCongBUS();
            this.loadData_Vao_GridView();
            bt_sua.Enabled = false;
            bt_xoa.Enabled = false;
            int matc = data_tiencong.RowCount + 1;
            tb_matiencong.Text = matc.ToString();
        }

        private void data_tiencong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                bt_xoa.Enabled = true;
                bt_sua.Enabled = true;
                bt_luu.Enabled = false;
                DataGridViewRow row = this.data_tiencong.Rows[e.RowIndex];
                tb_matiencong.Text = row.Cells["Matc"].Value.ToString();
                tb_tenloaitc.Text = row.Cells["Tenloaitc"].Value.ToString();
                tb_tiencong.Text = row.Cells["Tiencong"].Value.ToString();
            }
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            tb_tenloaitc.Clear();
            tb_tiencong.Clear();
            bt_xoa.Enabled = false;
            bt_sua.Enabled = false;
            bt_luu.Enabled = true;
            int matc = data_tiencong.RowCount + 1;
            tb_matiencong.Text = matc.ToString();
        }
    }
}

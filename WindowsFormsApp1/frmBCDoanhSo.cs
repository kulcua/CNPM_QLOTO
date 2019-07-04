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
    public partial class frmBCDoanhSo : Form
    {
        private ThoiGianBUS tgBus;
        private HieuXeBUS hxBus;
        public frmBCDoanhSo()
        {
            InitializeComponent();
        }

        private void loadThoiGian_combobox()
        {
            List<ThoiGianDTO> listThoiGian = tgBus.select();

            if (listThoiGian == null)
            {
                MessageBox.Show("Có lỗi xảy ra");
                return;
            }
            cb_thang.DataSource = new BindingSource(listThoiGian, String.Empty);
            cb_thang.DisplayMember = "thang";
            cb_thang.ValueMember = "mathoigian";
            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[cb_thang.DataSource];
            myCurrencyManager.Refresh();

            if (cb_thang.Items.Count > 0)
            {
                cb_thang.SelectedIndex = 0;
            }
        }

        private void frmBCDoanhSo_Load(object sender, EventArgs e)
        {
            tgBus = new ThoiGianBUS();
            hxBus = new HieuXeBUS();
            loadThoiGian_combobox();
        }

        private void bt_xuatdoanhso_Click(object sender, EventArgs e)
        {
            string kw = cb_thang.Text.Trim();
            List<HieuXeDTO> listHieuxe = hxBus.selectByKeyWord(kw);
            this.loadData_Vao_GridView(listHieuxe);
            tinhtongdoanhthu();
        }
        private void loadData_Vao_GridView(List<HieuXeDTO> listHieuxe)
        {
            if (listHieuxe == null)
            {
                MessageBox.Show("Có lỗi khi lấy DB");
                return;
            }

            data_doanhso.Columns.Clear();
            data_doanhso.DataSource = null;

            data_doanhso.AutoGenerateColumns = false;
            data_doanhso.AllowUserToAddRows = false;
            data_doanhso.DataSource = listHieuxe;

            DataGridViewTextBoxColumn clHieuxe = new DataGridViewTextBoxColumn();
            clHieuxe.Name = "Hieuxe";
            clHieuxe.HeaderText = "Hiệu xe";
            clHieuxe.DataPropertyName = "Tenhieuxe";
            data_doanhso.Columns.Add(clHieuxe);

            DataGridViewTextBoxColumn clSoluotsua = new DataGridViewTextBoxColumn();
            clSoluotsua.Name = "Soluotsua";
            clSoluotsua.HeaderText = "Số Lượt Sửa";
            clSoluotsua.DataPropertyName = "Soluotsua";
            data_doanhso.Columns.Add(clSoluotsua);

            DataGridViewTextBoxColumn clThanhtien = new DataGridViewTextBoxColumn();
            clThanhtien.Name = "Thanhtien";
            clThanhtien.HeaderText = "Thành tiền";
            clThanhtien.DataPropertyName = "Thanhtien";
            data_doanhso.Columns.Add(clThanhtien);

            //DataGridViewTextBoxColumn clTile = new DataGridViewTextBoxColumn();
            //clTile.Name = "Tile";
            //clTile.HeaderText = "Tỉ lệ";
            //clTile.DataPropertyName = "Tile";
            //data_doanhso.Columns.Add(clTile);

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[data_doanhso.DataSource];
            myCurrencyManager.Refresh();
        }
         private void tinhtongdoanhthu()
        {
            int tien = data_doanhso.RowCount;
            int thanhtien = 0;
            for (int i=0; i<tien; i++)
            {
                thanhtien += int.Parse(data_doanhso.Rows[i].Cells["Thanhtien"].Value.ToString());
            }
            lb_tongdoanhthu.Text = String.Format("{0:0,0}", thanhtien);
        }
    }
}

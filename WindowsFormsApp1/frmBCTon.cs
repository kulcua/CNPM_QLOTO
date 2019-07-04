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
    public partial class frmBCTon : Form
    {
        private ThoiGianBUS tgBus;
        private VatTuPhuTungBUS vtptBus;
        public frmBCTon()
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
            //tb_dongia.Text = 
            cb_thang.DisplayMember = "thang";
            cb_thang.ValueMember = "mathoigian";
            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[cb_thang.DataSource];
            myCurrencyManager.Refresh();

            if (cb_thang.Items.Count > 0)
            {
                cb_thang.SelectedIndex = 0;
            }
        }

        private void loadVTPT_Ton_Vao_GridView()
        {
            List<VatTuPhuTungDTO> listVatTuPhuTung = vtptBus.select_ton();
            if (listVatTuPhuTung == null)
            {
                MessageBox.Show("Có lỗi khi lấy DB");
                return;
            }

            data_ton.Columns.Clear();
            data_ton.DataSource = null;

            data_ton.AutoGenerateColumns = false;
            data_ton.AllowUserToAddRows = false;
            data_ton.DataSource = listVatTuPhuTung;

            DataGridViewTextBoxColumn clMa = new DataGridViewTextBoxColumn();
            clMa.Name = "Mavtpt";
            clMa.HeaderText = "Mã VTPT";
            clMa.DataPropertyName = "Maloaivattu";
            data_ton.Columns.Add(clMa);

            DataGridViewTextBoxColumn clTen = new DataGridViewTextBoxColumn();
            clTen.Name = "Tenvtpt";
            clTen.HeaderText = "Tên VTPT";
            clTen.DataPropertyName = "Tenloaivattu";
            data_ton.Columns.Add(clTen);

            DataGridViewTextBoxColumn clTon = new DataGridViewTextBoxColumn();
            clTon.Name = "Soluongton";
            clTon.HeaderText = "Số lượng tồn";
            clTon.DataPropertyName = "Soluongton";
            data_ton.Columns.Add(clTon);

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[data_ton.DataSource];
            myCurrencyManager.Refresh();
        }

        private void frmBCTon_Load(object sender, EventArgs e)
        {
            vtptBus = new VatTuPhuTungBUS();
            tgBus = new ThoiGianBUS();
            loadThoiGian_combobox();
            this.loadVTPT_Ton_Vao_GridView();
            this.loadVTPT_Het_Vao_GridView();
        }

        private void loadVTPT_Het_Vao_GridView()
        {
            List<VatTuPhuTungDTO> listVatTuPhuTung = vtptBus.select_het();
            if (listVatTuPhuTung == null)
            {
                MessageBox.Show("Có lỗi khi lấy DB");
                return;
            }

            data_het.Columns.Clear();
            data_het.DataSource = null;

            data_het.AutoGenerateColumns = false;
            data_het.AllowUserToAddRows = false;
            data_het.DataSource = listVatTuPhuTung;

            DataGridViewTextBoxColumn clMa = new DataGridViewTextBoxColumn();
            clMa.Name = "Mavtpt";
            clMa.HeaderText = "Mã VTPT";
            clMa.DataPropertyName = "Maloaivattu";
            data_het.Columns.Add(clMa);

            DataGridViewTextBoxColumn clTen = new DataGridViewTextBoxColumn();
            clTen.Name = "Tenvtpt";
            clTen.HeaderText = "Tên VTPT";
            clTen.DataPropertyName = "Tenloaivattu";
            data_het.Columns.Add(clTen);

            DataGridViewTextBoxColumn clTon = new DataGridViewTextBoxColumn();
            clTon.Name = "Soluongton";
            clTon.HeaderText = "Số lượng tồn";
            clTon.DataPropertyName = "Soluongton";
            data_het.Columns.Add(clTon);

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[data_het.DataSource];
            myCurrencyManager.Refresh();
        }

    }  
}

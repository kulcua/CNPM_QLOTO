namespace WindowsFormsApp1
{
    partial class frmPhieuSuaChua
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label7 = new System.Windows.Forms.Label();
            this.lb_bienso = new System.Windows.Forms.Label();
            this.lb_ngaysuachua = new System.Windows.Forms.Label();
            this.tb_bienso = new System.Windows.Forms.TextBox();
            this.time_ngaysuachua = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_Them = new System.Windows.Forms.Button();
            this.tb_giatiencong = new System.Windows.Forms.TextBox();
            this.bt_xuatphieu = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_luu = new System.Windows.Forms.Button();
            this.cb_tiencong = new System.Windows.Forms.ComboBox();
            this.cb_vattu = new System.Windows.Forms.ComboBox();
            this.tb_thanhtien = new System.Windows.Forms.TextBox();
            this.tb_dongia = new System.Windows.Forms.TextBox();
            this.tb_soluong = new System.Windows.Forms.TextBox();
            this.tb_noidung = new System.Windows.Forms.TextBox();
            this.lb_dongia = new System.Windows.Forms.Label();
            this.lb_tiencong = new System.Windows.Forms.Label();
            this.lb_thanhtien = new System.Windows.Forms.Label();
            this.lb_soluong = new System.Windows.Forms.Label();
            this.lb_vattu = new System.Windows.Forms.Label();
            this.lb_noidung = new System.Windows.Forms.Label();
            this.data_suachua = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.lb_tx_mahs = new System.Windows.Forms.Label();
            this.tb_machitiet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_mahs = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_suachua)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(279, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 22);
            this.label7.TabIndex = 15;
            this.label7.Text = "PHIẾU SỬA CHỮA";
            // 
            // lb_bienso
            // 
            this.lb_bienso.AutoSize = true;
            this.lb_bienso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_bienso.Location = new System.Drawing.Point(16, 16);
            this.lb_bienso.Name = "lb_bienso";
            this.lb_bienso.Size = new System.Drawing.Size(73, 17);
            this.lb_bienso.TabIndex = 0;
            this.lb_bienso.Text = "Biển số xe";
            // 
            // lb_ngaysuachua
            // 
            this.lb_ngaysuachua.AutoSize = true;
            this.lb_ngaysuachua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ngaysuachua.Location = new System.Drawing.Point(353, 16);
            this.lb_ngaysuachua.Name = "lb_ngaysuachua";
            this.lb_ngaysuachua.Size = new System.Drawing.Size(103, 17);
            this.lb_ngaysuachua.TabIndex = 3;
            this.lb_ngaysuachua.Text = "Ngày sửa chữa";
            // 
            // tb_bienso
            // 
            this.tb_bienso.Location = new System.Drawing.Point(131, 15);
            this.tb_bienso.Name = "tb_bienso";
            this.tb_bienso.Size = new System.Drawing.Size(196, 20);
            this.tb_bienso.TabIndex = 6;
            // 
            // time_ngaysuachua
            // 
            this.time_ngaysuachua.Location = new System.Drawing.Point(462, 15);
            this.time_ngaysuachua.Name = "time_ngaysuachua";
            this.time_ngaysuachua.Size = new System.Drawing.Size(196, 20);
            this.time_ngaysuachua.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.time_ngaysuachua);
            this.groupBox1.Controls.Add(this.tb_bienso);
            this.groupBox1.Controls.Add(this.lb_ngaysuachua);
            this.groupBox1.Controls.Add(this.lb_bienso);
            this.groupBox1.Location = new System.Drawing.Point(12, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(669, 54);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_Them);
            this.groupBox2.Controls.Add(this.tb_giatiencong);
            this.groupBox2.Controls.Add(this.bt_xuatphieu);
            this.groupBox2.Controls.Add(this.bt_sua);
            this.groupBox2.Controls.Add(this.bt_xoa);
            this.groupBox2.Controls.Add(this.bt_luu);
            this.groupBox2.Controls.Add(this.cb_tiencong);
            this.groupBox2.Controls.Add(this.cb_vattu);
            this.groupBox2.Controls.Add(this.tb_thanhtien);
            this.groupBox2.Controls.Add(this.tb_dongia);
            this.groupBox2.Controls.Add(this.tb_soluong);
            this.groupBox2.Controls.Add(this.tb_noidung);
            this.groupBox2.Controls.Add(this.lb_dongia);
            this.groupBox2.Controls.Add(this.lb_tiencong);
            this.groupBox2.Controls.Add(this.lb_thanhtien);
            this.groupBox2.Controls.Add(this.lb_soluong);
            this.groupBox2.Controls.Add(this.lb_vattu);
            this.groupBox2.Controls.Add(this.lb_noidung);
            this.groupBox2.Location = new System.Drawing.Point(12, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(669, 179);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // bt_Them
            // 
            this.bt_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Them.Location = new System.Drawing.Point(408, 140);
            this.bt_Them.Name = "bt_Them";
            this.bt_Them.Size = new System.Drawing.Size(75, 23);
            this.bt_Them.TabIndex = 24;
            this.bt_Them.Text = "Thêm mới";
            this.bt_Them.UseVisualStyleBackColor = true;
            this.bt_Them.Click += new System.EventHandler(this.bt_Them_Click);
            // 
            // tb_giatiencong
            // 
            this.tb_giatiencong.Location = new System.Drawing.Point(596, 60);
            this.tb_giatiencong.Name = "tb_giatiencong";
            this.tb_giatiencong.ReadOnly = true;
            this.tb_giatiencong.Size = new System.Drawing.Size(62, 20);
            this.tb_giatiencong.TabIndex = 19;
            // 
            // bt_xuatphieu
            // 
            this.bt_xuatphieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xuatphieu.Location = new System.Drawing.Point(489, 140);
            this.bt_xuatphieu.Name = "bt_xuatphieu";
            this.bt_xuatphieu.Size = new System.Drawing.Size(169, 23);
            this.bt_xuatphieu.TabIndex = 18;
            this.bt_xuatphieu.Text = "Xuất phiếu sửa chữa";
            this.bt_xuatphieu.UseVisualStyleBackColor = true;
            // 
            // bt_sua
            // 
            this.bt_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sua.Location = new System.Drawing.Point(19, 140);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(75, 23);
            this.bt_sua.TabIndex = 17;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoa.Location = new System.Drawing.Point(100, 140);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(75, 23);
            this.bt_xoa.TabIndex = 16;
            this.bt_xoa.Text = "Xoá";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_luu
            // 
            this.bt_luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_luu.Location = new System.Drawing.Point(181, 140);
            this.bt_luu.Name = "bt_luu";
            this.bt_luu.Size = new System.Drawing.Size(75, 23);
            this.bt_luu.TabIndex = 15;
            this.bt_luu.Text = "Lưu";
            this.bt_luu.UseVisualStyleBackColor = true;
            this.bt_luu.Click += new System.EventHandler(this.bt_luu_Click);
            // 
            // cb_tiencong
            // 
            this.cb_tiencong.FormattingEnabled = true;
            this.cb_tiencong.Location = new System.Drawing.Point(462, 59);
            this.cb_tiencong.Name = "cb_tiencong";
            this.cb_tiencong.Size = new System.Drawing.Size(128, 21);
            this.cb_tiencong.TabIndex = 12;
            this.cb_tiencong.SelectedIndexChanged += new System.EventHandler(this.cb_tiencong_SelectedIndexChanged);
            // 
            // cb_vattu
            // 
            this.cb_vattu.FormattingEnabled = true;
            this.cb_vattu.Location = new System.Drawing.Point(131, 22);
            this.cb_vattu.Name = "cb_vattu";
            this.cb_vattu.Size = new System.Drawing.Size(196, 21);
            this.cb_vattu.TabIndex = 11;
            this.cb_vattu.SelectedIndexChanged += new System.EventHandler(this.cb_vattu_SelectedIndexChanged);
            // 
            // tb_thanhtien
            // 
            this.tb_thanhtien.Location = new System.Drawing.Point(462, 98);
            this.tb_thanhtien.Name = "tb_thanhtien";
            this.tb_thanhtien.ReadOnly = true;
            this.tb_thanhtien.Size = new System.Drawing.Size(196, 20);
            this.tb_thanhtien.TabIndex = 10;
            this.tb_thanhtien.Text = "0";
            // 
            // tb_dongia
            // 
            this.tb_dongia.Location = new System.Drawing.Point(131, 61);
            this.tb_dongia.Name = "tb_dongia";
            this.tb_dongia.ReadOnly = true;
            this.tb_dongia.Size = new System.Drawing.Size(196, 20);
            this.tb_dongia.TabIndex = 8;
            // 
            // tb_soluong
            // 
            this.tb_soluong.Location = new System.Drawing.Point(131, 101);
            this.tb_soluong.Name = "tb_soluong";
            this.tb_soluong.Size = new System.Drawing.Size(196, 20);
            this.tb_soluong.TabIndex = 9;
            // 
            // tb_noidung
            // 
            this.tb_noidung.Location = new System.Drawing.Point(462, 19);
            this.tb_noidung.Name = "tb_noidung";
            this.tb_noidung.Size = new System.Drawing.Size(196, 20);
            this.tb_noidung.TabIndex = 7;
            // 
            // lb_dongia
            // 
            this.lb_dongia.AutoSize = true;
            this.lb_dongia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dongia.Location = new System.Drawing.Point(16, 61);
            this.lb_dongia.Name = "lb_dongia";
            this.lb_dongia.Size = new System.Drawing.Size(57, 17);
            this.lb_dongia.TabIndex = 6;
            this.lb_dongia.Text = "Đơn giá";
            // 
            // lb_tiencong
            // 
            this.lb_tiencong.AutoSize = true;
            this.lb_tiencong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tiencong.Location = new System.Drawing.Point(353, 59);
            this.lb_tiencong.Name = "lb_tiencong";
            this.lb_tiencong.Size = new System.Drawing.Size(71, 17);
            this.lb_tiencong.TabIndex = 5;
            this.lb_tiencong.Text = "Tiền công";
            // 
            // lb_thanhtien
            // 
            this.lb_thanhtien.AutoSize = true;
            this.lb_thanhtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_thanhtien.Location = new System.Drawing.Point(353, 98);
            this.lb_thanhtien.Name = "lb_thanhtien";
            this.lb_thanhtien.Size = new System.Drawing.Size(76, 17);
            this.lb_thanhtien.TabIndex = 4;
            this.lb_thanhtien.Text = "Thành tiền";
            // 
            // lb_soluong
            // 
            this.lb_soluong.AutoSize = true;
            this.lb_soluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_soluong.Location = new System.Drawing.Point(16, 101);
            this.lb_soluong.Name = "lb_soluong";
            this.lb_soluong.Size = new System.Drawing.Size(64, 17);
            this.lb_soluong.TabIndex = 3;
            this.lb_soluong.Text = "Số lượng";
            // 
            // lb_vattu
            // 
            this.lb_vattu.AutoSize = true;
            this.lb_vattu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_vattu.Location = new System.Drawing.Point(16, 22);
            this.lb_vattu.Name = "lb_vattu";
            this.lb_vattu.Size = new System.Drawing.Size(105, 17);
            this.lb_vattu.TabIndex = 2;
            this.lb_vattu.Text = "Vật tư phụ tùng";
            // 
            // lb_noidung
            // 
            this.lb_noidung.AutoSize = true;
            this.lb_noidung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_noidung.Location = new System.Drawing.Point(353, 22);
            this.lb_noidung.Name = "lb_noidung";
            this.lb_noidung.Size = new System.Drawing.Size(65, 17);
            this.lb_noidung.TabIndex = 1;
            this.lb_noidung.Text = "Nội dung";
            // 
            // data_suachua
            // 
            this.data_suachua.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_suachua.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.data_suachua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_suachua.Location = new System.Drawing.Point(12, 288);
            this.data_suachua.Name = "data_suachua";
            this.data_suachua.Size = new System.Drawing.Size(728, 177);
            this.data_suachua.TabIndex = 17;
            this.data_suachua.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_suachua_CellClick_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(571, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Mã ";
            // 
            // lb_tx_mahs
            // 
            this.lb_tx_mahs.AutoSize = true;
            this.lb_tx_mahs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tx_mahs.Location = new System.Drawing.Point(622, 18);
            this.lb_tx_mahs.Name = "lb_tx_mahs";
            this.lb_tx_mahs.Size = new System.Drawing.Size(0, 17);
            this.lb_tx_mahs.TabIndex = 18;
            // 
            // tb_machitiet
            // 
            this.tb_machitiet.Location = new System.Drawing.Point(112, 14);
            this.tb_machitiet.Name = "tb_machitiet";
            this.tb_machitiet.Size = new System.Drawing.Size(59, 20);
            this.tb_machitiet.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Mã chi tiết";
            // 
            // lb_mahs
            // 
            this.lb_mahs.AutoSize = true;
            this.lb_mahs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mahs.Location = new System.Drawing.Point(622, 17);
            this.lb_mahs.Name = "lb_mahs";
            this.lb_mahs.Size = new System.Drawing.Size(16, 17);
            this.lb_mahs.TabIndex = 23;
            this.lb_mahs.Text = "0";
            // 
            // frmPhieuSuaChua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 504);
            this.Controls.Add(this.lb_mahs);
            this.Controls.Add(this.tb_machitiet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lb_tx_mahs);
            this.Controls.Add(this.data_suachua);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPhieuSuaChua";
            this.Load += new System.EventHandler(this.frmPhieuSuaChua_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_suachua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_bienso;
        private System.Windows.Forms.Label lb_ngaysuachua;
        private System.Windows.Forms.TextBox tb_bienso;
        private System.Windows.Forms.DateTimePicker time_ngaysuachua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lb_noidung;
        private System.Windows.Forms.Label lb_dongia;
        private System.Windows.Forms.Label lb_tiencong;
        private System.Windows.Forms.Label lb_thanhtien;
        private System.Windows.Forms.Label lb_soluong;
        private System.Windows.Forms.Label lb_vattu;
        private System.Windows.Forms.ComboBox cb_tiencong;
        private System.Windows.Forms.ComboBox cb_vattu;
        private System.Windows.Forms.TextBox tb_thanhtien;
        private System.Windows.Forms.TextBox tb_dongia;
        private System.Windows.Forms.TextBox tb_soluong;
        private System.Windows.Forms.TextBox tb_noidung;
        private System.Windows.Forms.Button bt_luu;
        private System.Windows.Forms.DataGridView data_suachua;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_xuatphieu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lb_tx_mahs;
        private System.Windows.Forms.TextBox tb_machitiet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_mahs;
        private System.Windows.Forms.TextBox tb_giatiencong;
        private System.Windows.Forms.Button bt_Them;
    }
}
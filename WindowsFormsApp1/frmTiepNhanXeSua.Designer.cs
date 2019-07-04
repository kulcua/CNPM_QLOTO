namespace WindowsFormsApp1
{
    partial class frmTiepNhanXeSua
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tiếpNhậnXeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traCứuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lậpPhiếuBáoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doanhSốToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoTồnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bổSungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýHiệuXeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýVTPTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýTiềnCôngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thayĐổiQuyĐịnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_Them = new System.Windows.Forms.Button();
            this.bt_luu = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_lapphieusuachua = new System.Windows.Forms.Button();
            this.time_ngaytiepnhan = new System.Windows.Forms.DateTimePicker();
            this.cb_hieuxe = new System.Windows.Forms.ComboBox();
            this.tb_dienthoai = new System.Windows.Forms.TextBox();
            this.tb_bienso = new System.Windows.Forms.TextBox();
            this.tb_diachi = new System.Windows.Forms.TextBox();
            this.tb_tenchuxe = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.data_tiepnhan = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_ma = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_tiepnhan)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiếpNhậnXeToolStripMenuItem,
            this.traCứuToolStripMenuItem,
            this.lậpPhiếuBáoCáoToolStripMenuItem,
            this.bổSungToolStripMenuItem,
            this.thayĐổiQuyĐịnhToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tiếpNhậnXeToolStripMenuItem
            // 
            this.tiếpNhậnXeToolStripMenuItem.Name = "tiếpNhậnXeToolStripMenuItem";
            this.tiếpNhậnXeToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.tiếpNhậnXeToolStripMenuItem.Text = "Tiếp nhận xe sửa";
            // 
            // traCứuToolStripMenuItem
            // 
            this.traCứuToolStripMenuItem.Name = "traCứuToolStripMenuItem";
            this.traCứuToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.traCứuToolStripMenuItem.Text = "Tra cứu xe";
            this.traCứuToolStripMenuItem.Click += new System.EventHandler(this.traCứuToolStripMenuItem_Click);
            // 
            // lậpPhiếuBáoCáoToolStripMenuItem
            // 
            this.lậpPhiếuBáoCáoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doanhSốToolStripMenuItem,
            this.báoCáoTồnToolStripMenuItem});
            this.lậpPhiếuBáoCáoToolStripMenuItem.Name = "lậpPhiếuBáoCáoToolStripMenuItem";
            this.lậpPhiếuBáoCáoToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.lậpPhiếuBáoCáoToolStripMenuItem.Text = "Lập phiếu báo cáo";
            // 
            // doanhSốToolStripMenuItem
            // 
            this.doanhSốToolStripMenuItem.Name = "doanhSốToolStripMenuItem";
            this.doanhSốToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.doanhSốToolStripMenuItem.Text = "Doanh số";
            this.doanhSốToolStripMenuItem.Click += new System.EventHandler(this.doanhSốToolStripMenuItem_Click);
            // 
            // báoCáoTồnToolStripMenuItem
            // 
            this.báoCáoTồnToolStripMenuItem.Name = "báoCáoTồnToolStripMenuItem";
            this.báoCáoTồnToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.báoCáoTồnToolStripMenuItem.Text = "Báo cáo tồn";
            this.báoCáoTồnToolStripMenuItem.Click += new System.EventHandler(this.báoCáoTồnToolStripMenuItem_Click);
            // 
            // bổSungToolStripMenuItem
            // 
            this.bổSungToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýHiệuXeToolStripMenuItem,
            this.quảnLýVTPTToolStripMenuItem,
            this.quảnLýTiềnCôngToolStripMenuItem});
            this.bổSungToolStripMenuItem.Name = "bổSungToolStripMenuItem";
            this.bổSungToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.bổSungToolStripMenuItem.Text = "Bổ sung";
            // 
            // quảnLýHiệuXeToolStripMenuItem
            // 
            this.quảnLýHiệuXeToolStripMenuItem.Name = "quảnLýHiệuXeToolStripMenuItem";
            this.quảnLýHiệuXeToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.quảnLýHiệuXeToolStripMenuItem.Text = "Quản lý hiệu xe";
            this.quảnLýHiệuXeToolStripMenuItem.Click += new System.EventHandler(this.quảnLýHiệuXeToolStripMenuItem_Click);
            // 
            // quảnLýVTPTToolStripMenuItem
            // 
            this.quảnLýVTPTToolStripMenuItem.Name = "quảnLýVTPTToolStripMenuItem";
            this.quảnLýVTPTToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.quảnLýVTPTToolStripMenuItem.Text = "Quản lý VTPT";
            this.quảnLýVTPTToolStripMenuItem.Click += new System.EventHandler(this.quảnLýVTPTToolStripMenuItem_Click);
            // 
            // quảnLýTiềnCôngToolStripMenuItem
            // 
            this.quảnLýTiềnCôngToolStripMenuItem.Name = "quảnLýTiềnCôngToolStripMenuItem";
            this.quảnLýTiềnCôngToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.quảnLýTiềnCôngToolStripMenuItem.Text = "Quản lý tiền công";
            this.quảnLýTiềnCôngToolStripMenuItem.Click += new System.EventHandler(this.quảnLýTiềnCôngToolStripMenuItem_Click);
            // 
            // thayĐổiQuyĐịnhToolStripMenuItem
            // 
            this.thayĐổiQuyĐịnhToolStripMenuItem.Name = "thayĐổiQuyĐịnhToolStripMenuItem";
            this.thayĐổiQuyĐịnhToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.thayĐổiQuyĐịnhToolStripMenuItem.Text = "Thay đổi quy định";
            this.thayĐổiQuyĐịnhToolStripMenuItem.Click += new System.EventHandler(this.thayĐổiQuyĐịnhToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_Them);
            this.groupBox1.Controls.Add(this.bt_luu);
            this.groupBox1.Controls.Add(this.bt_sua);
            this.groupBox1.Controls.Add(this.bt_xoa);
            this.groupBox1.Controls.Add(this.bt_lapphieusuachua);
            this.groupBox1.Controls.Add(this.time_ngaytiepnhan);
            this.groupBox1.Controls.Add(this.cb_hieuxe);
            this.groupBox1.Controls.Add(this.tb_dienthoai);
            this.groupBox1.Controls.Add(this.tb_bienso);
            this.groupBox1.Controls.Add(this.tb_diachi);
            this.groupBox1.Controls.Add(this.tb_tenchuxe);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(682, 177);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // bt_Them
            // 
            this.bt_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Them.Location = new System.Drawing.Point(417, 133);
            this.bt_Them.Name = "bt_Them";
            this.bt_Them.Size = new System.Drawing.Size(75, 23);
            this.bt_Them.TabIndex = 17;
            this.bt_Them.Text = "Thêm mới";
            this.bt_Them.UseVisualStyleBackColor = true;
            this.bt_Them.Click += new System.EventHandler(this.bt_Them_Click);
            // 
            // bt_luu
            // 
            this.bt_luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_luu.Location = new System.Drawing.Point(181, 133);
            this.bt_luu.Name = "bt_luu";
            this.bt_luu.Size = new System.Drawing.Size(75, 23);
            this.bt_luu.TabIndex = 16;
            this.bt_luu.Text = "Lưu";
            this.bt_luu.UseVisualStyleBackColor = true;
            this.bt_luu.Click += new System.EventHandler(this.bt_luu_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sua.Location = new System.Drawing.Point(19, 133);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(75, 23);
            this.bt_sua.TabIndex = 14;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoa.Location = new System.Drawing.Point(100, 133);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(75, 23);
            this.bt_xoa.TabIndex = 13;
            this.bt_xoa.Text = "Xoá";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_lapphieusuachua
            // 
            this.bt_lapphieusuachua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_lapphieusuachua.Location = new System.Drawing.Point(498, 133);
            this.bt_lapphieusuachua.Name = "bt_lapphieusuachua";
            this.bt_lapphieusuachua.Size = new System.Drawing.Size(160, 23);
            this.bt_lapphieusuachua.TabIndex = 12;
            this.bt_lapphieusuachua.Text = "Lập phiếu sửa chữa";
            this.bt_lapphieusuachua.UseVisualStyleBackColor = true;
            this.bt_lapphieusuachua.Click += new System.EventHandler(this.bt_lapphieusuachua_Click);
            // 
            // time_ngaytiepnhan
            // 
            this.time_ngaytiepnhan.Location = new System.Drawing.Point(462, 90);
            this.time_ngaytiepnhan.Name = "time_ngaytiepnhan";
            this.time_ngaytiepnhan.Size = new System.Drawing.Size(196, 20);
            this.time_ngaytiepnhan.TabIndex = 11;
            // 
            // cb_hieuxe
            // 
            this.cb_hieuxe.FormattingEnabled = true;
            this.cb_hieuxe.Location = new System.Drawing.Point(462, 49);
            this.cb_hieuxe.Name = "cb_hieuxe";
            this.cb_hieuxe.Size = new System.Drawing.Size(196, 21);
            this.cb_hieuxe.TabIndex = 10;
            // 
            // tb_dienthoai
            // 
            this.tb_dienthoai.Location = new System.Drawing.Point(462, 13);
            this.tb_dienthoai.Name = "tb_dienthoai";
            this.tb_dienthoai.Size = new System.Drawing.Size(196, 20);
            this.tb_dienthoai.TabIndex = 9;
            // 
            // tb_bienso
            // 
            this.tb_bienso.Location = new System.Drawing.Point(114, 87);
            this.tb_bienso.Name = "tb_bienso";
            this.tb_bienso.Size = new System.Drawing.Size(196, 20);
            this.tb_bienso.TabIndex = 8;
            // 
            // tb_diachi
            // 
            this.tb_diachi.Location = new System.Drawing.Point(114, 51);
            this.tb_diachi.Name = "tb_diachi";
            this.tb_diachi.Size = new System.Drawing.Size(196, 20);
            this.tb_diachi.TabIndex = 7;
            // 
            // tb_tenchuxe
            // 
            this.tb_tenchuxe.Location = new System.Drawing.Point(114, 15);
            this.tb_tenchuxe.Name = "tb_tenchuxe";
            this.tb_tenchuxe.Size = new System.Drawing.Size(196, 20);
            this.tb_tenchuxe.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(333, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngày tiếp nhận";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(333, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hiệu xe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(333, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Biển số";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Địa chỉ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên chủ xe";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(272, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 22);
            this.label7.TabIndex = 3;
            this.label7.Text = "TIẾP NHẬN XE SỬA";
            // 
            // data_tiepnhan
            // 
            this.data_tiepnhan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data_tiepnhan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_tiepnhan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.data_tiepnhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_tiepnhan.Location = new System.Drawing.Point(12, 243);
            this.data_tiepnhan.Name = "data_tiepnhan";
            this.data_tiepnhan.Size = new System.Drawing.Size(744, 160);
            this.data_tiepnhan.TabIndex = 4;
            this.data_tiepnhan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_tiepnhan_CellClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(562, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "Mã ";
            // 
            // tb_ma
            // 
            this.tb_ma.Location = new System.Drawing.Point(599, 34);
            this.tb_ma.Name = "tb_ma";
            this.tb_ma.ReadOnly = true;
            this.tb_ma.Size = new System.Drawing.Size(71, 20);
            this.tb_ma.TabIndex = 7;
            this.tb_ma.Text = "22";
            // 
            // frmTiepNhanXeSua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_ma);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.data_tiepnhan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmTiepNhanXeSua";
            this.Load += new System.EventHandler(this.frmTiepNhanXeSua_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_tiepnhan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tiếpNhậnXeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traCứuToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem lậpPhiếuBáoCáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thayĐổiQuyĐịnhToolStripMenuItem;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_lapphieusuachua;
        private System.Windows.Forms.DateTimePicker time_ngaytiepnhan;
        private System.Windows.Forms.ComboBox cb_hieuxe;
        private System.Windows.Forms.TextBox tb_dienthoai;
        private System.Windows.Forms.TextBox tb_bienso;
        private System.Windows.Forms.TextBox tb_diachi;
        private System.Windows.Forms.TextBox tb_tenchuxe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView data_tiepnhan;
        private System.Windows.Forms.ToolStripMenuItem doanhSốToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoTồnToolStripMenuItem;
        private System.Windows.Forms.Button bt_luu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_ma;
        private System.Windows.Forms.ToolStripMenuItem bổSungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýHiệuXeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýVTPTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýTiềnCôngToolStripMenuItem;
        private System.Windows.Forms.Button bt_Them;
    }
}


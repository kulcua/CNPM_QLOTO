namespace WindowsFormsApp1
{
    partial class frmQuanLyVTPT
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_mavtpt = new System.Windows.Forms.TextBox();
            this.tb_dongia = new System.Windows.Forms.TextBox();
            this.tb_soluongton = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_tenvtpt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_ngaysuachua = new System.Windows.Forms.Label();
            this.lb_bienso = new System.Windows.Forms.Label();
            this.data_vtpt = new System.Windows.Forms.DataGridView();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_luu = new System.Windows.Forms.Button();
            this.bt_Them = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_vtpt)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(180, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(260, 22);
            this.label7.TabIndex = 29;
            this.label7.Text = "QUẢN LÝ VẬT TƯ PHỤ TÙNG";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_mavtpt);
            this.groupBox1.Controls.Add(this.tb_dongia);
            this.groupBox1.Controls.Add(this.tb_soluongton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_tenvtpt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lb_ngaysuachua);
            this.groupBox1.Controls.Add(this.lb_bienso);
            this.groupBox1.Location = new System.Drawing.Point(21, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(617, 97);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // tb_mavtpt
            // 
            this.tb_mavtpt.Location = new System.Drawing.Point(108, 19);
            this.tb_mavtpt.Name = "tb_mavtpt";
            this.tb_mavtpt.ReadOnly = true;
            this.tb_mavtpt.Size = new System.Drawing.Size(152, 20);
            this.tb_mavtpt.TabIndex = 36;
            // 
            // tb_dongia
            // 
            this.tb_dongia.Location = new System.Drawing.Point(445, 54);
            this.tb_dongia.Name = "tb_dongia";
            this.tb_dongia.Size = new System.Drawing.Size(142, 20);
            this.tb_dongia.TabIndex = 35;
            // 
            // tb_soluongton
            // 
            this.tb_soluongton.Location = new System.Drawing.Point(445, 18);
            this.tb_soluongton.Name = "tb_soluongton";
            this.tb_soluongton.Size = new System.Drawing.Size(142, 20);
            this.tb_soluongton.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(331, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 34;
            this.label3.Text = "Đơn giá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(331, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Số lượng tồn";
            // 
            // tb_tenvtpt
            // 
            this.tb_tenvtpt.Location = new System.Drawing.Point(108, 57);
            this.tb_tenvtpt.Name = "tb_tenvtpt";
            this.tb_tenvtpt.Size = new System.Drawing.Size(152, 20);
            this.tb_tenvtpt.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Mã VTPT";
            // 
            // lb_ngaysuachua
            // 
            this.lb_ngaysuachua.AutoSize = true;
            this.lb_ngaysuachua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ngaysuachua.Location = new System.Drawing.Point(353, 16);
            this.lb_ngaysuachua.Name = "lb_ngaysuachua";
            this.lb_ngaysuachua.Size = new System.Drawing.Size(0, 17);
            this.lb_ngaysuachua.TabIndex = 3;
            // 
            // lb_bienso
            // 
            this.lb_bienso.AutoSize = true;
            this.lb_bienso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_bienso.Location = new System.Drawing.Point(6, 57);
            this.lb_bienso.Name = "lb_bienso";
            this.lb_bienso.Size = new System.Drawing.Size(73, 17);
            this.lb_bienso.TabIndex = 0;
            this.lb_bienso.Text = "Tên VTPT";
            // 
            // data_vtpt
            // 
            this.data_vtpt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.data_vtpt.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.data_vtpt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_vtpt.Location = new System.Drawing.Point(21, 156);
            this.data_vtpt.Name = "data_vtpt";
            this.data_vtpt.Size = new System.Drawing.Size(490, 197);
            this.data_vtpt.TabIndex = 33;
            this.data_vtpt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_vtpt_CellClick);
            // 
            // bt_sua
            // 
            this.bt_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sua.Location = new System.Drawing.Point(563, 263);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(75, 23);
            this.bt_sua.TabIndex = 32;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoa.Location = new System.Drawing.Point(563, 321);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(75, 23);
            this.bt_xoa.TabIndex = 31;
            this.bt_xoa.Text = "Xoá";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_luu
            // 
            this.bt_luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_luu.Location = new System.Drawing.Point(563, 209);
            this.bt_luu.Name = "bt_luu";
            this.bt_luu.Size = new System.Drawing.Size(75, 23);
            this.bt_luu.TabIndex = 30;
            this.bt_luu.Text = "Lưu";
            this.bt_luu.UseVisualStyleBackColor = true;
            this.bt_luu.Click += new System.EventHandler(this.bt_luu_Click);
            // 
            // bt_Them
            // 
            this.bt_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Them.Location = new System.Drawing.Point(563, 156);
            this.bt_Them.Name = "bt_Them";
            this.bt_Them.Size = new System.Drawing.Size(75, 23);
            this.bt_Them.TabIndex = 34;
            this.bt_Them.Text = "Thêm mới";
            this.bt_Them.UseVisualStyleBackColor = true;
            this.bt_Them.Click += new System.EventHandler(this.bt_Them_Click);
            // 
            // frmQuanLyVTPT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 368);
            this.Controls.Add(this.bt_Them);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.data_vtpt);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_luu);
            this.Name = "frmQuanLyVTPT";
            this.Load += new System.EventHandler(this.frmQuanLyVTPT_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_vtpt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_ngaysuachua;
        private System.Windows.Forms.Label lb_bienso;
        private System.Windows.Forms.DataGridView data_vtpt;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_luu;
        private System.Windows.Forms.TextBox tb_dongia;
        private System.Windows.Forms.TextBox tb_soluongton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_mavtpt;
        private System.Windows.Forms.TextBox tb_tenvtpt;
        private System.Windows.Forms.Button bt_Them;
    }
}
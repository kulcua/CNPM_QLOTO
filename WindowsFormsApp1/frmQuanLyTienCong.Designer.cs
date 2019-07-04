namespace WindowsFormsApp1
{
    partial class frmQuanLyTienCong
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
            this.tb_tenloaitc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_tiencong = new System.Windows.Forms.TextBox();
            this.tb_matiencong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_ngaysuachua = new System.Windows.Forms.Label();
            this.lb_bienso = new System.Windows.Forms.Label();
            this.data_tiencong = new System.Windows.Forms.DataGridView();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_luu = new System.Windows.Forms.Button();
            this.bt_Them = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_tiencong)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(108, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 22);
            this.label7.TabIndex = 29;
            this.label7.Text = "QUẢN LÝ TIỀN CÔNG";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_tenloaitc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_tiencong);
            this.groupBox1.Controls.Add(this.tb_matiencong);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lb_ngaysuachua);
            this.groupBox1.Controls.Add(this.lb_bienso);
            this.groupBox1.Location = new System.Drawing.Point(20, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 125);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // tb_tenloaitc
            // 
            this.tb_tenloaitc.Location = new System.Drawing.Point(121, 57);
            this.tb_tenloaitc.Name = "tb_tenloaitc";
            this.tb_tenloaitc.Size = new System.Drawing.Size(161, 20);
            this.tb_tenloaitc.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Tên tiền công";
            // 
            // tb_tiencong
            // 
            this.tb_tiencong.Location = new System.Drawing.Point(121, 93);
            this.tb_tiencong.Name = "tb_tiencong";
            this.tb_tiencong.Size = new System.Drawing.Size(161, 20);
            this.tb_tiencong.TabIndex = 29;
            // 
            // tb_matiencong
            // 
            this.tb_matiencong.Location = new System.Drawing.Point(121, 18);
            this.tb_matiencong.Name = "tb_matiencong";
            this.tb_matiencong.ReadOnly = true;
            this.tb_matiencong.Size = new System.Drawing.Size(161, 20);
            this.tb_matiencong.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Mã tiền công";
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
            this.lb_bienso.Location = new System.Drawing.Point(6, 96);
            this.lb_bienso.Name = "lb_bienso";
            this.lb_bienso.Size = new System.Drawing.Size(71, 17);
            this.lb_bienso.TabIndex = 0;
            this.lb_bienso.Text = "Tiền công";
            // 
            // data_tiencong
            // 
            this.data_tiencong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_tiencong.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.data_tiencong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_tiencong.Location = new System.Drawing.Point(20, 170);
            this.data_tiencong.Name = "data_tiencong";
            this.data_tiencong.Size = new System.Drawing.Size(282, 172);
            this.data_tiencong.TabIndex = 33;
            this.data_tiencong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_tiencong_CellClick);
            // 
            // bt_sua
            // 
            this.bt_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sua.Location = new System.Drawing.Point(313, 268);
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
            this.bt_xoa.Location = new System.Drawing.Point(313, 319);
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
            this.bt_luu.Location = new System.Drawing.Point(313, 219);
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
            this.bt_Them.Location = new System.Drawing.Point(313, 170);
            this.bt_Them.Name = "bt_Them";
            this.bt_Them.Size = new System.Drawing.Size(75, 23);
            this.bt_Them.TabIndex = 34;
            this.bt_Them.Text = "Thêm mới";
            this.bt_Them.UseVisualStyleBackColor = true;
            this.bt_Them.Click += new System.EventHandler(this.bt_Them_Click);
            // 
            // frmQuanLyTienCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 354);
            this.Controls.Add(this.bt_Them);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.data_tiencong);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_luu);
            this.Name = "frmQuanLyTienCong";
            this.Load += new System.EventHandler(this.frmQuanLyTienCong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_tiencong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_matiencong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_ngaysuachua;
        private System.Windows.Forms.Label lb_bienso;
        private System.Windows.Forms.DataGridView data_tiencong;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_luu;
        private System.Windows.Forms.TextBox tb_tiencong;
        private System.Windows.Forms.TextBox tb_tenloaitc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_Them;
    }
}
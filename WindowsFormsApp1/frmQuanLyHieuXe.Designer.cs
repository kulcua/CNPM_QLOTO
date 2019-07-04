namespace WindowsFormsApp1
{
    partial class frmQuanLyHieuXe
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
            this.tb_mahieuxe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_ngaysuachua = new System.Windows.Forms.Label();
            this.lb_bienso = new System.Windows.Forms.Label();
            this.tb_hieuxe = new System.Windows.Forms.TextBox();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_luu = new System.Windows.Forms.Button();
            this.data_hieuxe = new System.Windows.Forms.DataGridView();
            this.bt_Them = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_hieuxe)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(145, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 22);
            this.label7.TabIndex = 22;
            this.label7.Text = "QUẢN LÝ HIỆU XE";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_mahieuxe);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lb_ngaysuachua);
            this.groupBox1.Controls.Add(this.lb_bienso);
            this.groupBox1.Location = new System.Drawing.Point(28, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 97);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // tb_mahieuxe
            // 
            this.tb_mahieuxe.Location = new System.Drawing.Point(121, 18);
            this.tb_mahieuxe.Name = "tb_mahieuxe";
            this.tb_mahieuxe.ReadOnly = true;
            this.tb_mahieuxe.Size = new System.Drawing.Size(161, 20);
            this.tb_mahieuxe.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Mã hiệu xe";
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
            this.lb_bienso.Size = new System.Drawing.Size(55, 17);
            this.lb_bienso.TabIndex = 0;
            this.lb_bienso.Text = "Hiệu xe";
            // 
            // tb_hieuxe
            // 
            this.tb_hieuxe.Location = new System.Drawing.Point(149, 100);
            this.tb_hieuxe.Name = "tb_hieuxe";
            this.tb_hieuxe.Size = new System.Drawing.Size(161, 20);
            this.tb_hieuxe.TabIndex = 6;
            // 
            // bt_sua
            // 
            this.bt_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sua.Location = new System.Drawing.Point(321, 250);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(75, 23);
            this.bt_sua.TabIndex = 25;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoa.Location = new System.Drawing.Point(321, 301);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(75, 23);
            this.bt_xoa.TabIndex = 24;
            this.bt_xoa.Text = "Xoá";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_luu
            // 
            this.bt_luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_luu.Location = new System.Drawing.Point(321, 201);
            this.bt_luu.Name = "bt_luu";
            this.bt_luu.Size = new System.Drawing.Size(75, 23);
            this.bt_luu.TabIndex = 23;
            this.bt_luu.Text = "Lưu";
            this.bt_luu.UseVisualStyleBackColor = true;
            this.bt_luu.Click += new System.EventHandler(this.bt_luu_Click);
            // 
            // data_hieuxe
            // 
            this.data_hieuxe.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.data_hieuxe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_hieuxe.Location = new System.Drawing.Point(28, 156);
            this.data_hieuxe.Name = "data_hieuxe";
            this.data_hieuxe.Size = new System.Drawing.Size(258, 168);
            this.data_hieuxe.TabIndex = 26;
            this.data_hieuxe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_hieuxe_CellClick);
            // 
            // bt_Them
            // 
            this.bt_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Them.Location = new System.Drawing.Point(321, 156);
            this.bt_Them.Name = "bt_Them";
            this.bt_Them.Size = new System.Drawing.Size(75, 23);
            this.bt_Them.TabIndex = 27;
            this.bt_Them.Text = "Thêm mới";
            this.bt_Them.UseVisualStyleBackColor = true;
            this.bt_Them.Click += new System.EventHandler(this.bt_Them_Click);
            // 
            // frmQuanLyHieuXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 344);
            this.Controls.Add(this.bt_Them);
            this.Controls.Add(this.data_hieuxe);
            this.Controls.Add(this.tb_hieuxe);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_luu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmQuanLyHieuXe";
            this.Load += new System.EventHandler(this.frmQuanLyHieuXe_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_hieuxe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_hieuxe;
        private System.Windows.Forms.Label lb_ngaysuachua;
        private System.Windows.Forms.Label lb_bienso;
        private System.Windows.Forms.TextBox tb_mahieuxe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_luu;
        private System.Windows.Forms.DataGridView data_hieuxe;
        private System.Windows.Forms.Button bt_Them;
    }
}
namespace WindowsFormsApp1
{
    partial class frmTraCuuXe
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
            this.tb_ma = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.bt_tracuu = new System.Windows.Forms.Button();
            this.cb_hieuxe = new System.Windows.Forms.ComboBox();
            this.bt_lapphieuthutien = new System.Windows.Forms.Button();
            this.tb_chuxe = new System.Windows.Forms.TextBox();
            this.tb_dienthoai = new System.Windows.Forms.TextBox();
            this.tb_bienso = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.data_tracuu = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_tracuu)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(283, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 22);
            this.label7.TabIndex = 4;
            this.label7.Text = "TRA CỨU XE";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_ma);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.bt_tracuu);
            this.groupBox1.Controls.Add(this.cb_hieuxe);
            this.groupBox1.Controls.Add(this.bt_lapphieuthutien);
            this.groupBox1.Controls.Add(this.tb_chuxe);
            this.groupBox1.Controls.Add(this.tb_dienthoai);
            this.groupBox1.Controls.Add(this.tb_bienso);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(674, 174);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // tb_ma
            // 
            this.tb_ma.Location = new System.Drawing.Point(114, 90);
            this.tb_ma.Name = "tb_ma";
            this.tb_ma.Size = new System.Drawing.Size(196, 20);
            this.tb_ma.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Mã số hồ sơ";
            // 
            // bt_tracuu
            // 
            this.bt_tracuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_tracuu.Location = new System.Drawing.Point(394, 130);
            this.bt_tracuu.Name = "bt_tracuu";
            this.bt_tracuu.Size = new System.Drawing.Size(98, 23);
            this.bt_tracuu.TabIndex = 14;
            this.bt_tracuu.Text = "Tra cứu";
            this.bt_tracuu.UseVisualStyleBackColor = true;
            this.bt_tracuu.Click += new System.EventHandler(this.bt_tracuu_Click);
            // 
            // cb_hieuxe
            // 
            this.cb_hieuxe.FormattingEnabled = true;
            this.cb_hieuxe.Location = new System.Drawing.Point(114, 52);
            this.cb_hieuxe.Name = "cb_hieuxe";
            this.cb_hieuxe.Size = new System.Drawing.Size(196, 21);
            this.cb_hieuxe.TabIndex = 13;
            // 
            // bt_lapphieuthutien
            // 
            this.bt_lapphieuthutien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_lapphieuthutien.Location = new System.Drawing.Point(498, 130);
            this.bt_lapphieuthutien.Name = "bt_lapphieuthutien";
            this.bt_lapphieuthutien.Size = new System.Drawing.Size(160, 23);
            this.bt_lapphieuthutien.TabIndex = 12;
            this.bt_lapphieuthutien.Text = "Lập phiếu thu tiền";
            this.bt_lapphieuthutien.UseVisualStyleBackColor = true;
            this.bt_lapphieuthutien.Click += new System.EventHandler(this.bt_lapphieuthutien_Click);
            // 
            // tb_chuxe
            // 
            this.tb_chuxe.Location = new System.Drawing.Point(462, 13);
            this.tb_chuxe.Name = "tb_chuxe";
            this.tb_chuxe.Size = new System.Drawing.Size(196, 20);
            this.tb_chuxe.TabIndex = 9;
            // 
            // tb_dienthoai
            // 
            this.tb_dienthoai.Location = new System.Drawing.Point(462, 52);
            this.tb_dienthoai.Name = "tb_dienthoai";
            this.tb_dienthoai.Size = new System.Drawing.Size(196, 20);
            this.tb_dienthoai.TabIndex = 8;
            // 
            // tb_bienso
            // 
            this.tb_bienso.Location = new System.Drawing.Point(114, 15);
            this.tb_bienso.Name = "tb_bienso";
            this.tb_bienso.Size = new System.Drawing.Size(196, 20);
            this.tb_bienso.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(333, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(333, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Chủ xe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hiệu xe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Biển số";
            // 
            // data_tracuu
            // 
            this.data_tracuu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_tracuu.Location = new System.Drawing.Point(10, 226);
            this.data_tracuu.Name = "data_tracuu";
            this.data_tracuu.Size = new System.Drawing.Size(674, 118);
            this.data_tracuu.TabIndex = 6;
            this.data_tracuu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_tracuu_CellClick);
            // 
            // frmTraCuuXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 366);
            this.Controls.Add(this.data_tracuu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Name = "frmTraCuuXe";
            this.Load += new System.EventHandler(this.frmTraCuuXe_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_tracuu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_lapphieuthutien;
        private System.Windows.Forms.TextBox tb_bienso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_hieuxe;
        private System.Windows.Forms.DataGridView data_tracuu;
        private System.Windows.Forms.Button bt_tracuu;
        private System.Windows.Forms.TextBox tb_chuxe;
        private System.Windows.Forms.TextBox tb_dienthoai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_ma;
        private System.Windows.Forms.Label label8;
    }
}
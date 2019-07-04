namespace WindowsFormsApp1
{
    partial class frmBCDoanhSo
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
            this.bt_xuatdoanhso = new System.Windows.Forms.Button();
            this.cb_thang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.data_doanhso = new System.Windows.Forms.DataGridView();
            this.lb_tongdoanhthu = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_doanhso)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(277, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 22);
            this.label7.TabIndex = 4;
            this.label7.Text = "DOANH SỐ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_tongdoanhthu);
            this.groupBox1.Controls.Add(this.bt_xuatdoanhso);
            this.groupBox1.Controls.Add(this.cb_thang);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(657, 125);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // bt_xuatdoanhso
            // 
            this.bt_xuatdoanhso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xuatdoanhso.Location = new System.Drawing.Point(463, 85);
            this.bt_xuatdoanhso.Name = "bt_xuatdoanhso";
            this.bt_xuatdoanhso.Size = new System.Drawing.Size(169, 23);
            this.bt_xuatdoanhso.TabIndex = 22;
            this.bt_xuatdoanhso.Text = "Xuất bảng doanh số";
            this.bt_xuatdoanhso.UseVisualStyleBackColor = true;
            this.bt_xuatdoanhso.Click += new System.EventHandler(this.bt_xuatdoanhso_Click);
            // 
            // cb_thang
            // 
            this.cb_thang.FormattingEnabled = true;
            this.cb_thang.Location = new System.Drawing.Point(312, 16);
            this.cb_thang.Name = "cb_thang";
            this.cb_thang.Size = new System.Drawing.Size(196, 21);
            this.cb_thang.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(137, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tổng doanh thu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tháng";
            // 
            // data_doanhso
            // 
            this.data_doanhso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data_doanhso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_doanhso.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.data_doanhso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_doanhso.Location = new System.Drawing.Point(17, 165);
            this.data_doanhso.Name = "data_doanhso";
            this.data_doanhso.Size = new System.Drawing.Size(657, 131);
            this.data_doanhso.TabIndex = 19;
            // 
            // lb_tongdoanhthu
            // 
            this.lb_tongdoanhthu.AutoSize = true;
            this.lb_tongdoanhthu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tongdoanhthu.Location = new System.Drawing.Point(308, 48);
            this.lb_tongdoanhthu.Name = "lb_tongdoanhthu";
            this.lb_tongdoanhthu.Size = new System.Drawing.Size(60, 18);
            this.lb_tongdoanhthu.TabIndex = 23;
            this.lb_tongdoanhthu.Text = "000,000";
            // 
            // frmBCDoanhSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 310);
            this.Controls.Add(this.data_doanhso);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Name = "frmBCDoanhSo";
            this.Load += new System.EventHandler(this.frmBCDoanhSo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_doanhso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_thang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView data_doanhso;
        private System.Windows.Forms.Button bt_xuatdoanhso;
        private System.Windows.Forms.Label lb_tongdoanhthu;
    }
}
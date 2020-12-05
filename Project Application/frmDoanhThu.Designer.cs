namespace Project_Application
{
    partial class frmDoanhThu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btntongthang = new System.Windows.Forms.Button();
            this.btntongtuan = new System.Windows.Forms.Button();
            this.btntongngay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDTNgay = new System.Windows.Forms.Label();
            this.lblTienThang = new System.Windows.Forms.Label();
            this.lblDTThang = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Aquamarine;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.btntongthang);
            this.groupBox1.Controls.Add(this.btntongtuan);
            this.groupBox1.Controls.Add(this.btntongngay);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(26, 114);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(564, 268);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản Lý Hóa Đơn";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(13, 87);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(534, 177);
            this.dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "STT";
            this.Column1.Name = "Column1";
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "HÓA ĐƠN";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // btntongthang
            // 
            this.btntongthang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btntongthang.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntongthang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btntongthang.Location = new System.Drawing.Point(428, 25);
            this.btntongthang.Margin = new System.Windows.Forms.Padding(2);
            this.btntongthang.Name = "btntongthang";
            this.btntongthang.Size = new System.Drawing.Size(92, 26);
            this.btntongthang.TabIndex = 0;
            this.btntongthang.Text = "Theo Tháng";
            this.btntongthang.UseVisualStyleBackColor = false;
            // 
            // btntongtuan
            // 
            this.btntongtuan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btntongtuan.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntongtuan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btntongtuan.Location = new System.Drawing.Point(230, 25);
            this.btntongtuan.Margin = new System.Windows.Forms.Padding(2);
            this.btntongtuan.Name = "btntongtuan";
            this.btntongtuan.Size = new System.Drawing.Size(83, 26);
            this.btntongtuan.TabIndex = 0;
            this.btntongtuan.Text = "Theo Tuần";
            this.btntongtuan.UseVisualStyleBackColor = false;
            // 
            // btntongngay
            // 
            this.btntongngay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btntongngay.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntongngay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btntongngay.Location = new System.Drawing.Point(29, 25);
            this.btntongngay.Margin = new System.Windows.Forms.Padding(2);
            this.btntongngay.Name = "btntongngay";
            this.btntongngay.Size = new System.Drawing.Size(85, 26);
            this.btntongngay.TabIndex = 0;
            this.btntongngay.Text = "Theo Ngày";
            this.btntongngay.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Doanh Thu Hôm Nay";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Doanh Thu Tháng Này";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDTNgay
            // 
            this.lblDTNgay.AutoSize = true;
            this.lblDTNgay.Location = new System.Drawing.Point(153, 13);
            this.lblDTNgay.Name = "lblDTNgay";
            this.lblDTNgay.Size = new System.Drawing.Size(70, 13);
            this.lblDTNgay.TabIndex = 2;
            this.lblDTNgay.Text = "doanh thu nè";
            // 
            // lblTienThang
            // 
            this.lblTienThang.AutoSize = true;
            this.lblTienThang.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTienThang.Location = new System.Drawing.Point(153, 72);
            this.lblTienThang.Name = "lblTienThang";
            this.lblTienThang.Size = new System.Drawing.Size(0, 13);
            this.lblTienThang.TabIndex = 2;
            // 
            // lblDTThang
            // 
            this.lblDTThang.AutoSize = true;
            this.lblDTThang.Location = new System.Drawing.Point(153, 72);
            this.lblDTThang.Name = "lblDTThang";
            this.lblDTThang.Size = new System.Drawing.Size(70, 13);
            this.lblDTThang.TabIndex = 2;
            this.lblDTThang.Text = "doanh thu nè";
            // 
            // frmDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(601, 393);
            this.Controls.Add(this.lblTienThang);
            this.Controls.Add(this.lblDTThang);
            this.Controls.Add(this.lblDTNgay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDoanhThu";
            this.Text = "frmtonghoadon";
            this.Load += new System.EventHandler(this.frmtonghoadon_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btntongngay;
        private System.Windows.Forms.Button btntongthang;
        private System.Windows.Forms.Button btntongtuan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDTNgay;
        private System.Windows.Forms.Label lblTienThang;
        private System.Windows.Forms.Label lblDTThang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}
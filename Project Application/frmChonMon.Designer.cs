namespace Project_Application
{
    partial class frmChonMon
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
            this.cboMonAn = new System.Windows.Forms.ComboBox();
            this.numberSoLuong = new System.Windows.Forms.NumericUpDown();
            this.btnThemMon = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lsvDSMonAn = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numberSoLuong)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboMonAn
            // 
            this.cboMonAn.FormattingEnabled = true;
            this.cboMonAn.Location = new System.Drawing.Point(8, 23);
            this.cboMonAn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboMonAn.Name = "cboMonAn";
            this.cboMonAn.Size = new System.Drawing.Size(255, 24);
            this.cboMonAn.TabIndex = 0;
            // 
            // numberSoLuong
            // 
            this.numberSoLuong.Location = new System.Drawing.Point(288, 25);
            this.numberSoLuong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numberSoLuong.Name = "numberSoLuong";
            this.numberSoLuong.Size = new System.Drawing.Size(76, 22);
            this.numberSoLuong.TabIndex = 1;
            // 
            // btnThemMon
            // 
            this.btnThemMon.Location = new System.Drawing.Point(405, 21);
            this.btnThemMon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(100, 28);
            this.btnThemMon.TabIndex = 2;
            this.btnThemMon.Text = "Thêm Món";
            this.btnThemMon.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(316, 422);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 28);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(441, 422);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 28);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // lsvDSMonAn
            // 
            this.lsvDSMonAn.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lsvDSMonAn.GridLines = true;
            this.lsvDSMonAn.Location = new System.Drawing.Point(16, 148);
            this.lsvDSMonAn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lsvDSMonAn.Name = "lsvDSMonAn";
            this.lsvDSMonAn.Size = new System.Drawing.Size(527, 248);
            this.lsvDSMonAn.TabIndex = 3;
            this.lsvDSMonAn.UseCompatibleStateImageBehavior = false;
            this.lsvDSMonAn.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên Món";
            this.columnHeader1.Width = 132;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số Lượng";
            this.columnHeader2.Width = 132;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.Width = 132;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboMonAn);
            this.groupBox1.Controls.Add(this.numberSoLuong);
            this.groupBox1.Controls.Add(this.btnThemMon);
            this.groupBox1.Location = new System.Drawing.Point(16, 43);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(525, 63);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn Món";
            // 
            // frmChonMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 464);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lsvDSMonAn);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnOK);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmChonMon";
            this.Text = "frmChonMon";
            this.Load += new System.EventHandler(this.frmChonMon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numberSoLuong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboMonAn;
        private System.Windows.Forms.NumericUpDown numberSoLuong;
        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ListView lsvDSMonAn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Application
{
    public partial class frmDangNhap : Form
    {
        string a = "tenladanh";
        public frmDangNhap()
        {
            InitializeComponent();
        }
        //viet events cho button dang nhap
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
                this.Hide();
                frmNhanVien f = new frmNhanVien();
                f.Text = "Nhan Vien";
                f.ShowDialog();
                this.Close();   
        }

        private void txtTaiKhoan_Leave(object sender, EventArgs e)
        {
            if(txtTaiKhoan.TextLength==0)
            {
                errorProvider1.SetError(txtTaiKhoan, "Vui long nhap tai khoan");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtMatKhau_Leave(object sender, EventArgs e)
        {
            if (txtMatKhau.TextLength == 0)
            {
                errorProvider1.SetError(txtMatKhau, "Vui long nhap tai khoan");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn thoát không ?","Xác nhân",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

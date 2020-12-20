using BUS;
using DTO;
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
    public partial class btnThanhToan : Form
    {
        public btnThanhToan()
        {
            InitializeComponent();
            loadBanAn();
        }
        #region Method
       
        void showHoaDon(int tableID)
        {
            lsvHoaDon.Items.Clear();
            double tongTien = 0;
            List<MenuBill> listMenu = BUS_InfoHoaDon.Instance.getBillByTableID(tableID);
            foreach (MenuBill item in listMenu)
            {
                string[] subItem = new string[] { item.TenMon, item.SoLuong.ToString(), item.DonGia.ToString(), item.ThanhTien.ToString() };
                ListViewItem a = new ListViewItem(subItem);
                lsvHoaDon.Items.Add(a);
                tongTien += item.ThanhTien;
            }
            txtTotalPrice.Text = String.Format("{0:0,0}", tongTien);
        }
        void loadBanAn()
        {
            List<BanAn> listBanAn = new List<BanAn>();
            listBanAn = BUS_BanAn.Instance.getTableList();
            foreach (BanAn item in listBanAn)
            {
                Button btn = new Button();
                btn.Width = 90;
                btn.Height = 90;
                btn.Click += btnClick;
                btn.Tag = item;
                string status = "";
                if (item.TrangThai == 1)
                {
                    status = "Có người";
                    btn.BackColor = Color.Aqua;
                }
                else
                {
                    status = "Trống";
                    btn.BackColor = Color.Honeydew;
                }
                btn.Text = "Bàn " + item.ID + Environment.NewLine + status;
                flpBanAn.Controls.Add(btn);
            }
        }
        #endregion
        #region events
        void btnClick(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as BanAn).ID;
            lsvHoaDon.Tag = tableID;
            showHoaDon(tableID);
        }
        private void btnGiamGia_Click(object sender, EventArgs e)
        {
            int giamGia = int.Parse(txtGiamGia.Text);

            double totalPrice = int.Parse(string.Format("{0}", txtTotalPrice.Text.Remove(txtTotalPrice.Text.LastIndexOf('.'), 1)));
            totalPrice = Math.Round((totalPrice - totalPrice * giamGia / 100), 3);
            txtTotalPrice.Text = totalPrice.ToString();
        }

        #endregion

        private bool KiemTraTrung(string tenMon)
        {
            for(int i=0;i<lsvHoaDon.Items.Count;i++)
            {
                if(tenMon == lsvHoaDon.Items[i].SubItems[0].ToString())
                {
                    return false;
                }
            }
            return true;
        }
        private void btnThemMon_Click(object sender, EventArgs e)
        {
            object[] listPara = new object[] {cboChonMon.Text ,nudSoLuong.Value };
            if(lsvHoaDon.Items.Count==0)
            {
                //them hoa don
                    
                //them info hoa don
                int tableID = (int)lsvHoaDon.Tag;
                //update trang thai ban 
            }
            else
            {
                if(KiemTraTrung(cboChonMon.Text))
                {
                    //them info hoa don
                }
                else
                {
                    //update info hoa don 
                }
            }
        }
    }
}

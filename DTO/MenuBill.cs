using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MenuBill
    {
        private string tenMon;
        private int soLuong;
        private double donGia;
        private double thanhTien;
        
        public string TenMon
        {
            get
            {
                return tenMon;
            }

            set
            {
                tenMon = value;
            }
        }

        public int SoLuong
        {
            get
            {
                return soLuong;
            }

            set
            {
                soLuong = value;
            }
        }

        public double DonGia
        {
            get
            {
                return donGia;
            }

            set
            {
                donGia = value;
            }
        }

        public double ThanhTien
        {
            get
            {
                return thanhTien;
            }

            set
            {
                thanhTien = value;
            }
        }
        public MenuBill(DataRow row)
        {
            tenMon = (string)row["Tên Món"];
            soLuong = (int)row["Số Lượng"];
            donGia  = Convert.ToDouble(row["Đơn Giá"]);
            thanhTien = Convert.ToDouble(row["Thành tiền"]);
        }
    }
}

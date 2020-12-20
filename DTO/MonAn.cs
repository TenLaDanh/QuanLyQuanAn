using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class MonAn
    {
        private int iDMonAn;
        private int donGia;
        private string tenMon;

        public int IDMonAn
        {
            get
            {
                return iDMonAn;
            }

            set
            {
                iDMonAn = value;
            }
        }

        public int DonGia
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

        public MonAn(DataRow row)
        {
            this.iDMonAn = (int)row["iDMonAn"];
            this.donGia = (int)row["donGia"];
            this.tenMon = (string)row["tenMon"];
        }
        public MonAn(int idMonAn,string tenMon, int donGia)
        {
            this.iDMonAn = idMonAn;
            this.tenMon = tenMon;
            this.donGia = donGia;
        }
    }
}

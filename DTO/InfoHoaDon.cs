using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class InfoHoaDon
    {
        private int iDHoaDon;
        private int iDMonAn;
        private int iDBan;
        private int soLuong;

        public int IDHoaDon
        {
            get
            {
                return iDHoaDon;
            }

            set
            {
                iDHoaDon = value;
            }
        }

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

        public int IDBan
        {
            get
            {
                return iDBan;
            }

            set
            {
                iDBan = value;
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

        public InfoHoaDon() { }
        public InfoHoaDon(DataRow row)
        {
            this.iDHoaDon = (int)row["iDHoaDon"];
            this.iDMonAn = (int)row["iDMonAn"];
            this.soLuong = (int)row["soLuong"];
            this.iDBan = (int)row["iDBan"];
        }
        public InfoHoaDon(int idHD,int idMonAn,int soLuong,int idBan)
        {
            this.iDHoaDon = idHD;
            this.iDMonAn = idMonAn;
            this.soLuong = soLuong;
            this.iDBan = idBan;
        }

    }
}

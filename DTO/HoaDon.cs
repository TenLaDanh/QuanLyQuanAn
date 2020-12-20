using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDon
    {
        private int iD;
        private DateTime ngayXuatHD;
        private string trangThai;
        public int ID
        {
            get
            {
                return iD;
            }

            set
            {
                ID = value;
            }
        }

        public DateTime NgayXuatHD
        {
            get
            {
                return ngayXuatHD;
            }

            set
            {
                ngayXuatHD = value;
            }
        }

        public string TrangThai
        {
            get
            {
                return trangThai;
            }

            set
            {
                trangThai = value;
            }
        }

        public HoaDon() { }
        public HoaDon(DataRow row)
        {
            this.iD = (int)row["ID"];
            this.ngayXuatHD = (DateTime)row["ngayXuatHD "];
            this.TrangThai = (string)row["noiDung"];
        }
        public HoaDon(int iD , DateTime ngayXuatHD,string trangThai)
        {
            this.iD = iD;
            this.ngayXuatHD = ngayXuatHD;
            this.TrangThai = trangThai;
        }

    }
}

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
        private int ID;
        private string ngayXuatHD;

        public int ID1
        {
            get
            {
                return ID;
            }

            set
            {
                ID = value;
            }
        }

        public string NgayXuatHD
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

        public HoaDon() { }
        public HoaDon(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.ngayXuatHD = (string)row["ngayXuatHD "];
        }

    }
}

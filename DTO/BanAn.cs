using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BanAn
    {
        private int iD;
        private int trangThai;

        public int ID
        {
            get
            {
                return iD;
            }

            set
            {
                iD = value;
            }
        }

        public int TrangThai
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

        public BanAn() { }
        public BanAn(DataRow row)
        {
            this.iD = (int)row["iDBan"];
            this.trangThai = (int)row["trangThai "];
        }
    }
}

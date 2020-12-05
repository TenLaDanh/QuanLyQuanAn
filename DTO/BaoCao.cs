using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BaoCao
    {
        private int iD;
        private int iDTaiKhoan;

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

        public int IDTaiKhoan
        {
            get
            {
                return iDTaiKhoan;
            }

            set
            {
                iDTaiKhoan = value;
            }
        }

        public BaoCao() { }
        public BaoCao(DataRow row)
        {
            this.iD = (int)row["iD"];
            this.iDTaiKhoan = (int)row["iDTaiKhoan "];
        }
    }
}

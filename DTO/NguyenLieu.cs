using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class NguyenLieu
    {
        private int iD;
        private string tenNguyenLieu;
        private float soLuong;
        private string donVi;

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

        public string TenNguyenLieu
        {
            get
            {
                return tenNguyenLieu;
            }

            set
            {
                tenNguyenLieu = value;
            }
        }

        public float SoLuong
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

        public string DonVi
        {
            get
            {
                return donVi;
            }

            set
            {
                donVi = value;
            }
        }

        public NguyenLieu(DataRow row)
        {
            this.iD = (int)row["iD"];
            this.tenNguyenLieu = (string)row["tenNguyenLieu"];
            this.soLuong = (float)row["soLuong"];
            this.donVi = (string)row["donVi"];
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class TaiKhoan
    {
        private int iD;
        private string sTaiKhoan;
        private string matKhau;
        private string tenHienThi;
        private string hoTen;
        private string gioiTinh;

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

        public string STaiKhoan
        {
            get
            {
                return sTaiKhoan;
            }

            set
            {
                sTaiKhoan = value;
            }
        }

        public string MatKhau
        {
            get
            {
                return matKhau;
            }

            set
            {
                matKhau = value;
            }
        }

        public string TenHienThi
        {
            get
            {
                return tenHienThi;
            }

            set
            {
                tenHienThi = value;
            }
        }

        public string HoTen
        {
            get
            {
                return hoTen;
            }

            set
            {
                hoTen = value;
            }
        }

        public string GioiTinh
        {
            get
            {
                return gioiTinh;
            }

            set
            {
                gioiTinh = value;
            }
        }
        public TaiKhoan(DataRow row)
        {
            this.iD = (int)row["iD"];
            this.sTaiKhoan = (string)row["taiKhoan"];
            this.matKhau = (string)row["matKhau"];
            this.tenHienThi = (string)row["tenHienThi"];
            this.hoTen = (string)row["hoTen"];
            this.gioiTinh = (string)row["gioiTinh"];
        }
    }
}

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
        private string tenTaiKhoan;
        private string matKhau;
        private string tenHienThi;
        private int loaiTK;

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

        public int LoaiTK
        {
            get
            {
                return loaiTK;
            }

            set
            {
                loaiTK = value;
            }
        }

        public string TenTaiKhoan
        {
            get
            {
                return tenTaiKhoan;
            }

            set
            {
                tenTaiKhoan = value;
            }
        }

        public TaiKhoan(DataRow row)
        {
            this.iD = (int)row["iD"];
            this.tenTaiKhoan = (string)row["taiKhoan"];
            this.matKhau = (string)row["matKhau"];
            this.tenHienThi = (string)row["tenHienThi"];
            this.loaiTK = (int)row["loaiTK"];
        }
        public TaiKhoan(int id,string tenTK,string matKhau,string tenHienThi,int loaiTK)
        {
            this.iD = id;
            this.tenTaiKhoan = tenTK;
            this.matKhau = matKhau;
            this.tenHienThi = tenHienThi;
            this.loaiTK = loaiTK;
        }
    }
}

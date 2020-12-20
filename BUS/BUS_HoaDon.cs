using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BUS
{
    public class BUS_HoaDon
    {
        private static BUS_HoaDon instance;

        public static BUS_HoaDon Instance
        {
            get
            {
                if (instance == null) instance = new BUS_HoaDon(); return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private BUS_HoaDon() { }

       public void ThemHoaDon(HoaDon hd)
        {
            DAL_HoaDon.Instance.ThemHoaDon(new object[] { hd.NgayXuatHD, hd.TrangThai });
        }
    }
}

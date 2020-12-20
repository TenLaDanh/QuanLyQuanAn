using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_HoaDon
    {
        private static DAL_HoaDon instance;

        public static DAL_HoaDon Instance
        {
            get
            {
                if (instance == null) instance = new DAL_HoaDon();  return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private DAL_HoaDon() { }

        public DataTable getBillByTableID(int tableID)
        {
            DataTable dtBill = new DataTable();
            dtBill = DataProvider.Instance.ExecuteQuery("exec sp_ShowHoaDonByTableID @tableID", new object[] { tableID });
            return dtBill;
        }
        public int ThemHoaDon(object[] listPara)
        {
            return DataProvider.Instance.ExecuteNonQuery("exec sp_ThemHoaDon @ngayXuatHD , @trangThai ", listPara);
        }
    }
}

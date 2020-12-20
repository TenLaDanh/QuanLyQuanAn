using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class DAL_BanAn
    {
        private static DAL_BanAn instance;

        public static DAL_BanAn Instance
        {
            get
            {
                if (instance == null) instance = new DAL_BanAn(); return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private DAL_BanAn() { }

        public DataTable getTableList()
        {
            DataTable dtBanAn = new DataTable();
            dtBanAn = DataProvider.Instance.ExecuteQuery("sp_DSBanAn");
            return dtBanAn;
        }
       
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_InfoHoaDon
    {
        private static DAL_InfoHoaDon instance;

        public static DAL_InfoHoaDon Instance
        {
            get
            {
                if (instance == null) instance = new DAL_InfoHoaDon(); return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private DAL_InfoHoaDon() { }
        public DataTable GetIFUncheckByTableID(int tableID)
        {
            DataTable dtInforHoaDon = new DataTable();
            dtInforHoaDon = DataProvider.Instance.ExecuteQuery("exec sp_GetIFUncheckByTableID @tableID", new object[] { tableID });
            return dtInforHoaDon;
        }
    }
}

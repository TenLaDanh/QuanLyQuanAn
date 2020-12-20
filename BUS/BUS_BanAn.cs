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
    public class BUS_BanAn
    {
        private static BUS_BanAn instance;

        public static BUS_BanAn Instance
        {
            get
            {
                if (instance == null) instance = new BUS_BanAn(); return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private BUS_BanAn() { }

        public List<BanAn> getTableList()
        {
            List<BanAn> listBanAn = new List<BanAn>();
            DataTable dtTable = new DataTable();
            dtTable = DAL_BanAn.Instance.getTableList();
            foreach(DataRow row in dtTable.Rows)
            {
                BanAn newBanAn = new BanAn(row);
                listBanAn.Add(newBanAn);
            }
            return listBanAn;
        }
       
    }
}

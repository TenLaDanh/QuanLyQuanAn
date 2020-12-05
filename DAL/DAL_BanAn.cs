using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    class DAL_BanAn
    {
        private static DAL_BanAn instance;

        internal static DAL_BanAn Instance
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

        public List<BanAn> getTableList()
        {
            List<BanAn> listBanAn = new List<BanAn>();
            
            return listBanAn;
        }
    }
}

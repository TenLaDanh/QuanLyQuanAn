using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_InfoHoaDon
    {
        private static BUS_InfoHoaDon instance;

        public static BUS_InfoHoaDon Instance
        {
            get
            {
                if (instance == null) instance = new BUS_InfoHoaDon(); return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private BUS_InfoHoaDon() { }

        public List<MenuBill> getBillByTableID(int tableID)
        {
            int check = 1;
            List<MenuBill> listMenu = new List<MenuBill>();
            DataTable dtBill = new DataTable();
            dtBill = DAL_InfoHoaDon.Instance.GetIFUncheckByTableID(tableID);
            foreach (DataRow row in dtBill.Rows)
            {
                check = 0;
                MenuBill mNew = new MenuBill(row);
                foreach (MenuBill menu in listMenu)
                {
                    if (menu.TenMon == mNew.TenMon)
                    {
                        menu.SoLuong += mNew.SoLuong;
                        check = 1;
                    }
                }
                if (check == 0)
                {
                    listMenu.Add(mNew);
                }

            }
            return listMenu;
        }
    }
}

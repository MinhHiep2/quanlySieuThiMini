using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Revenue
    {
        private DataProvider db = new DataProvider();
        public static DataTable GetRevenue(DateTime date, string criteria = null)
        {
            DataProvider db = new DataProvider();
            string sql = "sp_GetRevenue";
            DataTable tblRevenue = null;

            //keySearch: is Text in ComboBox Search user choice
            //Value: Text in TextBox user input
            db.addParam("Ngay", date);
            if (criteria != null)
            {
                db.addParam("TieuChi", criteria);
            }
            tblRevenue = db.queryExecuteAdapter(sql);

            return tblRevenue;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Role
    {
        private DataProvider db = new DataProvider();
        public DataTable GetRole(string keySearch, string value = null)
        {
            DataProvider db = new DataProvider();
            string sql = "sp_getRole";
            DataTable tblRole = null;

            //keySearch: is Text in ComboBox Search user choice
            //Value: Text in TextBox user input
            db.addParam(keySearch, value);
            tblRole = db.queryExecuteAdapter(sql);

            return tblRole;
        }
    }
}

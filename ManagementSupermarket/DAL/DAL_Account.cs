﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Collections;
namespace DAL
{
    public class DAL_Account
    {
        public DataTable GetAccount(string keySearch = null, string value = null, bool? status = null)
        {
            DataProvider db = new DataProvider();

            if (keySearch != null)
            {
                db.addParam(keySearch, value);
            }
            db.addParam("TrangThai", status);
            DataTable result = db.queryExecuteAdapter("sp_GetAccount");

            return result;
        }
        public int UpdateStatusAccount(string username, bool status)
        {
            DataProvider db = new DataProvider();

            db.addParam("MaNV", username);
            db.addParam("TrangThai", status);

            DataTable result = db.queryExecuteAdapter("sp_UpdateStatusAccount");


            return result.Rows.Count;
        }
        public DataTable IsAccount(string username, string password)
        {
            DataProvider db = new DataProvider();
            db.addParam("MaNV", username);
            db.addParam("MatKhau", password);

            DataTable result = db.queryExecuteAdapter("sp_checkAccount");

            return result;
        }

        public bool UpdatePasswordAccount(string username, string password)
        {
            DataProvider db = new DataProvider();
            db.addParam("MaNV", username);
            db.addParam("MatKhau", password);

            DataRow row = db.queryExecuteAdapter("sp_UpdatePasswordAccount").Rows[0];

            bool result = (int)row[0] > 0 ? true : false;
            return result;
        }
    }
}

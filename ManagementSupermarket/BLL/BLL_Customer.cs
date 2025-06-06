﻿using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class BLL_Customer
    {
        private DAL_Customer dataCustomer = new DAL_Customer();
        public DataTable GetCustomerTo(string keySearch, string value = null)
        {
            return dataCustomer.GetCustomerTo(keySearch, value);
        }
        public DataTable GetCustomerToPhone(string value)
        {
            return dataCustomer.GetCustomerToPhone(value);
        }
        public int InsertCustomer(DTO_Customer customer)
        {
            return dataCustomer.InsertCustomer(customer);
        }
        public int UpdateCustomer(DTO_Customer customer)
        {
            return dataCustomer.UpdateCustomer(customer);
        }
        //DELETE EMPLOYEE, BUT ACTUALLY IS UPDATE STATUS FROM 1 TO 0
        public int UpdateStatusCustomer(string id)
        {
            return dataCustomer.UpdateStatusCustomer(id);
        }
    }
}

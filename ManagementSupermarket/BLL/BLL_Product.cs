﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class BLL_Product
    {
        private DAL_Product dataProduct = new DAL_Product();
        public DataTable GetProduct(string keySearch, string value = null, bool? status = null)
        {
            return dataProduct.GetProduct(keySearch, value, status);
        }
        public DataTable GetProductExpire()
        {
            return dataProduct.GetProductExpire();
        }
        public int InsertProduct(DTO_Product product)
        {
            return dataProduct.InsertProduct(product);
        }

        public int UpdateProduct(DTO_Product product)
        {
            return dataProduct.UpdateProduct(product);
        }

        public int UpdateStatusProduct(string id)
        {
            return dataProduct.UpdateStatusProduct(id);
        }
    }
}

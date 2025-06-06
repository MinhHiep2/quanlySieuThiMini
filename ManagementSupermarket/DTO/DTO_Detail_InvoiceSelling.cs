﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Detail_InvoiceSelling
    {
        private string s_IdInvoice;
        private string s_IdProduct;
        private string s_IdDiscount;
        private int i_Count;
        private double d_Price;

        public DTO_Detail_InvoiceSelling(string idInvoice, string idProduct, string IdDiscount, int i_Count, double d_Price)
        {
            S_IdInvoice = idInvoice;
            S_IdProduct = idProduct;
            S_Discount = IdDiscount;
            this.I_Count = i_Count;
            this.D_Price = d_Price;
        }

        public string S_IdInvoice { get => s_IdInvoice; set => s_IdInvoice = value; }
        public string S_IdProduct { get => s_IdProduct; set => s_IdProduct = value; }
        public string S_Discount { get => s_IdDiscount; set => s_IdDiscount = value; }
        public int I_Count { get => i_Count; set => i_Count = value; }
        public double D_Price { get => d_Price; set => d_Price = value; }
    }
}

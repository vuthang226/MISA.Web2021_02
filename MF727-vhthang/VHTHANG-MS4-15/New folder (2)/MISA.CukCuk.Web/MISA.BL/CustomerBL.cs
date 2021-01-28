﻿using MISA.BL.Interfaces;
using MISA.Common;
using MISA.DL;
using MISA.DL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.BL
{
    public class CustomerBL:ICustomerBL
    {
        ICustomerDL _customerDL;
        public CustomerBL(ICustomerDL customerDL)
        {
            _customerDL = customerDL;
        }
        public int InsertCustomer(Customer customer)
        {
            //CustomerDL customerDL = new CustomerDL();
            // check trung ma
            if(_customerDL.CheckDuplicateCustomerCode(customer.CustomerCode) == true)
            {
                return -1;
            }
            else
            {
                var effectRows = _customerDL.Insert(customer);
                return effectRows;
            }
            // check trung sdt
            
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManage
{
    internal class CustomerDAO
    {
        DBConnection DbConnection = new DBConnection();
        public void Create(Customer customer)
        {
            string sqlStr = string.Format("INSERT INTO Customer(STK, Name, Address, Dob, CitizenId, PhoneNum, Money, CreateAt) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', {6}, '{7}')", customer.Stk, customer.Name, customer.Address, customer.Dob, customer.CitizenId, customer.PhoneNumber, customer.Money, customer.CreatedAt);
            DbConnection.Execute(sqlStr, "Create");
        }
        public void Update(Customer customer)
        {
            string sqlStr = string.Format("UPDATE Customer SET Name = '{1}', Address = '{2}', Dob = '{3}', CitizenId = '{4}', PhoneNum = '{5}', Money = {6}, UpdateAt = '{7}' WHERE STK = '{0}'", customer.Stk, customer.Name, customer.Address, customer.Dob, customer.CitizenId, customer.PhoneNumber, customer.Money, customer.UpdatedAt);
            DbConnection.Execute(sqlStr, "Update");
        }
        public void Delete(Customer customer)
        {
            string sqlStr = string.Format("DELETE FROM Customer where STK = '{0}'", customer.Stk);
            DbConnection.Execute(sqlStr, "Delete");
        }
        public bool ValidateFormCreate(Customer customer)
        {
            return string.IsNullOrEmpty(customer.Stk) || string.IsNullOrEmpty(customer.Name) || string.IsNullOrEmpty(customer.Address) || string.IsNullOrEmpty(customer.PhoneNumber);
        }
    }
}

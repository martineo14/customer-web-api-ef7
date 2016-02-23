using System;
using System.Collections.Generic;
using CustomerWebApi.DAL.Entities;

namespace CustomerWebApi.DAL
{
    public interface IRepository : IDisposable
    {
        IEnumerable<Customer> GetCustomers();
        Customer GetCustomerByID(int customerID);
        void InsertCustomer(Customer customer);
        void DeleteCustomer(int customerID);
        void UpdateCustomer(Customer customer);
        void Save();
    }
}
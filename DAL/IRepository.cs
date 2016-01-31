using System;
using System.Collections.Generic;
using CustomerWebApi.DAL.Entities;

namespace CustomerWebApi.DAL
{
    public interface IRepository : IDisposable
    {
        IEnumerable<Customer> GetCustomers();
        Customer GetCustomerByID(int studentId);
        void InsertCustomer(Customer student);
        void DeleteCustomer(int studentID);
        void UpdateCustomer(Customer student);
        void Save();
    }
}
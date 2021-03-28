using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public class CustomerManager
    {
        void Add(Customer customer)
        {
            Console.WriteLine("Customer added.");
        }

        public string GetCustomers()
        {
            return "Customers listed.";
        }

        void Delete(Customer customer)
        {
            Console.WriteLine("Customer deleted.");
        }

        void Update(Customer customer)
        {
            Console.WriteLine("Customer updated.");
        }
    }
}

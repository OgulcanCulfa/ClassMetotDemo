using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customer = new CustomerManager();
            Console.WriteLine(customer.GetCustomers());
        }
    }
}
